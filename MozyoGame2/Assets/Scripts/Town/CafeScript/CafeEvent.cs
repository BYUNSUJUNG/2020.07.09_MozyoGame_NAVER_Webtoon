using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CafeEvent : MonoBehaviour
{
    public GameObject Player;

    public GameObject CafeObj;


    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject == Player) {
            if (Input.GetKey(KeyCode.Z))
            {
                CafeObj.SetActive(true);
            } 
        }
    }
}
