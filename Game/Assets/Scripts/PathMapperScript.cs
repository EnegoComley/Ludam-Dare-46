using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PathMapperScript : MonoBehaviour
{
    Vector3 destination;
    NavMeshAgent pathfindingAgent;
    public GameObject pathMapPrefab;
    Transform myTransform;
    // Start is called before the first frame update
    void Start()
    {
        destination = MainManagerController.theMainManagerScript.payLoadDestination;
        pathfindingAgent = gameObject.GetComponent<NavMeshAgent>();
        myTransform = gameObject.transform;
        pathfindingAgent.SetDestination(destination);
        pathfindingAgent.updateRotation = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (pathfindingAgent.remainingDistance > 0.1)
        {
            GameObject pathMap = Instantiate(pathMapPrefab);
            pathMapPrefab.transform.position = myTransform.position;
        }
    }
}
