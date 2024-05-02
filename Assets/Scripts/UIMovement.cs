using System.Collections;
using UnityEngine;
using TMPro;
using System.Linq;

public class UIMovement : MonoBehaviour
{
    public GameObject[] sprites; // อาเรย์ของ Sprite 4 ชิ้น
    public TextMeshProUGUI[] texts; // อาเรย์ของ TextMeshPro สำหรับแสดงข้อความ

    private Animator[] animators; // อาเรย์ของ Animator

    void Start()
    {
        StartCoroutine(AnimateSprites());
    }

    IEnumerator AnimateSprites()
    {
        // เรียงลำดับ Sprites ตามค่า Speed จาก BaseCharacter
        var sortedSprites = sprites.OrderBy(s => s.GetComponent<CharacterSpeed>().speed).ToArray();

        for (int i = 0; i < sortedSprites.Length; i++)
        {
            // แสดงข้อความของ Sprite นั้น
            texts[i].text = "ลำดับ " + (i + 1);

            yield return new WaitForSeconds(1.5f);
        }
    }
}
