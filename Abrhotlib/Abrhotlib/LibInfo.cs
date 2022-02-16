using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abrhotlib
{
    abstract class LibInfo
    {
        public abstract String booktitle();
        public abstract String authorname();
        public abstract String bookpage();
        public abstract String readingHour();

    }

    class Oromay : LibInfo
    {
        public override String booktitle()
        {
            return "Oromay";
        }
        public override String authorname()
        {
            return "Bealu Girma";
        }
        public override String bookpage()
        {
            return "300";
        }
        public override String readingHour()
        {
            return "7-10 AM";
        }
        private string booktype = "Romance Novel"; // encapsulation process goes here
        public string Booktype                   // property to access the hidden
        {
            get { return booktype; }
        }
    }

    class Dertogada : LibInfo
    {
        public override String booktitle()
        {
            return "Dertogada";
        }
        public override String authorname()
        {
            return "Yismake Worku";
        }
        public override String bookpage()
        {
            return "220";
        }
        public override String readingHour()
        {
            return "3-7 AM";
        }
        private string booktype = "Science Fiction"; 
        public string Booktype                   
        {
            get { return booktype; }
        }
    }

    class Yotor : LibInfo
    {
        public override String booktitle()
        {
            return "Yotor";
        }
        public override String authorname()
        {
            return "Alemayehu Demeke";
        }
        public override String bookpage()
        {
            return "200";
        }
        public override String readingHour()
        {
            return "12-2 PM";
        }
        private string booktype = "Mystery"; 
        public string Booktype                   
        {
            get { return booktype; }
        }
    }

    class Zgora : LibInfo
    {
        public override String booktitle()
        {
            return "Zgora";
        }
        public override String authorname()
        {
            return "Alemayehu Wase Eshete";
        }
        public override String bookpage()
        {
            return "166";
        }
        public override String readingHour()
        {
            return "6-8 AM";
        }
        private string booktype = "Fantasy"; 
        public string Booktype                   
        {
            get { return booktype; }
        }
    }
}
