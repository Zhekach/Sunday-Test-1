using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ViewerUI : MonoBehaviour
{
    public void GoToGallery()
    {
        SceneManager.LoadScene(1);
    }
}
