using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreImageChange : MonoBehaviour
{
    public GameObject[] obj = new GameObject[2];

    public void HairStore() {
        obj[0].SetActive(true);
        obj[1].SetActive(false);
    }
    public void ColorStore() {
        obj[0].SetActive(false);
        obj[1].SetActive(true);
    }
}
