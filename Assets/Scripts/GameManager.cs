using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<GameObject> targetPrefabs;
    public TextMeshProUGUI scoreText;
    private float score;
    private float spawnRate = 1.0f;
    void Start()
    {
        StartCoroutine(WaitForSpawnTarget());
        scoreText = GameObject.Find("Score").GetComponent<TextMeshProUGUI>();

    }

    void Update()
    {
        scoreText.text = "Score:" + GetScore();
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
    public float GetScore(){
        Debug.Log("score = " + score);
        return score;
    }
    public void SetScore(float increaseScore){
        score += increaseScore;
    }
}
