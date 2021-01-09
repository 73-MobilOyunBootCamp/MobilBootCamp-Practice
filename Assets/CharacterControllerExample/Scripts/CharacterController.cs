using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CharacterControllerExample
{
    /// <summary>
    /// Responsible for  Health
    /// </summary>
    public class CharacterController : MonoBehaviour
    {
        private bool _isControllable;
        public bool IsControllable
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

