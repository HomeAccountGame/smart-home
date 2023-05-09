using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(TextMeshPro))]
public class updat_money : MonoBehaviour
{
    // Start is called before the first frame update
    float money;
    // Start is called before the first frame update
    void Start()
    {
        money = 100000.0f;
        GetComponent<TextMeshPro>().text = money.ToString();

    }
    public void SetNumber(float newNumber)
    {
        this.money = newNumber;

        GetComponent<TextMeshPro>().text = Mathf.Round(money).ToString();
    }
    public float GetMoney() { return money; }
}
