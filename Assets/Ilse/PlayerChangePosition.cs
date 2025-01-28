using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChangePosition : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private Camera cam;
    
   private void OnTriggerEnter2D(Collider2D collision)
   {




    ///Volver al centro

   if (collision.gameObject.tag == "area3")
    {
        cam.transform.position = new Vector3(19.19f,-0.04f,-10);
         this.transform.position = new Vector3(11.98f,2.94f,0);

    }

  if (collision.gameObject.tag == "derecha1")
    {
        cam.transform.position = new Vector3(19.19f,-0.04f,-10);
         this.transform.position = new Vector3(27.78f,1.2f,0);

    }


     if (collision.gameObject.tag == "downm1")
    {
        cam.transform.position = new Vector3(0,-0.53f,-10);
        this.transform.position = new Vector3(-1.15f,-2.51f,0);
    }
      if (collision.gameObject.tag == "area1Right")
    {
         cam.transform.position = new Vector3(0,-0.53f,-10);
         this.transform.position = new Vector3(7.34f,2.4f,0);
    }
     if (collision.gameObject.tag == "upm1")
    {
        cam.transform.position = new Vector3(0,-0.53f,-10);
        this.transform.position = new Vector3(1.26f,3.69f,0);
    }
    
       if (collision.gameObject.tag == "leftm1")
    {
        cam.transform.position = new Vector3(0,-0.53f,-10);
        this.transform.position = new Vector3(-8.06f,1.26f,0);
    }



    ///

   
    if (collision.gameObject.tag == "cdown")
    {
        cam.transform.position = new Vector3(0,-11.79f,-10);
         this.transform.position = new Vector3(6.31f,-8.39f,0);

    }

    
    if (collision.gameObject.tag == "cleft")
    {
        cam.transform.position = new Vector3(-19.93f,-0.09f,-10f);
         this.transform.position = new Vector3(-12.41f,1.92f,0);

    }

  

    if (collision.gameObject.tag == "cup")
    {
         cam.transform.position = new Vector3(0.02f,11.67f,-10);
         this.transform.position = new Vector3(1.5f,7.76f,0);

    }
    if (collision.gameObject.tag == "derder")
    {
         cam.transform.position = new Vector3(40.31f,-0.09f,-10f);
         this.transform.position = new Vector3(32.07f,2.83f,0);

    }
    }
    }
    
   

