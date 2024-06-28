using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple_detect : MonoBehaviour
{
    private Spawn_normal keep;
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Bad")
        {
            Debug.Log("Take away point");
            Destroy(col.gameObject);
        }
        else if (col.gameObject.tag == "Good")
        {
            //keep.changeTag(col.gameObject);
            Debug.Log(col.gameObject.tag);   
        }
    }

    private void OnCollisionStay(Collision col)
    {
        
    }

}
