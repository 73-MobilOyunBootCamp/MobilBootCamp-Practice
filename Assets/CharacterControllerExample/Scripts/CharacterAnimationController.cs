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

        private void OnEnable()
        {
            Character.OnCharacterAttack.AddListener(OnAttack);
            Character.OnCharacterDie.AddListener(() => Animator.enabled = false);
            Character.OnCharacterRevive.AddListener(() => Animator.enabled = true);
        }

        private void OnDisable()
        {
            Character.OnCharacterAttack.RemoveListener(OnAttack);

            Character.OnCharacterDie.AddListener(() => Animator.enabled = false);
            Character.OnCharacterRevive.AddListener(() => Animator.enabled = true);
        }

        private void Update()
        {
            UpdateAnimations();
        }

        private void UpdateAnimations()
        {
            Animator.SetFloat("Speed", CharacterController.GetCurrentSpeed());
        }

        private void OnAttack()
        {
            Animator.SetTrigger("Attack");
        }
    }
}

