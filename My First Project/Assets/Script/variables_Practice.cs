using UnityEngine;         //ye unity ki library h jahan se hum keywords import krte hain

public class variables_Practice : MonoBehaviour
{
    //number ko store krne k lie jo daraz use krte hain uska name h int
    //int = integer
    // int is called data type
    int yourinteger;


    int myInteger ;     //pehle data type btani h phir us daraz ka name rkhna h 

    private void Start()   //ye function unity me pehle se h jo k game play krte waqt aik dfa run hota h.....
    {
        myInteger = 9;   //myInteger daraz me 9 ki value dal rahe hain
        yourinteger = 55;
        Debug.Log(myInteger + "ye value start function se h");     //console ko bula rahe hain aur usko keh rahe hain k aik line likho aur usme daraaz me jo bhi h wo likho
        Debug.Log(yourinteger);
    }


    private void Update()
    {
        Debug.Log(myInteger);
    }


}



// () ki paranthesis bolte hain, isko hr function k name k bad lgate hain

// {} inko braces bolte hain, joke btate hain k function kahan se start hua aur kahan khtm hua