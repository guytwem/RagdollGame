using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject playerPrefab;
    private Vector3 spawnLocation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            spawnLocation = new Vector3(3.5f, 20f, Random.Range(21, 40));
            Instantiate(playerPrefab, spawnLocation, Quaternion.identity);
        }
    }
}
