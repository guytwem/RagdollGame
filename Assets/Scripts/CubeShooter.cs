using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeShooter : MonoBehaviour
{
    [SerializeField]
    private float maxDistance = 500f;
    public GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3.MoveTowards(cube.transform.position, transform.forward, maxDistance);
        }

        
    }
}
