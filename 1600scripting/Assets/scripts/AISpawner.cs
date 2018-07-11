using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AISpawner : MonoBehaviour
{

    public GameObject Ai;
    public Transform Destination;
    public Level CurrentLevel;
    private int aiCount;

	void Start ()
    {
        StartCoroutine(StartSpawn());
	}

    IEnumerator StartSpawn()
    {
        while (aiCount > 0)
        {
            GameObject newAI = Instantiate(Ai);
            newAI.GetComponent<AIMovement>().Destination = Destination;
            aiCount--;
            yield return new WaitForSeconds(CurrentLevel.Time);
        }
    }
	

}
