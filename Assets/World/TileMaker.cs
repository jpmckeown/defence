using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.AI;

[ExecuteInEditMode]
public class TileMaker : MonoBehaviour
{
    //[SerializeField] int width = 12;
    //[SerializeField] int height = 8;
    [SerializeField] public Vector2Int worldSize = new Vector2Int(12, 8);
    [SerializeField] public int tileSize = 10;
    [SerializeField] Tile tile;

    GameObject world;

    void Start()
    {
        // MakeTiles(); // currently not used in play mode
    }

    void MakeTiles()
    {
        world = GameObject.Find("World");

        for (int i = 0; i < worldSize.x; i++)
        {
            for (int j = 0; j < worldSize.y; j++)
            {
                var spawnedTile = Instantiate(tile, new Vector3(i * tileSize, 0, j * tileSize), Quaternion.identity);
                spawnedTile.name = $"{i},{j}";
                spawnedTile.transform.parent = world.transform;
            }
        }
    }
}
