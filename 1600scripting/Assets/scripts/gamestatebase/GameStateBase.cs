using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameStateBase : ScriptableObject, IGamestate
{
    public virtual void Run()
    {
        Debug.Log("Running");
    }
	
}

public interface IGamestate
{
    void Run();
}
