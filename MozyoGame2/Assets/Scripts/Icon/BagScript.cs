using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagScript : MonoBehaviour
{
    public GameObject BagObject;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void ShowBagImage() {
        BagObject.SetActive(true);
    }
    public void OutBagImage() {
        BagObject.SetActive(false);
    }
}
