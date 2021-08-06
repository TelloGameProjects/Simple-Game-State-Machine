using System;


[Serializable]
public class SplashScreenState : State 
{
    private string name = String.Empty;

    #region Properties
    public string Name 
    {
        get { return this.name; }
        protected set { this.name = value; }
    }
    #endregion

    #region Class Methods
    public abstract void OnEnter();
    public abstract void OnExit();
    public abstract void Update();
    public abstract void FixedUpdate();
    #endregion
}
