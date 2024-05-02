using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class IntroDialogue : MonoBehaviour
{
    public float interval = 0.5f;

    private string[] loadingDots = { "", ".", "..", "..." };
    private int dotIndex = 0;
    private int roundCount = 0;
    public TextMeshProUGUI dialogueText;
    public GameObject dialoguePanel;
    public Sprite newBackgroundSprite;
    public GameObject nextUICanvasOne;
    public GameObject nextUICanvasTwo;

    public GameObject nextUICanvasThree;

    public GameObject nextUIPanel;

    public TextMeshProUGUI loadingText;
    public Color redColor = Color.red;
    public Color whiteColor = Color.white;
    public float flashInterval = 1f;
    public int flashCount = 5;

    void Start()
    {
        StartCoroutine(DisplayDialogue());
    }

    IEnumerator DisplayDialogue()
    {
        while (roundCount < 3)
        {
            dialogueText.text = "กำลังตรวจสอบพื้นที่" + loadingDots[dotIndex];
            dotIndex = (dotIndex + 1) % loadingDots.Length; // วนลูปจุด

            yield return new WaitForSeconds(interval);

            if (dotIndex == 0)
            {
                roundCount++; // เพิ่มจำนวนรอบเมื่อจุดถึงจุดสุดท้าย
            }
        }

        dialoguePanel.GetComponent<Image>().sprite = newBackgroundSprite;

        nextUICanvasOne.SetActive(true);

        StartCoroutine(FlashText());

        yield return new WaitForSeconds(4f);

        // เปลี่ยนหน้า UI ไปที่อื่น ๆ
        Animator nextUIPanelAnimator = nextUIPanel.GetComponent<Animator>();
        nextUIPanelAnimator.SetTrigger("FadeOut");
        
        nextUICanvasTwo.SetActive(true); // เปิดหน้า UI ถัดไปหรือทำการเปลี่ยนหน้าตามที่ต้องการ

        yield return new WaitForSeconds(2f);

        nextUICanvasThree.SetActive(true); // เปิดหน้า UI ถัดไปหรือทำการเปลี่ยนหน้าตามที่ต้องการ
        nextUICanvasTwo.SetActive(false);
    }

    IEnumerator FlashText()
    {
        for (int i = 0; i < flashCount; i++)
        {
            // เปลี่ยนสีเป็นแดง
            loadingText.color = redColor;
            yield return new WaitForSeconds(flashInterval);

            // เปลี่ยนสีเป็นขาว
            loadingText.color = whiteColor;
            yield return new WaitForSeconds(flashInterval);
        }

        // ตั้งค่าสีกลับไปเป็นสีขาวหลังจากกระพริบสีเสร็จสิ้น
        loadingText.color = whiteColor;
    }
}