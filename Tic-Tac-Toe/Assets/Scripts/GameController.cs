using UnityEngine.UI;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class GameController : MonoBehaviour
{

    public int whoturn; //0 -> x, 1 -> 0
    public int turnCount; //counts the number of turns played
    public GameObject[] turnIcons; //displays whos turn it is
    public Sprite[] playIcons; //0 -> x's icon, 1 -> 0's icon
    public Button[] tictactoeSpaces; //playable space for our game
    public Button []  


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    void GameSetup()
    {
        whoturn = 0;
        turnCount = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
