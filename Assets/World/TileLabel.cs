using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[ExecuteAlways]
[RequireComponent(typeof(TextMeshPro))]
public class TileLabel : MonoBehaviour
{
    TextMeshPro label;
    Vector2Int coordinates = new Vector2Int();
    TileMaker tileMaker;

    void Awake()
    {
        tileMaker = FindObjectOfType<TileMaker>();
        label = GetComponent<TextMeshPro>();
        label.enabled = false;
        DisplayCoordinates();
    }

    void Update()
    {
        if (!Application.isPlaying)
        {
            DisplayCoordinates();
            UpdateObjectName();
            label.enabled = true;
        }
    }

    void DisplayCoordinates()
    {
        // if (tileMaker == null) { return; }

        coordinates.x = Mathf.RoundToInt(transform.parent.position.x / tileMaker.cellSize);
        coordinates.y = Mathf.RoundToInt(transform.parent.position.z / tileMaker.cellSize);

        label.text = "--,--"; // coordinates.x + "," + coordinates.y; //
    }

    void UpdateObjectName()
    {
        // transform.parent.name = "Tile";
    }
}
