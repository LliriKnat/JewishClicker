using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class testBigInt : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        {
            BigInt test1 = new BigInt();
            BigInt test2 = new BigInt();
            test1.add(1);
            print(test1.show());
            test2.add(1);
            test1.add(2);
            test2.add(2);
            test2.add(333);
            test1.plus(test2);
            print(test1.show());
            test2.add(1);
            test2.add(2);
            test2.add(3);
            print(test2.showAsLetter());
            test2.add(1);
            test2.add(1);
            test2.add(1);
            test2.add(1);
            test2.add(1);
            test2.add(1);
            test2.add(1);
            test2.add(1);
            test2.add(1);
            test2.add(1);
            test2.add(1);
            test2.add(1);
            test2.add(1);
            test2.add(1);
            test2.add(1);
            test2.add(1);
            test2.add(1);
            test2.add(1);
            test2.add(1);
            test2.add(1);
            test2.add(1);
            test2.add(1);
            test2.add(1);
            test2.add(1);
            test2.add(1);
            test2.add(1);
            test2.add(1);
            test2.add(1);
            test2.add(1);
            test2.add(1);
            test2.add(1);
            test2.add(1);
            test2.add(1);
            test2.add(1);
            test2.add(1);
            test2.add(1);
            test2.add(1);
            test2.add(1);
            test2.add(1);
            test2.add(1);
            test2.add(1);
            test2.add(1);
            test2.plus(test2);
            print(test2.show());
            print(test2.showAsLetter());
            BigInt test3 = new BigInt();
            test3.add(100);
            test3.add(200);
            test3.add(10);
            test3.plusSmall(1102203);
            print(test3.show());
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
