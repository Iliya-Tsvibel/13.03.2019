using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Knight : IComparable<Knight>
    {
        

        public string Name { get; private set; }
        public string Birthtown { get; private set; }
        public string Title { get; private set; }

        public Knight(string name, string birthtown, string title)
        {
            Name = name;
            Birthtown = birthtown;
            Title = title;
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
                    return this.Title;
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
                    this.Title = value;
                }
            }
        }

        public override string ToString()

        {
            return $"Name is: {Name} ||| The town of the birth: {Birthtown}  The favorite spell: {Title} ";
        }

        public int CompareTo(Knight other)
        {
            return this.Name.CompareTo(other);
        }
    }
}
