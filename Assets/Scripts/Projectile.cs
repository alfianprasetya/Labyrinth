using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField, Range(10,50)] float speed = 20;
    
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Ball"))
        {
            Destroy(this.gameObject);
        }
        else if(other.CompareTag("Terrain"))
        {
            Destroy(this.gameObject);
        }
    
    }
}
