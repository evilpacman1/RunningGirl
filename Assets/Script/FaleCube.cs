using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FaleCube : MonoBehaviour
{
    // Start is called before the first frame update
    
    public TextMeshProUGUI textMeshProUGUI;
    public int counterFalese;

    private void Start()
    {
        counterFalese = 0;
    }
    public void Update()
    {
        textMeshProUGUI.text = counterFalese.ToString();
        if (counterFalese > 10 ) 
        {
            textMeshProUGUI.text = "Fales";
        
        }
    }
    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "cube") 
        {
            counterFalese += 1;
        }
    }
}
