using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class imageToPrint : MonoBehaviour
{


    //public Sprite _imageToPrint;

    public Texture2D tex;



    public void saveImageToPrint(){

           string name = "Ashgabat_City_AR_ImageToPrint" + System.DateTime.Now.ToString("yyyy-MM-dd_HH-mm-55") + ".png";
           NativeGallery.SaveImageToGallery(tex, "AshgabatCityAR", name);
           Debug.Log("Saved ImageToPrint.png");
    }







 
}
