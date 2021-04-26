using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    // Start is called before the first frame update
    float[,] grid;
    [SerializeField]
    int row, col, rowCount, colCount;
    void Start()
    {
        GenerateGrid();
    }

    void GenerateGrid()
    {
        // Math for Row and Col in here

        grid = new float[colCount,rowCount];

    }
    public float[,] getGrid
    {
        get
        {
            return grid;
        }
        set
        {
            grid = value;
        }
    }

    void Draw()
    {
        // Draw the grid in here
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
