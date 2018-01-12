using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractZombie : MonoBehaviour, IZombie {
    private CharacterProperty property;
    private ZombieColor color;

    public AbstractZombie(CharacterProperty property) : this(property, ZombieColor.Unpainted) { }
    public AbstractZombie(CharacterProperty property, ZombieColor zombieColor) {
        this.property = property;
        this.color = zombieColor;
    }

    public virtual CharacterProperty characterProperty {
        get { return property; }
        set {
            property = value;
        }
    } 

    public virtual ZombieColor zombieColor
    {
        get {
            return color;
        }
        set {
            color = value;
        }
    }



    public virtual void Paint(ZombieColor color) {
        this.color = color;
    }
}
