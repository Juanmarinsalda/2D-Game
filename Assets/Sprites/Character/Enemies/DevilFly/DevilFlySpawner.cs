using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DevilFlySpawner : MonoBehaviour
{
    float timer;
    int EnemyCant = 0;
    public GameObject Enemy;
    public int MaxEnemiesPerLvl;

    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= 5f && EnemyCant <= MaxEnemiesPerLvl)
        {
            timer = 0;
            Instantiate(Enemy);
            EnemyCant++;
        }
    }
}
