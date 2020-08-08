using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PicnicEvent : MonoBehaviour
{
    public GameObject Player;

    public GameObject PicnicObj;


    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject == Player) {
            if (Input.GetKey(KeyCode.Z))
            {
                PicnicObj.SetActive(true);
            } 
        }
    }
}
