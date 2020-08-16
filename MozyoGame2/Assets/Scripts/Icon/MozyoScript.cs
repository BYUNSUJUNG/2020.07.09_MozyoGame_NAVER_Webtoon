using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MozyoScript : MonoBehaviour
{
    public GameObject MozyoObject;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void ShowMozyoImage() {
        MozyoObject.SetActive(true);
    }
    public void OutMozyoImage() {
        MozyoObject.SetActive(false);
    }
}
