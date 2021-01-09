using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CharacterControllerExample
{
    /// <summary>
    /// Responsible for  Health
    /// </summary>
    public class CharacterController : CharacterControllerBase
    {
        private Rigidbody _rigidbody;
        public Rigidbody Rigidbody
        {
            get { return (_rigidbody == null) ? _rigidbody = GetComponent<Rigidbody>() : _rigidbody; }
        }
        
        public override void Move(Vector3 direction)
        {
            if (!Character.IsControllable)
            {
                return;
            }
            
            Rotate(direction);
            if (Rigidbody.velocity.magnitude > Character.CharacterData.MovementData.MaxSpeed)
            {
                return;
            }
            Rigidbody.AddForce(direction * Character.CharacterData.MovementData.MovementForce * Time.fixedDeltaTime, ForceMode.VelocityChange);
        }
    }
}

