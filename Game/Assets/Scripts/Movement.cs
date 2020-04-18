using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Movement : MonoBehaviour
{
    Vector2 movement;
    public GameObject player;
    public float MovementSpeed = 5f;
    public Camera Payload_Cam;
    Vector2 Mouse_Pos;
    public GameObject bullet;
    public Rigidbody2D RB2D;
    private bool stagger = false;
    private void Start()
    {
       
    }
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
        RB2D.MovePosition(RB2D.position + movement * MovementSpeed * Time.fixedDeltaTime);
        Vector2 dir = Mouse_Pos - RB2D.position;
        float angle = Mathf.Atan2(dir.y, dir.x);
        RB2D.rotation = (angle * Mathf.Rad2Deg) + 180;
    }


    //guns
    //{GunName}[ClipSize, ReloadTime, Dammage, BulletType]
    public void shoot()
    {
         Transform shootpoint = transform.Find("Gun").Find("Shootpoint");
         GameObject instance = Instantiate(bullet, new Vector3(shootpoint.position.x, shootpoint.position.y, 1), player.GetComponent<Transform>().rotation);
         instance.GetComponent<Rigidbody2D>().AddForce(-shootpoint.right * 10f, ForceMode2D.Impulse);

    }
}
