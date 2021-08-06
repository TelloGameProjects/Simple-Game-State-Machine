using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vast.StateMachine;

public class GameStateController : MonoBehaviour
{
    StateMachine stateMachine;

    private enum eState { SPLASHSCREENSTATE, PLAYINGSTATE, PAUSESTATE, GAMEOVERSTATE};
    
    private Dictionary<eState, State> gameStateDict;
    private Dictionary<eState, Action<State>> OnStateChangeCallbackDict;
    

    void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //stateMachine.UpdateActiveState();
    }


    private void RegisterStates()
    {

    }
}
