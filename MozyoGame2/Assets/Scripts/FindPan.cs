using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Text 사용하기 때문에
using System; // 랜덤 사용

public class FindPan : MonoBehaviour
{
	public GameObject[] obj = new GameObject[12];
    int iScore = 0; //  점수
    public Text score;

    void Start()
    {
        
        System.Random r = new System.Random();
        for (int i = 0; i < 12; i++)
        {
            obj[i].transform.position = new Vector3 (r.Next(110, 1000), r.Next(340, 800), 0);
        }
    }

    void Update()
    {
        
    }

    public void Click00() {
        obj[0].SetActive(false);
    }
    public void Click01() {
        obj[1].SetActive(false);
    }
    public void Click02() {
        obj[2].SetActive(false);
    }
    public void Click03() {
        obj[3].SetActive(false);
    }
    public void Click04() {
        obj[4].SetActive(false);
    }
    public void Click05() {
        obj[5].SetActive(false);
    }
    public void Click06() {
        obj[6].SetActive(false);
    }
    public void Click07() {
        obj[7].SetActive(false);
    }
    public void Click08() {
        obj[8].SetActive(false);
    }
    public void Click09() {
        obj[9].SetActive(false);
        iScore+=10;
        
		score.text = iScore.ToString();
    }
    public void Click10() {
        obj[10].SetActive(false);
        iScore+=10;

		score.text = iScore.ToString();
    }
    public void Click11() {
        obj[11].SetActive(false);
        iScore+=10;
        
		score.text = iScore.ToString();
    }
}
