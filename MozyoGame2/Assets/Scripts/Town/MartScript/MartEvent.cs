using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MartEvent : MonoBehaviour
{
    public GameObject Player;

    public GameObject MartObj;


    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject == Player) {
            if (Input.GetKey(KeyCode.Z))
            {
                MartObj.SetActive(true);
            } 
        }
    }
}
