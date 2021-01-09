using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CharacterControllerExample
{


    public abstract class CharacterBrainBase : MonoBehaviour, ICharacterBrain
    {
        private ICharacterController _characterController;
        public ICharacterController CharacterController
        {
            get { return (_characterController == null) ? _characterController = GetComponent<ICharacterController>() : _characterController; }
        }

        public virtual void Initialize()
        {
            Debug.Log("Brain Initialize" + gameObject.GetType());
        }

        public abstract void Logic();

        public virtual void Dispose()
        {
            Debug.Log("Brain Disposed" + gameObject.GetType());
        }
    }

}