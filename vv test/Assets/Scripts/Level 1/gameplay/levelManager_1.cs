using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelManager_1 : MonoBehaviour
{
    // Start is called before the first frame update

    private void Awake()
    {
        SceneManager.LoadScene("Background Operations", LoadSceneMode.Additive);
    }
    public void restartLevel()
    {
        //restart level by reloading scene
        SceneManager.LoadScene("Level 1");
    }

    public void proceedToNextLevel()
    {
        SceneManager.LoadScene("Level 2");
    }
}
