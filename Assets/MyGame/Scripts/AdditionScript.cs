using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdditionScript : MonoBehaviour
{
    public InputField if1;
    public InputField if2;
    public Text sum;
    public Text message;
    public string errorString = "Geben Sie eine gültige Zahl ein";

    public float if1Float = 0;
    public float if2Float = 0;
    public bool num1 = true;
    public bool num2 = true;

    public void Addition()
    {
        try
        {
            if1Float = float.Parse(if1.text);
            if1.image.color = Color.white;
            num1 = true;
        }
        catch (System.Exception)
        {
            if1.image.color = Color.red;
            num1 = false;
            message.text = errorString;
        }

        try
        {
            if2Float = float.Parse(if2.text);
            num2 = true;
            if2.image.color = Color.white;
        }
        catch (System.Exception)
        {
            if2.image.color = Color.red;
            num2 = false;
            message.text = errorString;
        }

        Debug.Log(num1 +""+ num2);

        if(num1 == true && num2 == true)
        {
        sum.text = (if1Float + if2Float).ToString();
        Debug.Log("Die Addition ergibt: " + sum.text);
        }
    }
}