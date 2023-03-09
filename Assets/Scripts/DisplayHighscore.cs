using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class DisplayHighscore : MonoBehaviour
{

    public static int MaxPinCount;
    public Text HighScoreText;

    // Start is called before the first frame update
    void Start()
    {
        HighScoreText.text = Score.MaxPointCount.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
