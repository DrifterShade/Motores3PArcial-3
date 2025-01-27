using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointsManager : MonoBehaviour
{
    [SerializeField] private GameDataController gameDataController;
    [SerializeField] private bool canSave;
    [SerializeField] private GameObject checkpintSprite;

    private void Start()
    {
        canSave = false;
    }


    private void Update()
    {
        checkIfCehckpoint();
    }

    private void checkIfCehckpoint()
    {
        if(canSave && Input.GetKeyDown(KeyCode.M))
        {
            gameDataController.SaveData();
            Debug.Log("Seha guardado con el checpoint");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Checkpoint"))
        {
            canSave = true;
            checkpintSprite.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Checkpoint"))
        {
            canSave = false;
            checkpintSprite.SetActive(false);
        }
    }

}
