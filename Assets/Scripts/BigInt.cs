using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigInt
{
    private List<int> value = new List<int>();
    //добавляет разряд со значением v
    public void add(int v)
    {
        this.value.Add(v);
    }
    //возвращает количество разрядов
    public int count()
    {
        return this.value.Count;
    }
    // возвращает значение указанного разряда
    public int getCatNum(int category)
    {
        return this.value[category];
    }
    // превращает разряд внутри числа в его нормальное отображение
    private string tranformToString(int x)
    {
        if (x < 0)
        {
            return "ERROR:can't tranform";
        }
        string s = "";
        if (x > 99)
        {
            s += x;
        }
        else if (x > 9)
        {
            s += "0";
            s += x;
        }
        else
        {
            s += "00";
            s += x;
        }
        return s;
    }
    // крутое отображение чисел как Кирилл и хотел
    public string showAsLetter()
    {
        int count = this.count();
        if (count <= 0)
        {
            return "error";

        }

        string s = "";
        s += this.value[count - 1];
        if (count > 1)
        {
            s += "." + tranformToString(this.value[count - 2]);
            switch (count)
            {
                case 2:
                    break;
                case 3:
                    s += "M";
                    break;
                case 4:
                    s += "B";
                    break;
                case 5:
                    s += "T";
                    break;
                case 6:
                    s += "Q";
                    break;
                default:
                    s += "A LOT OF SHIT IF HAPPENING HERE";
                    break;
            }
        }

        return s;

    }
    // просто отображает все число
    public string show()
    {
        if (this.count() > 0)
        {
            string s = this.value[this.count() - 1].ToString();
            for (int i = this.count() - 2; i >= 0; i--)
            {
                s += tranformToString(this.value[i]);
            }
            return s;
        }
        else
        {
            return "error";
        }

    }
    // сложение двух больших чисел
    public void plus(BigInt x)
    {
        // сложение больших чисел
        for (int i = 0; i < x.count(); i++)
        {
            // если прибавляемое число имет больше разрядов чем то, к которому прибавляем
            if (i >= this.value.Count)
            {
                // скидываем лишние разряды в то, к которому прибавляем
                this.value.Add(x.getCatNum(i));
            }
            else
            {
                // складываем текущие разряды
                this.value[i] += x.getCatNum(i);
                //если выходим из размера разряда и прибавляем к следующему излишки
                if (this.value[i] / 1000 > 0)
                {
                    //если разряда еще нет
                    if (i + 1 >= value.Count)
                    {
                        this.value.Add(value[i] / 1000);
                    }
                    else
                    {
                        this.value[i + 1] += value[i] / 1000;
                    }
                    this.value[i] = value[i] % 1000;
                }
            }


        }

    }

}
