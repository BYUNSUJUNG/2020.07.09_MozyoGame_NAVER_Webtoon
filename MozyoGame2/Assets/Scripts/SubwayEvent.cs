using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SubwayEvent : MonoBehaviour
{
    public GameObject Player;

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject == Player) {
            if (Input.GetKey(KeyCode.Z))
            {
                if(SceneManager.GetActiveScene().name == "SeaScene") {
                    Debug.Log("타운 이동");
		            SceneManager.LoadScene("TownScene");
                } else if(SceneManager.GetActiveScene().name == "TownScene") {
                    Debug.Log("바다 이동");
		            SceneManager.LoadScene("SeaScene");
                }
               
            } 
        }
    }
}