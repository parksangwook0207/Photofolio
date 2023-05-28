using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private List<Sprite> moveSprite;

    private SpriteAnimation sa;
    private 


    // Start is called before the first frame update
    void Start()
    {
        sa = GetComponent<SpriteAnimation>();
        sa.SetSprite(moveSprite,0.1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
