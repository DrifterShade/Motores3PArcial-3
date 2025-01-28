using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using TMPro;

public class GameDataController : MonoBehaviour
{
    [SerializeField] private GameObject player;

    [SerializeField] private string saveFile;

    [SerializeField] private GameData gameData = new GameData();

    [SerializeField] private GameObject MenuInicio;

    [SerializeField] private TMP_InputField nameInput;

    [SerializeField] private TextMeshProUGUI nameText;

    [SerializeField] private MusicController music;

    [SerializeField] private Camera mainCamera;

    private void Awake()
    {
        saveFile = Path.Combine(Application.persistentDataPath, "dataGame.json");

        player = GameObject.FindGameObjectWithTag("Player");

        //setName();

        //LoadData();

    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.L))
        {
            LoadData();
        }

        setName();
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
            player.GetComponent<PlayerMovement>().hasKey = gameData.hasKey;
            MenuInicio.SetActive(false);
            music.PlayMusic();
            mainCamera.transform.position = new Vector3(-0.26f, -0.09f, -10);


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
            currentCollectables = player.GetComponent<CollectableManager>().currentCollectables,
            hasKey = player.GetComponent<PlayerMovement>().hasKey,
            username = nameInput.text

        };

        string stringJSON = JsonUtility.ToJson(newData); 
        File.WriteAllText(saveFile, stringJSON);

        Debug.Log("Archivo guardado en: " + saveFile);
    }


    public void setName()
    {
        if (File.Exists(saveFile))
        {
            string content = File.ReadAllText(saveFile);
            gameData = JsonUtility.FromJson<GameData>(content);
            nameText.text = gameData.username;
        }
    }

}

