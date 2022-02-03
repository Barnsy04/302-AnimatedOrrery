using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GUIDemo : MonoBehaviour
{

    public TMP_Text textPlayerHealth;

    public Slider slider;

    void Start()
    {
        if (slider) slider.value = Time.timeScale;
    }


    void Update()
    {
        //textPlayerHealth.text = ("Adjust Time Speed");
    }

    public void StartButtonClicked()
    {
        
        Time.timeScale = 0.5f;
        
    }
    public void StopButtonClicked()
    {
        
        Time.timeScale = 0;

    }
   // public void FFButtonClicked()
   //{
   //
   //     Time.timeScale = 2;
   //
   // }
   //public void RewindButtonClicked()
   //{
   //
   //    Time.timeScale = -1;
   //
   //}
    public void SliderUpdated(float value)
    {
        Time.timeScale = value;
    }
}
