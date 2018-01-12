using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour,IZombie {
    private CharacterProperty property;
    private ZombieColor color;
    public  CharacterProperty characterProperty
    {
        get { return property; }
        set { property = value; }
    }

    public  ZombieColor zombieColor
    {
        get
        {
            return color;
        }
        set {
            color = value;
        }
    }



    public  void Paint(ZombieColor color)
    {
        this.color = color;
    }
}
