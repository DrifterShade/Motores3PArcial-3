using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatueChange : MonoBehaviour
{
  [SerializeField] private GameObject statueDelay;
    [SerializeField] private int time = 0;
    [SerializeField] private GameObject bridge;
    [SerializeField] private GameObject  path;




    private void OnTriggerEnter2D(Collider2D collision)

    {
        if(collision.tag =="Player")
        {
            StartCoroutine(ActivateButton(time));
        }
    }
    IEnumerator ActivateButton(int time)

    {
        statueDelay.SetActive(false);
        bridge.SetActive(true);
         path.SetActive(false);
        yield return new WaitForSeconds(time);
        statueDelay.SetActive(true);
        bridge.SetActive(false);
         path.SetActive(true);
    }

}


