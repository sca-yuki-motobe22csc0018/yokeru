using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField]
    [Tooltip("対象物(向く方向)")]
    private GameObject target;

    GameObject obstaclePrefab;
    public float speed = 4.0f;
    private PlayerController pc;

    private void Start()
    {
        target = GameObject.Find("Player");
        Vector3 vector3 = target.transform.position - this.transform.position;
        Quaternion quaternion = Quaternion.LookRotation(vector3);
        this.transform.rotation = quaternion;
    }




    private void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        if (transform.position.x > 10 || transform.position.x < -10 || transform.position.y < -10 || transform.position.y > 10)
        {
            Destroy(this.gameObject);
        }
    }
}