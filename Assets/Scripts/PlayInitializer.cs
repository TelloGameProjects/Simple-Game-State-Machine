using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vast.StateMachine;

public class PlayInitializer : MonoBehaviour
{
    [SerializeField] private AppManager managingParent;


    // Start is called before the first frame update
    void Start()
    {
        managingParent.AppStateMachine.AddState(new PlayingState());
        managingParent.AppStateMachine.OnStateChange += CheckChangedState;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void CheckChangedState(State newState)
    {

        // TODO check if newState is relevant to us in MainMenu
    }
}
