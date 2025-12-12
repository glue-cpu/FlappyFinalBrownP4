using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour
{
    public float jumpForce = 200f;
    
    private bool dead = false;
    private Rigidbody2D rb2d;
    
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!dead)
        {
            if (Input.GetMouseButtonDown (0))
            {
                rb2d.velocity = Vector2.zero;
                rb2d.AddForce(new Vector2(0, jumpForce));
            }
        }
    }

    void OnCollisionEnter2D()
    {
        dead = true;
        GameController.instance.BirdDown();
        rb2d.velocity = Vector2.zero;
    }
}
