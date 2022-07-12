using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossHealth_3 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemySpawnManager;

    public int maxBossHealth;

    private int currentBossHealth;

    void Start()
    {
        currentBossHealth = maxBossHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentBossHealth <= 0)
            Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {

            currentBossHealth--;
            print(currentBossHealth);
        }

    }
}
