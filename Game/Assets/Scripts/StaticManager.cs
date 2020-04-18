using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun_Alpha
{
    private string name = "Gun_Alpha";
    private GameObject Model = GameObject.Find("Gun_Alpha");
    private int ClipSize = 20;
    private int AmmoMax = 1000;
    private int Reload = 5;
    private int Dammage = 10;
    private GameObject Bullet = GameObject.Find("Bullet_Alpha");
    public string Name
    {
        get { return name; }
    }
}

    




