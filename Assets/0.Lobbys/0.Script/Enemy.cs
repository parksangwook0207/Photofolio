using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float startY = 200;
    [SerializeField] private float removeX = -110;

    public int speed = 10;
    public bool isRemove = false;

   

    private RectTransform rect;

    private void Start()
    {
        rect = GetComponent<RectTransform>();
    }
    
    void Update()
    {
        if (rect.anchoredPosition.x > removeX)
        {
            if (isRemove)
            {
                Destroy(gameObject);

            }
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

    }
}
