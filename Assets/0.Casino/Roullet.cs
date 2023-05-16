using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roullet : MonoBehaviour
{
    [SerializeField] RouletteBG rBG;
    [SerializeField] RouletteBall rBall;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnStart()
    {
        //rBG.OnStart();
        rBall.OnStart();
    }
}
