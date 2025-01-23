using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectableManager : MonoBehaviour
{
    [SerializeField] private int currentCollectables;
    [SerializeField] private TextMeshProUGUI TMProCurrentCollectables;


    private void Update()
    {
        TMProCurrentCollectables.text = "Current Collectables" + currentCollectables.ToString();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Collectable"))
        {
            Destroy(collision.gameObject);
            currentCollectables++;
        }
    }

}
