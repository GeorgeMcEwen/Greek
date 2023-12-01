using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SG
{
    public class PlayerAttacker : MonoBehaviour
    {
        AnimatorHandler animatorHandler;
        PlayerEquipmentManager playerEquipmentManager;
        PlayerStats playerStats;
        InputHandler inputHandler;
        WeaponSlotManager weaponSlotManager;
        PlayerManager playerManager;
        public string lastAttack;

        private void Awake()
        {
            animatorHandler = GetComponentInChildren<AnimatorHandler>();
            playerEquipmentManager = GetComponent<PlayerEquipmentManager>();
            playerStats = GetComponent<PlayerStats>();
            weaponSlotManager = GetComponentInChildren<WeaponSlotManager>();
            inputHandler = GetComponent<InputHandler>();
            playerManager = GetComponentInParent<PlayerManager>();
        }

        public void HandleWeaponCombo(WeaponItem weapon)
        {

            if (playerStats.currentStamina <= 0)
                return;

            if (inputHandler.comboFlag)
            {
                animatorHandler.anim.SetBool("canDoCombo", false);

                if (lastAttack == weapon.OH_Light_Attack_01)
                {
                    animatorHandler.PlayTargetAnimation(weapon.OH_Light_Attack_02, true);
                }
                else if (lastAttack == weapon.TH_Light_Attack_01)
                {
                    animatorHandler.PlayTargetAnimation(weapon.TH_Light_Attack_02, true);
                }
            }

        }

        public void HandleLightAttack(WeaponItem weapon)
        {

            if (playerStats.currentStamina <= 0)
                return;

            weaponSlotManager.attackingWeapon = weapon;

            if (inputHandler.twoHandFlag)
            {
                animatorHandler.PlayTargetAnimation(weapon.TH_Light_Attack_01, true);
                lastAttack = weapon.TH_Light_Attack_01;
            }
            else
            {
                animatorHandler.PlayTargetAnimation(weapon.OH_Light_Attack_01, true);
                lastAttack = weapon.OH_Light_Attack_01;
            }

        }

        public void HandleHeavyAttack(WeaponItem weapon)
        {
            if (playerStats.currentStamina <= 0)
                return;

            weaponSlotManager.attackingWeapon = weapon;
            if (inputHandler.twoHandFlag)
            {
                animatorHandler.PlayTargetAnimation(weapon.TH_Heavy_Attack_01, true);
                lastAttack = weapon.OH_Heavy_Attack_01;
            }
            else
            {
                animatorHandler.PlayTargetAnimation(weapon.OH_Heavy_Attack_01, true);
                lastAttack = weapon.OH_Heavy_Attack_01;
            }
        }

        public void HandleLBAction() //Handle Blocking
        {
            PerformLBBlockingAction();
        }

        #region Defense Actions
        private void PerformLBBlockingAction()
        {
            if (playerManager.isInteracting) 
                return;

            if (playerManager.isBlocking)
                return;

            animatorHandler.PlayTargetAnimation("straight_sword_th_guard_block_medium_01", false, true);
            playerEquipmentManager.OpenBlockingCollider();
            playerManager.isBlocking = true;
        }
        #endregion
    }
}

