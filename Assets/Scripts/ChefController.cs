using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChefController : MonoBehaviour
{
    public float speed;
    public float fastRatio;

    private void Update()
    {
        if (Input.GetKey(KeyCode.D) && transform.position.x < 8.5)
        {
            if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
            {
                transform.Translate(speed * fastRatio * Time.deltaTime, 0, 0);

            }
            else
            {
                transform.Translate(speed * Time.deltaTime, 0, 0);

            }
        }
        
        if (Input.GetKey(KeyCode.A) && transform.position.x > -8.5)
        {
            if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
            {
                transform.Translate(-speed * fastRatio * Time.deltaTime, 0, 0);
            }
            else
            {
                transform.Translate(-speed * Time.deltaTime, 0, 0);
            }
        }

    }
}
