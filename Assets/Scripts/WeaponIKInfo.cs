using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponIKInfo : MonoBehaviour
{
    [SerializeField]
    Transform leftHandTransform;

    public Transform LeftHandTransform
    {
        get
        {
            return leftHandTransform;
        }
    }
}
