using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SG
{
    public class PursueTargetState : State
    {
        public override State Tick(EnemyManager enemyManager, EnemyStats enemyStats, EnemyAnimatorManager enemyAnimatorManager)
        {
            // Chase the target
            //if within attack range, return to combat stance state
            //if target is out of range, return to this state and continue to chase target
            return this;
        }
    }
}

