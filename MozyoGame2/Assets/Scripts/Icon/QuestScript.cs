using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestScript : MonoBehaviour
{
    public GameObject QuestObject;

    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void OutQuestImage() {
        QuestObject.SetActive(false);
    }
    public void ShowQuestImage() {
        QuestObject.SetActive(true);
    }
    

}
