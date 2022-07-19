using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B4_DayCycle : MonoBehaviour
{
    private Transform tf;
    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        tf = GetComponent<Transform>();   
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        
        if (timer >= 0.5f)
        {
            if (tf.rotation.x+5 >= 360)
            {
                tf.rotation = Quaternion.Euler(0, 0, 0);
            } else
            {
                tf.rotation = Quaternion.Euler(tf.rotation.x + 1, tf.rotation.y, tf.rotation.z);
            }
            timer = 0;
        }


    }
}
