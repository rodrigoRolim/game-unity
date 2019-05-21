using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_1 : MonoBehaviour
{
    // Start is called before the first frame update
    private bool dir = true;
    private int velocidade;
    private Rigidbody2D rbg;
    private Animator anim;
    public Transform feet;
    public LayerMask mask;
    // Start is called before the first frame update

    void Start()
    {
        velocidade = 5;
        rbg = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        feet = transform.GetChild(0);
    }

    // Update is called once per frame
    void Update()
    {
        
        float dirx  = Input.GetAxis("Horizontal");
        rbg.velocity = new Vector2(dirx*velocidade, rbg.velocity.y);
        if (dirx == 0)
            anim.SetBool("andar", false);
        else
            anim.SetBool("andar", true);
        if (dirx < 0 && dir || dirx > 0 && !dir) {
            transform.Rotate(new Vector2(0, 180));
            dir = !dir;
        }
        if (Input.GetKeyDown(KeyCode.Space)) {
            rbg.AddForce(new Vector2(0, 400));
        }
        Collider2D col;
        if (col=Physics2D.OverlapCircle(feet.position, 0.2f, mask)) {
           Destroy(col.gameObject);
        } else {
            transform.parent = null;
        }
           
        
    }
    void OnCollisionEnter2D(Collision2D col)
    {   
        if (col.gameObject.name == "Barrel_0") {
            Destroy(this.gameObject);
        }
        
    }
}
