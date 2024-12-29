using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class codepractice : MonoBehaviour
{
    int mycode = 5;
    string myscript = "my name is huzaifa";
    float wavy = 5.5f;
    // Start is called before the first frame update
    private void Start()
    { Debug.Log (mycode
         + myscript + wavy);        
    }
    private void Update()
    {
  Debug.Log (mycode + myscript + wavy);
    }
}
