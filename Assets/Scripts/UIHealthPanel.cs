﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHealthPanel : MonoBehaviour
{

	[SerializeField] Image[] hearts;


	public void SetLives (int maxLives, int lives)
	{
		UpdateHearts (lives);
	}

	/// <summary>
	/// Updates the text simply by setting it to the number of lives.
	/// </summary>
	/// <param name="lives">Lives.</param>

	/// <summary>
	/// Updates the hearts by modifying its image component depending of the number of lives.
	/// </summary>
	/// <param name="lives">Lives.</param>
	void UpdateHearts(int lives){
		for (int i = 0; i < hearts.Length; i++) 
		{
			if (i < lives) {
				hearts [i].enabled = true;
			} else {
				hearts [i].enabled = false;
			}
		}
	}

}