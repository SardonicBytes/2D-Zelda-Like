using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Condition
{
    public enum ConditionType { Stunned, AttackEmpowered, SpeedUp };
    public ConditionType conditionType;
    public float duration;

    public static bool operator ==(Condition c1, Condition c2)
    {
        return (c1.conditionType == c2.conditionType);
    }
    public static bool operator !=(Condition c1, Condition c2)
    {
        return (c1.conditionType == c2.conditionType);
    }
    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
    public override bool Equals(object obj)
    {
        return base.Equals(obj);
    }
}
