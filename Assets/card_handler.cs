using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class card_handler : MonoBehaviour
{
    [SerializeField] setTask text;
    [SerializeField] move moveYes;
    [SerializeField] move moveNo;
    private SpriteRenderer[] boardRenderers;
    GameObject pressY;
    GameObject pressN;

    // Start is called before the first frame update
    void Start()
    {
        boardRenderers = new SpriteRenderer[22];
        for (int i = 0; i < 22; i++)
        {
            string curr = "board" + i;
            boardRenderers[i] = GameObject.Find("board" + i).GetComponent<SpriteRenderer>();
        }
        pressN = GameObject.Find("pressNo");
        pressY = GameObject.Find("pressYes");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void playCard(int pos)
    {
        if(pos == 7 || pos == 13 || pos == 18)
        {

            text.setText("do you want get new job from home?");
            moveNo.moveInNo();
            moveYes.moveInYes();
        }
    }
    public void press(string name)
    {
        if (name == "Yes")
        {
            text.setText("you choose yes! you lost 200$");
        }
        else if (name == "No")
        {
            text.setText("you choose NO! you get 200$");
        }
        moveNo.moveOut();
        moveYes.moveOut();
        StartCoroutine(wait());
    }

    IEnumerator wait()
    {

        yield return new WaitForSeconds(2f);
        text.setText("");

    }
}
