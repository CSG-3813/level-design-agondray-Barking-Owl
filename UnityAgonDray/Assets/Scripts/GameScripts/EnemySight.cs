/***
 * Author: Andrew Nguyen
 * Created: 27 November 2022
 * Modified: 27 November 2022
 * Description: Manages enemy's ability to chase the player
 ***/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SphereCollider))]
public class EnemySight : MonoBehaviour
{
    public Transform EyePoint;
    private bool SightedTarget = false;
    public string TargetTag = "Player";
    public float FieldOfView = 90f;
    public bool IsTargetSighted { get; set; } = false;
    public Vector3 LastSighted { get; set; } = Vector3.zero;

    private SphereCollider ThisRange;

    private void Awake()
    {
        ThisRange = GetComponent<SphereCollider>();
        LastSighted = transform.position;
    }

    private bool TargetInFOV(Transform target)
    {
        Vector3 DirToTarget = target.position - EyePoint.position;
        float angle = Vector3.Angle(EyePoint.forward, DirToTarget);

        if (angle <= FieldOfView)
        {
            return true;
        }

        return false;
    }

    private bool HasClearSightToTarget(Transform target)
    {
        RaycastHit info;

        Vector3 DirToTarget = (target.position - EyePoint.position).normalized;

        if (Physics.Raycast(EyePoint.position, DirToTarget, out info, ThisRange.radius))
        {
            if (info.transform.CompareTag(TargetTag))
            {
                return true;
            }
        }

        return false;
    }

    private void UpdateSight(Transform target)
    {
        SightedTarget = HasClearSightToTarget(target) && TargetInFOV(target);
        if (SightedTarget)
        {
            LastSighted = target.position;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag(TargetTag))
        {
            Debug.Log("Player spotted");
            UpdateSight(other.transform);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(TargetTag))
        {
            SightedTarget = false;
        }
    }

}
