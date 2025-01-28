using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Vector2 moveDirection;
    [SerializeField] private float moveSpeed;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Attack attack;
    [SerializeField] public bool hasKey;
    // [SerializeField] private Animator anim;

     public GameObject llave;

    private void Start()
    {
        hasKey = false;
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Movement();
        // Animation();
        attack.attackDirection(moveDirection);

        if (hasKey)
        {
            llave.SetActive(true);
        }
        else
        {

            llave.SetActive(false);
        }
            
    }

    private void Movement()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        moveDirection = new Vector2(moveX, moveY);
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);

    }

    private void CheckDirection()
    {
        Debug.Log("Direcci�n actual: " + moveDirection);
    }
    /*
    private void Animation()
    {
        anim.SetFloat("moveX", moveDirection.x);
        anim.SetFloat("moveY", moveDirection.y);
    }
    */


     private void OnTriggerEnter2D(Collider2D other)
    {
            if (other.tag == "key")
         {
            
            hasKey = true;
            Destroy(other.gameObject);
            
         }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Exit") && hasKey)
        {
            Debug.Log("Victoria");
            //Funcion de victoria
        }
    }
}
