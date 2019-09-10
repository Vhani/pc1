using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agent : MonoBehaviour
{
    Vector3 velocity = Vector3.zero;
    Vector3 desired = Vector3.zero;
    Vector3 steer = Vector3.zero;
    

    float maxSpeed = 5;
    float maxSteer = 1;

    Transform target;
 
   
    void Update()
    {
        target = GameObject.Find("Target").transform;
        //desired
        desired = (target.position - transform.position).normalized * maxSpeed;

        //steer
        steer = Vector3.ClampMagnitude(desired - velocity, maxSteer);

        velocity = steer * Time.deltaTime;
        transform.position -=velocity;

        if(transform.position.x <= 0.5 & transform.position.x >= -0.5)
        {
            Debug.Log("¡You win!");
            Destroy(gameObject);
        }else if(transform.position.y <= 0.3 & transform.position.y > -0.3)
        {
            Debug.Log("¡You win");
            Destroy(gameObject);
        }
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
        Debug.Log("You Lose");
    }
}
