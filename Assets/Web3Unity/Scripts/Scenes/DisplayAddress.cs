using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class DisplayAddress : MonoBehaviour
{
    //public WalletLogin wl;
    public TextMeshProUGUI WalletAddress;

    //GH = FindObjectOfType<GameHandler>();

    /*public void Start()
    {
        wl = FindObjectOfType<WalletLogin>();
        //wl.account = "0";
       

    }*/
    //debug.log(WalletAddress);

    

    private void Update()
    {
        WalletAddress.text = "" + PlayerPrefs.GetString("Account");

    }
}
