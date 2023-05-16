using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteBall : MonoBehaviour
{
    [SerializeField] Transform parent;
    float startSpeed = 100;
    float delaySpeed = 0.01f;

    float ballHeight = 640;

    // Start is called before the first frame update
    void Start()
    {
        
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
            CancelInvoke("RotateRoullet");
        }

        transform.Rotate(Vector3.back * Time.deltaTime * startSpeed);
    }

    public void OnStart()
    {
        ballHeight = 640;
        startSpeed = 100;
        InvokeRepeating("RotateRoullet", 1f, 0.001f);
    }
}
