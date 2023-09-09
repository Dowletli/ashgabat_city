using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class tutorManager : MonoBehaviour
{

    public string[] tutorText;
    public string[,] stepText = new string[3,4];
    public string[,] stepDescText = new string[3,4];
    public string[] nextButtonText;
    public string[] startButtonText;

    int step = 0;

    public Image _imageTutor;

    public Sprite[] _spritesTutor;

    public GameObject[] _leftAndRightButton;

    public TextMeshProUGUI tutorTextField;
    public TextMeshProUGUI stepTextField;
    public TextMeshProUGUI stepDescTextField;
    public TextMeshProUGUI buttonTextField;

    // Start is called before the first frame update
    void Start()
    {
        addTextToStep();
        addTextToStepDesc();
        intFirstText();   
    }

    // Update is called once per frame
    void Update()
    {
            if(step==0){
                _leftAndRightButton[0].SetActive(false);
            } 
            else if(step==3){
                _leftAndRightButton[1].SetActive(false);
            }
            else{
                _leftAndRightButton[0].SetActive(true);
                _leftAndRightButton[1].SetActive(true);
            }
        
    }

    public void decIntIndex(){
        if(step!=0){
            step--;
            intFirstText();
            addTextToStepDesc();
        }
        
    }

    public void IncIntIndex(){
        if(step!=3){
            step++;
            intFirstText();
            addTextToStepDesc();
        }
        else{
            SceneManager.LoadScene(2);
        }
    }


    void intFirstText(){
        tutorTextField.text = tutorText[Constants._langInt];
        stepTextField.text = stepText[Constants._langInt,step];
        stepDescTextField.text = stepDescText[Constants._langInt,step];  
        
        if(step!=3){
            buttonTextField.text = nextButtonText[Constants._langInt];
        }  
        else{
            buttonTextField.text = startButtonText[Constants._langInt];
        }
        
        _imageTutor.sprite =  _spritesTutor[step];  
    }

    void addTextToStep(){
        stepText [0,0] = "Ädim 1";
        stepText [0,1] = "Ädim 2";
        stepText [0,2] = "Ädim 3";
        stepText [0,3] = "Ädim 4";
        stepText [1,0] = "Шаг 1 из 4";
        stepText [1,1] = "Шаг 2 из 4";
        stepText [1,2] = "Шаг 3 из 4";
        stepText [1,3] = "Шаг 4 из 4";
        stepText [2,0] = "Step 1 of 4";
        stepText [2,1] = "Step 2 of 4";
        stepText [2,2] = "Step 3 of 4";
        stepText [2,3] = "Step 4 of 4";      
    }

    void addTextToStepDesc(){
        stepDescText [0,0] = "Ýörite AR markery tapyň";
        stepDescText [0,1] = "Podiumda goýulan markeryň ýüzüne öz akylly gurluşyňyzy tutuň";
        stepDescText [0,2] = "Aşgabat şäheriniň ajaýyp binalaryna Üsti doldurylan hakykat üsti arkaly syn ediň";
        stepDescText [0,3] = "Üsti doldurylan hakykatdan alnan, ýatdan çykmajak duýgulary öz dostlaryňyz we ýakynlaryňyz bilen paýlaşyň";
        stepDescText [1,0] = "Найдите специальный маркер";
        stepDescText [1,1] = "Наведите свое устройство на маркер расположенный на подиуме";
        stepDescText [1,2] = "Исследуйте архитектурное великолепие города Ашхабада в дополненной реальности";
        stepDescText [1,3] = "Поделитесь  незабываемыми впечатлениями от дополненной реальности со своими друзьями и близкими";
        stepDescText [2,0] = "Find a special AR marker";
        stepDescText [2,1] = "Focus your camera on AR marker located on the podium";
        stepDescText [2,2] = "Explore Ashgabat City buildings with Augmented Reality";
        stepDescText [2,3] = "Share your unforgettable AR experience with friends and family";      
    }
}
