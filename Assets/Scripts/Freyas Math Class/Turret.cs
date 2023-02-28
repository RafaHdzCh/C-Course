using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] WedgeTrigger wedgeTrigger;
    [SerializeField] Transform cannonTf;

    private void OnDrawGizmos()
    {
        Vector3 vecToTarget = target.position - cannonTf.position;
        Quaternion targetRotation;

        //Note: World space
        if (wedgeTrigger.Contains(target.position))
        {
            //cannonTf.rotation = Quaternion.Slerp(cannonTf.position, targetRotation)
        }
        else
        {
            cannonTf.rotation = default;
        }
    }
}
