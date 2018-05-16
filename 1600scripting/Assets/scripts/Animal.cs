using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Animal : MonoBehaviour {

    public float Speed;
    public int PowerLevel;
    public string PlayerName;

    // Use this for initialization
    void Start () {
        //transform.Rotate(0, Speed, 0);
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Speed,Speed,0);
        transform.Translate(Speed,0,0);
	}
}
