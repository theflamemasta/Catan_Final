using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addPieces : MonoBehaviour
{
    public GameObject City;
    public GameObject Road;
    public GameObject Settlement;
    public GameObject ResourcesArea;



    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 15; i++)
        {
            GameObject newRoad = Instantiate(Road, new Vector3((-50+15*i), 15, 0), Quaternion.identity);
            //GameObject newRoad = Instantiate(Road, new Vector3(-50, -50, 0), Quaternion.identity);
            newRoad.transform.SetParent(ResourcesArea.transform, false);
        }
        
        for (int i = 0; i < 5; i++)
        {
            GameObject newSettlement = Instantiate(Settlement, new Vector3((-50+40*i), -15, 0), Quaternion.identity);
            //GameObject newSettlement= Instantiate(Settlement, new Vector3(0, -50, 0), Quaternion.identity);
            newSettlement.transform.SetParent(ResourcesArea.transform, false);
        }

        for (int i = 0; i < 4; i++)
        {
            GameObject newCity = Instantiate(City, new Vector3((-45+50*i), -45, 0), Quaternion.identity);
            //GameObject newCity = Instantiate(City, new Vector3(50, -45, 0), Quaternion.identity);
            newCity.transform.SetParent(ResourcesArea.transform, false);
        }      
        
    }

    


}
