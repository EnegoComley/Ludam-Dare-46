using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class PayloadController : MonoBehaviour
{
    // Start is called before the first frame update

    public NavMeshAgent payloadAgent;
    void Start()
    {
        payloadAgent.SetDestination(new Vector3(-10, 0, 1));

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
