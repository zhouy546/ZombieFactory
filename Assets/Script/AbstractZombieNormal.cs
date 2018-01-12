using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbstractZombieNormal : AbstractZombie {
    public AbstractZombieNormal(CharacterProperty property) : this(property, ZombieColor.Unpainted) { }
    public AbstractZombieNormal(CharacterProperty property, ZombieColor color) : base(property, color) { }
}
