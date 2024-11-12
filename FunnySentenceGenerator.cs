using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    void Start()
    {
         string[] words = { "Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird" };
        
        string sentence = "";
        
        int index = 2;
        
        int wordCount = 0;

        while (wordCount < words.Length)
        {
              sentence += words[index] + " ";
              
              wordCount++;
              
              index = (index + 3) % words.Length;
        }

       Debug.Log("Funny Sentence: " + sentence.Trim());
    }

}
 
