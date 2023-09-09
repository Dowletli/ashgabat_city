using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class buttonSpirteChanger : MonoBehaviour
{

    public int langIndex;

    public Image _image;

    public string _langName;
    public string _loadingName;

    public TextMeshProUGUI langName;
    public TextMeshProUGUI loadingName;

    public Sprite[] _sprites;

    void Update(){
        if(Constants._langInt == langIndex){
           _image.sprite =  _sprites[1];
        }
        else{
             _image.sprite =  _sprites[0];
        }
    }

    public void setIntToLang(){
        Constants._langInt =langIndex;
        langName.text = _langName;
        loadingName.text = _loadingName;
    }






}
