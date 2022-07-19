using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class B4_SceneHandler : MonoBehaviour
{
    public static bool isMainscreen_b4 = false;
    public static bool isGame = false;
    // Start is called before the first frame update
    void Awake()
    {
        if(SceneManager.GetActiveScene().name == "B4_Game")
        {
            isGame = true;
            isMainscreen_b4 = false;
        }
        if (SceneManager.GetActiveScene().name == "B4_Mainscreen")
        {
            isGame = false;
            isMainscreen_b4 = true;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (isGame && SceneManager.GetActiveScene().name != "B4_Game")
        {
            SceneManager.LoadScene("B4_Game");
        }

        if (isMainscreen_b4 && SceneManager.GetActiveScene().name != "B4_Mainscreen")
        {
            SceneManager.LoadScene("B4_Mainscreen");
        }

        if (Input.GetKey(KeyCode.X) && isGame)
        {
            isGame = false;
            isMainscreen_b4 = true;
            SceneManager.LoadScene("B4_Mainscreen");
        }

    }

    public void EnterWorld()
    {
        isGame = true;
        isMainscreen_b4 = false;
    }
}
