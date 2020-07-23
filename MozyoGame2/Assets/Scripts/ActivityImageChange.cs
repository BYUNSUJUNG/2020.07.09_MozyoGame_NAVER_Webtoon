using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivityImageChange : MonoBehaviour
{
    public GameObject[] obj = new GameObject[4];

    void Start()
    {
        
    }


    void Update()
    {
        
    }

    public void MoneyActivity() {
        obj[0].SetActive(true);
        obj[1].SetActive(false);
        obj[2].SetActive(false);
        obj[3].SetActive(false);
    }
    public void StudyActivity() {
        obj[0].SetActive(false);
        obj[1].SetActive(true);
        obj[2].SetActive(false);
        obj[3].SetActive(false);
    }
    public void HappyActivity()
    {
        obj[0].SetActive(false);
        obj[1].SetActive(false);
        obj[2].SetActive(true);
        obj[3].SetActive(false);
    }
}
