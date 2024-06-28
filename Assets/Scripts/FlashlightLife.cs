using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightLife : MonoBehaviour
{
    private Material lens;
    public Light _light;

    private bool l_on = false;
    private float timer = 0f;
    private int currentBat = 4;
    public Battery B_life;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(l_on)
        {
            timer += Time.deltaTime;

            if (timer >= 10f && _light.intensity != 0)
            {
                timer = 0f;
                currentBat -= 1;
                B_life.UpdateBattery((float)currentBat/4f);
                _light.intensity -= 0.5f;
                //Debug.Log("Se pudoooo");
            }
        }
    }

    public void LightOn()
    {
        // lens.EnableKeyword("_EMISSION");
        _light.enabled = true;
        l_on = true;
    }

    public void LightOff()
    {
        // lens.DisableKeyword("_EMISSION");
        _light.enabled = false;
        l_on = false;
    }

    public void Refill()
    {
        currentBat = 4;
        B_life.UpdateBattery((float)currentBat / 4f);
        _light.intensity = 2f;
    }
}
