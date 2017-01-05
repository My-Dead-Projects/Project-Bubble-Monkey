using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(BoardController))]
public class BoardControllerEditor : Editor
{
	// The BoardController script we are inspecting
	BoardController bc;

	public override void OnInspectorGUI ()
	{
		// Cast the target to the appropriate type so we can access its fields
		bc = (BoardController)target;

		DrawDefaultInspector();

		// Create a button which will generate a new set of tiles
		if (GUILayout.Button("Generate Board")) {
			GenerateBoard();
		}
	}

	void GenerateBoard()
	{
		bc.tileControllers = new TileController[bc.width, bc.height];

		for (int x = 0; x < bc.width; x++) {
			for (int y = 0; y < bc.height; y++) {
				// Instantiate a new tile from the prefab stored in the boardController
				GameObject tileObject = Instantiate(bc.tilePrefab);
				// Set the board as the tile's parent
				tileObject.transform.parent = bc.boardObject.transform;
				// Set the tile's position
				tileObject.transform.position = new Vector3(x, 0, y);
				// Set the tile's name
				tileObject.name = "Tile";
				// Create a new TileController, passing it the instantiated tile
				bc.tileControllers[x, y] = new TileController(tileObject);
			}
		}
	}
}
