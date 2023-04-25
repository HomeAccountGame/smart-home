using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class steps : MonoBehaviour
{
    private int step;
    private string player;
    private int currentPos;
    GameObject Dice;
    rollTheDice dices;
    int totalBoard = 22;

    // Start is called before the first frame update
    void Start()
    {
        Dice = GameObject.Find("Dice");
        dices = Dice.GetComponent<rollTheDice>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setTurn(string turn)
    {
        player = turn;
    }
    public void moveplayer()
    {
        GameObject Pla = GameObject.Find(dices.getCurrTurn());
        info status = Pla.GetComponent<info>();
        int pos = status.getPos();
        step = dices.getSteps();
        for(int i = 0; i < step;i++)
        {
            pos += 1;
            pos = pos % totalBoard;
        }
        status.setPos(pos);

    }
}
