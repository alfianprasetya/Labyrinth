using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class OrientationTest : MonoBehaviour
{
    [SerializeField] TMP_Text systemInfoText;
    // Start is called before the first frame update
    void Start()
    {
        systemInfoText.text = "Sensors : ";
        if(SystemInfo.supportsAccelerometer)
            systemInfoText.text += " Accelerometer";

        if(SystemInfo.supportsGyroscope)
            systemInfoText.text += " Support Gyroscope";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
