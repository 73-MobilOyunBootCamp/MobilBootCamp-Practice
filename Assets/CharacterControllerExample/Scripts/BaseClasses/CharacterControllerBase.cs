﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CharacterControllerExample
{


    public abstract class CharacterControllerBase : MonoBehaviour, ICharacterController
    {
        public virtual void Dispose()
        {
            Debug.Log("Controller Disposed" + gameObject.GetType());
        }

        public virtual void Initialize()
        {
            Debug.Log("Controller Initialize" + gameObject.GetType());
        }

        public abstract void Move(Vector3 direction);

        public virtual void Rotate(Vector3 direction)
        {
            
        }

        
    }
}