using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{

    Rect ScorePosition;
    public int CurrentScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        ScorePosition = new Rect(Screen.width - 100, 30, 100, 30);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnGUI()
    {
        GUI.Label(ScorePosition, CurrentScore.ToString());
    }
}
