using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Scoring : MonoBehaviour
{
    List<Joint> joints;
    [SerializeField]
    private float minForceForScore;
    [SerializeField]
    private float scoreMultiplier;
    private float currentScore = 0;
    private float currentPoints = 0;
    

    [SerializeField]
    private float pointsPerHoop = 3f;

    [SerializeField]
    private TMP_Text scoreText;

    [SerializeField]
    private TMP_Text pointsText;

    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        joints = new List<Joint>(GetComponentsInChildren<Joint>());

        
    }

    // Update is called once per frame
    void Update()
    {
        float forceBeingApplied = 0;


        foreach (Joint joint in joints)
        {
            forceBeingApplied += joint.currentForce.magnitude;
        }
        if(forceBeingApplied > minForceForScore)
        {

            currentScore += (forceBeingApplied * scoreMultiplier * Time.deltaTime);
            scoreText.text = currentScore.ToString();
        }
        //Debug.Log(forceBeingApplied);

        if(currentPoints > 0)
        {
            pointsText.text = currentPoints.ToString();
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Hoop")
        {
            Debug.Log("Collision");
            currentPoints += pointsPerHoop;
        }

    }
}
