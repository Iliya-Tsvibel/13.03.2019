using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Magician : IComparable<Magician>
    {
        

        public string Name { get; private set; }
        public string Birthtown { get; private set; }
        public string FavoriteSpell { get; private set; }

        public Magician(string name, string birthtown, string favoriteSpell)
        {
            Name = name;
            Birthtown = birthtown;
            FavoriteSpell = favoriteSpell;
        }
        public string this[string b]
        {
            get
            {
                if (b == "The name is")
                {
                    return this.Name;
                }
                if (b == "The BirthTown is")
                {
                    return this.Birthtown;
                }
                if (b == "The title")
                {
                    return this.FavoriteSpell;
                }

                return "Unknown";
            }
            set
            {
                if (b == "The name is")
                {
                    this.Name = value;
                }
                if (b == "The BirthTown is")
                {
                    this.Birthtown = value;
                }
                if (b == "The title")
                {
                    this.FavoriteSpell = value;
                }
            }
        }

        public override string ToString()

        {
            return $"Name is: {Name} ||| The town of the birth: {Birthtown}  The favorite spell: {FavoriteSpell} ";
        }
        





        public int CompareTo(Magician other)
        {
            return this.Name.CompareTo(other);
        }
    }
}
