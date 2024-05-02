using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class SortingImage : MonoBehaviour
{
    public List<GameObject> sprites; // รายการของ Sprite ใน Prefabs ที่ต้องการจัดลำดับ

    void Start()
    {
        // เรียงลำดับ Sprite โดยใช้ LINQ ตามค่า Speed ที่ฝังใน CharacterSpeed
        sprites = sprites.OrderBy(sprite => sprite.GetComponent<CharacterSpeed>().speed).ToList();

        // ตรวจสอบการจัดลำดับที่ถูกต้อง
        for (int i = 0; i < sprites.Count; i++)
        {
            Debug.Log("Sprite " + (i + 1) + " Speed: " + sprites[i].GetComponent<CharacterSpeed>().speed);
        }

        // กำหนดชื่อใหม่ให้กับ Sprite ตามลำดับ First, Second, Third, Fourth
        for (int i = 0; i < sprites.Count; i++)
        {
            string newName = "";
            switch (i)
            {
                case 0:
                    newName = "First";
                    break;
                case 1:
                    newName = "Second";
                    break;
                case 2:
                    newName = "Third";
                    break;
                case 3:
                    newName = "Fourth";
                    break;
                // คุณสามารถเพิ่มเงื่อนไขสำหรับลำดับอื่น ๆ ตามต้องการ
            }

            sprites[i].name = newName;
        }
    }
}
