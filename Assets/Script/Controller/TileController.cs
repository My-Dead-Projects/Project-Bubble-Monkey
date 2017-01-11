using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileController : MonoBehaviour
{
	// The View component of a Tile
	public GameObject tileObject;
	// The Model component of a Tile
	public Tile tile = new Tile();

	public Tile.TileType tileType {
		get {
			return tile.type;
		}
		set {
			tile.type = value;
			// Set the texture of the tile to reflect the change
			switch (tile.type) {
			case Tile.TileType.Blank:
				{
					Renderer renderer = tileObject.GetComponent<Renderer>();
					Material mat = new Material(renderer.sharedMaterial);
					mat.color = Color.gray;
					renderer.sharedMaterial = mat;
				}
				break;
			case Tile.TileType.Portal:
				{
					Renderer renderer = tileObject.GetComponent<Renderer>();
					Material mat = new Material(renderer.sharedMaterial);
					mat.color = Color.blue;
					renderer.sharedMaterial = mat;
				}
				break;
			}
		}
	}
}
