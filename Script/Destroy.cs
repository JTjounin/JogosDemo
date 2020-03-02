using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{



    public float timeLife;
    // private float tempTime;


    // Use this for initialization
    void Start()
    {
        Invoke("DestroyObjeto", timeLife);
    }

    // Update is called once per frame
    void Update() // Tempo de vida do objeto
    {
        /* tempTime += Time.deltaTime;
         if(tempTime >= timeLife)
         {
             Destroy(this.gameObject);
         }*/

        Debug.Log(timeLife);
    }


    void DestroyObjeto()
    {
        Destroy(this.gameObject);
    }
}
    