using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private List<Sprite> moveSprite;

    private SpriteAnimation sa;
    private Rigidbody2D rigid;

    public float jumppower = 10f;
    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        //rigid.freezeRotation = true;
        sa = GetComponent<SpriteAnimation>();
        sa.SetSprite(moveSprite, 0.1f);
    }


    // Update is called once per frame
    void Update()
    {
        //AddForce : AddForce(¹æÇâ * Èû, ÈûÀÇ Á¾·ù)
        if (Input.GetKey(KeyCode.Space))
        {
            rigid.AddForce(Vector2.up * jumppower, ForceMode2D.Impulse);
        }
    }

    public void OnCollisionEnter2D(Collision2D coll)
    {
       
        if (coll.gameObject.CompareTag("Enemy"))
        {
            this.gameObject.SetActive(false);
        }
    }




}
