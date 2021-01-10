using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CharacterControllerExample
{
    public class AICharacterController : CharacterController
    {
        public override void Rotate(Vector3 direction)
        {
            direction = CharacterManager.Instance.Player.transform.position - transform.position;
            base.Rotate(direction);
        }
    }
}

