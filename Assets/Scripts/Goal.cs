using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Goal : MonoBehaviour
{
    public UnityEvent onBallEnter = new UnityEvent();

    private void OnCollisionEnter(Collision other) 
    {
        OnTriggerEnter(other.collider);
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.CompareTag("Ball"))
        {
            onBallEnter.Invoke();
        }    
    }
}
