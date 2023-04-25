using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rollTheDice : MonoBehaviour
{
    GameObject dice1;
    GameObject dice2;
    GameObject mange;
    GameObject sts;
    Roll dice1_roll;
    Roll dice2_roll;
    turn_handler handler;
    private int steps = 0;
    string currTurn = "player1";

    // Start is called before the first frame update
    void Start()
    {
        dice1 = GameObject.Find("dice1");
        dice2 = GameObject.Find("dice2");
        mange = GameObject.Find("managment");
        dice1_roll = dice1.GetComponent<Roll>();
        dice2_roll = dice2.GetComponent<Roll>();
        handler = mange.GetComponent<turn_handler>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnMouseDown()
    {
        Debug.Log("click");
        currTurn =handler.getTurn();
        StartCoroutine(move());
    }

    IEnumerator move()
    {
        dice1_roll.StartCoroutine("RollTheDice");
        yield return dice2_roll.StartCoroutine("RollTheDice");
        steps = dice1_roll.getVal() + dice2_roll.getVal();


        sts = GameObject.Find("steps");
        steps st = sts.GetComponent<steps>();
        st.moveplayer();
        handler.nextTurn();
    }

    public int getSteps() { return steps; }
    public string getCurrTurn() { return currTurn; }

    


}
