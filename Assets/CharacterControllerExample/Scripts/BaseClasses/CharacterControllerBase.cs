using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CharacterControllerExample
{


    public abstract class CharacterControllerBase : MonoBehaviour, ICharacterController
    {
        private Character _character;
        public Character Character => (_character == null) ? _character = GetComponent<Character>() : _character;


        public virtual void Dispose()
        {
            Debug.Log("Controller Disposed" + gameObject.GetType());
        }


        public abstract float CurrentSpeed();

        public virtual void Initialize()
        {
            Debug.Log("Controller Initialize" + gameObject.GetType());
        }

        public abstract void Move(Vector3 direction);

        public virtual void Rotate(Vector3 direction)
        {
            if (direction == Vector3.zero)
            {
                return;
            }
            direction.Normalize();
            float distanceToTargetDir = Vector3.Distance(transform.position, direction);
        }

        
    }
}