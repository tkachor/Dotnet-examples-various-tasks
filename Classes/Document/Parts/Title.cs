using System;


namespace Classes.Document.Parts
{
    class Title
    {
        private string content;

        public string Content
        {
            private get
            {
                if (content != null)
                    return content;
                else
                    return "Title is missing.";
            }

            set
            {
                content = value;
            }

        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

    }
}
