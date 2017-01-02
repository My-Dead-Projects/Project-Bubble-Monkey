using UnityEngine;
using System.Collections;

public class World {

	Tile[,] tiles;
	int width;
	public int Width {
		get {
			return width;
		}
	}
	int height;
	public int Height {
		get {
			return height;
		}
	}

	public World(int width, int height) {
		this.width = width;
		this.height = height;
		tiles = new Tile[width, height];
		for (int x = 0; x < width; x++) {
			for (int y = 0; y < height; y++) {
				tiles [x, y] = new Tile (this, x, y);
			}
		}

		Debug.Log ("World created");
	}

	public Tile GetTileAt(int x, int y) {
		return tiles [x, y];
	}
}
