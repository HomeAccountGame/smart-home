using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class split_money : MonoBehaviour
{
    //[SerializeField] public InputField number1Field;
    //[SerializeField] public InputField number2Field;
    //[SerializeField] public InputField number3Field;
    [SerializeField] public Canvas canvasToEnable;
    [SerializeField] public TMP_InputField inputField1;
    [SerializeField] public TMP_InputField inputField2;
    [SerializeField] public TMP_InputField inputField3;

    [SerializeField] updat_money moneyField;


    // Start is called before the first frame update
    private void OnMouseDown()
    {
        canvasToEnable.enabled = true;
        inputField3.text = moneyField.GetMoney().ToString();
    }

    public void sumbit()
    {
        canvasToEnable.enabled = false;
        string inputText1 = inputField1.text;
        string inputText2 = inputField2.text;
        string inputText3 = inputField3.text;

        moneyField.SetNumber(moneyField.GetMoney()-(float.Parse(inputText1)+ float.Parse(inputText1)));
        Debug.Log(inputText1);
        Debug.Log(inputText2);
        Debug.Log(inputText3);

    }
}
