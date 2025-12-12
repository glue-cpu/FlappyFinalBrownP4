using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrolling : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private BoxCollider2D groundcollider;
    private float groundXLength;
    
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = new Vector2(GameController.instance.scrollSpeed, 0);

        groundcollider = GetComponent<BoxCollider2D>();
        groundXLength = groundcollider.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameController.instance.dead)
        {
            rb2d.velocity = Vector2.zero;
        }

        if(transform.position.x < -groundXLength)
        {
            moveit();
        }
    }

    private void moveit()
    {
        Vector2 groundOffset = new Vector2(groundXLength * 2f, 0);
        transform.position = (Vector2) transform.position + groundOffset;
    }
}
