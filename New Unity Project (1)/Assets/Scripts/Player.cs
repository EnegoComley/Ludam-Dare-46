using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player : MonoBehaviour
{
    Vector2 movement;
    public GameObject player;
    public float MovementSpeed = 5f;
    public Camera Payload_Cam;
    Vector2 Mouse_Pos;
    public GameObject bullet;
    public Rigidbody2D RB2D;
    List<dynamic> gun1 = new List<dynamic>();
    List<dynamic> gun2 = new List<dynamic>();
    bool reload = false;
    dynamic maingun = null;
    public int timer;
    private void Start()
    {
                            //0 (Name)       1 (GameObject)     2 (Current Clip)
        dynamic[] tempar = { Gun_Alpha.Name, Gun_Alpha.Model, Gun_Alpha.Clip, 
                            Gun_Alpha.AmmoMax,     Gun_Alpha.AmmoMax, Gun_Alpha.Clip,  Gun_Alpha.Reload, Gun_Alpha.Bullet};
                            //3 (Current Ammo)       4(Max Ammo)       5(Max Clip)       6(Reload)           7(Bullet)
        gun1.AddRange(tempar);
        maingun = gun1;
        Debug.Log(maingun[7]);
    }
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxis("Vertical");
        Mouse_Pos = Payload_Cam.ScreenToWorldPoint(Input.mousePosition);
        if ((reload == true) && (timer >0) )
        {
            timer -= 1;
        }

        //Debug.Log(timer);
    }
    void FixedUpdate()
    {
        RB2D.MovePosition(RB2D.position + movement * MovementSpeed * Time.fixedDeltaTime);  
        Vector2 dir = Mouse_Pos - RB2D.position;
        float angle = Mathf.Atan2(dir.y, dir.x);
        RB2D.rotation = (angle * Mathf.Rad2Deg) + 180;
        GunManager();
    }


    //guns
    //{GunName}[ClipSize, ReloadTime, Dammage, BulletType]
    public void shoot()
    {
        Transform shootpoint = transform.Find(maingun[0]).Find("Shootpoint");
        GameObject instance = Instantiate(maingun[7], new Vector3(shootpoint.position.x, shootpoint.position.y, 1), player.GetComponent<Transform>().rotation);
        instance.GetComponent<Rigidbody2D>().AddForce(-shootpoint.right * 10f, ForceMode2D.Impulse);
    }
    
    public void GunManager()
    {
        if (Input.GetMouseButton(0))
        {
            if (maingun[2] > 0)
            {
                shoot();
                maingun[2] -= 1;
            }
            else //reload
            {
                if (reload != true) { reload = true; timer = maingun[6] * 20; }
                else { if (timer == 0) { maingun[2] = maingun[5]; reload = false; timer = 0; } }

                /*if (maingun1[3] > 0)
                {
                    /*if((maingun1[3] - maingun1[5]) < 0)
                    {
                        maingun1[2] = maingun1[3];
                        gun1[3] = 0;
                    }
                 maingun1[2] = maingun1[5];
                 maingun1[3] -= maingun1[5];
                 //Debug.Log("Clip = " + maingun1[2] + " Ammo =" + maingun1[3]);
                }*/
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.Alpha1)){maingun = gun1;}
            if (Input.GetKey(KeyCode.Alpha2)) { maingun = gun2;}
            if (Input.GetKey(KeyCode.Alpha3)) {maingun = "sword"; }
        }
        
    }

}

