using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LibraryEvent : MonoBehaviour
{
    public GameObject Player;

    public GameObject LibraryObj;


    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject == Player) {
            if (Input.GetKey(KeyCode.Z))
            {
                LibraryObj.SetActive(true);
            } 
        }
    }
}
