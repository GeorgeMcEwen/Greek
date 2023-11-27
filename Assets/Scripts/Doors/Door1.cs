using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Door1 : MonoBehaviour
{
    public GameObject Door;
    private void OnCollisionStay(Collision other)
    {
        if (other.gameObject.CompareTag("Door"))
        {
            Door.SetActive(false);
            Destroy(Door);
        }
    }
}
