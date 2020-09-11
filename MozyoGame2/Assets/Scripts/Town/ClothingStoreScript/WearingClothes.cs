using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WearingClothes : MonoBehaviour
{
    public GameObject[] clothes = new GameObject[7];
    private bool wearing = false; // 옷 착용 여부
    private int wearingClothesNum = 0; // 입고 있는 옷 번호 

    // 01옷을 클릭함
    public void clothes01Click() {
        // 옷을 이미 입고 있음
        if (wearing == true) {
            // 01옷을 입고 있음 -> 벗음
            if (wearingClothesNum == 1)
            {
                wearing = false;
                clothes[0].SetActive(false);
            }
            else { // 다른 옷을 입고 있음 -> 해당 옷을 벗기고 01옷을 입힘
                // 그대로 옷입고 있기에 wearing(true/false)값은 변경하지 않음
                clothes[wearingClothesNum-1].SetActive(false);
                wearingClothesNum = 1;
                clothes[0].SetActive(true);
            }

        } else { // 옷을 입고 있지 않음 -> 01옷을 입음
            wearingClothesNum = 1;
            wearing = true;
            clothes[0].SetActive(true);
        }
        
    } // end of clothes01Click()

    // 02옷을 클릭함
    public void clothes02Click()
    {
        // 옷을 이미 입고 있음
        if (wearing == true)
        {
            // 02옷을 입고 있음 -> 벗음
            if (wearingClothesNum == 2)
            {
                wearing = false;
                clothes[1].SetActive(false);
            }
            else
            { // 다른 옷을 입고 있음 -> 해당 옷을 벗기고 02옷을 입힘
                // 그대로 옷입고 있기에 wearing(true/false)값은 변경하지 않음
                clothes[wearingClothesNum - 1].SetActive(false);
                wearingClothesNum = 2;
                clothes[1].SetActive(true);
            }

        }
        else
        { // 옷을 입고 있지 않음 -> 02옷을 입음
            wearingClothesNum = 2;
            wearing = true;
            clothes[1].SetActive(true);
        }

    } // end of clothes02Click()

    // 03옷을 클릭함
    public void clothes03Click()
    {
        // 옷을 이미 입고 있음
        if (wearing == true)
        {
            // 03옷을 입고 있음 -> 벗음
            if (wearingClothesNum == 3)
            {
                wearing = false;
                clothes[2].SetActive(false);
            }
            else
            { // 다른 옷을 입고 있음 -> 해당 옷을 벗기고 03옷을 입힘
                // 그대로 옷입고 있기에 wearing(true/false)값은 변경하지 않음
                clothes[wearingClothesNum - 1].SetActive(false);
                wearingClothesNum = 3;
                clothes[2].SetActive(true);
            }

        }
        else
        { // 옷을 입고 있지 않음 -> 03옷을 입음
            wearingClothesNum = 3;
            wearing = true;
            clothes[2].SetActive(true);
        }

    } // end of clothes03Click()

    // 04옷을 클릭함
    public void clothes04Click()
    {
        // 옷을 이미 입고 있음
        if (wearing == true)
        {
            // 04옷을 입고 있음 -> 벗음
            if (wearingClothesNum == 4)
            {
                wearing = false;
                clothes[3].SetActive(false);
            }
            else
            { // 다른 옷을 입고 있음 -> 해당 옷을 벗기고 04옷을 입힘
                // 그대로 옷입고 있기에 wearing(true/false)값은 변경하지 않음
                clothes[wearingClothesNum - 1].SetActive(false);
                wearingClothesNum = 4;
                clothes[3].SetActive(true);
            }

        }
        else
        { // 옷을 입고 있지 않음 -> 04옷을 입음
            wearingClothesNum = 4;
            wearing = true;
            clothes[3].SetActive(true);
        }

    } // end of clothes04Click()

    // 05옷을 클릭함
    public void clothes05Click()
    {
        // 옷을 이미 입고 있음
        if (wearing == true)
        {
            // 05옷을 입고 있음 -> 벗음
            if (wearingClothesNum == 5)
            {
                wearing = false;
                clothes[4].SetActive(false);
            }
            else
            { // 다른 옷을 입고 있음 -> 해당 옷을 벗기고 05옷을 입힘
                // 그대로 옷입고 있기에 wearing(true/false)값은 변경하지 않음
                clothes[wearingClothesNum - 1].SetActive(false);
                wearingClothesNum = 5;
                clothes[4].SetActive(true);
            }

        }
        else
        { // 옷을 입고 있지 않음 -> 05옷을 입음
            wearingClothesNum = 5;
            wearing = true;
            clothes[4].SetActive(true);
        }

    } // end of clothes05Click()

    // 06옷을 클릭함
    public void clothes06Click()
    {
        // 옷을 이미 입고 있음
        if (wearing == true)
        {
            // 06옷을 입고 있음 -> 벗음
            if (wearingClothesNum == 6)
            {
                wearing = false;
                clothes[5].SetActive(false);
            }
            else
            { // 다른 옷을 입고 있음 -> 해당 옷을 벗기고 06옷을 입힘
                // 그대로 옷입고 있기에 wearing(true/false)값은 변경하지 않음
                clothes[wearingClothesNum - 1].SetActive(false);
                wearingClothesNum = 6;
                clothes[5].SetActive(true);
            }

        }
        else
        { // 옷을 입고 있지 않음 -> 06옷을 입음
            wearingClothesNum = 6;
            wearing = true;
            clothes[5].SetActive(true);
        }

    } // end of clothes06Click()

    // 07옷을 클릭함
    public void clothes07Click()
    {
        // 옷을 이미 입고 있음
        if (wearing == true)
        {
            // 07옷을 입고 있음 -> 벗음
            if (wearingClothesNum == 7)
            {
                wearing = false;
                clothes[6].SetActive(false);
            }
            else
            { // 다른 옷을 입고 있음 -> 해당 옷을 벗기고 07옷을 입힘
                // 그대로 옷입고 있기에 wearing(true/false)값은 변경하지 않음
                clothes[wearingClothesNum - 1].SetActive(false);
                wearingClothesNum = 7;
                clothes[6].SetActive(true);
            }

        }
        else
        { // 옷을 입고 있지 않음 -> 07옷을 입음
            wearingClothesNum = 7;
            wearing = true;
            clothes[6].SetActive(true);
        }

    } // end of clothes07Click()

}
