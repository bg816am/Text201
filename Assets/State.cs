using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// creates a menu item in unity for a script of type state
[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
 [TextArea (10,14)][SerializeField] private string storyText; //Use SerializeField to have it show up in Unity
}
