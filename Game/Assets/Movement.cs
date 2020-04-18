using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Vector2 movement;
    public Rigidbody2D player;
    public float MovementSpeed = 5f;
    void Update()
    {
        movement.x =  Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxis("Vertical");
        
    }
    void FixedUpdate()
    {
        player.MovePosition(player.position + movement * MovementSpeed * Time.fixedDeltaTime);
    }
}
