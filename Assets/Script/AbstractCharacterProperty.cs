using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractCharacterProperty : CharacterProperty
{
    private float hp;
    private float mp;
    private float speed;
    private string name;
    private bool isrange;

    public AbstractCharacterProperty(float hp,float mp,float speed,string name, bool isrange) {
        this.hp = hp;
        this.mp = mp;
        this.speed = speed;
        this.isrange = isrange;
        this.name = name;
    }


    public virtual float HP {
        get
        {
            return hp;
        }
        set {
            hp = value;
        }
    }


    public virtual float MP {
        get {
            return mp;
        }
        set
        {
            mp = value;
        }
    }

    public virtual float Speed {
        get {
           return speed;
        }
        set {
            speed = value;
        }
    }

    public virtual string Name
    {
        get
        {
            return name;
        }
        set {
            name = value;
        }
    }

    public virtual bool IsRange {
        get {
            return isrange;
        }
    }

}
