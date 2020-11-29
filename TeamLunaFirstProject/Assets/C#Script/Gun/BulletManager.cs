using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManager : MonoBehaviour
{
    public Rigidbody Bullet;
    public float BulletSpeed;
    public AudioClip BulletAudioClip;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Rigidbody cb = (Rigidbody)Instantiate(Bullet, transform.position, transform.rotation);
            cb.velocity = transform.TransformDirection(new Vector3(0, 0, BulletSpeed));
            AudioSource.PlayClipAtPoint(BulletAudioClip, transform.position);
        }
    }
}
