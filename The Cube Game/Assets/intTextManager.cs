using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class intTextManager : MonoBehaviour
{
    public int bells = 0;
    public Text bellsText;
    // Start is called before the first frame update
    void Start()
    {
        bellsText.text = bells.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
