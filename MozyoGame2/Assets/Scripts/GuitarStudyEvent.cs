using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GuitarStudyEvent : MonoBehaviour
{
    public GameObject Player;

    public GameObject GuitarStudyObj;


    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject == Player) {
            if (Input.GetKey(KeyCode.Z))
            {
                GuitarStudyObj.SetActive(true);
            } 
        }
    }
}
