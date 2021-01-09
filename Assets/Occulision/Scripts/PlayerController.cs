using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    private CharacterController characterController;
    public CharacterController CharacterController { get { return (characterController == null) ? characterController = GetComponent<CharacterController>() : characterController; } }

    public float speed;

    private void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(h, 0, v);
        dir = Camera.main.transform.TransformDirection(dir);

        CharacterController.SimpleMove(dir * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
    }
}
