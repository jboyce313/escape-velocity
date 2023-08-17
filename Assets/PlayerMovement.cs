using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float dirX = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(dirX * 7f, rb.velocity.y);

        if (Input.GetButton("Jump"))
        {
            rb.velocity = new Vector2(0, 7f);
            dirX = Input.GetAxis("Horizontal");
            rb.velocity = new Vector2(dirX * 7f, rb.velocity.y);
        }
    }
}
