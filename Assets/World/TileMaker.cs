using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class TileMaker : MonoBehaviour
{
    [SerializeField] int width = 5;
    [SerializeField] int height = 5;
    [SerializeField] public int tileSize = 10;
    [SerializeField] Tile tile;

    void Start()
    {
        // MakeTiles(); // currently not used in play mode
    }

    void MakeTiles()
    {
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                var spawnedTile = Instantiate(tile, new Vector3(i * tileSize, 0, j * tileSize), Quaternion.identity);
                spawnedTile.name = $"{i},{j}";
            }
        }
    }
}
