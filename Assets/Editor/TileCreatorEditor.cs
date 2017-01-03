using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(TileCreator))]
public class TileCreatorEditor : Editor {

	public override void OnInspectorGUI() {
		TileCreator tileCreator = (TileCreator)target;

		DrawDefaultInspector ();

		if (GUILayout.Button ("Create Board")) {
			tileCreator.createBoard ();
		}
	}
}
