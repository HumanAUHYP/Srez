using System;
using System.Collections.Generic;
using System.Text;

namespace Srez
{
    public class Project
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }

        public Project() { }

        public Project(string str)
        {
            var data = str.Split(';');
            Name = data[0];
            Description = data[1];
            Url = data[2];
        }

        public override string ToString()
        {
            return $"{Name};{Description};{Url}";
        }
    }
}
