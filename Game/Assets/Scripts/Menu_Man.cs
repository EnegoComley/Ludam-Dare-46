using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_Man : MonoBehaviour
{
    public Transform Main;
    public Transform Options;
    public void switcher()
    {
        Vector2 temp = Main.localPosition;
        Main.localPosition = Options.localPosition;
        Options.localPosition = temp;
        Debug.Log("Run");
    }
    public void off()
    {
        Application.Quit();
        Debug.Log("Editor wont allow .Quit but i should have turned off now");
    }
}
