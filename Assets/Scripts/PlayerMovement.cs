using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject puerta;
    private Rigidbody2D rb;
    private SpriteRenderer sprite;
    private Animator anim;
    public float jumpForce = 7f;
    public float speed = 14f;
    public BoxCollider2D coll;
    public LayerMask jumpableGround;
    private float dirX = 0f;


    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        coll = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        dirX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(dirX * 7, rb.velocity.y);

        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(rb.velocity.x, jumpForce);
        }

        UpdateAnimationUpdate();

      
    }

    private void UpdateAnimationUpdate()
    {
        if (dirX > 0f)
        {
            anim.SetBool("running", true);
            sprite.flipX = false;
        }
        else if (dirX < 0f)
        {
            anim.SetBool("running", true);
            sprite.flipX = true;
        }
        else
        {
            anim.SetBool("running", false);
        }
    }
    public bool IsGrounded()
    {
       return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, .1f, jumpableGround);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag.Equals("Item"))
        {
            counterItems.numberItem += 1;
            Destroy(collision.gameObject);

            if(counterItems.numberItem == 3)
            {
                puerta.SetActive(false);
            }
        }
    }
}
