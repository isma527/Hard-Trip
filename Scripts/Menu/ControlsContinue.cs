﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlsContinue : MonoBehaviour
{

	// Update is called once per frame
	void Update ()
    {

        if (Input.GetKeyDown(KeyCode.E))
            SceneManager.LoadScene("Alpha");
            
	}
}
