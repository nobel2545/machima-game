using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneLoadimg : MonoBehaviour
{
    public void LoadScene()
    {
        SceneManager.LoadScene("BattleScene");
    }
}