using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    public int MoveSpeed { get; private set; }
    public int MaxHealth { get; private set; }
    public Condition[] ConditionImmunities { get; private set; }
    public DamageType[] DamageTypeImmunities { get; private set; }
    public DamageType[] DamageTypeResistances { get; private set; }
}
