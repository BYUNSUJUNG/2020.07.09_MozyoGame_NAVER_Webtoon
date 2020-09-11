using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using LitJson;
using System; // Convert.ToInt32
using Newtonsoft.Json; // JsonConvert, Formatting

public class ChangingHair : MonoBehaviour
{
    public GameObject[] hair = new GameObject[4];

    private string hairString; //파일의 모든 텍스트를 string 형태로 저장하기 위해
    private JsonData hairData; //string 형태의 데이터를 Json 형태로 변경하기 위해
    private string wearingBool; // 옷 착용 여부
    private int iWearingHairNum; // 입고 있는 옷 번호 // 배열값에 이용 // 데이터를 받을 때 사용
    private string sWearingHairNum; // 입고 있는 옷 번호 // 데이터를 저장할 때 사용
    
    void Start()
    {
        hairString = File.ReadAllText(Application.dataPath + "/DB/HairData.json");
        hairData = JsonMapper.ToObject(hairString);
        wearingBool = hairData["wearing"].ToString();
        iWearingHairNum = Convert.ToInt32(hairData["wearingHairNum"].ToString());
        
    }
    
    // 01머리을 클릭함
    public void hair01Click()
    {
        // 머리을 이미 쓰고 있음
        if (wearingBool.Equals("true"))
        {
            // 01머리을 이미 쓰고 있음 -> 벗음
            if (iWearingHairNum == 1)
            {
                wearingBool = "false";
                hair[0].SetActive(false);
            }
            else
            {   // 다른 머리를 쓰고 있음 -> 해당 머리를 벗기고 01머리을 씀
                // 그대로 옷입고 있기에 wearing(true/false)값은 변경하지 않음
                hair[iWearingHairNum - 1].SetActive(false);
                iWearingHairNum = 1;
                hair[0].SetActive(true);
            }

        }
        else
        { // 머리을 이미 쓰고 있음 -> 01머리를 씀
            iWearingHairNum = 1;
            wearingBool = "true";
            hair[0].SetActive(true);
        }

        sWearingHairNum = iWearingHairNum.ToString();
        Dictionary<string, string> DataDict = new Dictionary<string, string>
        {
            {"wearing", wearingBool},
            {"wearingHairNum", sWearingHairNum}
        };
        string json = JsonConvert.SerializeObject(DataDict, Formatting.Indented);

        File.WriteAllText(Application.dataPath + "/DB/HairData.json", json);
        Debug.Log("[wearing]: " + wearingBool + "[wearingHairNum]" + iWearingHairNum);
    } // end of hair01Click()

    // 02머리을 클릭함
    public void hair02Click()
    {
        // 머리을 이미 쓰고 있음
        if (wearingBool.Equals("true"))
        {
            // 02머리을 이미 쓰고 있음 -> 벗음
            if (iWearingHairNum == 2)
            {
                wearingBool = "false";
                hair[1].SetActive(false);
            }
            else
            {   // 다른 머리를 쓰고 있음 -> 해당 머리를 벗기고 02머리을 씀
                // 그대로 옷입고 있기에 wearing(true/false)값은 변경하지 않음
                hair[iWearingHairNum - 1].SetActive(false);
                iWearingHairNum = 2;
                hair[1].SetActive(true);
            }

        }
        else
        { // 머리을 이미 쓰고 있음 -> 02머리를 씀
            iWearingHairNum = 2;
            wearingBool = "true";
            hair[1].SetActive(true);
        }

        sWearingHairNum = iWearingHairNum.ToString();
        Dictionary<string, string> DataDict = new Dictionary<string, string>
        {
            {"wearing", wearingBool},
            {"wearingHairNum", sWearingHairNum}
        };
        string json = JsonConvert.SerializeObject(DataDict, Formatting.Indented);

        File.WriteAllText(Application.dataPath + "/DB/HairData.json", json);
        Debug.Log("[wearing]: " + wearingBool + "[wearingHairNum]" + iWearingHairNum);
    } // end of hair02Click()

    // 03머리을 클릭함
    public void hair03Click()
    {
        // 머리을 이미 쓰고 있음
        if (wearingBool.Equals("true"))
        {
            // 03머리을 이미 쓰고 있음 -> 벗음
            if (iWearingHairNum == 3)
            {
                wearingBool = "false";
                hair[2].SetActive(false);
            }
            else
            { // 다른 머리를 쓰고 있음 -> 해당 머리를 벗기고 03머리을 씀
                // 그대로 옷입고 있기에 wearing(true/false)값은 변경하지 않음
                hair[iWearingHairNum - 1].SetActive(false);
                iWearingHairNum = 3;
                hair[2].SetActive(true);
            }

        }
        else
        { // 머리을 이미 쓰고 있음 -> 03머리를 씀
            iWearingHairNum = 3;
            wearingBool = "true";
            hair[2].SetActive(true);
        }

        sWearingHairNum = iWearingHairNum.ToString();
        Dictionary<string, string> DataDict = new Dictionary<string, string>
        {
            {"wearing", wearingBool},
            {"wearingHairNum", sWearingHairNum}
        };
        string json = JsonConvert.SerializeObject(DataDict, Formatting.Indented);

        File.WriteAllText(Application.dataPath + "/DB/HairData.json", json);
        Debug.Log("[wearing]: " + wearingBool + "[wearingHairNum]" + iWearingHairNum);
    } // end of hair03Click()

    // 04머리을 클릭함
    public void hair04Click()
    {
        // 머리을 이미 쓰고 있음
        if (wearingBool.Equals("true"))
        {
            // 04머리을 이미 쓰고 있음 -> 벗음
            if (iWearingHairNum == 4)
            {
                wearingBool = "false";
                hair[3].SetActive(false);
            }
            else
            { // 다른 머리를 쓰고 있음 -> 해당 머리를 벗기고 04머리을 씀
                // 그대로 옷입고 있기에 wearing(true/false)값은 변경하지 않음
                hair[iWearingHairNum - 1].SetActive(false);
                iWearingHairNum = 4;
                hair[3].SetActive(true);
            }

        }
        else
        { // 머리을 이미 쓰고 있음 -> 04머리를 씀
            iWearingHairNum = 4;
            wearingBool = "true";
            hair[3].SetActive(true);
        }

        sWearingHairNum = iWearingHairNum.ToString();
        Dictionary<string, string> DataDict = new Dictionary<string, string>
        {
            {"wearing", wearingBool},
            {"wearingHairNum", sWearingHairNum}
        };
        string json = JsonConvert.SerializeObject(DataDict, Formatting.Indented);

        File.WriteAllText(Application.dataPath + "/DB/HairData.json", json);
        Debug.Log("[wearing]: " + wearingBool + "[wearingHairNum]" + iWearingHairNum);
    } // end of hair04Click()


}
