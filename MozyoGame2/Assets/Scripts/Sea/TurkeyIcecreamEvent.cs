using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TurkeyIcecreamEvent : MonoBehaviour
{
    public GameObject Player;

    public GameObject TurkeyIcecreamObj;


    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject == Player) {
            if (Input.GetKey(KeyCode.Z))
            {
                TurkeyIcecreamObj.SetActive(true);
            } 
        }
    }
}
