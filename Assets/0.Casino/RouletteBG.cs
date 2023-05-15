using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteBG : MonoBehaviour
{
    float startSpeed = 100;
    float delaySpeed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("RotateRoullet", 1f, 0.001f);
    }

    void RotateRoullet()
    {
        if (startSpeed > 0)
        {
            startSpeed -= delaySpeed;
        }
        else
        {
            startSpeed = 0;
        }


        transform.Rotate(Vector3.back * Time.deltaTime * startSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
