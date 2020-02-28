using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour {

    public float speed;
    public float x;
    public float y;
    public bool onCloud;

    // Use this for initialization
    void Start()
    {
        x = transform.position.x;
        y = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        eixoX();
        
    }

    void eixoX() // muda a direção da plataforma em relação ao eixo
    {            
        if (onCloud)
        {
            x += -speed * Time.deltaTime;

            transform.position = new Vector3(x, transform.position.y, transform.position.z);
        }
            
    }

}
