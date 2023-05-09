using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class StartGame : MonoBehaviour
{
    [SerializeField] string scene;
    [SerializeField] public TMP_InputField inputField1;
    [SerializeField] public TMP_InputField inputField2;
    private void OnMouseDown()
    {
        string myString = inputField1.text +","+ inputField2.text ;
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
        PlayerPrefs.SetString("myString", myString);
    }
}
