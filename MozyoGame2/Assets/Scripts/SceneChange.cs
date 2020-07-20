using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour {

	public void ActivityScene() {
		Debug.Log("활동이동");
		SceneManager.LoadScene("ActivityScene");
	}
    public void StoreScene() {
        Debug.Log("상점이동");
		SceneManager.LoadScene("StoreScene");
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