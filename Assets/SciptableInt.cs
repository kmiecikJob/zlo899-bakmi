using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Thanks to this line you can create new Scriptable object that will hold only 1 int value
//after creation it has different icon than rest of scripts, you CAN'T attach it to game object like normal scripts
//but you can create scripta that can hold it
[CreateAssetMenu (menuName ="ScriptableInt")]
public class SciptableInt : ScriptableObject
{
    public int value;
}
