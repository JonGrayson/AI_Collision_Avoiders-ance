using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Face : Align
{
    // TODO: override Align's getTargetAngle to face the target instead of matching it's orientation

    public GameObject playerTarget;

    public override float getTargetAngle()
    {
        Vector3 direction = target.transform.position - character.transform.position;

        // --- replace me ---
        character.transform.rotation = Quaternion.LookRotation(direction);
        float targetAngle = 0f;
        // ------------------

        return targetAngle;
    }
}
