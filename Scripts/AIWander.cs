using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIWander : MonoBehaviour {

    public float velocity = 2f;

    Vector3 waypoint;

    void Start()
    {
        waypoint = Random.insideUnitSphere * 47;
        waypoint.y = 1;
        transform.LookAt(waypoint);
    }

    void Update()
    {
        transform.position += transform.position * velocity * Time.deltaTime;
    }
}
