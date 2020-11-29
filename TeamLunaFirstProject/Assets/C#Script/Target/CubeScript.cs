using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    public int Score;
    public int HP;
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
                Camera.main.GetComponent<Score>().CurrentScore += Score;
                Destroy(gameObject);
            }
        }
    }
}
