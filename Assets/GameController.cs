﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameController : MonoBehaviour {

	public static GameController Instance;

	public float elapsedWorldTime = 0.00F;
	public float timeConstant = 0.001F;
	public float worldSpeed = 0F;
	//public float deltaWorldTime;

	private List<CharacterSheetAlpha> activeCharacters;

	void Awake()
	{
		Instance = this;
	}

	// Use this for initialization
	void Start () {
		activeCharacters = new List<CharacterSheetAlpha>(GameObject.Find ("CharacterContainer").GetComponentsInChildren<CharacterSheetAlpha>());
	}
	
	// Update is called once per frame
	void Update () {
	
		elapsedWorldTime += timeConstant * worldSpeed;

		foreach(CharacterSheetAlpha character in activeCharacters)
		{

		}

	}

	void LateUpdate()
	{
	}
}
