using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFollower : Kinematic
{
    PathFollow myMoveType;
    public GameObject[] myPath;

    private void Start()
    {
        myMoveType = new PathFollow();
        myMoveType.character = this;
        myMoveType.objectPath = myPath;
    }

    protected override void Update()
    {
        steeringUpdate = new SteeringOutput();
        steeringUpdate.linear = myMoveType.getSteering().linear;
        base.Update();
    }
}
