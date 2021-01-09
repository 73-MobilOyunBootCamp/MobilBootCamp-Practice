using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CharacterControllerExample
{
    /// <summary>
    /// Responsible for Animations
    /// </summary>
    public class CharacterAnimationController : MonoBehaviour
    {
        Character character;
        Character Character { get { return (character == null) ? character = GetComponentInParent<Character>() : character; } }

        ICharacterController characterController;
        ICharacterController CharacterController { get { return (characterController == null) ? characterController = GetComponentInParent<CharacterController>() : characterController; } }

        Animator animator;
        Animator Animator { get { return (animator == null) ? animator = GetComponent<Animator>() : animator; } }

        private void Update()
        {
            UpdateAnimations();
        }

        private void UpdateAnimations()
        {
            Animator.SetFloat("Speed", CharacterController.GetCurrentSpeed());
        }
    }
}

