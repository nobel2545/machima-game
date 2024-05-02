using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]

public class BaseCharacter : MonoBehaviour {
    public string name;

    public enum Element {
        EARTH,
        WATER,
        WIND,
        FIRE,
        NONE
    }

    public Element element;

    public float baseHP;
    public float curHP;

    [SerializeField]
    private Slider sliderHP;

    public float baseMP;
    public float curMP;

    public float earthATK;
    public float waterATK;
    public float windATK;
    public float fireATK;
    public float ATK;
    
    public float range;
    public float space;
    public float speed;

    // ตัวละครของผู้เล่น
    public class PlayerCharacter : BaseCharacter
    {
        public void TakeDamage(int damage)
        {
        int damageTaken = damage;
        curHP -= damageTaken;
        if (curHP <= 0)
          {
            Die();
          }
        }

    private void Die()
    {
        // ตรงนี้คุณสามารถเขียนโค้ดที่เกี่ยวข้องกับการตายของตัวละครผู้เล่นได้
    }
    }

    // ตัวละครของศัตรู
    public class EnemyCharacter : BaseCharacter
{
    // เพิ่มเมทอดและคุณสมบัติของตัวละครศัตรู
    public int enemyLevel;
    public int maxHealth;
    public int currentHealth;
    public int attackDamage;

    public void TakeDamage(int damage)
    {
        curHP -= damage;
        if (curHP <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        // ตรงนี้คุณสามารถเขียนโค้ดที่เกี่ยวข้องกับการตายของศัตรูได้
    }
}

    private void Start() {
        sliderHP.value = baseHP;
    }
}
