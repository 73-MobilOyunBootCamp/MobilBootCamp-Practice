using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CharacterControllerExample
{
    public class CoinCollectable : MonoBehaviour, ICollectable
    {
        public void Collect(CharacterCurrentData coinData)
        {
            coinData.CurrentCoin++;
            Destroy(gameObject);
        }

        private void OnTriggerEnter(Collider other)
        {
            Character character = other.GetComponent<Character>();

            if (character)
                Collect(character.CharacterCurrentData);
        }
    }
}

