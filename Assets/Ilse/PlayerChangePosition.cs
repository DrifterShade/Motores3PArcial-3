using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChangePosition : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private Camera cam;
    
   private void OnTriggerEnter2D(Collider2D collision)
   {
    if (collision.gameObject.tag == "area1")
    {
        cam.transform.position = new Vector3(0,-0.53f,-10);
        this.transform.position = new Vector3(-1.15f,-2.51f,0);
    }
    if (collision.gameObject.tag == "area2")
    {
        cam.transform.position = new Vector3(0,-11.79f,-10);
         this.transform.position = new Vector3(2.41f,-7.6f,0);

    }

     if (collision.gameObject.tag == "area3")
    {
        cam.transform.position = new Vector3(19.19f,-0.04f,-10);
         this.transform.position = new Vector3(11.98f,2.94f,0);

    }

      if (collision.gameObject.tag == "area1Right")
    {
         cam.transform.position = new Vector3(0,-0.53f,-10);
         this.transform.position = new Vector3(7.34f,2.4f,0);

    }
   }
}
