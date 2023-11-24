using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace SG
{
    public class EnemyLocomotionManager : MonoBehaviour
    {
        EnemyManager enemyManager;
        EnemyAnimatorManager enemyAnimatorManager;

        public LayerMask detectionLayer;

        private void Awake()
        {
            enemyManager = GetComponent<EnemyManager>();
            enemyAnimatorManager = GetComponentInChildren<EnemyAnimatorManager>();
        }
    }
}

