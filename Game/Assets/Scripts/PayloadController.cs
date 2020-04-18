using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PayloadController : MonoBehaviour
{
    // Start is called before the first frame update
    NavMeshAgent pathfindingAgent;
    public Transform camera;
    public Transform sprite;
    Transform payloadTrans;

    void Start()
    {
        pathfindingAgent = gameObject.GetComponent<NavMeshAgent>();
        payloadTrans = gameObject.GetComponent<Transform>();
        pathfindingAgent.SetDestination(new Vector3(0,-12,0));
        
    }

    // Update is called once per frame
    void Update()
    {
        camera.position = new Vector3(payloadTrans.position.x, payloadTrans.position.y, -12);
        //sprite.position = new Vector3(payloadTrans.position.x, payloadTrans.position.y, payloadTrans.position.z);
    }
}
