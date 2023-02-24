using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TransformationLocalWorld : MonoBehaviour
{
    public Vector2 worldPos;

    //public Vector2 localPos;
    void OnDrawGizmos()
    {
        //Vector2 worldPos = LocalToWorld(localPos);
        worldPos = WorldToLocal(worldPos);
        Gizmos.DrawSphere(worldPos, 0.1f);
    }

    //3A
    Vector2 LocalToWorld(Vector2 local)
    {
        Vector2 position = transform.position;
        position += local.x * (Vector2)transform.right;
        position += local.y * (Vector2)transform.up;
        return position;
    }
   
    //3B
    Vector2 WorldToLocal(Vector2 local) 
    { 
        Vector2 rel = worldPos - (Vector2)transform.position;
        float x = Vector2.Dot(rel, transform.right);
        float y = Vector2.Dot(rel, transform.up);
        return new(x, y);
    }
}
