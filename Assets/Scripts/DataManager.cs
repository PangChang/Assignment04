using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataManager : MonoBehaviour
{
    public static float spawnDelay = 0.3f;
    public Slider SpawnDelaySlider;
    public Text ShowSpawnSpeed;

    public static float CarSpeed = 1f;
    public Slider CarSpeedSlider;
    public Text ShowCarSpeed;


    public static string PlayerName;
    public InputField PlayerNameInput;
    public Text showPlayerName;


    void Awake()
    {
        DontDestroyOnLoad(this.gameObject); // don't destroy this game object when a new scene is loaded.
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UpdateName()
    {
        PlayerName = PlayerNameInput.text;
        Debug.Log(PlayerName);
        showPlayerName.text = PlayerName;
        
    }
    public void ShowName()
    {
        showPlayerName.text = PlayerName;
        Debug.Log(PlayerName);
    }


    public void AdjustSpeed()
    {
        CarSpeed = CarSpeedSlider.value;
        ShowCarSpeed.text = "Car Speed is: " + CarSpeed.ToString();

        spawnDelay = SpawnDelaySlider.value;
        ShowSpawnSpeed.text = "Spawn speed is: " + spawnDelay.ToString();

    }

}
