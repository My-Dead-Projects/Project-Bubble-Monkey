using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileCreator : MonoBehaviour {

	public int height;
	public int width;
	public GameObject tilePrefab;

	public void createBoard() {
		// Create an empty game object which will act as a container for all of the tiles
		GameObject board = new GameObject ();
		// Set the name of the parent object to Board
		board.name = "Board";
		for (int x = 0; x < width; x++) {
			for (int y = 0; y < height; y++) {
				// Create the tile from the Tile prefab
				GameObject tile_object = Instantiate (tilePrefab);
				// Set the tile's parent as Board
				tile_object.transform.parent = board.transform;
				// Set the physical position in the world
				tile_object.transform.position = new Vector3(x, 0, y);
				// Get the tile's script object
				Tile tile = tile_object.GetComponent<Tile> ();
				// Set the tile's logical position (on its script)
				tile.x = x;
				tile.y = y;
				// Set the Tile's name in the editor
				tile_object.name = "Tile";
			}
		}
	}
}
