using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_barrel : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rgb;
    private float velocidade;
    
    void Start()
    {
        rgb = GetComponent<Rigidbody2D>();
        velocidade = 5;
    }

    // Update is called once per frame
    void Update()
    {   
        rgb.velocity = new Vector2(-velocidade, rgb.velocity.y);
        
    }
    void OnCollisionEnter2D(Collision2D col) {
        if (col.gameObject.name == "wall_left") {
            velocidade = -velocidade;
            transform.Rotate(new Vector2(0, 180));  
        }
        if (col.gameObject.name == "wall_right") {
            velocidade = -velocidade;
            transform.Rotate(new Vector2(0, 180)); 
        }
            
           
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "pirata") {
            Debug.Log("yeah");
        }
    }
}
