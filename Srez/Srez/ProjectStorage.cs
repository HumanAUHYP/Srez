using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Srez
{
    public class ProjectStorage
    {
        public List<Project> Projects { get; private set; }

        public ProjectStorage()
        {
            Projects = new List<Project>();
        }

        public void Add(Project project)
        {
            Projects.Add(project);
        }

        public void RemoveByName(string name)
        {
            Projects.RemoveAll(p => p.Name == name);
        }

        public void ReadFromFile(string path)
        {
            Projects.Clear();
            try
            {
                using (var sr = new StreamReader(path))
                {
                    string str;
                    while ((str = sr.ReadLine()) != null)
                    {
                        Projects.Add(new Project(str));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void WriteInFile(string path)
        {
            using (var sw = new StreamWriter(path, false))
            {
                foreach (var el in Projects)
                {
                    sw.WriteLine(el);
                }
            }
        }
    }
}
