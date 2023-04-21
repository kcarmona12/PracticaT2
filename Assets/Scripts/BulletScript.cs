using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float Speed = 10f;

    private Rigidbody2D Rigidbody2D;
    private Vector2 Direction;
    

    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
    }


    private void FixedUpdate()
    {
        Rigidbody2D.velocity = Direction * Speed;
    }

    public void SetDirection(Vector2 direction)
    {
        Direction = direction;


    }

    public void DestroyBullet() 
    {
        Destroy(gameObject);
    
    }

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        PlayerController1 player = collision.GetComponent<PlayerController1>();
        GrountScript grout = collision.GetComponent<GrountScript>();


    }

    
}
