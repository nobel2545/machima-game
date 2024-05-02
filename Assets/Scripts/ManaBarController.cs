using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManaBarController : MonoBehaviour
{
    
    [SerializeField]
    private Slider sliderMP;

    [SerializeField]
    private float curMP;

    [SerializeField]
    private float baseMP;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sliderMP.value = curMP / baseMP;
    }
}
