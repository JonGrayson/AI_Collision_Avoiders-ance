using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetFacer : Kinematic
{
    Face myMoveType;

    private void Start()
    {
        myMoveType = new Face();
        myMoveType.character = this;
        myMoveType.target = myTarget;
    }

    protected override void Update()
    {
        steeringUpdate = new SteeringOutput();
        steeringUpdate.linear = myMoveType.getSteering().linear;
        base.Update();
    }
}
