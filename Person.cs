using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR
{
    public class Person
    {
        private string fname, lname, email,contactno;
        private static int cnt = 0;

        public Person()
        {
            fname = "Kritika";
            lname = "Verma";
            email = "qwe@gmail.com";
            contactno = "7876556774";
            cnt++;
        }

        public Person(string fname,string lname,string email,string contactno)
        {
            this.fname = fname;
            this.lname = lname;
            this.email = email;
            this.contactno = contactno;
            cnt++;
        }

        public static int Getcount()
        {
            return cnt;
        }

        public string Getfname()
        {
            return fname;
        }

        public string Getlname()
        {
            return lname;
        }

        public string Getemailid()
        {
            return email;
        }

        public string Getcontactno()
        {
            return contactno;
        }

        public string Setfname(string fn)
        {
            fname = fn;
            return fname;
        }

        public string Setlname(string ln)
        {
            lname = ln;
            return lname;
        }

        public string Setemail(string em)
        {
            email = em;
            return email;
        }

        public string Setcontact(string cno)
        {
            contactno = cno;
            return contactno;
        }


    }
}
