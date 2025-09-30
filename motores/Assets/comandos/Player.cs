using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    public float velocidade = 20;
    public float forcaDoPulo = 4;
    
    private bool noChao = false;
    
    private SpriteRenderer sprite;
    private Rigidbody2D rb;
    
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
    }

       
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.position += new Vector3(-velocidade * Time.deltaTime,0,0);
            sprite.flipX = true;
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.position += new Vector3(velocidade * Time.deltaTime,0,0);
            sprite.flipX = false;
        }

        if (Input.GetKeyDown(KeyCode.Space) && noChao == true)
        {
            rb.AddForce(new Vector2(0,forcaDoPulo), ForceMode2D.Impulse);
        }

    }

    void OnCollisionEnter2D(Collision2D colisao)
    {
        //if (colisao.gameObject.tag == "Chao")
        if(colisao.gameObject.CompareTag("Chao"))
        {
            noChao = true;
        }
    }

    void OnCollisionExit2D(Collision2D colisao)
    {
        if(colisao.gameObject.CompareTag("Chao"))
        {
            noChao = false;
        }
    }
}