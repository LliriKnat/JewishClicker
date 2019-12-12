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
    public int getLastCatNum()
    {
        return this.value[this.count() - 1];
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
            string s = this.getLastCatNum().ToString();
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

    public char compare(BigInt x)
    {
        if (this.count() > x.count())
        {
            return '>';
        }
        else if (this.count() < x.count())
        {
            return '<';
        }
        else
        {
            for (int i = this.count() - 1; i >= 0; i--)
            {
                if (this.value[i] > x.getCatNum(i))
                {
                    return '>';
                }
                else if (this.value[i] < x.getCatNum(i))
                {
                    return '<';
                }
            }
        }
        return '=';
    }

    //превращение простого числа в большое
    public BigInt transToBigInt(int x)
    {
        BigInt t = new BigInt();

        if (x >= 1)
        {
            t.add(x % 1000);
        }
        if (x >= 1000)
        {
            t.add((x % 1000000) / 1000);
        }
        if (x >= 1000000)
        {
            t.add(x / 1000000);
        }
        return t;
    }

    // сложение двух больших чисел
    public void plus(BigInt x)
    {
        // сложение больших чисел
        for (int i = 0; i < x.count(); i++)
        {
            // если прибавляемое число имет больше разрядов чем то, к которому прибавляем
            if (i >= this.count())
            {
                // скидываем лишние разряды в то, к которому прибавляем
                this.add(x.getCatNum(i));
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
    //сложение c простым интом
    public void plusSmall(int x)
    {
        this.plus(transToBigInt(x));
    }
    // разница между числами
    public void minus(BigInt x)
    {
        switch (this.compare(x))
        {
            case '>':
                int minCount = Mathf.Min(this.count(), x.count());
                for (int i = 0; i < minCount; i++)
                {
                    this.value[i] -= x.getCatNum(i);
                    if (this.value[i] < 0)
                    {
                        int j = i + 1;
                        this.value[i + 1]--;
                        this.value[i] += 1000;
                        while (j < this.count() && this.value[j] < 0)
                        {
                            this.value[j + 1]--;
                            this.value[j] += 1000;
                            j++;
                        }
                    }
                }

                int z = this.count() - 1;
                while (z >= 0 && this.value[z] == 0)
                {
                    this.value.RemoveAt(z);
                    z--;
                }

                break;
            case '<':
                BigInt temp = new BigInt();
                temp.value = x.value;
                temp.minus(this);
                this.value = temp.value;
                temp = null;
                break;
            case '=':
                this.value.Clear();
                this.add(0);
                break;
        }
    }

    // разница с int
    public void minusSmall(int x)
    {
        this.minus(transToBigInt(x));
    }


}