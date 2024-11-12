using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    void Start()
    {
        int num = 0;
        
        while (num < 20)
        {
            int random = Random.Range(1, 20);
            Debug.Log(random);
            num++;
            if (num == 5){ continue;}
            if (num == 15){break;}
            Debug.Log("Alaa");

        }
    }

    
}
