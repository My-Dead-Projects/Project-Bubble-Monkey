using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
	
	BoardController boardController;

	public GameObject boardObject;

	void Start()
	{
		// Get the board controller, which will be instantiated for us
		boardController = boardObject.GetComponent<BoardController>();
	}
}
