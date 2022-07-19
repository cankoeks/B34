using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class B3_HighscoreHandler : MonoBehaviour
{
    public static float highscore;

    private TMP_Text tp;
    void Start()
    {
        if (PlayerPrefs.HasKey("highscore"))
        {
            highscore = PlayerPrefs.GetFloat("highscore");
        }
        else
        {
            highscore = 0;
        }
        tp = GetComponent<TMP_Text>();
        tp.text = "Highscore: " + highscore.ToString("F2") + "s";
    }

    public static void SetHighscore()
    {
        if (PlayerPrefs.HasKey("highscore"))
        {
            highscore = PlayerPrefs.GetFloat("highscore");
            if (highscore >= B3_TimeHandler.timer)
            {
                PlayerPrefs.SetFloat("highscore", B3_TimeHandler.timer);
            }
        }
        else
        {
            PlayerPrefs.SetFloat("highscore", B3_TimeHandler.timer);
        }
    }
}
