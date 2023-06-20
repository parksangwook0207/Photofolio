using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameFinish : MonoBehaviour
{
    public GameObject finishpanel;
    

    float finishCnt = 100;
    // Start is called before the first frame update

    private void Start()
    {
        finishpanel.SetActive(false);
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Score.coin == finishCnt)
        {
            finishpanel.SetActive(true);
            Time.timeScale = 0f;
        }
    }
    public void OnReturn()
    {
        SceneManager.LoadScene("Lobby Scene");
    }
}
