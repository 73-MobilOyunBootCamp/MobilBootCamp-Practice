using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ForceArea : MonoBehaviour
{
    private List<Rigidbody> rigidbodies = new List<Rigidbody>();

    private void OnTriggerEnter(Collider other)
    {
        Rigidbody rigidbody = other.GetComponent<Rigidbody>();
        if (rigidbody)
        {
            if(!rigidbodies.Contains(rigidbody))
                rigidbodies.Add(rigidbody);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        foreach (var body in rigidbodies)
        {
            body.AddForceAtPosition(Vector3.up * 10, other.transform.position, ForceMode.Acceleration);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Rigidbody rigidbody = other.GetComponent<Rigidbody>();
        if (rigidbody)
        {
            if(rigidbodies.Contains(rigidbody))
                rigidbodies.Remove(rigidbody);
        }
    }


}
