using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public static int MaxPointCount = 0;
    public static int CurrentScore = 0;

    public Text scoreText;
    public Text MaxScore;



void Start()
    {
        MaxScore.text = MaxPointCount.ToString();
    }

    void Update()
    {
        scoreText.text = CurrentScore.ToString();
        if (MaxPointCount < CurrentScore)
        {
            MaxPointCount = CurrentScore;
            Debug.Log(MaxPointCount);
        }
        MaxScore.text = MaxPointCount.ToString();
    }

}

