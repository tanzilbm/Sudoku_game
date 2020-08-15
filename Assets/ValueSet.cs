using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValueSet : MonoBehaviour
{
    [SerializeField]
    InputField text_ref;
    [SerializeField]
    private int i, j;
    public void SetText(int value)
    {
        text_ref.textComponent.text = value.ToString();
        if (value != -1)
            text_ref.text = value.ToString();
        else
            text_ref.text = "";
    }
    public void setIJ(int i, int j)
    {
        this.i = i;
        this.j = j;
    }
    public void DisableField()
    {
        text_ref.interactable = false;
    }

    public int GetValue()
    {
        return int.Parse(text_ref.text);
    }

    public void OnKeyPress(string value)
    {
        if (!string.IsNullOrEmpty(value) && value!="0" && value!="-")
        {
            int numberEntered = int.Parse(value);
            int firstRowIndexOfGrid = i - (i % 3);
            int firstColumnIndexOfGrid = j - (j % 3);
            List<int> gridValues = new List<int>();
            var rowValues = new List<int>();
            var columnValues = new List<int>();
            for (var l = firstRowIndexOfGrid; l < firstRowIndexOfGrid + 3; l++)
                for (var m = firstColumnIndexOfGrid; m < firstColumnIndexOfGrid + 3; m++)
                    gridValues.Add(Grid.Instance.problem[l][m]);
            for (var l = 0; l < 9; l++)
            {
                rowValues.Add(Grid.Instance.problem[i][l]);               
            }
            for (var m = 0; m < 9; m++)
            {
                columnValues.Add(Grid.Instance.problem[m][j]);
            }
            if (!gridValues.Contains(numberEntered)&&!rowValues.Contains(numberEntered)&&!columnValues.Contains(numberEntered))
                Grid.Instance.problem[i][j] = numberEntered;
            else if (!text_ref.interactable) { }
            else
                SetText(-1);
                
        }
        else if(string.IsNullOrEmpty(value))
        {
            Grid.Instance.problem[i][j] = -1;
        }
        else
        {
            SetText(-1);
        }
        Debug.Log(value);
    }
}