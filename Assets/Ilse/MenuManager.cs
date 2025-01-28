using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField]  private GameObject menu;
      [SerializeField]  private GameObject play;
        [SerializeField]  private GameObject death;
          [SerializeField]  private GameObject victory;
    

   [SerializeField] private AudioSource song;
    // Start is called before the first frame update
   
 void Start()
    {
            Time.timeScale = 0;
           
         }
       




   
   public void PlayBtn()
    {
      play.SetActive(false);
      Time.timeScale = 1;
       song.Play(); 
   
    }

    // Update is called once per frame
    public void ExitBtn()

    {
        Application.Quit();
        Debug.Log("Exit Game");
    }

     public void DeathBtn()
    {
        death.SetActive(true);
         song.Pause(); 
    }

}