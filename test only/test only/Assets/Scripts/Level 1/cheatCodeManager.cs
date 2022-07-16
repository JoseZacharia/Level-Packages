using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cheatCodeManager : MonoBehaviour
{
    [SerializeField]
    private bool playerTyping = false;
    [SerializeField]
    private string currentString = "";

    [SerializeField]
    private List<cheatCodeInstance> cheatCodeList = new List<cheatCodeInstance>();

    private void Start()
    {
        print(SceneManager.GetActiveScene().buildIndex);
        print(SceneManager.GetActiveScene().name);
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            playerTyping = true;
        }
        if (playerTyping)
        {
            foreach(char c in Input.inputString)
            {
                if(c == '\b')
                {
                    if (currentString.Length > 0)
                        currentString = currentString.Substring(0, currentString.Length - 1);
                }
                else if (c == '\n' || c == '\r')
                {
                    checkCheat(currentString);
                    playerTyping = false;
                    currentString = "";
                }
                else
                {
                    currentString += c;
                }
            }
        }
    }

    private bool checkCheat(string input)
    {
        foreach (cheatCodeInstance code in cheatCodeList)
        {
            if (input == code.code)
            {
                code.cheatEvent?.Invoke();
                return true;
            }
        }
        return false;
    }   

    public void progress()
    {
       // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void exit()
    {
        print("exit");
    }
}
