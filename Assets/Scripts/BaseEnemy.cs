using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class BaseEnemy : MonoBehaviour {
    public string name;

    public enum Element {
        EARTH,
        WATER,
        WIND,
        FIRE
    }

    public enum Type {
        BOSS,
        ELITE,
        COMMON
    }

    public Element element;
    public Type type;

    public float baseHP;
    public float curHP;

    public float baseATK;
    public float curATK;

    public float baseDEF;
    public float curDEF;

    public float range;
    public float space;
    public float speed;
}
