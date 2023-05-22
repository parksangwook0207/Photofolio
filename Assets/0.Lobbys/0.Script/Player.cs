using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float speed = 10f;
    Rigidbody rigidbody;
    

    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody.MovePosition(Vector3.up * speed * Time.deltaTime);
        }
    }
}
