using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SocialPlatforms.Impl;

public class UI_Script : MonoBehaviour
{



    public int score;


    public TMPro.TMP_Text textScore;


    public TMPro.TMP_Text textPNG;


    public GameObject imagePNG;


    public Image imageRGB;

    public Slider redSlider;
    public Slider greenSlider;
    public Slider blueSlider;
    public Slider alphaSlider;


    public Button buttonCoin;
    public Slider progressBar;


    private void Start()
    {
        //
        progressBar.minValue = 0.0f;
        progressBar.maxValue = 10.0f;
        progressBar.value = 0.0f;


        score = 0;

        textScore.text = "Score: " + score;

        textPNG.text = "Hide";

        progressBar.interactable = false; 


        redSlider.maxValue = 1.0f;
        greenSlider.maxValue = 1.0f;
        blueSlider.maxValue = 1.0f;
        alphaSlider.maxValue = 1.0f;

        redSlider.minValue = 0.0f;
        greenSlider.minValue = 0.0f;
        blueSlider.minValue = 0.0f;
        alphaSlider.minValue = 0.0f;

        redSlider.value = 1.0f;
        greenSlider.value = 1.0f;
        blueSlider.value = 1.0f;
        alphaSlider.value = 1.0f;

    }

    private void Update()
    {
        Color newColor = new Color(redSlider.value, greenSlider.value, blueSlider.value, alphaSlider.value);
        imageRGB.color = newColor;
    }



    public void CoinFound()
    {
        if (progressBar.value < progressBar.maxValue)
        {
            progressBar.value += 1;
        }
    }















    public void UpdateScore(int num)
    {
        if (num == 0)
        {
            score = 0;

        }
        else 
        {
            score += num;

            score = Mathf.Clamp(score, 0, 999999999);
        }
        textScore.text = "Score: " + score;
    }



    public void RandomScore()
    {
        var rd = Random.Range(0, 999999999);

        score = rd;

        textScore.text = "Score: " + score;
    }





    public void HidePNG()
    {
        if (imagePNG.activeInHierarchy)
        {
            imagePNG.SetActive(false);
            textPNG.text = "Show";
        }
        else
        {
            imagePNG.SetActive(true);
            textPNG.text = "Hide";
        }
        
    }

    public void ExitGame()
    { 
        Application.Quit();
    }






}
