using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectIndexSetButton : MonoBehaviour
{

    public int objectSelfIndex;

    public void setSelfIndexToInsObject(){

        //objectController.pastIndex = objectController.objectIndex;

        objectController.objectIndex = objectSelfIndex;
    }


}
