using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HahaGoBrrrr : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float rotate;
    public float rotationSpeed;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}
