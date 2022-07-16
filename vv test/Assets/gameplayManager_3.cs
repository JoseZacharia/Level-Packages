using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameplayManager_3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        SceneManager.LoadScene("Background Operations", LoadSceneMode.Additive);
        Time.timeScale = 1;
        PlayerPrefs.SetString("Current Level", "Level 3");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void restartLevel3()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Level 3");
    }

    public void proceedToNextLevel()
    {
        SceneManager.LoadScene("Level 4");
    }
}
