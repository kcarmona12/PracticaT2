using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrountScript : MonoBehaviour
{
    public float xVelocity = 1f;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        var yVelocity = rb.velocity.y;

        rb.velocity = new Vector2(-xVelocity, yVelocity);
    }
}