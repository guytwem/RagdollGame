using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spawner : MonoBehaviour
{
    private bool isPlayerSpawned;
    public GameObject playerPrefab;
    private Vector3 spawnLocation;
    public Scoring Scoring;
    // Start is called before the first frame update
    void Start()
    {
        isPlayerSpawned = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isPlayerSpawned == false)
        {
            spawnLocation = new Vector3(3.5f, 20f, Random.Range(21, 40));
            Instantiate(playerPrefab, spawnLocation, Quaternion.identity);
            isPlayerSpawned = true;
        }
    }

    public void Reset()
    {
        
        Scoring.currentScore = 0;
        isPlayerSpawned = false;
        SceneManager.LoadScene("GameScene");
    }
}
