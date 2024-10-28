using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Target : MonoBehaviour
{
    private Rigidbody targetRb;
    private float minForce = 10f;
    private float maxForce = 16f;
    private float targetTorque = 10f;
    private float valuePosX = 4f;
    private float targetPosY = -5;
    public float targetScore;
    public GameManager gameManager;
    void Start()
    {
        targetRb = GetComponent<Rigidbody>();

        targetRb.AddForce(Vector3.up * RandomForce(), ForceMode.Impulse);
        targetRb.AddTorque(RandomTorque(), ForceMode.Impulse);
        transform.position = RandomSpawnPos();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void Update()
    {

    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
        gameManager.SetScore(targetScore);
    }
    private void OnTriggerEnter()
    {
        Destroy(gameObject);
    }
    private Vector3 RandomSpawnPos()
    {
        return new Vector3(Random.Range(-valuePosX, valuePosX), targetPosY);
    }
    private float RandomForce()
    {
        return Random.Range(minForce, maxForce);
    }
    private Vector3 RandomTorque()
    {
        return new Vector3(Random.Range(-targetTorque, targetTorque),
        Random.Range(-targetTorque, targetTorque),
        Random.Range(-targetTorque, targetTorque));
    }
}
