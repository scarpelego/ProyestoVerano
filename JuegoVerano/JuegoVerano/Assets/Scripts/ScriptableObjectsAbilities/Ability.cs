﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Ability : ScriptableObject
{
    public string name;
    public Sprite aSprite;
    public AudioClip aSound;
    public float aBaseCoolDown = 1f;

    public abstract void Initialize(GameObject obj);
    public abstract void TriggerAbility();

    public string getName()
    {
        return name;
    }
}
