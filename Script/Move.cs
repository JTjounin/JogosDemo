using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    public float speed;
    public float x;
    public float y;
    public bool on;

    // Use this for initialization
    void Start()
    {
        on = true;
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
        if (on)
        {
            x += -speed * Time.deltaTime;

            transform.position = new Vector3(x, transform.position.y, transform.position.z);
        }
            
    }

}
