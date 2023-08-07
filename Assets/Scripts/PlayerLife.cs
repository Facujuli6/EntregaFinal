using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerLife : MonoBehaviour
{
    public Animator anim;
    public Rigidbody2D rb;
  
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
       anim = GetComponent<Animator>(); 
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Trap"))
        {
            Die();
        }
    }
    public void Die()
    {
        rb.bodyType = RigidbodyType2D.Static;
        anim.SetTrigger("death");
    }
    public void RestartLevel()
    {
     SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
