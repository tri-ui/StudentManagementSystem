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
        //get, set title
        public string gsetTitle
        {
            get { return title; }
            set { title = value; }
        }
        //add content to menu
        public void addContent(string content)
        {
            listContent.Add(content);
        }
        //print
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