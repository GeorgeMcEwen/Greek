using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FootstepsAudio : MonoBehaviour
{
    public GameObject objectToActivateAndDeactivate;

    void Update()
    {
       //For W
        if (Input.GetKeyDown(KeyCode.W))
        {
            objectToActivateAndDeactivate.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            objectToActivateAndDeactivate.SetActive(false);
        }

        //For A
        if (Input.GetKeyDown(KeyCode.A))
        {
            objectToActivateAndDeactivate.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            objectToActivateAndDeactivate.SetActive(false);
        }

        //For S
        if (Input.GetKeyDown(KeyCode.S))
        {
            objectToActivateAndDeactivate.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            objectToActivateAndDeactivate.SetActive(false);
        }

        //For D
        if (Input.GetKeyDown(KeyCode.D))
        {
            objectToActivateAndDeactivate.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            objectToActivateAndDeactivate.SetActive(false);
        }
    }
}