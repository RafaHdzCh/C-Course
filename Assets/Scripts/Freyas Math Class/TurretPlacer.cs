using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretPlacer : MonoBehaviour
{
    public Transform turret;

    private void OnDrawGizmos()
    {
        if (turret == null) return;

        Ray ray = new Ray(transform.position, transform.forward);

        if(Physics.Raycast(ray, out RaycastHit hit))
        {
            turret.position = hit.point;

            Vector3 yAxis = hit.normal;
            Vector3 zAxis = Vector3.Cross(transform.right, yAxis).normalized;

            Gizmos.color = Color.green;
            Gizmos.DrawRay(hit.point, yAxis);
            Gizmos.color = Color.blue;
            Gizmos.DrawRay(hit.point, zAxis);

            Gizmos.color = Color.white;
            Gizmos.DrawLine(ray.origin, hit.point);

            turret.rotation = Quaternion.LookRotation(zAxis, yAxis);
        }
    }
}
