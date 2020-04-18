using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManagerController : MonoBehaviour
{
    public static MainManagerController theMainManagerScript;
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
