using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Master : MonoBehaviour
{
    public string newText;
    public InputField i;

    public int newSize;
    public Text t;

    public float newValue;
    public Slider s;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        i.text = newText;
        t.fontSize = newSize;
        s.value = newValue;
    }
}
