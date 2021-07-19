using Classes.Document.Parts;
using System;


namespace Classes.Document
{
    class Document
    {
        Title title = null;
        Body body = null;
        Footer footer = null;

        void InitializeDocument()
        {
            title = new Title();
            body = new Body();
            footer = new Footer();
        }

        public Document()
        {
            InitializeDocument();                  
        }

        public void Show()
        {
            this.title.Show();
            this.body.Show();
            this.footer.Show();
        }

        public string Title
        {
            set
            {
                this.title.Content = value;
            }
        }

        public string Body
        {
            set
            {
                this.body.Content = value;
            }
        }

        public string Footer
        {
            set
            {
                this.body.Content = value;
            }
        }

    }
}
