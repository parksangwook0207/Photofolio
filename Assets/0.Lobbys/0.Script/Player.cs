using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    [SerializeField] private List<Sprite> moveSprite;
    [SerializeField] private List<Sprite> jumpSprite;

    private SpriteAnimation sa;
    private Rigidbody2D rigid;

    public Animator anim;
  
    public float jumppower = 10f;
    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
       
        sa = GetComponent<SpriteAnimation>();
        sa.SetSprite(moveSprite, 0.1f);
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //AddForce : AddForce(¹æÇâ * Èû, ÈûÀÇ Á¾·ù)
        if (Input.GetKey(KeyCode.Space)) //!anim.GetBool("isWalk"))
        {
            rigid.AddForce(Vector3.up * jumppower, ForceMode2D.Impulse);
            anim.SetBool("isJump", true);
        }

        if (Mathf.Abs(rigid.velocity.x) < 0.5)
        {
            anim.SetBool("isWalk", false);
        }
        else
        {
            anim.SetBool("isWalk", true);
        }

        RaycastHit2D raycast = Physics2D.Raycast(rigid.position, Vector3.down, 1, LayerMask.GetMask(""));
        if (raycast.collider != null)
        {
            Debug.Log(raycast.collider.name);
        }
    }

    public void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("Enemy"))
        {
            this.gameObject.SetActive(false);
            Time.timeScale = 0;
        }       
    }
}
