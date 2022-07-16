using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameplayManager_4 : MonoBehaviour
{
    public GameObject startScreen;
    //bool started;
    private void Awake()
    {
        SceneManager.LoadScene("Background Operations", LoadSceneMode.Additive);
        Time.timeScale = 0;
        PlayerPrefs.SetString("Current Level", "Level 4");
    }
    // Start is called before the first frame update
    void Start()
    {
        //started = false;
        startScreen.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startLevel4()
    {
        startScreen.SetActive(false);
        Time.timeScale = 1;
        //started = true;
    }
    public void Restart()
    {
        SceneManager.LoadScene("Level 4");

    }
}
