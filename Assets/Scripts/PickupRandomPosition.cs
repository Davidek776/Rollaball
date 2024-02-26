using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupRandomPosition : MonoBehaviour
{
    public GameObject PickupPrefab;

    // Start is called before the first frame update
    void Start()
    {
    }

   void GenerateRandomPosition(){
        float x = Random.Range(-8,8);
        float y = 0.5F;  
        float z = Random.Range(-8,8);
        Vector3 pos=new Vector3(x,y,z);
       
   }
}
