using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evader : Kinematic
{
    Evade myMoveType;

    private void Start()
    {
        myMoveType = new Evade();
        myMoveType.target = myTarget;
        myMoveType.character = this;
    }

    protected override void Update()
    {
        steeringUpdate = new SteeringOutput();
        steeringUpdate.linear = myMoveType.getSteering().linear;
        base.Update();
    }
}
