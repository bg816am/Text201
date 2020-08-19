using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

// creates a menu item in unity for a script of type state
[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
 [TextArea (10,14)][SerializeField] private string storyText; //Use SerializeField to have it show up in Unity
 [SerializeField] private State[] nextStates;
 public string GetStateStory()
 {
  return storyText;
 }

 public State[] GetNextStates()
 {
  return nextStates;
 }
 
}
