using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Tile))]
public class TileEditor : Editor {

	enum Type {
		Blank,
		Portal
	}

	// Represents the type of tile this is
	Type type;

	public override void OnInspectorGUI() {
		Tile tile = (Tile)target;

		// Create a dropdown list of tile types
		type = (Type)EditorGUILayout.EnumPopup ("Type", type);

		switch (type) {
		case Type.Blank:
			tile.GetComponent<Renderer> ().material = Resources.Load ("Materials/Blank Tile", typeof(Material)) as Material;
			break;
		case Type.Portal:
			tile.GetComponent<Renderer> ().material = Resources.Load("Materials/Portal Tile", typeof(Material)) as Material;
			break;
		}
	}
}
