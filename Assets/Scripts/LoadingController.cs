using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class LoadingController : MonoBehaviour
{

    public int sceneIndex;

    public GameObject _loadingScreen;
    public Slider _loadingSliderBar;
    //public TextMeshProUGUI loadingProgress;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadScene(){
        _loadingScreen.SetActive(true);
        //SceneManager.LoadScene(sceneIndex);

        StartCoroutine(LoadAsync());
    }

    IEnumerator LoadAsync(){
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneIndex);
        asyncLoad.allowSceneActivation = false;
        while (!asyncLoad.isDone){
            //_loadingSliderBar.value = asyncLoad.progress;
            //loadingProgress.text = _loadingSliderBar.value.ToString() + " %";
            if (_loadingSliderBar.value == 1f && !asyncLoad.allowSceneActivation){
                asyncLoad.allowSceneActivation = true;
            }
            yield return null;
        }
    }
}
