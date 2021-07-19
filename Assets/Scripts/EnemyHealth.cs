using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int maxHitPoints = 5;
    int currnetHitPoint = 0;
    // Start is called before the first frame update
    void Start()
    {
        currnetHitPoint = maxHitPoints;
    }

    private void OnParticleCollision(GameObject other)
    {
        ProcessHit();
    }

    private void ProcessHit()
    {
        currnetHitPoint--;
        if(currnetHitPoint <= 0)
        {
            Destroy(gameObject);
        }
    }
}
