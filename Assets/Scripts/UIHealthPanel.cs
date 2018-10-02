using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHealthPanel : MonoBehaviour
{
   
    public static int maxLives = 3;
    [SerializeField] Image[] hearts = new Image[maxLives];


	public void SetLives (int maxLives, int lives)
	{
		UpdateHearts (lives);
	}

	/// <summary>
	/// Updates the text simply by setting it to the number of lives.
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
