using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HospitalEvent : MonoBehaviour
{
    public GameObject Player;

    public GameObject HospitalObj;


    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject == Player) {
            if (Input.GetKey(KeyCode.Z))
            {
                HospitalObj.SetActive(true);
            } 
        }
    }
}
