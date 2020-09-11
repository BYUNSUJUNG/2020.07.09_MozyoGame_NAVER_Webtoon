using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using LitJson;
using System; // Convert.ToInt32
using Newtonsoft.Json; // JsonConvert, Formatting

public class WearingClothes : MonoBehaviour
{
    public GameObject[] clothes = new GameObject[7];

    private string ClothesString; //파일의 모든 텍스트를 string 형태로 저장하기 위해
    private JsonData ClothesData; //string 형태의 데이터를 Json 형태로 변경하기 위해
    private string wearingBool; // 옷 착용 여부
    private int iWearingClothesNum; // 입고 있는 옷 번호 // 배열값에 이용 // 데이터를 받을 때 사용
    private string sWearingClothesNum; // 입고 있는 옷 번호 // 데이터를 저장할 때 사용
    
    void Start()
    {
        ClothesString = File.ReadAllText(Application.dataPath + "/DB/ClothesData.json");
        ClothesData = JsonMapper.ToObject(ClothesString);
        wearingBool = ClothesData["wearing"].ToString();
        iWearingClothesNum = Convert.ToInt32(ClothesData["wearingClothesNum"].ToString());
        
    }


    // 01옷을 클릭함
    public void clothes01Click()
    {
        // 옷을 이미 입고 있음
        if (wearingBool.Equals("true"))
        {
            // 01옷을 입고 있음 -> 벗음
            if (iWearingClothesNum == 1)
            {
                wearingBool = "false";
                clothes[0].SetActive(false);
            }
            else
            { // 다른 옷을 입고 있음 -> 해당 옷을 벗기고 01옷을 입힘
                // 그대로 옷입고 있기에 wearing(true/false)값은 변경하지 않음
                clothes[iWearingClothesNum - 1].SetActive(false);
                iWearingClothesNum = 1;
                clothes[0].SetActive(true);
            }

        }
        else
        { // 옷을 입고 있지 않음 -> 01옷을 입음
            iWearingClothesNum = 1;
            wearingBool = "true";
            clothes[0].SetActive(true);
        }

        sWearingClothesNum = iWearingClothesNum.ToString();
        Dictionary<string, string> DataDict = new Dictionary<string, string>
        {
            {"wearing", wearingBool},
            {"wearingClothesNum", sWearingClothesNum}
        };
        string json = JsonConvert.SerializeObject(DataDict, Formatting.Indented);

        File.WriteAllText(Application.dataPath + "/DB/ClothesData.json", json);
        Debug.Log("[wearing]: " + wearingBool + "[wearingClothesNum]" + iWearingClothesNum);
    } // end of clothes01Click()

    // 02옷을 클릭함
    public void clothes02Click()
    {
        // 옷을 이미 입고 있음
        if (wearingBool.Equals("true"))
        {
            // 02옷을 입고 있음 -> 벗음
            if (iWearingClothesNum == 2)
            {
                wearingBool = "false";
                clothes[1].SetActive(false);
            }
            else
            { // 다른 옷을 입고 있음 -> 해당 옷을 벗기고 02옷을 입힘
                // 그대로 옷입고 있기에 wearing(true/false)값은 변경하지 않음
                clothes[iWearingClothesNum - 1].SetActive(false);
                iWearingClothesNum = 2;
                clothes[1].SetActive(true);
            }

        }
        else
        { // 옷을 입고 있지 않음 -> 02옷을 입음
            iWearingClothesNum = 2;
            wearingBool = "true";
            clothes[1].SetActive(true);
        }

        sWearingClothesNum = iWearingClothesNum.ToString();
        Dictionary<string, string> DataDict = new Dictionary<string, string>
        {
            {"wearing", wearingBool},
            {"wearingClothesNum", sWearingClothesNum}
        };
        string json = JsonConvert.SerializeObject(DataDict, Formatting.Indented);

        File.WriteAllText(Application.dataPath + "/DB/ClothesData.json", json);
        Debug.Log("[wearing]: " + wearingBool + "[wearingClothesNum]" + iWearingClothesNum);
    } // end of clothes02Click()

    // 03옷을 클릭함
    public void clothes03Click()
    {
        // 옷을 이미 입고 있음
        if (wearingBool.Equals("true"))
        {
            // 03옷을 입고 있음 -> 벗음
            if (iWearingClothesNum == 3)
            {
                wearingBool = "false";
                clothes[2].SetActive(false);
            }
            else
            { // 다른 옷을 입고 있음 -> 해당 옷을 벗기고 03옷을 입힘
                // 그대로 옷입고 있기에 wearing(true/false)값은 변경하지 않음
                clothes[iWearingClothesNum - 1].SetActive(false);
                iWearingClothesNum = 3;
                clothes[2].SetActive(true);
            }

        }
        else
        { // 옷을 입고 있지 않음 -> 03옷을 입음
            iWearingClothesNum = 3;
            wearingBool = "true";
            clothes[2].SetActive(true);
        }

        sWearingClothesNum = iWearingClothesNum.ToString();
        Dictionary<string, string> DataDict = new Dictionary<string, string>
        {
            {"wearing", wearingBool},
            {"wearingClothesNum", sWearingClothesNum}
        };
        string json = JsonConvert.SerializeObject(DataDict, Formatting.Indented);

        File.WriteAllText(Application.dataPath + "/DB/ClothesData.json", json);
        Debug.Log("[wearing]: " + wearingBool + "[wearingClothesNum]" + iWearingClothesNum);
    } // end of clothes03Click()

    // 04옷을 클릭함
    public void clothes04Click()
    {
        // 옷을 이미 입고 있음
        if (wearingBool.Equals("true"))
        {
            // 04옷을 입고 있음 -> 벗음
            if (iWearingClothesNum == 4)
            {
                wearingBool = "false";
                clothes[3].SetActive(false);
            }
            else
            { // 다른 옷을 입고 있음 -> 해당 옷을 벗기고 04옷을 입힘
                // 그대로 옷입고 있기에 wearing(true/false)값은 변경하지 않음
                clothes[iWearingClothesNum - 1].SetActive(false);
                iWearingClothesNum = 4;
                clothes[3].SetActive(true);
            }

        }
        else
        { // 옷을 입고 있지 않음 -> 04옷을 입음
            iWearingClothesNum = 4;
            wearingBool = "true";
            clothes[3].SetActive(true);
        }

        sWearingClothesNum = iWearingClothesNum.ToString();
        Dictionary<string, string> DataDict = new Dictionary<string, string>
        {
            {"wearing", wearingBool},
            {"wearingClothesNum", sWearingClothesNum}
        };
        string json = JsonConvert.SerializeObject(DataDict, Formatting.Indented);

        File.WriteAllText(Application.dataPath + "/DB/ClothesData.json", json);
        Debug.Log("[wearing]: " + wearingBool + "[wearingClothesNum]" + iWearingClothesNum);
    } // end of clothes04Click()

    // 05옷을 클릭함
    public void clothes05Click()
    {
        // 옷을 이미 입고 있음
        if (wearingBool.Equals("true"))
        {
            // 05옷을 입고 있음 -> 벗음
            if (iWearingClothesNum == 5)
            {
                wearingBool = "false";
                clothes[4].SetActive(false);
            }
            else
            { // 다른 옷을 입고 있음 -> 해당 옷을 벗기고 05옷을 입힘
                // 그대로 옷입고 있기에 wearing(true/false)값은 변경하지 않음
                clothes[iWearingClothesNum - 1].SetActive(false);
                iWearingClothesNum = 5;
                clothes[4].SetActive(true);
            }

        }
        else
        { // 옷을 입고 있지 않음 -> 05옷을 입음
            iWearingClothesNum = 5;
            wearingBool = "true";
            clothes[4].SetActive(true);
        }

        sWearingClothesNum = iWearingClothesNum.ToString();
        Dictionary<string, string> DataDict = new Dictionary<string, string>
        {
            {"wearing", wearingBool},
            {"wearingClothesNum", sWearingClothesNum}
        };
        string json = JsonConvert.SerializeObject(DataDict, Formatting.Indented);

        File.WriteAllText(Application.dataPath + "/DB/ClothesData.json", json);
        Debug.Log("[wearing]: " + wearingBool + "[wearingClothesNum]" + iWearingClothesNum);
    } // end of clothes05Click()

    // 06옷을 클릭함
    public void clothes06Click()
    {
        // 옷을 이미 입고 있음
        if (wearingBool.Equals("true"))
        {
            // 06옷을 입고 있음 -> 벗음
            if (iWearingClothesNum == 6)
            {
                wearingBool = "false";
                clothes[5].SetActive(false);
            }
            else
            { // 다른 옷을 입고 있음 -> 해당 옷을 벗기고 06옷을 입힘
                // 그대로 옷입고 있기에 wearing(true/false)값은 변경하지 않음
                clothes[iWearingClothesNum - 1].SetActive(false);
                iWearingClothesNum = 6;
                clothes[5].SetActive(true);
            }

        }
        else
        { // 옷을 입고 있지 않음 -> 06옷을 입음
            iWearingClothesNum = 6;
            wearingBool = "true";
            clothes[5].SetActive(true);
        }

        sWearingClothesNum = iWearingClothesNum.ToString();
        Dictionary<string, string> DataDict = new Dictionary<string, string>
        {
            {"wearing", wearingBool},
            {"wearingClothesNum", sWearingClothesNum}
        };
        string json = JsonConvert.SerializeObject(DataDict, Formatting.Indented);

        File.WriteAllText(Application.dataPath + "/DB/ClothesData.json", json);
        Debug.Log("[wearing]: " + wearingBool + "[wearingClothesNum]" + iWearingClothesNum);
    } // end of clothes06Click()

    // 07옷을 클릭함
    public void clothes07Click()
    {
        // 옷을 이미 입고 있음
        if (wearingBool.Equals("true"))
        {
            // 07옷을 입고 있음 -> 벗음
            if (iWearingClothesNum == 7)
            {
                wearingBool = "false";
                clothes[6].SetActive(false);
            }
            else
            { // 다른 옷을 입고 있음 -> 해당 옷을 벗기고 07옷을 입힘
                // 그대로 옷입고 있기에 wearing(true/false)값은 변경하지 않음
                clothes[iWearingClothesNum - 1].SetActive(false);
                iWearingClothesNum = 7;
                clothes[6].SetActive(true);
            }

        }
        else
        { // 옷을 입고 있지 않음 -> 07옷을 입음
            iWearingClothesNum = 7;
            wearingBool = "true";
            clothes[6].SetActive(true);
        }

        sWearingClothesNum = iWearingClothesNum.ToString();
        Dictionary<string, string> DataDict = new Dictionary<string, string>
        {
            {"wearing", wearingBool},
            {"wearingClothesNum", sWearingClothesNum}
        };
        string json = JsonConvert.SerializeObject(DataDict, Formatting.Indented);

        File.WriteAllText(Application.dataPath + "/DB/ClothesData.json", json);
        Debug.Log("[wearing]: " + wearingBool + "[wearingClothesNum]" + iWearingClothesNum);
    } // end of clothes07Click()

}
