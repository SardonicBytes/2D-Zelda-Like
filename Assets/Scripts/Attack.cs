using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Attack
{
    public float damage;
    public DamageType damageType;
    public float healing;
    public Condition[] conditionsToApply;
    public Condition[] conditionsToRemove;
}

public enum DamageType { Physical, Magical }
