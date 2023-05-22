using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretMovement : MonoBehaviour
{
    [SerializeField] Transform ball;
    [SerializeField] Projectile projectilePrefab;
    [SerializeField] AudioManager audioManager;
    [SerializeField] AudioClip shootClip;

    float timer = 2;
    Vector3 projectileSpawnPosition;

    private void Start() 
    {
        projectileSpawnPosition = this.transform.position;    
    }
    
    // Update is called once per frame
    void Update()
    {
        transform.LookAt(ball);

        if(timer <= 0)
        {
            timer = 2;
            var shoot = Instantiate(projectilePrefab, projectileSpawnPosition, this.transform.rotation);
            audioManager.PlaySFX(shootClip);
            return;
        }

        timer -= Time.deltaTime;
    }

    
}
