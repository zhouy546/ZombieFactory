using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface CharacterProperty {
    float HP { get; }
    float MP { get; }
    float Speed { get; }
    string Name { get; }
    bool IsRange { get; }
    
}
