using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SG
{
    public class CharacterManager : MonoBehaviour
    {
        public Transform lockOnTransform;

        [Header("Combat Flags")]
        public bool isBlocking;
    }
}