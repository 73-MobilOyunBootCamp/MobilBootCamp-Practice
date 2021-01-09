using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CharacterControllerExample
{
    public interface ICharacterController
    {
        void Intialize();
        void Move(Vector3 direction);
        void Rotate(Vector3 direction);
        void Dispose();
    }
}

