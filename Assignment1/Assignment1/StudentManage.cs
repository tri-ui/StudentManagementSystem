using System;
using System.Collections;

namespace Assignment1
{
    internal class StudentManage
    {
        private ArrayList listStudent;

        public void addStudent()
        {
            string id = null, name = null, address = null, phone = null;
            DateTime birthday = DateTime.Now;
            bool isTrue = inputInfo(ref id, ref name, ref address, ref phone, ref birthday);
            if (!isTrue)
            {
                if (listStudent == null)
                {
                    listStudent = new ArrayList();
                }
                listStudent.Add(new Student(id, name, birthday, address, phone));
                Console.WriteLine("Add Successfully");
            }
        }

        public void showAllInfo()
        {
            if (listStudent != null)
            {
                Console.WriteLine("----- List All of Student -----");
                Console.WriteLine("ID   Name        BirthDay         Address              Phone");
                foreach (Student x in listStudent)
                {
                    x.printInfo();
                }
            }
            else
            {
                Console.WriteLine("List Empty !!!");
            }
        }

        public void searchStudent()
        {
            if (listStudent == null)
            {
                Console.WriteLine("List Empty !!!");
                return;
            }
            Console.Write("Input ID: ");
            string id = Console.ReadLine();
            Student x = findStudentById(id);
            if (x != null)
            {
                Console.WriteLine("----------Your Information You Found----------");
                Console.WriteLine($"ID: {x.StuID}");
                Console.WriteLine($"Name: {x.FullName}");
                Console.WriteLine($"BirthDay: {x.StuBirthDay}");
                Console.WriteLine($"Address: {x.StuAddress}");
                Console.WriteLine($"Phone: {x.PhoneNum}");
            }
            else
            {
                Console.WriteLine($"Not Found Student with ID: {id}");
            }
        }

        public void updateStudentById()
        {
            if (listStudent == null)
            {
                Console.WriteLine("List Empty !!!");
                return;
            }
            Console.Write("Input ID: ");
            string id = Console.ReadLine();

            Student x = findStudentById(id);
            if (x != null)
            {
                string name, address, phone;
                DateTime birthday;
                inputInfoUpdate(out name, out phone, out address, out birthday);
                setValueStudent(x, name, address, phone, birthday);
                Console.WriteLine("-------------- Your New Information --------------");
                Console.WriteLine($"ID: {x.StuID}");
                Console.WriteLine($"Name: {x.FullName}");
                Console.WriteLine($"BirthDay: {x.StuBirthDay}");
                Console.WriteLine($"Address: {x.StuAddress}");
                Console.WriteLine($"Phone: {x.PhoneNum}");
            }
            else
            {
                Console.WriteLine($"Not Found Student with ID: {id}");
            }
        }

        public Student findStudentById(string id)
        {
            foreach (Student x in listStudent)
            {
                if (x.StuID.Equals(id))
                {
                    return x;
                }
            }
            return null;
        }

        public void setValueStudent(Student x, string name, string phone, string address, DateTime birthday)
        {
            x.FullName = name;
            x.StuAddress = address;
            x.PhoneNum = phone;
            x.StuBirthday = birthday;
        }

        private bool inputInfo(ref string id, ref string name, ref string address, ref string phone, ref DateTime birthday)
        {
            bool isTrue = false;
            int count = 0;
            string ans;
            do
            {
                ans = "N";
                Console.Write("ID: ");
                id = Console.ReadLine();
                if (listStudent != null)
                    isTrue = checkDuplicateID(id);
                if (isTrue)
                {
                    Console.WriteLine($"Duplicate with ID = {id}. Try again !!!");
                    Console.WriteLine("Do you want to continue (Y/N) ?");
                    ans = Console.ReadLine();
                }
            } while (!ans.ToUpper().Equals("N"));
            if (!isTrue)
            {
                Console.Write("Name: ");
                name = Console.ReadLine();
                Console.Write("Birthday(mm/DD/yyyy): ");
                birthday = DateTime.Parse(Console.ReadLine());
                Console.Write("Address: ");
                address = Console.ReadLine();
                Console.Write("Phone: ");
                phone = Console.ReadLine();
            }
            return isTrue;
        }

        private void inputInfoUpdate(out string name, out string address, out string phone, out DateTime birthday)
        {
            Console.Write("Name: ");
            name = Console.ReadLine();
            Console.Write("Birthday(mm/DD/yyyy): ");
            birthday = DateTime.Parse(Console.ReadLine());
            Console.Write("Address: ");
            address = Console.ReadLine();
            Console.Write("Phone: ");
            phone = Console.ReadLine();
        }

        private bool checkDuplicateID(string id)
        {
            foreach (Student x in listStudent)
            {
                if (x.StuID.Equals(id))
                {
                    return true;
                }
            }
            return false;
        }

        public bool checkIntInRange(int min, int max, int number)
        {
            if (number < min || number > max)
            {
                return true;
            }
            return false;
        }
    }
}