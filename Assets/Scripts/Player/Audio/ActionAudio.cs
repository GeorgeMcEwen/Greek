using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionAudio : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip1;
    public AudioClip clip2;
    public AudioClip clip3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            source.PlayOneShot(clip1);
        }

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            source.PlayOneShot(clip2);
        }

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            source.PlayOneShot(clip3);
        }
    }
}
