using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPlayer : MonoBehaviour
{

    [SerializeField] public int currentHealth;
    [SerializeField] private int maxHealth;

    private void Update()
    {
        checkDeath();
        healthUI();
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
        //Aqui va lo que queramos que pase cuando muera, encender menus, destruir al player, etc
    }

    private void healthUI()
    {
        switch (currentHealth)
        {
            case 3:
                break;
            case 2:
                break;
            case 1:
                break;
            case 0:
                break;
        }
    }

}
