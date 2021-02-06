using System;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// LividPhysics Feb 05 2020

public class CardParser : MonoBehaviour
{
    public RawImage card;
    public int atk, def;
    string walterText = System.IO.File.ReadAllText("Assets/walter.json");
    Card walter = new Card();
    // Start is called before the first frame update
    void Start()
    {   

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(walter.name);
    }
}

[Serializable]
class Card {
    public string name { get; set; }
    public string path { get; set; }
    public int atk { get; set; }
    public int def { get; set; }
    public int team { get; set; }
    public int place { get; set; }

    public Card() {

    }

    public void LoadJsonToSelf(string jsoninput) {
        JsonUtility.FromJson<Card>(jsoninput);
    }
}
