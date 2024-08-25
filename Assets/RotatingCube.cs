using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RotatingCube : MonoBehaviour
{
 public Vector3 editRotation;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey)
        {
        transform.Rotate(editRotation * Time.deltaTime);
        Debug.Log("Update");

    }
    else 
    {
        Debug.Log("else");
    }
    }
}
// private void FixedUpdate()
// {

// }
// private void OnCollisionEnter(Collision collision)
// {

// }