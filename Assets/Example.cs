using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example : MonoBehaviour
{
    public int SomeInt;
    public int OtherInt = 7;
    // Start is called before the first frame update
    void Start()
    {
        print(MyFunction(1, 2));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int MyFunction(int a, int b)
    {
        return a + b;
        return a + b;
    }
}
