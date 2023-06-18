using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    
    [SerializeField] private float startY = 150;
    [SerializeField] private float removeX = -100;

    public int speed = 10;

    public bool isbool = false;

    private RectTransform rect;

    

    private void Start()
    {
        rect = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rect.anchoredPosition.x > removeX)
        {           
            Destroy(gameObject);                       
        }
        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }
}
