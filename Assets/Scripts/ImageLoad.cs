using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class ImageLoad : MonoBehaviour
{

    //public Image image;
    public string url;
    private Texture2D texture;
    private Sprite sprite;

    void Start()
    {
        StartCoroutine(DownloadImage(url));
    }

    IEnumerator DownloadImage(string MediaUrl)
    { 
        UnityWebRequest request = UnityWebRequestTexture.GetTexture(MediaUrl);
        yield return request.SendWebRequest();
        //if (request.isNetworkError || request.isHttpError)
        if (request.result == UnityWebRequest.Result.ConnectionError || request.result == UnityWebRequest.Result.ProtocolError)
            Debug.Log(request.error);
        else
            //YourRawImage.texture = ((DownloadHandlerTexture)request.downloadHandler).texture;
            texture = ((DownloadHandlerTexture)request.downloadHandler).texture;
            sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(texture.width/2, texture.height/2));
            GetComponent<Image>().overrideSprite = sprite;

    }
}
