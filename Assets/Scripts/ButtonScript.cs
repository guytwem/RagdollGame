using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public GameObject player;
    public Scoring scoring;
    private Vector3 spawnLocation;
    public void Respawn()
    {

        player.transform.position = spawnLocation;
        scoring.currentScore = 0;

    }

    private void Start()
    {
        spawnLocation = new Vector3(0, 2, 0);
    }
}
