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
        private static string name = "Gun_Alpha";
        public static string Name
        {
            get { return name; }
        }
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
        private static int dammage = 10;
        public static int Dammage
        {
            get { return dammage; }
        }
    }
    private void Start()
    {
        Gun_Alpha.Model = Model_Alpha;


    }
}
