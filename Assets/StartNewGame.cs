﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartNewGame : MonoBehaviour {

    public static void LoadNewLevel(int levelNum){
        SceneManager.LoadScene(levelNum);
    }
}
