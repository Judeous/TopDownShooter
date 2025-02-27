﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New PowerUp", menuName = "PowerUp")]
public class PowerUpScriptableObject : ScriptableObject
{
    public float attackBoost;
    public float defenseBoost;
    public float healthBoost;
    public float speedBoost;
}
