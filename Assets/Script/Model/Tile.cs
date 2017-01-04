using System.Collections;
using UnityEngine;

public class Tile : MonoBehaviour {

	public int x;
	public int y;

	public enum Type {
		Blank,
		Portal
	}

	// Represents the type of tile this is
	public Type type;
}
