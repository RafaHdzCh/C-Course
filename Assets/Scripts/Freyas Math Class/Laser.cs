using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public int maxReflections = 4;

    private void OnDrawGizmos()
    {
        Vector2 origin = transform.position;
        Vector2 dir = transform.up;
        Ray ray = new Ray(origin,dir);

        for(int i=0; i<maxReflections; i++)
        {
            if(Physics.Raycast(ray, out RaycastHit hit))
            {
                Gizmos.color = Color.green;
                Gizmos.DrawLine(ray.origin, hit.point);
                Gizmos.DrawSphere(hit.point, 0.1f);
                Vector2 reflected = Reflect(ray.direction, hit.normal);
                
                Gizmos.color = Color.white;
                Gizmos.DrawLine(hit.point, (Vector2)hit.point + reflected);
                ray.direction = reflected;
                ray.origin = hit.point;
            }
        }
    }
    Vector2 Reflect(Vector2 inDir, Vector2 n)
    {
        float proj = Vector2.Dot(inDir, n);
        return inDir - 2 * proj * n;
    }
}