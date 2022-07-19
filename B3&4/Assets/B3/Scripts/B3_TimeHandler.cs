using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class B3_TimeHandler : MonoBehaviour
{
    private TMP_Text tp;
    public static float timer = 0;
    void Start()
    {
        timer = 0;
        tp = GetComponent<TMP_Text>();
    }

    void Update()
    {
        timer += Time.deltaTime;
        tp.text = timer.ToString("F2");
    }
}
