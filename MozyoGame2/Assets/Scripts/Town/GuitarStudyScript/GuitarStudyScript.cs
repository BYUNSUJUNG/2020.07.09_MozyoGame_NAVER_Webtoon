using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Text 사용하기 때문에

public class GuitarStudyScript : MonoBehaviour {

    public GameObject Backobj;

	void Start () {
	
	}
	
	void Update () {
		
	}

	public void Back() {
        Backobj.SetActive(false);
    }

}