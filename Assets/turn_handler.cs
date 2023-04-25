using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turn_handler : MonoBehaviour
{
    string currTurn;
    // Start is called before the first frame update
    void Start()
    {
        currTurn = "player1";
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool isTurn(string turn)
    {
        return currTurn == turn;
    }
    public void nextTurn()
    {
        if (currTurn == "player1") currTurn = "player2";
        else currTurn = "player1";
    }
    public string getTurn() { return currTurn; }


}
