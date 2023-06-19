using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameFinish : MonoBehaviour
{
    public GameObject finishpanel;
    

    float finishCnt = 30;
    // Start is called before the first frame update

    private void Awake()
    {
        finishpanel.SetActive(false);
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Score.coin == finishCnt)
        {
            finishpanel.SetActive(true);           
        }
    }
    public void OnReturn()
    {
        SceneManager.LoadScene("Lobby Scene");
        if (finishpanel.gameObject.activeInHierarchy == true)
        {
            finishpanel.SetActive(false);
        }       
    }
}
