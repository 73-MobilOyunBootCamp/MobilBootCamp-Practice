using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CharacterControllerExample
{
    public abstract class CharacterBrainBase : MonoBehaviour, ICharacterBrain
    {
        private ICharacterController characterController;
        public ICharacterController CharacterController { get { return (characterController == null) ? characterController = GetComponent<ICharacterController>() : characterController; } }

        public virtual void Dispose()
        {
            Debug.Log("Brain Disposed " + gameObject.GetType());
        }

        public virtual void Intialize()
        {
            Debug.Log("Brain Intialized " + gameObject.GetType());
        }

        public abstract void Logic();
    }
}

