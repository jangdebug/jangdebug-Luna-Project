using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//몬스터스킯트
public class MobScript : MonoBehaviour
{
    public int Score; //게임점수
    public int HP; //총알을 몇발맞으면 죽는지
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Bullet")
        {
            HP--;
            if (HP == 0)
            {
                //체력이 0이되면 스코어오르고 몹파괴
                Camera.main.GetComponent<UserInterFace>().CurrentScore += Score;
                Destroy(gameObject); //
            }
        }
    }
}
