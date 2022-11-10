using StudentService;
using StudentServiceLib;

namespace TestLab_09
{
    [TestClass]
    public class Test_Lab09
    {



     

        [TestMethod]
        public void addFirstStudent_Success_True()
        {
            StudentServiceLib.StudentService studentService = new StudentServiceLib.StudentService();
            Student s1 = new Student() { Id=1,Name="Nguyen Khac Van",Age=20, Score=9.8 };


            bool add_st = studentService.addStudent(s1);

            int length = studentService.size();
            Assert.AreEqual(1, length);
            Assert.IsTrue(add_st);

        }


        [TestMethod]
        public void addADuplicatStudent_ShouldReturn_False()
        {
            StudentServiceLib.StudentService studentService = new StudentServiceLib.StudentService();
            Student s1 = new Student() { Id = 1, Name = "Nguyen Khac Van", Age = 20, Score = 9.8 };
            Student s2 = new Student() { Id = 1, Name = "Nguyen Khac Van", Age = 20, Score = 9.8 };

            studentService.addStudent(s2);
            bool status = studentService.addStudent(s2);
            Assert.IsFalse(status);

        }

        [TestMethod]
        public void passingNullPara_ShouldThrow_NullEx()
        {
            bool ex = false;
            StudentServiceLib.StudentService studentService = new StudentServiceLib.StudentService();
            try
            {
                studentService.addStudent(null);
            }catch(NullReferenceException e)
            {
                ex = true;
            }

            Assert.IsTrue(ex);
        }



        [TestMethod]
        public void getStudentPosition_ShouldThrow_Ex()
        {
            int position = 9;
            bool ex = false;
            StudentServiceLib.StudentService studentService = new StudentServiceLib.StudentService();
            try
            {
                studentService.getStudentAt(position);
            }catch(IndexOutOfRangeException e)
            {
                ex = true;
            }
            Assert.IsTrue(ex);

        }
    }

}