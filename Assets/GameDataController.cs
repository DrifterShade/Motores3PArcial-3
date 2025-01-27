using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class GameDataController : MonoBehaviour
{
    [SerializeField] private GameObject player;

    [SerializeField] private string saveFile;

    [SerializeField] private GameData gameData = new GameData();

    private void Awake()
    {
        saveFile = Path.Combine(Application.persistentDataPath, "dataGame.json");

        player = GameObject.FindGameObjectWithTag("Player");

        LoadData();

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            SaveData();
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            LoadData();
        }
    }

    public void LoadData()
    {
        if (File.Exists(saveFile))
        {
            string content = File.ReadAllText(saveFile);
            gameData = JsonUtility.FromJson<GameData>(content);
            player.transform.position = gameData.position;
            player.GetComponent<HealthPlayer>().currentHealth = gameData.healthPlayer;
            player.GetComponent<CollectableManager>().currentCollectables = gameData.currentCollectables;

            Debug.Log("Posición cargada: " + gameData.position);
        }
        else
        {
            Debug.Log("El archivo no existe.");
        }
    }

    public void SaveData()
    {
        GameData newData = new GameData()
        {
            position = player.transform.position,
            healthPlayer = player.GetComponent<HealthPlayer>().currentHealth,
            currentCollectables = player.GetComponent<CollectableManager>().currentCollectables

        };

        string stringJSON = JsonUtility.ToJson(newData); 
        File.WriteAllText(saveFile, stringJSON);

        Debug.Log("Archivo guardado en: " + saveFile);
    }
}

