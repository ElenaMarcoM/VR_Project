using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Battery : MonoBehaviour
{
    public Image BatteryLeft;

    public void UpdateBattery(float n)
    {
        BatteryLeft.fillAmount = n;
    }
}
