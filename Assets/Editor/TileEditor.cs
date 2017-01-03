using System.Collections;
using System.Collections.Generic;
using UnityEditor;

[CustomEditor(typeof(Tile))]
public class TileEditor : Editor {

	public override void OnInspectorGUI() {
		Tile tile = (Tile)target;

		EditorGUILayout.IntField (tile.x);
		EditorGUILayout.IntField (tile.y);
	}
}
