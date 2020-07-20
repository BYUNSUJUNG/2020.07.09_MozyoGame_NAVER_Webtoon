using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainImageChange : MonoBehaviour
{
    public GameObject QuestObject;
    bool QuestBool = false;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

     public void QuestImage() {
         if (QuestBool==true)
         {
             QuestObject.SetActive(false);
             QuestBool=false;
         } else { // QuestBool==false
             QuestObject.SetActive(true);
             QuestBool=true;
         }
        
    }
}
