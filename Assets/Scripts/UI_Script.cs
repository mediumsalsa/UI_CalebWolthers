using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UI_Script : MonoBehaviour
{



    public int score;


    public TMPro.TMP_Text textScore;

    //public TextMeshProUGUI textScore;



    private void Start()
    {
        //textScore = GetComponent<TMP_Text>();

        score = 0;

        textScore.text = "Score: " + score;
    }



    public void UpdateScore(int num)
    {
        if (num == 0)
        {
            score = 0;
            textScore.text = "Score: " + score;
        }
        else 
        {
            score += num;

            if (score >= 1000000000)
            {
                score = 999999999;
            }
            else if (score <= -100000000)
            {
                score = -99999999;
            }

            textScore.text = "Score: " + score;
            
            
        }

    }







}
