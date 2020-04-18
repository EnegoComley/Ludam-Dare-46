using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManagerController : MonoBehaviour
{
    public static MainManagerController theMainManagerScript;
    public Vector3 payLoadDestination = new Vector3(0, -12, 0);
    // Start is called before the first frame update
    private void Awake()
    {
        if (theMainManagerScript == null)
        {
            theMainManagerScript = this;
            DontDestroyOnLoad(gameObject);
        } else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
