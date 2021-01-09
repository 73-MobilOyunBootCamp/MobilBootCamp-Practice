using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CharacterControllerExample
{


    public interface ICharacterBrain
    {
        ICharacterController CharacterController { get; }
        void Initialize();
        void Logic();
        void Dispose();
        

    }

}