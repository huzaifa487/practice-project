
using UnityEngine;

public class Integer_Daraz : MonoBehaviour
{
    int ourcomputer;
    // Start is called before the first frame update
    void Start()
    {
        
        ourcomputer = 10;
        Debug.Log(ourcomputer +"start function");
        
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(ourcomputer+ "update function");        
    }
}
