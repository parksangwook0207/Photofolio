using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public TMP_Text text;
    public static int coin;

    void Start()
    {
        text = GetComponent<TMP_Text>();
    }
    void Update()
    {
        text.text = coin.ToString();
    }
}
