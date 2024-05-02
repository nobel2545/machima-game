using UnityEngine;

public class ChangeAnimationClip : MonoBehaviour
{
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject button4;

    public GameObject button5;
    
    public Animator animator; // กำหนด Animator ที่ต้องการควบคุม

    public AnimationClip newAnimationClip; // กำหนด AnimationClip ที่ต้องการเปลี่ยนเป็น

    private bool button1Pressed = false; // เก็บว่า button1[1] ถูกกดหรือไม่
    private bool button2Pressed = false;
    private bool button3Pressed = false;
    private bool button4Pressed = false;

    public void ChangeClip()
    {
        if (OnButtonClick(button1)) {
            button1Pressed = true;

            if (OnButtonClick(button5) && button1Pressed) {
            button5.SetActive(false); // เมื่อ button2 ถูกกด และ button1[1] ถูกกดแล้ว
            animator.SetTrigger("TrSkill1"); // ให้เปิดใช้งาน Trigger "TrSkill2"
            }
        }

        if (OnButtonClick(button2)) {
            button2Pressed = true;

            if (OnButtonClick(button5) && button2Pressed) {
            button5.SetActive(false); // เมื่อ button2 ถูกกด และ button1[1] ถูกกดแล้ว
            animator.SetTrigger("TrSkill2"); // ให้เปิดใช้งาน Trigger "TrSkill2"
            }
        }

        if (OnButtonClick(button3)) {
            button3Pressed = true;

            if (OnButtonClick(button5) && button3Pressed) {
            button5.SetActive(false); // เมื่อ button2 ถูกกด และ button1[1] ถูกกดแล้ว
            animator.SetTrigger("TrUlt"); // ให้เปิดใช้งาน Trigger "TrSkill2"
            }
        }

        if (OnButtonClick(button4)) {
            button4Pressed = true;

            if (OnButtonClick(button5) && button4Pressed) {
            button5.SetActive(false); // เมื่อ button2 ถูกกด และ button1[1] ถูกกดแล้ว
            animator.SetTrigger("TrItem"); // ให้เปิดใช้งาน Trigger "TrSkill2"
        }
        }
    }

    // ตรวจสอบการคลิกปุ่ม
    private bool OnButtonClick(GameObject button)
    {
        // ใส่โค้ดที่ตรวจสอบการคลิกปุ่มตรงนี้
        return true; // ตัวอย่างการ return ค่าเป็น true เพื่อทดสอบ
    }
}
