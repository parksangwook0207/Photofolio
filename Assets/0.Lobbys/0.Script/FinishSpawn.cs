using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishSpawn : MonoBehaviour
{
    [SerializeField] private GameObject finishim;
    [SerializeField] private Transform parent;

    float finishvalue = 30;
    public int speed = 10;
    private void Start()
    {
       
    }
    // Update is called once per frame
    void Update()
    {
        if (Score.coin == finishvalue)
        {
            Instantiate(finishim, parent);
        }
        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }
}
