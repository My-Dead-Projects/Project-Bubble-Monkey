using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldController : MonoBehaviour {

	World world;
	public int world_width;
	public int world_height;
	public Sprite sprite;

	// Use this for initialization
	void Start () {
		world = new World (world_width, world_height);

		for (int x = 0; x < world.Width; x++) {
			for (int y = 0; y < world.Height; y++) {
				Tile tile = world.GetTileAt (x, y);
				GameObject tile_object = new GameObject ();
				tile_object.name = "Tile_" + x + "_" + y;
				tile_object.transform.position = new Vector3 (tile.X, tile.Y, 0);
				SpriteRenderer tile_sprite = tile_object.AddComponent<SpriteRenderer> ();
				tile_sprite.sprite = sprite;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
