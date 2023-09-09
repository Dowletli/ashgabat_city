using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectController : MonoBehaviour
{

    public static int objectIndex = 0;

    public static int pastIndex;
    public GameObject[] _objects;

    private GameObject objects;

    void Start(){
        _objects[objectIndex].SetActive(true);
        
    }


    public void activateObjectByIndex(){

        switch(objectIndex){
            case 0: _objects[0].SetActive(true); _objects[1].SetActive(false); _objects[2].SetActive(false); _objects[3].SetActive(false); _objects[4].SetActive(false); _objects[5].SetActive(false); _objects[6].SetActive(false); _objects[7].SetActive(false);
            break;
            case 1: _objects[0].SetActive(false); _objects[1].SetActive(true); _objects[2].SetActive(false); _objects[3].SetActive(false); _objects[4].SetActive(false); _objects[5].SetActive(false); _objects[6].SetActive(false); _objects[7].SetActive(false);
            break;
            case 2: _objects[0].SetActive(false); _objects[1].SetActive(false); _objects[2].SetActive(true); _objects[3].SetActive(false); _objects[4].SetActive(false); _objects[5].SetActive(false); _objects[6].SetActive(false); _objects[7].SetActive(false);
            break;
            case 3: _objects[0].SetActive(false); _objects[1].SetActive(false); _objects[2].SetActive(false); _objects[3].SetActive(true); _objects[4].SetActive(false); _objects[5].SetActive(false); _objects[6].SetActive(false); _objects[7].SetActive(false);
            break;
            case 4: _objects[0].SetActive(false); _objects[1].SetActive(false); _objects[2].SetActive(false); _objects[3].SetActive(false); _objects[4].SetActive(true); _objects[5].SetActive(false); _objects[6].SetActive(false); _objects[7].SetActive(false);
            break;
            case 5: _objects[0].SetActive(false); _objects[1].SetActive(false); _objects[2].SetActive(false); _objects[3].SetActive(false); _objects[4].SetActive(false); _objects[5].SetActive(true); _objects[6].SetActive(false); _objects[7].SetActive(false);
            break;
            case 6: _objects[0].SetActive(false); _objects[1].SetActive(false); _objects[2].SetActive(false); _objects[3].SetActive(false); _objects[4].SetActive(false); _objects[5].SetActive(false); _objects[6].SetActive(true); _objects[7].SetActive(false);
            break;
            case 7: _objects[0].SetActive(false); _objects[1].SetActive(false); _objects[2].SetActive(false); _objects[3].SetActive(false); _objects[4].SetActive(false); _objects[5].SetActive(false); _objects[6].SetActive(false); _objects[7].SetActive(true);
            break;                
        }

    }



}
