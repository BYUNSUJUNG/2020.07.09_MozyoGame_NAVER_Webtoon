using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LibraryEvent : MonoBehaviour
{
    public GameObject Player;

    void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("충돌");
        if (collision.gameObject == Player) {
            if (Input.GetKey(KeyCode.Z))
            {
                SceneManager.LoadScene("LibraryScene");
            } 
        }
    }
}
