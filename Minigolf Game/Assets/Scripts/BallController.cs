using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Rigidbody theRB;

    public float hitPower;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            theRB.velocity = Vector3.forward * hitPower;
        }
    }
}