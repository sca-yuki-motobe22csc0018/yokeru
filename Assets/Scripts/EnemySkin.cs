using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySkin : MonoBehaviour
{
    private EnemyController ec;

    // Start is called before the first frame update
    void Start()
    {
        ec = GameObject.Find("Enemy").GetComponent<EnemyController>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(ec.transform.position.x, ec.transform.position.y);
    }
}
