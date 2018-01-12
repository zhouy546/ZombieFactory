using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieIdle : AbstractZombieNormal
{
    public ZombieIdle(CharacterProperty property) : this(property, ZombieColor.Unpainted) { }
    public ZombieIdle(CharacterProperty property, ZombieColor color) : base(property, color) { }
}
