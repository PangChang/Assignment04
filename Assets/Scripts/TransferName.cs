using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TransferName : MonoBehaviour
{
    public Text Name;
    public static string PlayerName;


    // Start is called before the first frame update
    void Start()
    {
        Name.text = DataManager.PlayerName.ToString();
        Debug.Log(PlayerName);
    }

    // Update is called once per frame
    void Update()
    {

    }

}
