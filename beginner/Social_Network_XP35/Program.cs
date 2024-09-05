
using System;
using System.Collections.Generic;

namespace Social_Network_XP35
{
    class Program
    {
        static void Main(string[] args)
        {
            string? sPostText = Console.ReadLine();

            if (sPostText is not null)
            {
                Post post = new Post(sPostText);
                post.ShowPost();
            }
            else
            {
                Console.WriteLine("No input provided.");
            }
        }
    }

    class Post
    {
        private string text;

        //NOTE - Constructor mit Null-Wert Prüfung
        public Post(string text)
        {
            this.text = text ?? throw new ArgumentNullException(nameof(text));
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
            Console.WriteLine("New post");
            Console.WriteLine(Text); 
        }
    }
}