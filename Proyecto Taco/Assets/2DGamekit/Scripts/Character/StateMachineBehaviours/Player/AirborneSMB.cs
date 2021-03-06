﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gamekit2D
{
    public class AirborneSMB : SceneLinkedSMB<PlayerCharacter>
    {
        public override void OnSLStateNoTransitionUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            m_MonoBehaviour.UpdateFacing();
            m_MonoBehaviour.UpdateJump();
            m_MonoBehaviour.AirborneHorizontalMovement();
            m_MonoBehaviour.AirborneVerticalMovement();
            m_MonoBehaviour.CheckForGrounded();
            m_MonoBehaviour.CheckForHoldingGun();
            if (m_MonoBehaviour.CheckForMeleeAttackInput())
                m_MonoBehaviour.MeleeAttack();
            m_MonoBehaviour.CheckAndFireGun();
            if (m_MonoBehaviour.CheckForJumpInput() && m_MonoBehaviour.canDoubleJump == true)
            {
                m_MonoBehaviour.SetVerticalMovement(m_MonoBehaviour.jumpSpeed);

                m_MonoBehaviour.canDoubleJump = false;
            }
            m_MonoBehaviour.CheckForCrouching ();
        }
    }
}