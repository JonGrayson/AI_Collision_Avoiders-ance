using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFollow : Seek
{
    public GameObject[] objectPath;

    int currentIndex = 0;

    float targetRadius = .5f;

    public override SteeringOutput getSteering()
    {

        target = objectPath[currentIndex];

        float targetDistance = (character.transform.position - target.transform.position).magnitude;

        if (targetDistance < targetRadius)
        {
            currentIndex++;

            if (currentIndex > objectPath.Length - 1)
            {
                currentIndex = 0;
            }

            else
            {
                target = objectPath[currentIndex];
            }
        }

        return base.getSteering();
    }
}
