using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour {

	public void ActivityScene() {
		Debug.Log("활동이동");
		SceneManager.LoadScene("ActivityScene");
	}
	public void TownScene() {
        Debug.Log("마을이동");
		SceneManager.LoadScene("TownScene");
	}
	public void BarbecuePlaceGameScene() {
		Debug.Log("고깃집이동");
		SceneManager.LoadScene("BarbecuePlaceGameScene");
	}
	public void FindPanGameScene() {
		Debug.Log("펜찾기이동");
		SceneManager.LoadScene("FindPanGameScene");
	}


    public void StoreScene() {
        Debug.Log("상점이동");
		SceneManager.LoadScene("StoreScene");
	} 
	public void MainScene() {
        Debug.Log("메인이동");
		SceneManager.LoadScene("MainScene");
	}
	public void BagScene() {
        Debug.Log("가방이동");
		SceneManager.LoadScene("BagScene");
	}
    public void IllustratedBookScene() {
        Debug.Log("도감이동");
		SceneManager.LoadScene("IllustratedBookScene");
	}
    
    
}