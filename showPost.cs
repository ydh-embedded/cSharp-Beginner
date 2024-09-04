using System;
using System.Collections.Generic;

namespace Code_Coach_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string postText = Console.ReadLine();

            Post post = new Post(postText);
            post.ShowPost();
        }
    }

    class Post
    {
        private string text;

        // Constructor
        public Post(string text)
        {
            this.text = text;
        }

        // Property for text
        public string Text
        {
            get { return text; }
            set { text = value; }
        }

        public void ShowPost()
        {
            Console.WriteLine(text);
        }
    }
}