using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelManager : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject pauseMenu;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            pauseMenu.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void resumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }
}
