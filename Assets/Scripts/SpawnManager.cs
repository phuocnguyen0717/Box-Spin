using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public List<GameObject> targetPrefabs;
    private float spawnRate = 1.0f;
    void Start()
    {
        StartCoroutine(WaitForSpawnTarget());
    }

    void Update()
    {
    }
    private IEnumerator WaitForSpawnTarget()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnRate);
            Spawn();
        }
    }
    private void Spawn()
    {
        int indexTarget = Random.Range(0, targetPrefabs.Count);
        Instantiate(targetPrefabs[indexTarget]);
    }
}
