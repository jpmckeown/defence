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
        label.enabled = false; // default is to not show coordinates label 
        DisplayCoordinates();
    }

    void Update()
    {
        if (!Application.isPlaying)
        {
            DisplayCoordinates();
            UpdateObjectName();
            label.enabled = true; // show while editing
        }
    }

    void DisplayCoordinates()
    {
        if (tileMaker == null) { return; }

        coordinates.x = Mathf.RoundToInt(transform.parent.position.x / tileMaker.tileSize);
        coordinates.y = Mathf.RoundToInt(transform.parent.position.z / tileMaker.tileSize);

        label.text = coordinates.x + "," + coordinates.y;
    }

    void UpdateObjectName()
    {
        transform.parent.name = coordinates.ToString();
    }
}
