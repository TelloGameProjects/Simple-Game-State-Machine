using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vast.StateMachine;

public class MainMenuInitializer : MonoBehaviour
{
    [SerializeField] private AppManager managingParent;

    private SplashScreenState splashScreenState;
    

    // Start is called before the first frame update
    void Start()
    {
        splashScreenState = (SplashScreenState)(managingParent.AppStateMachine.AddState(new SplashScreenState()));
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
