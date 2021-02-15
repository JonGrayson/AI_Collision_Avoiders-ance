using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pursuer : Kinematic
{
    Pursue myMoveType;

    private void Start()
    {
        myMoveType = new Pursue();
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
