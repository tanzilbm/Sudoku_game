using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValueSet : MonoBehaviour
{
    [SerializeField]
    Text text_ref;

    public void SetText(int value)
    {
        text_ref.text = value.ToString();
        if (value != -1)
            text_ref.text = value.ToString();
        else
            text_ref.text = "";
    }

    public int GetValue()
    {
        return int.Parse(text_ref.text);
    }
}