﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : IWeapon
{
    public override WeaponType Type
    {
        get
        {
            return WeaponType.arm;
        }
    }

    public override void OnAttack()
    {
        
    }

    public override void PlaySoundEffects()
    {
        
    }
}
