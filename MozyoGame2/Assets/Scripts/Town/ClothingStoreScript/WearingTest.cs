using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using LitJson;
using System; // Convert.ToInt32
using Newtonsoft.Json; // JsonConvert, Formatting

public class WearingTest : MonoBehaviour
{
    private string ClothesString; //파일의 모든 텍스트를 string 형태로 저장하기 위해
    private JsonData ClothesData; //string 형태의 데이터를 Json 형태로 변경하기 위해
    //private string[] Cstring = new string[2];
    //private JsonData Cdata;
    private string wearingBool;
    private string wearingClothesNum;

    void Start()
    {
        ClothesString = File.ReadAllText(Application.dataPath + "/DB/ClothesData.json");
        ClothesData = JsonMapper.ToObject(ClothesString);
        
    }

    public void ClickMethod()
    {
        //UpCount = CountData["Count"]+1;
        //iUpCount = Convert.ToInt32(CountData["Count"].ToString())+1;
        //sUpCount = iUpCount.ToString();

        //Cstring[0] = "Count";
        //Cstring[1] = CountData["Count"].ToString();
        //Cdata = JsonMapper.ToJson(Cstring);

        wearingBool = ClothesData["wearing"].ToString();
        wearingClothesNum = ClothesData["wearingClothesNum"].ToString();

        
        if (wearingBool.Equals("false")) {
            wearingBool = "true";
        } else { //true일 경우
            wearingBool = "false";
        }
        wearingClothesNum = "1";

        Dictionary<string, string> DataDict = new Dictionary<string, string>
        {
            {"wearing", wearingBool/*CountData["Count"].ToString()*/},
            {"wearingClothesNum", wearingClothesNum}
        };
        string json = JsonConvert.SerializeObject(DataDict, Formatting.Indented);

        File.WriteAllText(Application.dataPath + "/DB/ClothesData.json", json);
        Debug.Log("[wearing]: " + wearingBool+ "[wearingClothesNum]"+ wearingClothesNum);
    }
}

/*
 * Dictionary로 만들기
 * string uploadedUrl = "http://whereTheFileWas.com/uploaded/what.jpg"
Dictionary<string, string> location = new Dictionary<string, string>
{
    {"location", uploadedUrl}
};
string json = JsonConvert.SerializeObject(location, Formatting.Indented); */
//Formatting.Indented(옵션): 자동으로 라인/들여쓰기된 문자열