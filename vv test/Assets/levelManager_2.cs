using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelManager_2 : MonoBehaviour
{
    // Start is called before the first frame update

    private void Awake()
    {
        SceneManager.LoadScene("Background Operations", LoadSceneMode.Additive);
        Time.timeScale = 1;
        PlayerPrefs.SetString("Current Level", "Level 2");
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void restart()
    {
        SceneManager.LoadScene("Level 2");
    }

    public void proceed()
    {
        SceneManager.LoadScene("Level 3");
    }
}
