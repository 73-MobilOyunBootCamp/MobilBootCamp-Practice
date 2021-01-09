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
        private Rigidbody rigidbody;
        public Rigidbody Rigidbody { get { return (rigidbody == null) ? rigidbody = GetComponent<Rigidbody>() : rigidbody; } }

        public override void Move(Vector3 direction)
        {
            if (!Character.IsControllable)
                return;

            Rotate(direction);
            //if (Rigidbody.velocity.magnitude > Character.CharacterData.MovementData.MaxSpeed)
            //    return;

            //Rigidbody.AddForce(direction * Character.CharacterData.MovementData.MovmeentForce * Time.fixedDeltaTime, ForceMode.VelocityChange);
            
            Rigidbody.velocity = direction * Character.CharacterData.MovementData.MovementForce * Time.fixedDeltaTime;
        }

        public override float CurrentSpeed()
        {
            return Rigidbody.velocity.magnitude;
        }
    }
}

