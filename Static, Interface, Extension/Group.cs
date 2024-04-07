using Static__Interface__Extension.HelperExtensıon;

namespace Static__Interface__Extension
{
    internal class Group
    {
        public static Group[] Groups = new Group[0];
        public static int GroupCount=0;
        public  int GroupID;
        public string GroupName;
        public static Student[] Student = new Student[0];

        public Group(string groupname)
        {
            GroupName = groupname;
            Student=new Student[0];
            Groups=new Group[0];
            GroupID = GroupCount;
            GroupCount++;
        }
        public void GetGroupInfo()
        {
            Console.WriteLine($"{GroupID}  {GroupName}");
            foreach (var student in Student)
            {
                student.GetInfo();
            }
        }
        public void AddStudent(Student student)
        {
            Array.Resize(ref Student, Student.Length-1);
            Student[Student.Length-1]=student;
        } 
        public void AddGroup(Group group) 
        {
            Array.Resize(ref Groups, Groups.Length - 1);
            Groups[Groups.Length - 1] = group;
        }
      public Student GetStudent(int id)
        {
        for (int i = 0; i < Student.Length; i++) 
            {
                if (i==id)
                {
                    return Student[i];
                }
            }
            return null;
        }

        public void Search(string serach) {
         foreach (var student in Student) 
            {
                if (serach.Capitalaize()==student.Name.Capitalaize()&&serach.Capitalaize()==student.Surname.Capitalaize())
                {
                    Console.WriteLine($"{student.Name} {student.Surname}");
                }
            }
        }

        public void ShowStudent() 
        {
            foreach (var student in Student) 
            {
                student.GetInfo();
            }
        }


        public override string ToString()
        {
            string a;
            return a =$"{GroupID}  {GroupName}  {Student.Length}";
        }


        public static void RemoveGroup(int id)
        {
            Group[] newArr = new Group[Groups.Length-1];
            for (int i = 0; i < Groups.Length; i++)
            {
                if (Groups[i].GroupID!=id)
                {
                    newArr[j] = Groups[i]
                        j++;
                }
            }
            newArr = Groups;
        }


    }
}
