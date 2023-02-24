using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vectors : MonoBehaviour
{
    public Transform A;
    public Transform B;

    public float dotValue;

    private void OnDrawGizmos()
    {
        //Declrarar vectores
        Vector2 a = A.position;
        Vector2 b = B.position;

        //Dibujarlos
        Gizmos.color = Color.red;
        Gizmos.DrawLine(default, a);

        Gizmos.color = Color.cyan;
        Gizmos.DrawLine(default, b);

       
        //Obtener la magnitud
        float aLength = a.magnitude;
        //float aLength= Mathf.Sqrt(a.x * a.x + a.y * a.y);

        //Normalizar un vector
        Vector2 aNorm = a.normalized;
        //Vector2 aNorm = a / aLength;

        Gizmos.color = Color.red;
        Gizmos.DrawSphere(aNorm, 0.05f);

        //Sscalar Projection
        dotValue = Vector2.Dot(aNorm, b);

        //Vector projection
        Vector2 vecProj = aNorm * dotValue;
        Gizmos.color = Color.white;
        Gizmos.DrawSphere(vecProj, 0.05f);
    } 
}
