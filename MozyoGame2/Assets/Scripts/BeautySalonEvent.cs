using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BeautySalonEvent : MonoBehaviour
{
    public GameObject Player;

    public GameObject BeautySalonObj;


    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject == Player) {
            if (Input.GetKey(KeyCode.Z))
            {
                BeautySalonObj.SetActive(true);
            } 
        }
    }
}
