using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class StartGame4 : MonoBehaviour
{     
    public GameObject GameFullOverPanel;
    public float maxTimeLeft;
   // [SerializeField] TextMeshProUGUI countdowntext;
    public Slider timerSlider;

    private float timeLeft;

    private void Start()
    {
        timeLeft = maxTimeLeft;
        timerSlider.maxValue = timeLeft;
        timerSlider.value = 0;
    }
    void Update()
    {
        timeLeft -= Time.deltaTime;
        //countdowntext.text = ("Time Left : "+ (timeLeft).ToString("0.0"));
    
        if (timeLeft <= 0 && GameObject.FindGameObjectWithTag("Player") != null)
        { 
            GameFullOverPanel.SetActive(true);
            timeLeft = 0;
        }
        updateSlider();
    }

    void updateSlider()
    {
        timerSlider.value = maxTimeLeft - timeLeft;
    }


}
