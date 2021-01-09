﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CharacterControllerExample
{
    public class CharacterInputController : MonoBehaviour
    {
        ICharacterBrain characterBrain;
        ICharacterBrain CharacterBrain { get { return (characterBrain == null) ? characterBrain = GetComponent<CharacterBrain>() : characterBrain; } }
        private void FixedUpdate()
        {
            CharacterBrain.Logic();
        }
    }
}

