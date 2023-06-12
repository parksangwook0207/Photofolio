using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Score : MonoBehaviour
{
    public TMP_Text text;
    public static int scoreValue;

    public void Awake()
    {
        scoreValue = 0;
        text = GetComponent<TMP_Text>();
        Setscore();
    }


    void Setscore()
    {
        text.text = "Score : " + scoreValue.ToString();
    }

    
}
