using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GalleryUI : MonoBehaviour
{
    void GoBack()
    {
        SceneManager.LoadScene(0);
    }
}
