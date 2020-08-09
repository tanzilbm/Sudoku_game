using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    public GameObject GridBackground;
    public GameObject small_grid;
    private ValueSet[,] arr = new ValueSet[9, 9];
    private List<List<int>> problem = new List<List<int>>
    {
        new List<int>{5, 3, -1, -1, -1, 7, -1, -1, -1},
        new List<int>{6, -1, -1, 1, 9, 5, -1, -1, -1},
        new List<int>{-1, 9, 8, -1, -1, -1, -1, 6, -1},
        new List<int>{8, -1, -1, -1, 6, -1, -1, -1, 3},
        new List<int>{4, -1, -1, 8, -1, 3, -1, -1, 1},
        new List<int>{7, -1, -1, -1, 2, -1, -1, -1, 6},
        new List<int>{-1, 6, -1, -1, -1, -1, 2, 8, -1},
        new List<int>{-1, -1, -1, 4, 1, 9, -1, -1, 5},
        new List<int>{-1, -1, -1, -1, 8, -1, -1, 7, 9}
    };

    void Start()
    {
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                arr[i, j] = Instantiate(small_grid, Vector3.zero, Quaternion.identity, GridBackground.transform).GetComponent<ValueSet>();
                arr[i, j].SetText(problem[i][j]);
            }
        }
    }
}
