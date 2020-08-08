using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Text 사용하기 때문에

public class Box03Button : MonoBehaviour {

    public GameObject BoxObj01;
    public GameObject BoxObj02;
    public GameObject BoxObj03;

	void Start () {
	
	}
	
	void Update () {
		
	}
    
    // 2페이지로 이동
    public void Forward() { 
        BoxObj01.SetActive(false);
        BoxObj02.SetActive(true);
        BoxObj03.SetActive(false);
    }
    
    /* 
	public void Back() {
        BoxObj01.SetActive(false);
        BoxObj02.SetActive(false);
        BoxObj03.SetActive(true);
    }*/

}