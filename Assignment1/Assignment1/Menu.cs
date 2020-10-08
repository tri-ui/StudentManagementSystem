using System;
using System.Collections;

namespace Assignment1
{
    internal class Menu
    {
        private string title;

        private ArrayList listContent = new ArrayList();
        //create title
        public Menu(string title)
        {
            gsetTitle = title;
        }

        public string gsetTitle
        {
            get { return title; }
            set { title = value; }
        }

        public void addContent(string content)
        {
            listContent.Add(content);
        }

        public void showMenu()
        {
            Console.WriteLine(gsetTitle);
            foreach (string x in listContent)
            {
                Console.WriteLine(x);
            }
        }
    }
}