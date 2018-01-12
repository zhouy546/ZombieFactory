using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ZombieFactory : MonoBehaviour {
    public enum Catagory {
        Normal,Crazy
    }

    public enum IsRange {
       Range,Melee
    }

    public virtual IZombie Build(IsRange isRange, ZombieColor color)
    {
        IZombie z = SelectZombie(isRange);
        z.Paint(color);
        return z;
    }

    protected internal abstract IZombie SelectZombie(IsRange isRange);

    public static IZombie Make(Catagory catagory, IsRange isRange, ZombieColor color) {
        ZombieFactory factory = null;

        if (catagory == Catagory.Crazy) {
            factory = new CrazyZombieFactory();
        } else if(catagory==Catagory.Normal){
            factory = new NormalZombieFactory();
        }
        return factory.Build(isRange, color);
    }
}
