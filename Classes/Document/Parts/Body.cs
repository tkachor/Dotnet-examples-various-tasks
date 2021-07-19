using System;

namespace Classes.Document.Parts
{
    class Body
    {
        private string content;

        public string Content
        {
            private get
            {
                if (content != null)
                    return content;
                else
                    return "The body of the document is missing";
            }

            set
            {
                content = value;
            }

        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

    }
}
