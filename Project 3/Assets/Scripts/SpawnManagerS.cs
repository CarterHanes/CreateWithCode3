using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerS : MonoBehaviour
{
    public float startDelay = 2;
    public float repeatRate = 2;
    public GameObject obstaclePrefab;
    public Vector3 spawnPos = new Vector3(18, 0, 0);
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate) ; 
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnObstacle()
    {
        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
    }
}
