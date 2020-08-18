using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] Text textComponent;
    // Start is called before the first frame update
    void Start()
    {
        textComponent.text =
            "You wake up in your room, nursing a headache. You remember the party, bits and pieces of" +
            "it at least. You knew you couldn't make it home and you checked in here at the El Dorado Hotel" +
            "Looking around the room you remember nothing past checking in";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
