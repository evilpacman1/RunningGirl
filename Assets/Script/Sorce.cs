using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Sorce : MonoBehaviour
{
    // Start is called before the first frame update
    public float _sorce;
    public float _speed;
    public float _timerLevel;
    public TextMeshProUGUI _textMeshProSorce;
    public static string save = "saveSorce";
    public static string saveSpeed = "saveSpeed";
    public static string saveTimer = "saveTimer";
    void Start()
    {

        if (PlayerPrefs.HasKey(save) == true) 
        { 
            _sorce = PlayerPrefs.GetFloat(save);
            _textMeshProSorce.text = _sorce.ToString();
        }
        else
        {
            PlayerPrefs.SetFloat(save, 0);
            _textMeshProSorce.text = "0";

        }
       

    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.HasKey(save) == true)
        {
            _sorce = PlayerPrefs.GetFloat(save);
            _textMeshProSorce.text = _sorce.ToString();
        }
        else
        {
            PlayerPrefs.SetFloat(save, 0);
            _textMeshProSorce.text = "0";

        }
        TimeSpeed();
    }
    public void TimeSpeed()
    {
        
        _timerLevel += Time.deltaTime;
       
        if (PlayerPrefs.HasKey(saveSpeed) == true)
        {
           
         
            if (_timerLevel < 10) 
            {
                ///PlayerPrefs.DeleteKey(saveSpeed);
                PlayerPrefs.SetFloat(saveSpeed, 10);
            
            }
            if (_timerLevel > 10 && _timerLevel < 20) 
            {
                //PlayerPrefs.DeleteKey(saveSpeed);
                PlayerPrefs.SetFloat(saveSpeed, 20 );

            }
            if (_timerLevel > 20 && _timerLevel < 30)
            {
                //PlayerPrefs.DeleteKey(saveSpeed);
                PlayerPrefs.SetFloat(saveSpeed, 30);

            }

        }
        else 
        {
            
           
            if (_timerLevel < 10)
            {
                ///PlayerPrefs.DeleteKey(saveSpeed);
                PlayerPrefs.SetFloat(saveSpeed, 10);

            }
        }
    }
}
