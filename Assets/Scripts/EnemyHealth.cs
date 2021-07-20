using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int maxHitPoints = 5;
    [SerializeField] int currentHitPoint = 0;
    // Start is called before the first frame update
    void OnEnable()
    {
        currentHitPoint = maxHitPoints;
    }

    private void OnParticleCollision(GameObject other)
    {
        ProcessHit();
    }

    private void ProcessHit()
    {
        currentHitPoint--;

        if(currentHitPoint <= 0)
        {
            gameObject.SetActive(false);
        }
    }
}
