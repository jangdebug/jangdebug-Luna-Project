using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserInterFace : MonoBehaviour
{
    //게임점수
    Rect ScorePosition;
    Rect TimePosition;
    public int CurrentScore = 0;
    public Slider HealthBar;
    public float Dammage;
    public float time = 0;

    // Start is called before the first frame update
    void Start()
    {
        ScorePosition = new Rect(Screen.width - 100, 30, 100, 30);
        TimePosition = new Rect(53, 41, 100, 30);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (Input.GetKey(KeyCode.H))
            HealthBar.value -= Dammage;
    }

    private void OnGUI()
    {
        GUI.Label(ScorePosition, CurrentScore.ToString());
        GUI.Label(TimePosition, time.ToString());
    }
}
