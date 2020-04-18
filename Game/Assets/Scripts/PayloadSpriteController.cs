using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PayloadSpriteController : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform payloadTransform;
    Transform myTransForm;
    void Start()
    {
        myTransForm = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        myTransForm.position = payloadTransform.position;   
    }
}
