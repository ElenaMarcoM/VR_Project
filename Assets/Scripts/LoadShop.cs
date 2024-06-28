using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LoadShop : MonoBehaviour
{
	[SerializeField] TextMeshProUGUI timeText;
	[SerializeField] private float remainTime = 6f;
	public GameObject pantalla1;
	public GameObject pantalla2;
	private int sec = 0;
	bool active = false;
	// Update is called once per frame
	void Update()
	{
		if(active)
        {
			if (remainTime > 0)
			{
				remainTime -= Time.deltaTime;
				sec = (int)remainTime;
				timeText.text = string.Format(sec.ToString());
			}
			else if (remainTime <= 0)
			{
				pantalla1.SetActive(true);
				pantalla2.SetActive(false);
				remainTime = 5f;
				active = false;
			}
			//timeText.text = string.Format("", sec);
		}
		
	}

	public void SetActive()
    {
		active = true;
    }
}
