using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_AI : MonoBehaviour
{

    public Transform Payload;
    public Transform Enemy;
    public Transform PlayerChar;
    public GameObject GUN;
    Vector2 dirPayLoad;//DIRECTION FROM PAYLOAD
    Vector2 dirPlayer;//DIRECTION FROM PLAYER
    bool reload;
    int timer;
    dynamic[] maingun;
    private void Start()
    {
                                    //0 (Name)      1 (GameObject)    2 (Current Clip)
        maingun = new dynamic[] { Gun_Alpha.Name, Gun_Alpha.Model, Gun_Alpha.Clip,
                                  Gun_Alpha.AmmoMax, Gun_Alpha.AmmoMax, Gun_Alpha.Clip,  Gun_Alpha.Reload, Gun_Alpha.Bullet }; //DW about the spaghetti N.
                            //3 (Current Ammo)       4(Max Ammo)       5(Max Clip)        6(Reload)          7(Bullet)

    }
    void Update()
    {
    }
    private void FixedUpdate()
    {
        dirPayLoad = Payload.position - Enemy.position;
        dirPlayer = PlayerChar.position - Enemy.position;
        float DistPlayer = Mathf.Sqrt(Mathf.Pow(dirPlayer.x, 2) + Mathf.Pow(dirPlayer.y, 2));
        float DistPayload = Mathf.Sqrt(Mathf.Pow(dirPayLoad.x, 2) + Mathf.Pow(dirPayLoad.y, 2));
        if (DistPlayer <= 50 || DistPayload <= 20)
        {
            if (DistPlayer < DistPayload + 3)
            {
                float angle = Mathf.Atan2(dirPayLoad.y, dirPayLoad.x) * Mathf.Rad2Deg;
                Enemy.GetComponent<Rigidbody2D>().rotation = angle + 180;
                Debug.Log("PAYLOAD");
                GunManager();
            }
            else
            {
                float angle = Mathf.Atan2(dirPlayer.y, dirPlayer.x) * Mathf.Rad2Deg;
                Enemy.GetComponent<Rigidbody2D>().rotation = angle + 180;
                Debug.Log("PLAYER");
                GunManager();
            }

        }
        else { Debug.Log("Too far away"); }
        Debug.Log("PAY " + DistPayload + "\nPLAY " + DistPlayer);
    }
    public void GunManager()
    {
        if (maingun[2] > 0)
        {
            //shoot();
            maingun[2] -= 1;
        }
        else //reload
        {
            if (reload != true) { reload = true; timer = maingun[6] * 20; }
            else { if (timer == 0) { maingun[2] = maingun[5]; reload = false; timer = 0; } }
        }
    }
    public void shoot()
    {
        Transform shootpoint = transform.Find(maingun[0]).Find("Shootpoint");
        GameObject instance = Instantiate(maingun[7], new Vector3(shootpoint.position.x, shootpoint.position.y, 1), GUN.GetComponent<Transform>().rotation);
        instance.GetComponent<Rigidbody2D>().AddForce(-shootpoint.right* 10f, ForceMode2D.Impulse);
    }


}
