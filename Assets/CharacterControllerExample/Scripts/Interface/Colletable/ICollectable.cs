using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CharacterControllerExample
{
    public interface ICollectable
    {
        void Collect(CharacterCurrentData coinData);
    }
}

