using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PianoStudyEvent : MonoBehaviour
{
    public GameObject Player;

    public GameObject PianoStudyObj;


    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject == Player) {
            if (Input.GetKey(KeyCode.Z))
            {
                PianoStudyObj.SetActive(true);
            } 
        }
    }
}
