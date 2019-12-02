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
            Console.WriteLine(test1.show());
            test2.add(1);
            test1.add(2);
            test2.add(2);
            test2.add(333);
            test1.plus(test2);
            Console.WriteLine(test1.show());
            test2.add(1);
            test2.add(2);
            test2.add(3);
            Console.WriteLine(test2.showAsLetter());
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
            Console.WriteLine(test2.show());
            Console.WriteLine(test2.showAsLetter());
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
