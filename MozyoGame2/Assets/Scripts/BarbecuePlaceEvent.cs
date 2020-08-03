using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BarbecuePlaceEvent : MonoBehaviour
{
    public GameObject Player;

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject == Player) {
            if (Input.GetKey(KeyCode.Z))
            {
                SceneManager.LoadScene("BarbecuePlaceGameScene");
            } 
        }
    }
}
