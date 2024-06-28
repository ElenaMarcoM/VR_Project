using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Take_Apple : MonoBehaviour
{
    public int points;
    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Player")
        {
            Debug.Log(points.ToString());
            ScoreSystem.instance.GainPoints(points);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}
