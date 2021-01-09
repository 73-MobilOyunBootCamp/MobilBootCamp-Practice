using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CharacterControllerExample
{


    public class CharacterInputController : MonoBehaviour
    {
        private ICharacterBrain _characterBrain;
        public ICharacterBrain CharacterBrain
        {
            get
            {
                return (_characterBrain == null) ? _characterBrain = GetComponent<ICharacterBrain>() : _characterBrain;
            }
        }
        
        private void FixedUpdate()
        {
            CharacterBrain.Logic();

        }
    }
}