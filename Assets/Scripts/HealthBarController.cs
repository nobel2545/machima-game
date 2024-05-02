using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarController : MonoBehaviour
{
    
    [SerializeField]
    private Slider sliderHP;

    [SerializeField]
    private float curHP;

    [SerializeField]
    private float baseHP;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sliderHP.value = curHP / baseHP;
    }
}
