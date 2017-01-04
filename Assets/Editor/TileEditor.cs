using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Tile))]
public class TileEditor : Editor {

	public override void OnInspectorGUI() {
		Tile tile = (Tile)target;

		tile.x = EditorGUILayout.IntField ("X", tile.x);
		tile.y = EditorGUILayout.IntField ("Y", tile.y);

		// Create a dropdown list of tile types
		tile.type = (Tile.Type)EditorGUILayout.EnumPopup ("Type", tile.type);

		switch (tile.type) {
		case Tile.Type.Blank:
			tile.GetComponent<Renderer> ().material = Resources.Load ("Materials/Blank Tile", typeof(Material)) as Material;
			break;
		case Tile.Type.Portal:
			tile.GetComponent<Renderer> ().material = Resources.Load("Materials/Portal Tile", typeof(Material)) as Material;
			break;
		}
	}
}
