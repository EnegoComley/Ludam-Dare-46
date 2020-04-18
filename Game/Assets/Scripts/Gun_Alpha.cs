using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Gun_Alpha : MonoBehaviour
{
    public GameObject Bullet_Alpha;
    public GameObject Gun;
    public void Awake()
    {
        Gun_Alpha.Bullet = Bullet_Alpha;
        Gun_Alpha.Model = Gun;
        Debug.Log("run");
    }

    public static string Name { get; } = "Gun_Alpha";
    private static int clip = 15;
     public static int Clip
     {
        get { return clip; }
     }
     private static int ammoMax = 200;
     public static int AmmoMax
     {
        get { return ammoMax; }
     }
     private static GameObject model;
     public static GameObject Model
     {
        get { return model; }
        set { model = value; }
     }
     private static GameObject bullet;
     public static GameObject Bullet
     {
        set { bullet = value; }
        get { return bullet; }
     }
     private static int dammage = 10;
     public static int Dammage
     {
        get { return dammage; }
     }
     private static int reload = 5;
     public static int Reload
     {
        get { return reload; }
     }
}




    




