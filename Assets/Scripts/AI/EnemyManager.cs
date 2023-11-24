using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

namespace SG
{
    public class EnemyManager : CharacterManager
    {
        EnemyLocomotionManager enemyLocomotionManager;
        EnemyAnimatorManager enemyAnimationManager;
        EnemyStats enemyStats;

        public State currentState;
        public CharacterStats currentTarget;

        public bool isPreformingAction;

        [Header("A.I Settings")]
        public float detectionRadius = 20;
        //Detection angles are the FoV of the enemy's AI
        public float maximumDetectionAngle = 50;
        public float minimumDetectionAngle = -50;

        public float currentRecoveryTime = 0;

        private void Awake()
        {
            enemyLocomotionManager = GetComponent<EnemyLocomotionManager>();
            enemyAnimationManager = GetComponentInChildren<EnemyAnimatorManager>();
            enemyStats = GetComponent<EnemyStats>();
        }

        private void Update()
        {
            HandleRecoveryTimer();
        }

        private void FixedUpdate()
        {
            HandleStateMachine();
        }

        private void HandleStateMachine()
        {
            if (currentState != null)
            {
                State nextState = currentState.Tick(this, enemyStats, enemyAnimationManager);

                if (nextState != null)
                {
                    SwitchToNextState(nextState);
                }
            }
        }

        private void SwitchToNextState(State state)
        {
            currentState = state;
        }


        private void HandleRecoveryTimer()
        {
            if (currentRecoveryTime > 0)
            {
                currentRecoveryTime -= Time.deltaTime;
            }

            if (isPreformingAction)
            {
                if (currentRecoveryTime <= 0)
                {
                    isPreformingAction = false;
                }
            }
        }


        #region Attacks

        private void AttackTarget()
       {
            //if (isPreformingAction)
                //return;

           // if (currentAttack == null)
           // {
               // GetNewAttack();
           // }
           // else
           // {
                //isPreformingAction = true;
               // currentRecoveryTime = currentAttack.recoveryTime;
                //enemyAnimatorManager.PlayTargetAnimation(currentAttack.actionAnimation, true);
               // currentAttack = null;
           // }
       }

        private void GetNewAttack()
        {
            //Vector3 targetsDirection = enemyLocomotionManager.currentTarget.transform.position - transform.position;
           // float viewableAngle = Vector3.Angle(targetsDirection, transform.forward);
           // enemyLocomotionManager.distanceFromTarget = Vector3.Distance(enemyLocomotionManager.currentTarget.transform.position, transform.position);

           // int maxScore = 0;

           // for (int i = 0; i < enemyAttacks.Length; i++)
            //{
                //EnemyAttackAction enemyAttackAction = enemyAttacks[i];

                //if (enemyLocomotionManager.distanceFromTarget <= enemyAttackAction.maximumDistanceNeededToAttack
                    //&& enemyLocomotionManager.distanceFromTarget >= enemyAttackAction.minimumDistanceNeededToAttack)
               // {
                   // if (viewableAngle <= enemyAttackAction.maximumAttackAngle
                       // && viewableAngle >= enemyAttackAction.minimumAttackAngle)
                   // {
                        //maxScore = enemyAttackAction.attackScore;
                   // }
               // }
           // }

            //int randomValue = Random.Range(0, maxScore);
            //int temporaryScore = 0;

           // for (int i = 0; i < enemyAttacks.Length; i++)
           // {
                //EnemyAttackAction enemyAttackAction = enemyAttacks[i];

                //if (enemyLocomotionManager.distanceFromTarget <= enemyAttackAction.maximumDistanceNeededToAttack
                   // && enemyLocomotionManager.distanceFromTarget >= enemyAttackAction.minimumDistanceNeededToAttack)
               // {
                   // if (viewableAngle <= enemyAttackAction.maximumAttackAngle
                       // && viewableAngle >= enemyAttackAction.minimumAttackAngle)
                  //  {
                        //if (currentAttack != null)
                            //return;

                       // temporaryScore = enemyAttackAction.attackScore;

                        //if (temporaryScore > randomValue)
                        //{
                            //currentAttack = enemyAttackAction;
                        //}
                   // }
               // }
           // }
        }
        #endregion

        private void OnDrawGizmosSelected()
        {
            //this code is just for dev stuff, so we can see the raidus of the enemy tracking radar
            Gizmos.color = Color.red; //replace red with whatever color you prefer
            Gizmos.DrawWireSphere(transform.position, detectionRadius);
        }
    }

}
