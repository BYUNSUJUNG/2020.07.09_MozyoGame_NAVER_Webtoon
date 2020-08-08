using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Text 사용하기 때문에

public class Box01Button : MonoBehaviour {

    public GameObject BoxObj01;
    public GameObject BoxObj02;
    public GameObject BoxObj03;

	void Start () {
	
	}
	
	void Update () {
		
	}
    /* 
    public void Forward() {
        BoxObj[0].SetActive(false);
    }
    */
    // 2페이지로 이동
	public void Back() {
        BoxObj01.SetActive(false);
        BoxObj02.SetActive(true);
        BoxObj03.SetActive(false);
    }

}