using UnityEngine;
using UnityEngine.UI;

public class PlayAnimationOnClick : MonoBehaviour
{
    public Animator animator; // อิงไปยัง Animator ของตัวละคร
    public Button button; // ปุ่มที่จะกดเพื่อเล่น Animation

    void Start()
    {
        // ดึงคอมโพเนนต์ Button จาก GameObject และเพิ่ม Listener
        button.onClick.AddListener(PlayCharacterAnimation);
    }

    void PlayCharacterAnimation()
    {
        // เรียกใช้งาน Animation โดยการเล่น Animation ที่มีชื่อ "YourAnimationName"
        animator.Play("YourAnimationName");
    }
}
