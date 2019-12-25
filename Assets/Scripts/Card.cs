using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="New Card", menuName="Card" )]
public class Card : ScriptableObject
{
    public string cardName;
    public string description;

    public int insanity;
    public int life;
    public int attack;

    public Sprite artWork;

}
