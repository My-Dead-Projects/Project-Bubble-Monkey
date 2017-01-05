using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardController : MonoBehaviour {

	public GameObject boardObject;
	public GameObject tilePrefab;
	public int width, height;
	// The board controller owns a bunch of tile controllers.
	// They have to be set up by the editor script which instantiates them
	public TileController[,] tileControllers;

}
