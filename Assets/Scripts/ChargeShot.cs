using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChargeShot : MonoBehaviour
{
    public GameObject player;

    private Rigidbody rb;
    private Collider cd;

    private float totalCharge = 0f;

    [SerializeField] private float chargeMultiplier = 250f;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = player.GetComponent<Rigidbody>();
        cd = player.GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey)
        {
            totalCharge += chargeMultiplier * 1;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {

            rb.AddForce(transform.forward * totalCharge);
            totalCharge = 0f;
        }
       
        Debug.Log(totalCharge);
    }
}
