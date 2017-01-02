using UnityEditor;
using UnityEngine;

public class Tools {

	public static int world_width;
	public static int world_height;
	public static Sprite sprite;

	[MenuItem("Tools/CreateTileBoard")]
	static void Create() {
		for (int x = 0; x < world_width; x++) {
			for (int y = 0; y < world_height; y++) {
				GameObject tile_object = new GameObject ();
				tile_object.name = "Tile_" + x + "_" + y;
				tile_object.transform.position = new Vector3 (x, y, 0);
				SpriteRenderer tile_sprite = tile_object.AddComponent<SpriteRenderer> ();
				tile_sprite.sprite = sprite;
			}
		}
	}
}
