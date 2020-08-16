using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlbumScript : MonoBehaviour
{
    public GameObject AlbumObject;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void ShowAlbumImage() {
        AlbumObject.SetActive(true);
    }
    public void OutAlbumImage() {
        AlbumObject.SetActive(false);
    }
}
