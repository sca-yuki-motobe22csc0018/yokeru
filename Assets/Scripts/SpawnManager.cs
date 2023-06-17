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
    private Vector3 spawnPosE = new Vector3(0, 5, 0);
    private Vector3 spawnPosF = new Vector3(5, 0, 0);
    private Vector3 spawnPosG = new Vector3(-5, 0, 0);
    private Vector3 spawnPosH = new Vector3(0, -5, 0);
    private float startDelay = 0;
    public float repeatRate = 0.5f;
    private PlayerController pc;

    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        pc = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void Update()
    {
        {
            if (spawnPosA.x >= 5 && spawnPosA.y >= -5)
            {
                spawnPosA.y -= 0.01f;
            }
            if (spawnPosA.x >= -5 && spawnPosA.y <= -5)
            {
                spawnPosA.x -= 0.01f;
            }
            if (spawnPosA.x <= -5 && spawnPosA.y <= 5)
            {
                spawnPosA.y += 0.01f;
            }
            if (spawnPosA.x <= 5 && spawnPosA.y >= 5)
            {
                spawnPosA.x += 0.01f;
            }

            if (spawnPosB.x >= 5 && spawnPosB.y >= -5)
            {
                spawnPosB.y -= 0.01f;
            }
            if (spawnPosB.x >= -5 && spawnPosB.y <= -5)
            {
                spawnPosB.x -= 0.01f;
            }
            if (spawnPosB.x <= -5 && spawnPosB.y <= 5)
            {
                spawnPosB.y += 0.01f;
            }
            if (spawnPosB.x <= 5 && spawnPosB.y >= 5)
            {
                spawnPosB.x += 0.01f;
            }

            if (spawnPosC.x >= 5 && spawnPosC.y >= -5)
            {
                spawnPosC.y -= 0.01f;
            }
            if (spawnPosC.x >= -5 && spawnPosC.y <= -5)
            {
                spawnPosC.x -= 0.01f;
            }
            if (spawnPosC.x <= -5 && spawnPosC.y <= 5)
            {
                spawnPosC.y += 0.01f;
            }
            if (spawnPosC.x <= 5 && spawnPosC.y >= 5)
            {
                spawnPosC.x += 0.01f;
            }

            if (spawnPosD.x >= 5 && spawnPosD.y >= -5)
            {
                spawnPosD.y -= 0.01f;
            }
            if (spawnPosD.x >= -5 && spawnPosD.y <= -5)
            {
                spawnPosD.x -= 0.01f;
            }
            if (spawnPosD.x <= -5 && spawnPosD.y <= 5)
            {
                spawnPosD.y += 0.01f;
            }
            if (spawnPosD.x <= 5 && spawnPosD.y >= 5)
            {
                spawnPosD.x += 0.01f;
            }

            if (spawnPosE.x >= 5 && spawnPosE.y >= -5)
            {
                spawnPosE.y -= 0.01f;
            }
            if (spawnPosE.x >= -5 && spawnPosE.y <= -5)
            {
                spawnPosE.x -= 0.01f;
            }
            if (spawnPosE.x <= -5 && spawnPosE.y <= 5)
            {
                spawnPosE.y += 0.01f;
            }
            if (spawnPosE.x <= 5 && spawnPosE.y >= 5)
            {
                spawnPosE.x += 0.01f;
            }

            if (spawnPosF.x >= 5 && spawnPosF.y >= -5)
            {
                spawnPosF.y -= 0.01f;
            }
            if (spawnPosF.x >= -5 && spawnPosF.y <= -5)
            {
                spawnPosF.x -= 0.01f;
            }
            if (spawnPosF.x <= -5 && spawnPosF.y <= 5)
            {
                spawnPosF.y += 0.01f;
            }
            if (spawnPosF.x <= 5 && spawnPosF.y >= 5)
            {
                spawnPosF.x += 0.01f;
            }

            if (spawnPosG.x >= 5 && spawnPosG.y >= -5)
            {
                spawnPosG.y -= 0.01f;
            }
            if (spawnPosG.x >= -5 && spawnPosG.y <= -5)
            {
                spawnPosG.x -= 0.01f;
            }
            if (spawnPosG.x <= -5 && spawnPosG.y <= 5)
            {
                spawnPosG.y += 0.01f;
            }
            if (spawnPosG.x <= 5 && spawnPosG.y >= 5)
            {
                spawnPosG.x += 0.01f;
            }

            if (spawnPosH.x >= 5 && spawnPosH.y >= -5)
            {
                spawnPosH.y -= 0.01f;
            }
            if (spawnPosH.x >= -5 && spawnPosH.y <= -5)
            {
                spawnPosH.x -= 0.01f;
            }
            if (spawnPosH.x <= -5 && spawnPosH.y <= 5)
            {
                spawnPosH.y += 0.01f;
            }
            if (spawnPosH.x <= 5 && spawnPosH.y >= 5)
            {
                spawnPosH.x += 0.01f;
            }
        }//controller
        
    }

    void SpawnObstacle()
    {
        Instantiate(obstaclePrefab, spawnPosA, obstaclePrefab.transform.rotation);
        Instantiate(obstaclePrefab, spawnPosB, obstaclePrefab.transform.rotation);
        Instantiate(obstaclePrefab, spawnPosC, obstaclePrefab.transform.rotation);
        Instantiate(obstaclePrefab, spawnPosD, obstaclePrefab.transform.rotation);
        Instantiate(obstaclePrefab, spawnPosE, obstaclePrefab.transform.rotation);
        Instantiate(obstaclePrefab, spawnPosF, obstaclePrefab.transform.rotation);
        Instantiate(obstaclePrefab, spawnPosG, obstaclePrefab.transform.rotation);
        Instantiate(obstaclePrefab, spawnPosH, obstaclePrefab.transform.rotation);
    }
}
