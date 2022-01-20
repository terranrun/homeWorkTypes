using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;
using UnityEngine.UI;

public class TypeScriptt : MonoBehaviour
{
    [SerializeField] private TMP_Text _intText;
    [SerializeField] private TMP_Text _floatText;
    [SerializeField] private TMP_Text _charText;
    [SerializeField] private Button _FileFlow;
    private char c ='c';
    private bool logic = true;


    private void OnEnable()
    {
        
        _FileFlow.onClick.AddListener(PushButton);
        
    }
    private void OnDisable()
    {
        _FileFlow.onClick.RemoveListener(PushButton);
    }
    public void IntNumber(string str)
    {

        _intText.text = str;
        int result;
        if (Int32.TryParse(str, out result))
            Debug.Log( result);
        else
            Debug.Log("попробуй еще раз");
    }
    public void FloatNumber(string str)
    {

        _floatText.text = str;
        float result;
        if (float.TryParse(str, out result))
            Debug.Log(result);
        else
            Debug.Log("попробуй еще раз");
    }
    


    private void PushButton()
    {
        try
        {
            
            StreamWriter sw = new StreamWriter("C:\\Test.txt");           
            sw.WriteLine(_intText.text);
            sw.WriteLine(_floatText.text);
            sw.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
        }
    }
}
