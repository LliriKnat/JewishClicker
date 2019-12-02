using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testBigInt : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        BigInt test1 = new BigInt();
        BigInt test2 = new BigInt();
        int x = 123;
        test1.value.Add(x);
        test1.value.Add(2 * x);
        test1.plus(test2);
        Debug.Log("test", test1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
