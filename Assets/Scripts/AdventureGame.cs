using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] Text textComponent;
    [SerializeField] private State startingState;
    
    private State _state;
    // Start is called before the first frame update
    void Start()
    {
        _state = startingState;
        textComponent.text = _state.GetStateStory();
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
    }

    private void ManageState()
    {
        var nextStates = _state.GetNextStates();
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            _state = nextStates[0];
        }
        else if (Input.GetKeyDown((KeyCode.Alpha2)))
        {
            _state = nextStates[1];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            _state = nextStates[2];
        }

        textComponent.text = _state.GetStateStory();
    }
}
