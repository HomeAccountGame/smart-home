using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class info : MonoBehaviour
{
    private int pos;
    private bool turn;
    [SerializeField] private string player_name;
    private float money;
    private SpriteRenderer[] boardRenderers;
    GameObject pl;
    [SerializeField] private card_handler hand;
    // Start is called before the first frame update
    void Start()
    {
        boardRenderers = new SpriteRenderer[22];
        pl = GameObject.Find(player_name);
        for (int i = 0; i < 22; i++)
        {
            string curr = "board" + i;
            boardRenderers[i] = GameObject.Find("board" + i).GetComponent<SpriteRenderer>();
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public int getPos() { return pos; }
    public void setPos(int pos) {
        this.pos = pos;
        Debug.Log("board in " + boardRenderers[pos] + " pos is " + pos);
        pl.transform.position =new Vector3(boardRenderers[pos].transform.position.x, boardRenderers[pos].transform.position.y, pl.transform.position.z);
        hand.playCard(pos);
        
    }
}
