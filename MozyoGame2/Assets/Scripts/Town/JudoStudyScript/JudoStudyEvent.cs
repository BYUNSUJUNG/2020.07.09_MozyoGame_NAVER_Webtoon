using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JudoStudyEvent : MonoBehaviour
{
    public GameObject Player;

    public GameObject JudoStudyObj;


    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject == Player) {
            if (Input.GetKey(KeyCode.Z))
            {
                JudoStudyObj.SetActive(true);
            } 
        }
    }
}
