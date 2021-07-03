using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Status
{
    Stats stats;
    Controller Controller;
    public List<Condition> ConditionImmunities { get; private set; }
    public List<Condition> Conditions { get; private set; }
    public float MoveSpeed;
    public float Health { get; private set; }

    void Init( Controller newController, Stats newStats )
    {
        Controller = newController;
        stats = newStats;
        ConditionImmunities = new List<Condition>();
        ConditionImmunities.AddRange(stats.ConditionImmunities);
        Conditions = new List<Condition>();
    }

    void GetHit(Attack attack)
    {
        Health -= attack.damage;
        if (Health <= 0)
        {
            Debug.Log("Death");
        }
        Conditions.AddRange(attack.conditionsToApply);
    }

    void Cure(Attack attack)
    {
        Health = Mathf.Max(Health + attack.healing, stats.MaxHealth);
        foreach (Condition condition in Conditions)
        {
            //This Array should typically be 1 MAYBE 2 members long, 
            //so iteration should not be a performance concern
            foreach (Condition conditionToRemove in attack.conditionsToRemove) { 
                if (condition == conditionToRemove)
                {
                    Conditions.Remove(conditionToRemove);
                }
            }
        }
    }



}
