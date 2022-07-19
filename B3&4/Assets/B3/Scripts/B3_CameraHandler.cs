using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B3_CameraHandler : MonoBehaviour
{
    [SerializeField] GameObject ball;
	void Update()
    {
        Vector3 pos = new Vector3(ball.transform.position.x, ball.transform.position.y+2.5f, ball.transform.position.z-5) ;
        transform.position = pos;
    }
}

