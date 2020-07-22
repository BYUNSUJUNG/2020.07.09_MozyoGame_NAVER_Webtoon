using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreImageChange : MonoBehaviour
{
    public GameObject[] obj = new GameObject[4];

    void Start()
    {
        
    }


    void Update()
    {
        
    }

    public void HairStore() {
        obj[0].SetActive(true);
        obj[1].SetActive(false);
        obj[2].SetActive(false);
        obj[3].SetActive(false);
    }
    public void ClothesStore() {
        obj[0].SetActive(false);
        obj[1].SetActive(true);
        obj[2].SetActive(false);
        obj[3].SetActive(false);
    }
    public void ColorStore() {
        obj[0].SetActive(false);
        obj[1].SetActive(false);
        obj[2].SetActive(true);
        obj[3].SetActive(false);
    }
}
