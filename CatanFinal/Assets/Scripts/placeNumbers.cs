using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class placeNumbers : MonoBehaviour
{
    //[SerializeField] GameObject point;
    public List<GameObject> numberObjects = new List<GameObject>();
    //private GameObject tmpGameObject;

    Vector3[] points = new Vector3[] {
        new Vector3(-6.7f, 3.7f, 0),
        new Vector3(-4.5f, 3.7f, 0),
        new Vector3(-2.3f, 3.7f, 0),
        new Vector3(-7.7f, 1.8f, 0),
        new Vector3(-5.5f, 1.8f, 0),
        new Vector3(-3.2f, 1.8f, 0),
        new Vector3(-1.0f, 1.8f, 0),
        new Vector3(-9.0f, 0, 0),
        new Vector3(-6.5f, 0, 0),
        new Vector3(-4.5f, 0, 0),
        new Vector3(-2.2f, 0, 0),
        new Vector3(0, 0, 0),
        new Vector3(-7.7f, -2, 0),
        new Vector3(-5.5f, -2, 0),
        new Vector3(-3.2f, -2, 0),
        new Vector3(-1.0f, -2, 0),
        new Vector3(-6.7f, -4, 0),
        //new Vector3(-2.5f, 0, 0),
        new Vector3(-2.2f, -4, 0)
    };

    void Start()
    {
        List<int> initIndexArray = Enumerable.Range(0, 18).ToList();
        //GameObject tmpGameObject;
        for (int i = 0; i < points.Length; i++)
        {
            int len = initIndexArray.Count;
            int indexMark = Random.Range(0, len);
            int index = initIndexArray[indexMark];
            GameObject mapNumber = Instantiate(numberObjects[index], points[i], Quaternion.identity);
            initIndexArray.Remove(index);
            Debug.Log("AAA");
            //tmpGameObject.name = "PointParent_" + i;
            //numberObjects.Add(tmpGameObject);
            //tmpGameObject.SetActive(false);
        }
    }
}
