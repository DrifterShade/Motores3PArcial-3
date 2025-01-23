using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{

    [SerializeField] private Transform attackZone;
    [SerializeField] private Transform playerTrnaform;
    [SerializeField] private GameObject DetectorAttackZone;

    [SerializeField] private bool canAttack;
    [SerializeField] private float cooldownTime, coolTime;
    // Start is called before the first frame update
    void Start()
    {
        playerTrnaform = GetComponent<Transform>();
        DetectorAttackZone.SetActive(false);
        canAttack = true;
    }

    // Update is called once per frame
    void Update()
    {
        attack();
    }

    public void attackDirection(Vector2 direction)
    {
        if(direction.x == 1)
        {
            attackZone.position = new Vector2(playerTrnaform.position.x + .85f, playerTrnaform.position.y);
        }
        else if(direction.x == -1)
        {
            attackZone.position = new Vector2(playerTrnaform.position.x -1.65f, playerTrnaform.position.y);
        }
        else if(direction.y == 1)
        {
            attackZone.position = new Vector2(playerTrnaform.position.x -0.36f, playerTrnaform.position.y + 1.82f);
        }
        else if(direction.y == -1)
        {
            attackZone.position = new Vector2(playerTrnaform.position.x - 0.36f, playerTrnaform.position.y - 1.8f);
        }
    }

    private void attack()
    {
        if (Input.GetKeyDown(KeyCode.Space) && canAttack)
        {
            DetectorAttackZone.SetActive(true);
            StartCoroutine(cooldownAttack(cooldownTime));
            
        }
    }

    private IEnumerator cooldownAttack(float time)
    {
        canAttack = false;
        yield return new WaitForSeconds(time);
        DetectorAttackZone.SetActive(false);
        yield return new WaitForSeconds(coolTime);
        canAttack = true;
    }

    
}
