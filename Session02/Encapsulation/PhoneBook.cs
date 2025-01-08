using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session02.Encapsulation
{
    internal struct PhoneBook
    {
        #region Attributes
        string[] Names;
        int[] Numbers;
        int Size;
        #endregion
        #region Constructors
        public PhoneBook(int size)
        {
            Names = new String[size];
            Numbers = new int[size];
            Size = size;

        } 
        #endregion
        public void AddPerson(int Position,string Name,int Number)
        {
            if(Names is not null && Numbers is not null)
            {
                if(Position < Size)
                {
                    Names[Position] = Name;
                    Numbers[Position] = Number;
                }
            }
        }
        #region EX01 => Getter - Setter 
        public int GetMumber(string Name)
        {
            for (int i = 0; i < Names.Length; i++)
            {
                if (Names[i] == Name)
                {
                    return Numbers[i];
                }
            }
            return -1;
        }
        public void SetNumber(string Name, int NewNumber)
        {
            for (int i = 0; i < Names.Length; i++)
            {
                if (Names[i] == Name)
                {
                    Numbers[i] = NewNumber;
                    break;
                }
            }
        }

        #endregion
    }
}
