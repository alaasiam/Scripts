using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    void Start()
    {
        int number;
        
        while (true)
        {
            number = random.Next(1, 21);

            if (number == 5)
            {
                continue;
            }
            Console.WriteLine(number);

            if (number == 15)
            {
                break;
            }
        }
    }

    
}
