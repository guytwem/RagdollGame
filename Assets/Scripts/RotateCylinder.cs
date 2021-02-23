using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCylinder : MonoBehaviour
{
    [SerializeField]
    private float rotationSpeed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        //transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
        //transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
    }
}
