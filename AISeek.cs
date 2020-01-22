using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AISeek : MonoBehaviour {

    public float velocity = 2f;

    float MaxVelocity = 2f;

    float time;

    public Transform target;

    Vector3 direction;

    Vector3 moveDirection;

    void Update()
    {
        direction = target.position - transform.position;
        transform.rotation = Quaternion.LookRotation(direction);
        transform.position += transform.TransformDirection(Vector3.forward) * velocity * Time.deltaTime;
        //velocity += velocity + 1;
    }

    /*void Seek() //seek function that will have the AI move towards the player
    {
        direction = target.position - transform.position;
        transform.rotation = Quaternion.LookRotation(direction);
        moveDirection = direction.normalized * moveSpeed * Time.deltaTime;
        transform.LookAt(moveDirection);
        rb.AddForce(moveDirection);
    }*/ //Seek Code for old

    //transform.position += transform.TransformDirection(Vector3.forward) * moveSpeed * Time.deltaTime;
}
