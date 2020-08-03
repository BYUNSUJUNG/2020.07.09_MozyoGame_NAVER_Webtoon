using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClothingStoreEvent : MonoBehaviour
{
    public GameObject Player;

    public GameObject ClothingStoreObj;


    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject == Player) {
            if (Input.GetKey(KeyCode.Z))
            {
                ClothingStoreObj.SetActive(true);
            } 
        }
    }
}
