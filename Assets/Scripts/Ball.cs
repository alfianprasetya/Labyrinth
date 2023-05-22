using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] Rigidbody thisRigidBody;

    private void OnTriggerEnter(Collider other) {

        if(other.CompareTag("Projectile"))
        {
            thisRigidBody.AddExplosionForce(500f, other.transform.position, 5f); 
        }
    }

}
