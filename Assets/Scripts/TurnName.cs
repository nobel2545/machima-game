using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TurnName : MonoBehaviour
{
     public TextMeshProUGUI turnText; // TextMeshProUGUI ที่จะแสดงชื่อตัวละคร
    public BaseCharacter[] characters; // อาเรย์ของตัวละคร

    private int currentTurn = 0; // ตัวแปรเก็บค่าเทิร์นปัจจุบัน

    void Start()
    {
        // เริ่มเกมโดยกำหนดเทิร์นแรก
        SetTurnText();
    }

    // ฟังก์ชันสำหรับเปลี่ยนเทิร์น
    public void NextTurn()
    {
        // เพิ่มค่าเทิร์นปัจจุบัน โดยรอบเมื่อถึงตัวละครสุดท้ายกลับไปที่ตัวแรก
        currentTurn = (currentTurn + 1) % characters.Length;
        
        // สั่งให้ TextMeshProUGUI แสดงชื่อตัวละครเทิร์นปัจจุบัน
        SetTurnText();
    }

    // ฟังก์ชันสำหรับตั้งค่าข้อความเทิร์น
    void SetTurnText()
    {
        // นำชื่อตัวละครเทิร์นปัจจุบันไปแสดงบน TextMeshProUGUI
        turnText.text = "เทิร์นของ" + characters[currentTurn].name;
    }
}
