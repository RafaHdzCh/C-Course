using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class WedgeTrigger : MonoBehaviour
{
    public float radius = 1;
    public float height = 1;
    [Range(0, 1)]
    public float angThresh = 0.5f;

    public Transform target;

    private void OnDrawGizmos()
    {
        //Local position

        Gizmos.matrix = Handles.matrix = transform.localToWorldMatrix;
        Gizmos.color = Handles.color = Contains(target.position) ? Color.white : Color.red;

        Vector3 top = new Vector3(0, height, 0);

        Handles.DrawWireDisc(default, Vector3.up, radius);
        Handles.DrawWireDisc(top, Vector3.up, radius);

        float p = angThresh;
        float x = Mathf.Sqrt(1 - p * p);

        Vector3 vLeft = new Vector3(-x, 0, p) * radius;
        Vector3 vRight = new Vector3(x, 0, p) * radius;

        Gizmos.DrawRay(default, vLeft);
        Gizmos.DrawRay(default, vRight);
        Gizmos.DrawRay(top, vLeft);
        Gizmos.DrawRay(top, vRight);

        Gizmos.DrawLine(default, top);
        Gizmos.DrawLine(vLeft, top + vLeft);
        Gizmos.DrawLine(vRight, top + vRight);

        /*
         * Global position
         * 
        Vector3 origin = transform.position;
        Vector3 up = transform.up;
        Vector3 right = transform.right;
        Vector3 forward = transform.forward;

        Vector3 top = origin+ up * radius;
         
        Handles.DrawWireDisc(origin, up, radius);
        Handles.DrawWireDisc(top, up, radius);

        float p = angThresh;
        float x = Mathf.Sqrt(1 - p * p);

        Vector3 vLeft = (forward * p + right * (-x)) * radius;
        Vector3 vRight = (forward * p + right * (x)) * radius;
        
        Gizmos.DrawRay(origin, vLeft);
        Gizmos.DrawRay(origin, vRight);
        Gizmos.DrawRay(top, vLeft);
        Gizmos.DrawRay(top, vRight);

        Gizmos.DrawLine(origin, top);
        Gizmos.DrawLine(origin + vLeft, top + vLeft);
        Gizmos.DrawLine(origin + vRight, top + vRight);
        */
    }

    public bool Contains(Vector3 _position)
    {
        Vector3 vecToTargetWorld = (_position - transform.position);

        //inverse transform is world to local
        Vector3 vecTotarget = transform.InverseTransformVector(vecToTargetWorld);

        //height position check
        if((vecTotarget.y < 0) || (vecTotarget.y > height))
        {
            return false; //outside the range
        }

        //angular check
        Vector3 flatDirToTarget = vecTotarget;
        flatDirToTarget.y = 0;
        float flatDistance = flatDirToTarget.magnitude;
        flatDirToTarget = flatDirToTarget / flatDistance;
        if(flatDirToTarget.z < angThresh)
        {
            return false;
        }
        if(flatDistance > radius)
        {
            return false;
        }

        return true;
    }
}
