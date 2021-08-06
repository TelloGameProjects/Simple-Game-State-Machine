using UnityEngine;
using Vast.StateMachine;

[CreateAssetMenu(fileName = "AppManager")]
public class AppManager : ScriptableObject
{
    [SerializeField]
    private StateMachine appState;
}