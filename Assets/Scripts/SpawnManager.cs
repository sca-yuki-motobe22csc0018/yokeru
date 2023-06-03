using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    
    public GameObject obstaclePrefab;
    private Vector3 spawnPosA = new Vector3(-5, 5, 0);
    private Vector3 spawnPosB = new Vector3(5, 5, 0);
    private Vector3 spawnPosC = new Vector3(-5, -5, 0);
    private Vector3 spawnPosD = new Vector3(5, -5, 0);
    private float startDelay = 0;
    private float repeatRate = 0.25f;
    private PlayerController pc;

    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        pc = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void Update()
    {
        //次回ここから
        //spawnPosA.x+=0.01f;
    }

    void SpawnObstacle()
    {
        Instantiate(obstaclePrefab, spawnPosA, obstaclePrefab.transform.rotation);
        Instantiate(obstaclePrefab, spawnPosB, obstaclePrefab.transform.rotation);
        Instantiate(obstaclePrefab, spawnPosC, obstaclePrefab.transform.rotation);
        Instantiate(obstaclePrefab, spawnPosD, obstaclePrefab.transform.rotation);
    }
}
