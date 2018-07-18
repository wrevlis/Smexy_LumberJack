﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceOnClick : MonoBehaviour
{
    private Animator anims;
    public IntData CoinColloection;
    private void start()
    {
        anims = GetComponent<Animator>();
    }
    private void OnMouseDown()
    {
        anims.SetTrigger("CanBounce");
    }
    private void OnTriggerEnter(Collider other)
    {
        anims.SetTrigger("CanBounce");
    }
    public void EndAnims()
    {
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<SphereCollider>().enabled = false;
        GetComponent<ParticleSystem>().Emit(20);
        CoinColloection.Value++;
    }
}
