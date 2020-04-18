using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticManager : MonoBehaviour
{
    public GameObject Model_Alpha;
    public GameObject Bullet_Alpha;
    public static class Gun_Alpha
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



    




