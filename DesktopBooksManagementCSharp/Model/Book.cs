using DevExpress.Xpo;
using System;

namespace DesktopBooksManagementCSharp.Model
{
    public class Book : XPObject
    {
        public Book() : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public Book(Session session) : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place here your initialization code.
        }

        string _title;
        [Size(60)]
        public string Title
        {
            get { return _title; }
            set { SetPropertyValue(nameof(Title), ref _title, value); }
        }

        string _description;
        [Size(600)]
        public string Description
        {
            get { return _description; }
            set { SetPropertyValue(nameof(Description), ref _description, value); }
        }

        DateTime _published;
        public DateTime Published
        {
            get { return _published; }
            set { SetPropertyValue(nameof(Published), ref _published, value); }
        }

        string _author;
        [Size(60)]
        public string Author
        {
            get { return _author; }
            set { SetPropertyValue(nameof(Author), ref _author, value); }
        }

        int _pages;
        public int Pages
        {
            get { return _pages; }
            set { SetPropertyValue(nameof(Pages), ref _pages, value); }
        }
    }

}