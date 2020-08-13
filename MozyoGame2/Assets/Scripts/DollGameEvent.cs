using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DollGameEvent : MonoBehaviour
{
    public GameObject Player;

    public GameObject DollGameObj;


    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject == Player) {
            if (Input.GetKey(KeyCode.Z))
            {
                DollGameObj.SetActive(true);
            } 
        }
    }
}
