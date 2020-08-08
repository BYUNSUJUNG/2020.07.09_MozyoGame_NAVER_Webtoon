using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeEvent : MonoBehaviour
{
    public GameObject Player;

    public GameObject HomeObj;


    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject == Player) {
            if (Input.GetKey(KeyCode.Z))
            {
                HomeObj.SetActive(true);
            } 
        }
    }
}
