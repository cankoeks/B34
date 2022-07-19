using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class B3_SceneHandler : MonoBehaviour
{
    public static bool isGameOver = false;
    public static bool isMainScreen = false;
    public static bool isLevel_1 = false;
    // Start is called before the first frame update
    void Awake()
    {
        isGameOver = false;

        if(SceneManager.GetActiveScene().name == "B3_Level_1")
        {
            isLevel_1 = true;
            isMainScreen = false;
        }
        if (SceneManager.GetActiveScene().name == "B3_Mainscreen")
        {
            isLevel_1 = false;
            isMainScreen = true;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver)
        {
            StartCoroutine(restartRoutine());
        }

        if (isLevel_1 && SceneManager.GetActiveScene().name != "B3_Level_1")
        {
            SceneManager.LoadScene("B3_Level_1");
        }

        if (isMainScreen && SceneManager.GetActiveScene().name != "B3_Mainscreen")
        {
            SceneManager.LoadScene("B3_Mainscreen");
        }

        if (Input.GetKey(KeyCode.X) && isLevel_1)
        {
            isLevel_1 = false;
            isMainScreen = true;
            SceneManager.LoadScene("B3_Mainscreen");
        }

    }

    public void StartLevel_1()
    {
        Debug.Log("StartLevel1 Executed");
        isLevel_1 = true;
        isMainScreen = false;
    }
    IEnumerator restartRoutine()
    {
        SceneManager.LoadScene("B3_Level_1");
        yield return 0;
    }
}
