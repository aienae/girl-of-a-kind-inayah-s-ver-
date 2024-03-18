using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotate : MonoBehaviour
{
    public Slider slider;
    public GameObject objectToRotate;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float rotationAmount = slider.value * 360 * 360f;
        objectToRotate.transform.rotation = Quaternion.Euler(0f, rotationAmount, 0f);
    }
}
