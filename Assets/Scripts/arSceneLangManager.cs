using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class arSceneLangManager : MonoBehaviour
{
    public TextMeshProUGUI galaryNameField;
    public TextMeshProUGUI galaryNameDescField;
    public TextMeshProUGUI loadingNameField;
    public TextMeshProUGUI findMarkerNameField;
    
    
    public string[] galaryNameText;
    public string[] galaryNameDescText;
    public string[] loadingNameText;
    public string[] findMarkerNameText;


    void Start()
    {
        galaryNameField.text = galaryNameText[Constants._langInt];
        galaryNameDescField.text = galaryNameDescText[Constants._langInt];
        loadingNameField.text = loadingNameText[Constants._langInt];
        findMarkerNameField.text = findMarkerNameText[Constants._langInt];
        
    }

}
