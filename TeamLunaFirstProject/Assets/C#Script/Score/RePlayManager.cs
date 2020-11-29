using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
        
//미션종료창에서 다시하기
public class RePlayManager: MonoBehaviour
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
        if (GUI.Button(new Rect(0, 0, 100, 30), "RePlay"))
        { 
            SceneManager.LoadScene("MainScene");
        }
    }
}
