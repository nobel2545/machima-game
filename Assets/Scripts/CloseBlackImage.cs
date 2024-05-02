using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseBlackImage : MonoBehaviour
{
    public GameObject image;
    
    private void DisableImage()
    {
    image.SetActive(false);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DisableImage", 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
