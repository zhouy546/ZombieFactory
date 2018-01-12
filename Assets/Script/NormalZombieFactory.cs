using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalZombieFactory : ZombieFactory
{
    protected internal override IZombie SelectZombie(IsRange isRange)
    {
        if (isRange == IsRange.Melee)
        {
            return new ZombieJack(new MeleeAttack(50, 50, 50,"NormalZombieJack"));
        }
        else if (isRange == IsRange.Range)
        {
            return new ZombieIdle(new RangeAttack(25, 100, 50,"NormalZombieIdle"));
        }
        else
        {
            return new ZombieJack(new MeleeAttack(50, 50, 50,"NormalZombieJake"));
        }
    }
}
