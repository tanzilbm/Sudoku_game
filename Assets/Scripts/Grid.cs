using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    public GameObject GridBackground;
    public GameObject small_grid;
    private ValueSet[,] arr = new ValueSet[9, 9];
    void Start()
    {
        for(int i = 0; i<9; i++)
        {
            for(int j = 0;j<9;j++)
            {
                arr[i, j] = Instantiate(small_grid, Vector3.zero, Quaternion.identity, GridBackground.transform).GetComponent<ValueSet>();
            }
        }
    }
}
