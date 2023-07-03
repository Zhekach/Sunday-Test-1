using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ImageArray : MonoBehaviour
{
    public GameObject prefab;
    public Transform content;
    private int vectorX = 100;
     private int vectorY = -100;
    //private GameObject objects;
    [SerializeField] private GameObject[] objects = new GameObject[66];

    private void Start()
    {
        for(int i = 0; i < 66;  i++)
        {
            objects[i] = Instantiate(prefab, content);
            objects[i].GetComponent<ImageLoad>().url = objects[i].GetComponent<ImageLoad>().url + (i + 1) + ".jpg";
            objects[i].transform.position = transform.position + new Vector3(vectorX, vectorY, 0);
            if (i%2 == 0)
            {
                vectorX += 150;
            }
            else
            {

                vectorX -= 150;
                vectorY -= 150;
            }
            
        }
    }

    
   /* private void Update()
    {
        if (objects[0].GetComponent<Button>(). )
        {
            SceneManager.LoadScene(2);
        }
    }*/
    

    public void ChangePosition()
    {
        //newObject.transform.position += new Vector3(vectorX,vectorY,0); //100,150
        //newObject.transform.position = Vector3.MoveTowards(transform.position, new Vector3(vectorX, vectorY),1000);
        //newObject.transform.SetPositionAndRotation(new Vector3(vectorX, vectorY, 0),quaternion.identity);
        objects[1].transform.Translate(vectorX, vectorY, 0);
        
    }

    public void ClearPosition()
    {
        //newObject.transform.position.x = 0;
    }
}
