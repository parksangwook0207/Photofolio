using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteBall : MonoBehaviour
{
    [SerializeField] RectTransform rectTrans;
    [SerializeField] Transform parent;
    float startSpeed = 500;
    float delaySpeed = 0.1f;

    float ballHeight = 640;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("RotateRoullet", 1f, 0.001f);
    }

    void RotateRoullet()
    {
        if (rectTrans.sizeDelta.y <= 540)
        {
            //transform.SetParent(parent);
            return;
        }

        if (startSpeed > 0)
        {
            startSpeed -= delaySpeed;
            ballHeight -= delaySpeed;
            rectTrans.sizeDelta = new Vector2(0, ballHeight);
        }
        else
        {
            startSpeed = 0;
        }


        transform.Rotate(Vector3.back * Time.deltaTime * startSpeed);
    }
}
