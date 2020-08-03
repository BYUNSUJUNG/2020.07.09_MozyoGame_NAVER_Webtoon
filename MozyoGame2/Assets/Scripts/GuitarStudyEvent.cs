using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GuitarStudyEvent : MonoBehaviour
{
    public GameObject Player;

     void OnTriggerEnter2D(Collider2D collision)
        {
            Debug.Log("충돌1");
        }
    void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("충돌");
        if (collision.gameObject == Player) {
            if (Input.GetKey(KeyCode.Z))
            {
                SceneManager.LoadScene("GuitarStudyScene");
            } 
        }
    }
}
