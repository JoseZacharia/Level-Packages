using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameplayManager_4 : MonoBehaviour
{

    private void Awake()
    {
        SceneManager.LoadScene("Background Operations", LoadSceneMode.Additive);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Restart()
    {
        SceneManager.LoadScene("Level 4");

    }
}