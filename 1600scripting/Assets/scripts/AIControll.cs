using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu]
public class AIControll : ScriptableObject
{
    public float Speed;
    public float AngularSpeed;

    public void ConfigAI(NavMeshAgent agent)
    {
        agent.speed = Speed;
        agent.angularSpeed = AngularSpeed;
    }
	
}
