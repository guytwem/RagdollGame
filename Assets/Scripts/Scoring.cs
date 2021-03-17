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
    public float currentScore = 0;
   
    

    

    [SerializeField]
    private TMP_Text scoreText;

    

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
        Debug.Log(forceBeingApplied);

        
        
    }

  
}
