using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{

    public void takeScreenShot(){
        ScreenshotHandler.TakeScreenshot_Static(Screen.width, Screen.height);
    }



}
