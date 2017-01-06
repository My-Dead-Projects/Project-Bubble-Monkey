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
				// Get tileObject's controller and give it a reference to tileObject
				TileController tileController = tileObject.GetComponent<TileController>();
				tileController.tileObject = tileObject;
				// The init method is necessary because we can't construct MonoBehaviors
				tileController.Init();
				// Add tileObject's controller to the 2D array of tile controllers
				bc.tileControllers[x, y] = tileController;
			}
		}
	}
}
