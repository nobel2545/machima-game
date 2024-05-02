using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelController : MonoBehaviour
{
    public int index;
    public string levelName;
    public Image black;
    public Animator anim; // เปลี่ยนประเภทของตัวแปรเป็น Animator
    
    public void OnTriggerEnter2D (Collider2D other) {
        if (other.CompareTag ("player")) {
            StartCoroutine(Fading());
        }
    }

    IEnumerator Fading() {
        anim.SetBool("Fade", true);
        yield return new WaitUntil(() => black.color.a == 1);
        SceneManager.LoadScene(index);
    }
}
