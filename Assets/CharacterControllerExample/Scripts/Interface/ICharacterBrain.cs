using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CharacterControllerExample
{


    public interface ICharacterBrain
    {

        void Initialize();
        void Logic();
        void Dispose();
        

    }

}