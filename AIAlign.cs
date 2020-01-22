using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIAlign : MonoBehaviour
{

    public Transform target;

    Vector3 direction;

    void Update()
    {
        transform.rotation = target.rotation;
        
    }
}
