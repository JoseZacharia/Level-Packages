using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class bossHealth_3 : MonoBehaviour
{
    // Start is called before the first frame update

    public int maxBossHealth;
    public GameObject bossHealthCounterObject;

    private int currentBossHealth;
    private TextMeshProUGUI bossHealthCounter;

    void Start()
    {
        currentBossHealth = maxBossHealth;
        StartCoroutine(activateBossHealthCounter());
        bossHealthCounter = bossHealthCounterObject.transform.Find("Boss Health Counter").GetComponent<TextMeshProUGUI>();
        updateBossHealthCounter();
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
            updateBossHealthCounter();
            //print(currentBossHealth);
        }

    }

    public void updateBossHealthCounter()
    {
        bossHealthCounter.text = currentBossHealth.ToString();
    }

    IEnumerator activateBossHealthCounter()
    {
        yield return new WaitForSeconds(2);
        bossHealthCounterObject.SetActive(true);
    }
}
