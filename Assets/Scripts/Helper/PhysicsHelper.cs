using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsHelper : MonoBehaviour
{
    private static PhysicsHelper Instance { get; set; }
    private float minForce = 12f;
    private float maxForce = 18f;
    private float targetTorque = 10f;
    private float valuePosX = 4f;
    private float targetPosY = -5f;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public Vector3 RandomSpawnPos()
    {
        return new Vector3(Random.Range(-valuePosX, valuePosX), targetPosY);
    }

    public float RandomForce()
    {
        return Random.Range(minForce, maxForce);
    }

    public Vector3 RandomTorque()
    {
        return new Vector3(Random.Range(-targetTorque, targetTorque),
                           Random.Range(-targetTorque, targetTorque),
                           Random.Range(-targetTorque, targetTorque));
    }
}
