using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponHoldIK : MonoBehaviour
{
    [SerializeField]
    WeaponIKInfo currentWeapon;
    Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public WeaponIKInfo CurrentWeapon
    {
        get
        {
            return currentWeapon;
        }

        set
        {
            currentWeapon = value;
        }
    }

    private void OnAnimatorIK(int layerIndex)
    {
        animator.SetIKPosition(AvatarIKGoal.LeftHand, CurrentWeapon.LeftHandTransform.position);
        animator.SetIKPositionWeight(AvatarIKGoal.LeftHand, 1f);

        animator.SetIKRotation(AvatarIKGoal.LeftHand, CurrentWeapon.LeftHandTransform.rotation);
        animator.SetIKRotationWeight(AvatarIKGoal.LeftHand, 1f);
    }
}
