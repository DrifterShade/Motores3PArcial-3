using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private Transform player;
    [SerializeField] private bool isPlayerInRange = false; 
    private Rigidbody2D rb; 
   // private Animator anim; Falta etso del animator
    [SerializeField] private Vector2 moveDirection; 

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
       // anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if (isPlayerInRange)
        {
            FollowPlayer();
        }
        else
        {
            rb.velocity = Vector2.zero;
            UpdateAnimation(Vector2.zero); 
        }
    }

    private void FollowPlayer()
    {
     
        moveDirection = (player.position - transform.position).normalized;

        rb.velocity = moveDirection * moveSpeed;

        UpdateAnimation(moveDirection);
    }

    private void UpdateAnimation(Vector2 direction) //Esta e sla parte de las animaciones
    {
       // anim.SetFloat("moveX", direction.x);
       // anim.SetFloat("moveY", direction.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isPlayerInRange = true;
            player = collision.transform;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isPlayerInRange = false;
            player = null;
        }
    }
}
