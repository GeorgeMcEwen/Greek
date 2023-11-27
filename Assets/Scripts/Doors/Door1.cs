using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Door1 : MonoBehaviour
{
    public GameObject Door;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag== "")
        {
            Door.SetActive(false);
            Debug.Log("Yes");
        }
    }
}