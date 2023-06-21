using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class StartUI : MonoBehaviour
{
    public GameObject loadingScreen;
    public Image bar;
    private int loadTime = 500;
    public TMP_Text percentText;
    public float percent;

    private void Start()
    {
        loadingScreen.SetActive(false);
    }
    public void Go()
    {
        loadingScreen.SetActive(true);

        StartCoroutine(LoadingScreen());
    }

    IEnumerator LoadingScreen()
    {
        print(Time.time);
        for (int i = 0; i <= loadTime; i++)
        {
            yield return new WaitForSecondsRealtime(0.001f);
            bar.fillAmount = (float)i / loadTime;
            percent = (float)i/loadTime*100;
            percentText.text = (int)percent + "%";
            //print(Time.time);
        }
        print(Time.time);

        SceneManager.LoadScene(1);
    }
}
