using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CharacterControllerExample
{
    /// <summary>
    /// Responsible for Logic
    /// </summary>
    public class CharacterBrain : CharacterBrainBase
    {
        public override void Logic()
        {
            CharacterController.Move(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")));
        }

        private void OnCollisionEnter(Collision collision)
        {
            Character aiCharacter = collision.collider.GetComponent<Character>();
            if(aiCharacter)
            {
                if(aiCharacter.CharacterType == CharacterType.AI)
                {
                    Character.OnCharacterAttack.Invoke();
                }
            }
        }
    }
}

