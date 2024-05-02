using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour
{
    // ตัวแปรเก็บรายชื่อตัวละครของผู้เล่นและศัตรู
    public List<BaseCharacter> players;
    public List<BaseCharacter> enemies;

    // เมื่อเริ่มเกม
    void Start()
    {
        // เรียกเมทอดเรียงลำดับเทิร์น
        SortTurnOrder();
    }

    // เรียงลำดับเทิร์นตามความเร็วของตัวละคร
    void SortTurnOrder()
    {
        // ผสมรายชื่อตัวละครของผู้เล่นและศัตรูเข้าด้วยกัน
        List<BaseCharacter> allCharacters = new List<BaseCharacter>();
        allCharacters.AddRange(players);
        allCharacters.AddRange(enemies);

        // เรียงลำดับตัวละครตามความเร็ว
        allCharacters.Sort((a, b) => b.speed.CompareTo(a.speed));

        // ส่งตัวละครเรียงลำดับเข้าไปใน TurnManager ตามลำดับ
        for (int i = 0; i < allCharacters.Count; i++)
        {
            TurnController turnController = allCharacters[i].GetComponent<TurnController>();
            if (turnController != null)
            {
                turnController.turnOrder = i + 1;
            }
        }
    }
}
