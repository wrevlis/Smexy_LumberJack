using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu]
public class Level : ScriptableObject
{
    public int AiCount = 1;
    public float Time = 2;

    public void CheckAICount(int finalCount)
    {
            Debug.Log("All AI Spawned");
    }
}
