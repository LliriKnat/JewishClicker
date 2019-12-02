using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigInt
{
    public static List<int> value = new List<int>();
    public static void plus (BigInt x)
    {
        // сложение больших чисел
        for (int i = 0; i < x.value.Count; i++)
        {
            // если прибавляемое число имет больше разрядов чем то, к которому прибавляем
            if (i > value.Count)
            {
                // скидываем лишние разряды в то, к которому прибавляем
                value.Add(x.value[i]);
            }
            else 
            {
                // складываем текущие разряды
                value[i] += x.value[i];
                //если выходим из размера разряда и прибавляем к следующему излишки
                if (value[i] / 1000 > 0)
                {
                    //если разряда еще нет
                    if (i + 1 > value.Count)
                    {
                        value.Add(value[i] / 1000);
                    }
                    else
                    {
                        value[i + 1] += value[i] / 1000;
                    }
                    value[i] = value[i] % 1000;
                }
            }
           

        }
        
    }

}
