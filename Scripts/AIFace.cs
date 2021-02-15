using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIFace : MonoBehaviour {

    public Transform target;

    Vector3 direction;

    void Update()
    {
        direction = transform.position - target.position;
        transform.rotation = Quaternion.LookRotation(direction);
    }
}
