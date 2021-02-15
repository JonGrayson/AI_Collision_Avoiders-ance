using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleAvoidance : Seek
{
    public float avoidDistance = 3f;

    public float lookAheadValue = 5f;

    protected override Vector3 getTargetPosition()
    {
        RaycastHit hitLine;

        if (Physics.Raycast(character.transform.position, character.linearVelocity, out hitLine, lookAheadValue))
        {
            Debug.DrawRay(character.transform.position, character.linearVelocity.normalized * hitLine.distance, Color.red, .5f);
            Debug.Log("hit the wall" + hitLine.collider);
            return hitLine.point + (hitLine.normal * avoidDistance);
        }

        else
        {
            Debug.DrawRay(character.transform.position, character.linearVelocity.normalized * lookAheadValue, Color.green, .5f);
            Debug.Log("didn't hit the wall");
            return base.getTargetPosition();
        }
    }
}
