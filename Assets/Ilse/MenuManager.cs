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
           private bool clickedOnce = false;

    // Start is called before the first frame update
   

   
   public void PlayBtn()
    {
      play.SetActive(true);
 
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
    }
}
    