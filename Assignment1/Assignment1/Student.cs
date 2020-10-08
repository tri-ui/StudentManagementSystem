using System;

namespace Assignment1
{
    internal class Student
    {
        private string id, name, address, phone;
        private DateTime birthday;

        public Student()
        {
        }

        public Student(string id, string name, DateTime birthday, string address, string phone)
        {
            StuID = id;
            FullName = name;
            PhoneNum = phone;
            StuBirthday = birthday;
            StuAddress = address;
        }

        public string StuID
        {
            get { return id; }
            set { id = value; }
        }

        public string FullName
        {
            get { return name; }
            set { name = value; }
        }

        public string StuAddress
        {
            get { return address; }
            set { address = value; }
        }

        public string PhoneNum
        {
            get { return phone; }
            set { phone = value; }
        }

        public DateTime StuBirthday
        {
            set { birthday = value; }
        }

        public string StuBirthDay
        {
            get { return String.Format("{0:MM/dd/yyyy}", birthday); }
        }

        public void printInfo()
        {
            {
                Console.WriteLine($"{StuID}    {FullName}       {StuBirthDay}      {StuAddress}  {PhoneNum} ");
            }
        }
    }
}