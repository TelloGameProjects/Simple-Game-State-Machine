using UnityEngine;
using Vast.StateMachine;

[CreateAssetMenu(fileName = "AppManager", menuName = "Managers/AppManager")]
public class AppManager : ScriptableObject
{
    [SerializeField]
    private StateMachine appState;
}