using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrazyZombieFactory : ZombieFactory {
    protected internal override IZombie SelectZombie(IsRange isRange)
    {
        if (isRange == IsRange.Melee)
        {
            return new ZombieJack(new MeleeAttack(100, 50, 50,"CrazyZombieJack"));
        }
        else if (isRange == IsRange.Range)
        {
            return new ZombieIdle(new RangeAttack(50, 100, 50,"CrazyZombieIdle"));
        }
        else {
            return new ZombieJack(new MeleeAttack(100, 50, 50, "CrazyZombieJack"));
        }
    }

}
