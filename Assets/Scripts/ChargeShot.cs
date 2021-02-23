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
            totalCharge += chargeMultiplier;
        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            rb.AddForce(transform.right * totalCharge);
            totalCharge = 0f;
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            rb.AddForce(transform.forward * totalCharge);
            totalCharge = 0f;
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            rb.AddForce(transform.right *- totalCharge);
            totalCharge = 0f;
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            rb.AddForce(transform.forward *- totalCharge);
            totalCharge = 0f;
        }
        Debug.Log(totalCharge);
    }
}
