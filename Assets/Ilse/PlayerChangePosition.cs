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
        cam.transform.position = new Vector3(0,1.03f,-10);
        this.transform.position = new Vector3(-1.15f,-2.51f,0);
    }
    if (collision.gameObject.tag == "area2")
    {
        cam.transform.position = new Vector3(0,-10.14f,-10);
         this.transform.position = new Vector3(-0.34f,-6.61f,0);

    }
   }
}
