using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Text 사용하기 때문에

public class BarbecuePlaceGameScript : MonoBehaviour {

	int iCnt = 0; // 클릭 횟수
    int iScore = 0; // 고기 점수

	public GameObject meat01;
	public GameObject meat02;
	public GameObject meat03;
	public Text score;

    public GameObject Backobj;

	void Start () {
		score.text = "0";
        meat01.SetActive(true);
        meat02.SetActive(false);
        meat03.SetActive(false);
	}
	
	void Update () {
		
	}

	public void Back() {
        Backobj.SetActive(false);
    }

	public void Click() {
		iCnt++;
		//Debug.Log("myNum: "+myNum);
		if(iCnt%3==0) { // 3, 6, 9, ......
			meat01.SetActive(true);
			meat02.SetActive(false);
			meat03.SetActive(false);
            // 다 구운 고기 이미지인 meat3이 없어지면서 점수가 올라감 
            iScore+=10;
		} else if(iCnt%3==1) { // 1, 4, 7, ......
			meat01.SetActive(false);
			meat02.SetActive(true);
			meat03.SetActive(false);
        } else { // iCnt%3==2 // 2, 5, 8, ......
        	meat01.SetActive(false);
			meat02.SetActive(false);
			meat03.SetActive(true);    
        }

		score.text = iScore.ToString();
        
	}
}