using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Vector2 movement;
    public Rigidbody2D player;
    public float MovementSpeed = 5f;
    public Camera Payload_Cam;
    Vector2 Mouse_Pos;
    public Transform shootpoint;
    public GameObject bullet;
    void Update()
    {
        movement.x =  Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxis("Vertical");
        Mouse_Pos = Payload_Cam.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButton(0))
        {
            shoot();
        }
        
    }
    void FixedUpdate()
    {
        player.MovePosition(player.position + movement * MovementSpeed * Time.fixedDeltaTime);
        Vector2 dir = Mouse_Pos - player.position;
        float angle = Mathf.Atan2(dir.y, dir.x);
        player.rotation = (angle * Mathf.Rad2Deg) + 180;
    }
    void shoot()
    {
        GameObject instance = Instantiate(bullet, new Vector2 (shootpoint.position.x, shootpoint.position.y),shootpoint.rotation);
        instance.GetComponent<Rigidbody2D>().AddForce(shootpoint.forward * 10f, ForceMode2D.Impulse);
        
    }
}
