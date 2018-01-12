using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeAttack : AbstractCharacterProperty {
    public MeleeAttack(float hp, float mp, float speed,string name) : base(hp, mp, speed,name, true) { }

}
