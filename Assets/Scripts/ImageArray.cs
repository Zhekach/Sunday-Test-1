using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageArray : MonoBehaviour
{
    public GameObject prefab;
    public Transform content;
    [SerializeField] private GameObject[] objects = new GameObject[66];

    private void Start()
    {
        Instantiate(prefab, new Vector2(200,700),Quaternion.identity, content);
    }
    
}
