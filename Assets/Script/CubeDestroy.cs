using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CubeDestroy : MonoBehaviour
{
    // Start is called before the first frame update

    private float sorce;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "bullet") 
        {
            sorce = PlayerPrefs.GetFloat(Sorce.save);
            sorce += 100;
            PlayerPrefs.SetFloat(Sorce.save, sorce);
            Destroy(gameObject);
            
        }
    }
}
