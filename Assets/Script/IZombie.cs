using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface  IZombie{
    CharacterProperty characterProperty { get; set; }
    ZombieColor zombieColor { get; set; }
    void Paint(ZombieColor color);

}
