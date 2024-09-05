using System;
using System.Collections.Generic;

namespace ReadWriteLine
{
    class Program
    {
        static void Main(string[] args)
        {
            string sPostText = Console.ReadLine();

            Post post = new Post(sPostText);
            post.ShowPost();
        }
    }

    class Post
    {
        private string text;

        //NOTE - Constructor
        public Post(string text)
        {
            this.text = text;
        }

        //NOTE - Property for text
        public string Text 
        { 
            get { return text; } 
            set { text = value; } 
        }

        //NOTE - changed this to use the property instead of the private field
        public void ShowPost()
        {
            Console.WriteLine(Text); 
        }
    }
}