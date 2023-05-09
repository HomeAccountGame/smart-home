using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SelectGameOption : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] string scene;
    void OnEnable()
    {
        SceneManager.LoadScene(scene);
    }

    
}
