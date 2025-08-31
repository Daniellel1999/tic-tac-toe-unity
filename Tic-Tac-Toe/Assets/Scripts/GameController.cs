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
    public int[] markedSpaces; //counts the number of spaces marked




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameSetup();
    }

    void GameSetup()
    {
        whoturn = 0;
        turnCount = 0;
        turnIcons[0].SetActive(true);
        turnIcons[1].SetActive(false);
        for (int i = 0; i < tictactoeSpaces.Length; i++)
        {
            tictactoeSpaces[i].interactable = true;
            tictactoeSpaces[i].GetComponent<Image>().sprite = null;
        }
        for (int i = 0; i < markedSpaces.Length; i++)
        {
            markedSpaces[i] = -100;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void TicTacToeButton(int whichNumber)
    {
        tictactoeSpaces[whichNumber].image.sprite = playIcons[whoturn];
        tictactoeSpaces[whichNumber].interactable = false;

        markedSpaces[whichNumber] = whoturn + 1;
        turnCount++;

        if (turnCount >= 5)
        {
            CheckWinCondition();
        }
        if (whoturn == 0)
        {
            whoturn = 1;
            turnIcons[0].SetActive(false);
            turnIcons[1].SetActive(true);
        }
        else
        {
            whoturn = 0;
            turnIcons[0].SetActive(true);
            turnIcons[1].SetActive(false);
        }

    }
    void CheckWinCondition()
    {
        int s1 = markedSpaces[0] + markedSpaces[1] + markedSpaces[2];
        int s2 = markedSpaces[3] + markedSpaces[4] + markedSpaces[5];
        int s3 = markedSpaces[6] + markedSpaces[7] + markedSpaces[8];
        int s4 = markedSpaces[0] + markedSpaces[3] + markedSpaces[6];
        int s5 = markedSpaces[1] + markedSpaces[4] + markedSpaces[7];
        int s6 = markedSpaces[2] + markedSpaces[5] + markedSpaces[8];
        int s7 = markedSpaces[0] + markedSpaces[4] + markedSpaces[8];
        int s8 = markedSpaces[2] + markedSpaces[4] + markedSpaces[6];
        var solutions = new int[] { s1, s2, s3, s4, s5, s6, s7, s8 };
        for (int i = 0; i < solutions.Length; i++)
        {
            if (solutions[i]== 3*(whoturn+1))
            {
                Debug.Log("Player " + (whoturn + 1) + " wins!");
                return;
            }
            else if (turnCount >= 9)
            {
                Debug.Log("It's a draw!");
                return;
            }
        }
    }      
    
}
