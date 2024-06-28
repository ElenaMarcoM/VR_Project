using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreSystem : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI ScoreHUD;
    public static ScoreSystem instance;
    int Score;
    public GameObject pantallaEnd;
    public GameObject OriginXRL;
    public GameObject OriginXRR;
    void Start()
    {
        instance = this;
        Score = 0;
        ScoreHUD.text = string.Format(Score.ToString());
    }
    private void Update()
    {
        if(Score < 0)
        {
            pantallaEnd.SetActive(true);
            OriginXRL.SetActive(false);
            OriginXRR.SetActive(false);
        }
    }
    public void GainPoints(int p)
    {
        Score += p;
        ScoreHUD.text = string.Format(Score.ToString());
        Debug.Log(p.ToString());
    }

    public void LosePoints(int p)
    {
        Score -= p;
        ScoreHUD.text = string.Format(Score.ToString());
    }
}
