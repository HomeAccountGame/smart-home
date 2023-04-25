using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    private Renderer renderer;
    [SerializeField] string name;
    [SerializeField] card_handler hand;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void moveInYes()
    {
        renderer.enabled = !renderer.enabled;
    }
    public void moveOut()
    {
        renderer.enabled = !renderer.enabled;
    }
    public void moveInNo()
    {
        renderer.enabled = !renderer.enabled;
    }
    private void OnMouseDown()
    {
        Debug.Log("click" + name);
        hand.press(name);
        //if(GameObject.name)
    }
}
