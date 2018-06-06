using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]
public class CangeUIColor : ScriptableObject
{

    public Color NewColor;

    public void ColorUI(Image imageParameter)
    {
        imageParameter.color = NewColor;
    }

}
