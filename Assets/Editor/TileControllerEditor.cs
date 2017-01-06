using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(TileController))]
public class TileControllerEditor : Editor
{
	TileController tc;
	public override void OnInspectorGUI()
	{
		tc = (TileController)target;
		serializedObject.Update();
		DrawPropertiesExcluding(serializedObject, new string[]{"m_Script"});
		serializedObject.ApplyModifiedProperties();

		// Provide a dropdown for tileType
		tc.tileType = (Tile.TileType)EditorGUILayout.EnumPopup("Tile Type", tc.tile.type);
	}
}
