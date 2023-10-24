using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

internal class StringManager
{
    private Stack<char> stack = new Stack<char>();

    public string Reverse(string sm)
    {
        return Reverse(sm,false );
    }

    public string Reverse(string sm, bool PreserveCaseLocation)
    {
        stack.Clear();
        Num = sm;
        if (PreserveCaseLocation == false)
        {
            foreach (char c in sm)
            {
                stack.Push(c);
            }
        }
        else
        {
            int revIndex = sm.Length - 1;
            for (int i = 0; i < sm.Length; i++)
            {
                if (char.IsUpper(sm[revIndex]))
                {
                    stack.Push(char.ToUpper(sm[i]));
                }
                else
                {
                    stack.Push(char.ToLower(sm[i]));
                }
                revIndex--;
            }
        }
        return new string(stack.ToArray());
    }

    public bool Symmetric(string sm)
    {
        Num = sm;
        string reversedStr = Reverse(sm);
        return sm==reversedStr;
    }
    public String Num = "";
    public override string ToString()
    {
        int ASCII_NO = 0;
        string myString = "";
        foreach (char c in Num)
        {
            ASCII_NO += (int)c;
        }
        string nbr = "";
        foreach (char c in ASCII_NO.ToString()) {
            if(c > 0)
            switch (c)
            {
                case '0':
                    nbr += "Zero";
                    break;
                case '1':
                    nbr += "One ";
                    break;
                case '2':
                    nbr += "Two ";
                    break;
                case '3':
                    nbr += "Three ";
                    break;
                case '4':
                    nbr += "Four ";
                    break;
                case '5':
                    nbr += "Five ";
                    break;
                case '6':
                    nbr += "Six ";
                    break;
                case '7':
                    nbr += "Seven ";
                    break;
                case '8':
                    nbr += "Eight ";
                    break;
                case '9':
                    nbr += "Nine ";
                    break;
            }
            if (nbr!= string.Empty) 
            {
                return nbr;
            }
        }
        
        return "Negative One";
    }
}
