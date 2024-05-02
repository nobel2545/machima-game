using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ATKCalculator : MonoBehaviour
{
    // ค่าโจมตีของแต่ละธาตุ
    public int fireATK;
    public int waterATK;
    public int earthATK;
    public int windATK;

    public int ATK;

    // จำนวนช่องธาตุที่เลือกของแต่ละธาตุ
    public int fireTileCount;
    public int waterTileCount;
    public int earthTileCount;
    public int windTileCount;

    // ค่าโจมตีทั้งหมด
    private int totalATK;

    // ฟังก์ชันสำหรับคำนวณค่าโจมตีทั้งหมด
    public int CalculateTotalATK()
    {
        totalATK = (fireATK * fireTileCount) + (waterATK * waterTileCount) + (earthATK * earthTileCount) + (windATK * windTileCount);
        return totalATK;
    }

    void Update () {
        Debug.Log(totalATK);
    }
}
