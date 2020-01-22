using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIFlee : MonoBehaviour {

    public float velocity = 2f;

    float MaxVelocity = 2f;

    float time;

    public Transform target;

    Vector3 direction;

    Vector3 moveDirection;

    void Update()
    {
        direction = transform.position - target.position;
        transform.rotation = Quaternion.LookRotation(direction);
        transform.position += transform.TransformDirection(Vector3.forward) * velocity * Time.deltaTime;
        //velocity += velocity + 1;
    }
}
