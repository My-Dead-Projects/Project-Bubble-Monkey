using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileController : MonoBehaviour
{
	// The View component of a Tile
	public GameObject tileObject;
	// The Model component of a Tile
	public Tile tile;

	public Tile.TileType tileType {
		get {
			return tile.type;
		}
		set {
			tile.type = value;
		}
	}

	public void Init()
	{
		tile = new Tile();
	}
}
