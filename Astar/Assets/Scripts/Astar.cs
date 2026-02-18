using System.Collections.Generic;
using UnityEngine;

public class Astar
{
    // https://www.geeksforgeeks.org/dsa/a-search-algorithm/
    
    /// <summary>
    /// TODO: Implement this function so that it returns a list of Vector2Int positions which describes a path from the startPos to the endPos
    /// Note that you will probably need to add some helper functions
    /// </summary>
    /// <param name="startPos"></param>
    /// <param name="endPos"></param>
    /// <param name="grid"></param>
    /// <returns></returns>
    public List<Vector2Int> FindPathToTarget(Vector2Int startPos, Vector2Int endPos, Cell[,] grid)
    {
        int row = grid.GetLength(0);
        int col = grid.GetLength(1);
        
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                Debug.Log(grid[i, j].gridPosition + " " + grid[i, j].walls);
            }
        }
        
        // setup
        bool[,] closedList = new bool[row, col];
        Node[,] cellDetails = new Node[row, col];
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                cellDetails[i, j].HScore = float.MaxValue;
                cellDetails[i, j].GScore = float.MaxValue;
                cellDetails[i, j].FScore = float.MaxValue;
                cellDetails[i, j].parent = new ();
            }
        }

        // test movement
        List<Vector2Int> yes = new List<Vector2Int>()
        {
            startPos,
            Vector2Int.one,
            Vector2Int.one * 2,
            Vector2Int.one * 3,
            Vector2Int.one * 4,
            Vector2Int.one * 5,
            endPos
        };
        
        return yes;
    }
}
