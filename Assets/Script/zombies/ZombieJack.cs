using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieJack : AbstractZombieNormal
{
    public ZombieJack(CharacterProperty property) : this(property, ZombieColor.Unpainted) { }
    public ZombieJack(CharacterProperty property, ZombieColor color) : base(property, color) { }
}

