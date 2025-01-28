using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthPlayer : MonoBehaviour
{

    [SerializeField] public int currentHealth;
    [SerializeField] private int maxHealth;
    [SerializeField] private RawImage[] hearts;

        [SerializeField]  private GameObject derrotaui;

         [SerializeField] private AudioSource song;

   

    private void Update()
    {
        checkDeath();
        UpdateHealthUI();
    }

    public void takeDamage()
    {
        currentHealth--;
    }

    private void checkDeath()
    {
        if(currentHealth <= 0)
        {
            death();
        }
    }

    private void death()
    {
        Debug.Log("Fallecido");
        derrotaui.SetActive(true);
        song.Pause(); 

        //Aqui va lo que queramos que pase cuando muera, encender menus, destruir al player, etc
    }

    private void UpdateHealthUI()
    {
        // Recorremos el array de corazones y desactivamos seg�n la salud actual.
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < currentHealth)
            {
                hearts[i].gameObject.SetActive(true);
            }
            else
            {
                hearts[i].gameObject.SetActive(false); 
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Enemigo");
            takeDamage();
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        
    }
    
   

    

}
