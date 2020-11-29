using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//게임스타트화면 
public class StartMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnGUI()
    {
        if (GUI.Button(new Rect(0, 0, 100, 30), "GameStart"))
        {
            SceneManager.LoadScene("MainScene");
        }
    }
}
