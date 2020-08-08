using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PensionEvent : MonoBehaviour
{
    public GameObject Player;

    public GameObject PensionObj;


    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject == Player) {
            if (Input.GetKey(KeyCode.Z))
            {
                PensionObj.SetActive(true);
            } 
        }
    }
}
