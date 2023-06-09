using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour
{
    public Slider sliderLoad;
    public Manager GM;
    void Start()
    {
        Load();
    }
    public void Load()
    {
        float timeLoad = Random.Range(3f, 4f);
        sliderLoad.value = 0;
        sliderLoad.maxValue = timeLoad;
        StartCoroutine(LoadingCor(timeLoad, GM.NeedId));
    }
    public IEnumerator LoadingCor(float maxLoad, int idScene)
    {
        float elapsedTime = 0f;
        while (elapsedTime < maxLoad)
        {
            elapsedTime += Time.deltaTime;
            sliderLoad.value = elapsedTime;
            yield return null;
        }
        Change(idScene);
    }
    public void Change(int sceneId)
    {
        SceneManager.LoadScene(sceneId);
    }
}

