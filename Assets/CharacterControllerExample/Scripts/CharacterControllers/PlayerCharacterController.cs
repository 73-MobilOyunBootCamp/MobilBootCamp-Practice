using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CharacterControllerExample
{
    public class PlayerCharacterController : CharacterController
    {
        public override void Move(Vector3 direction)
        {
            //direction = Camera.main.transform.TransformDirection(direction);
            base.Move(direction);
        }

        public override void Rotate(Vector3 direction)
        {
            //direction = CharacterManager.Instance.GetClosestAI(transform.position).transform.position - transform.position;
            base.Rotate(direction);
        }
    }
}

