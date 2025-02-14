﻿using UnityEngine;

public class SymbolsKeyBehaviour : MonoBehaviour
{
	public ShiftKeyBehaviour ShiftBehaviour;

	private Key symbolKeyController; 
	public GameObject[] keys;
	private Key[] keyControllers;
	private bool symbolToggle = true;

	void Start()
	{
		Key.keyPressed += SpecialKeyPressed;

		symbolKeyController = GetComponent<Key>();
		//keys = GameObject.FindGameObjectsWithTag ("Key");
		keyControllers = new Key[keys.Length];
		for (int i = 0; i < keys.Length; i++)
		{
			keyControllers [i] = keys [i].GetComponent<Key> ();
		}
	}

	void SpecialKeyPressed()
	{
		if (symbolKeyController.KeyPressed)
		{
			for (int i = 0; i < keyControllers.Length; i++)
			{
				keyControllers [i].SwitchToSymbols ();
			}
			if (symbolToggle)
			{
				ShiftBehaviour.ShiftVisibilityToggle (false);
				symbolKeyController.KeycapColor = symbolKeyController.PressedKeycapColor;
				symbolToggle = false;
			}
			else if (!symbolToggle)
			{
				ShiftBehaviour.ShiftVisibilityToggle (true);
				symbolKeyController.KeycapColor = symbolKeyController.InitialKeycapColor;
				symbolToggle = true;
			}
		}
	}

	void OnDisable()
	{
		Key.keyPressed -= SpecialKeyPressed;
	}
}
