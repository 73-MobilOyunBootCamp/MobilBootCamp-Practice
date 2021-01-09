using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace CharacterControllerExample
{
    /// <summary>
    /// Responsible for Communication
    /// Character State
    /// </summary>
    public class Character : MonoBehaviour
    {
        public static CharacterData CharacterData;

        #region Events
        public UnityEvent OnCharacterRevive = new UnityEvent();
        public UnityEvent OnCharacterDead = new UnityEvent();
        public UnityEvent OnCharacterJump = new UnityEvent();
        #endregion


        private static bool _isControllable = true;

        public static bool IsControllable
        {
            get { return _isControllable; }
            set { _isControllable = value; }
        }

        private bool _isDead;
        public bool IsDead
        {
            get{ return _isDead; }
            set { _isDead = value; }
        }

    }
}

