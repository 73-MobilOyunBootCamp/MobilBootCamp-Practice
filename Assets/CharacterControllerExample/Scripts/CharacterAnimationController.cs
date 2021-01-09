using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

namespace CharacterControllerExample
{
    /// <summary>
    /// Responsible for Animation
    /// </summary>
    [RequireComponent(typeof(Character))]
    public class CharacterAnimationController : MonoBehaviour
    {
        private Character _character;
        public Character Character => (_character == null) ? _character = GetComponentInParent<Character>() : _character;

        private ICharacterController _characterController;
        public ICharacterController CharacterController => (_characterController == null) ? GetComponentInParent<ICharacterController>() : _characterController;

        private void Update()
        {
            AnimationUpdate();
        }

        public void AnimationUpdate()
        {
            //todo animation on this method
            //Animator.SetFloat("Speed", CharacterController.GetCurrentSpeed());
            
        }
    }
}

