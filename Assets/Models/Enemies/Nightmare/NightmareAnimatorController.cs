using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NightmareAnimatorController : EnemyAnimatorController
{

    EnemyAttackDirections attackD;
    EnemyAttackParts attackP;
    EnemyAttackTypes attackT;

    public void SetAttackDirection(EnemyAttackDirections attackDirection)
    {
        attackD = attackDirection;
    }

    public void SetAttackType(EnemyAttackTypes attackType)
    {
        attackT = attackType;
    }

    public void SetAttackPart(EnemyAttackParts attackParts)
    {
        attackP = attackParts;
    }

    public void AttackDamageCallback()
    {
        mainController.AttackPlayer(attackT, attackP, attackD);
    }

}
