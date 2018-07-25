using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionTypes : MonoBehaviour
{
    void NoReturnType()
    {
        // do work
    }

    void VoidWithPeramiter()
    {

    }

    int NameOfFunction()
    {
        //do work
        return 0;
    }


    IEnumerator CoroutineName()
    {
        // Do work
        yield return new WaitForSeconds(1);
        // Do More Work
    }
}
