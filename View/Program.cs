using Appliaction.Contract;
using Appliaction.Services;
using Appliaction.Mapper;

using Autofac;
using AutoMapper;
using Context;
using Infrastructure.Repositores;
using Model.Models;

namespace View
{
    internal class Program
    {
        //mohammed
        //hellllllloo
        static IStudentService StudentService;
        //IStudentRepository _studentRepository = new IStudentRepository()
      //  StudentService StudentService = ;
        static void Main(string[] args)
        {
              StudentService = new StudentService(new StudentRepository(new _Context()));
          //     var con =  AutoFact.InJect();

          //    StudentService =con.Resolve<StudentService>();
         
             
           // StudentService.Addstudent(new Student() { Name = " Abanob ", Age = 22 });

        var StdbYID =    StudentService.GetStudentbyID(2);
            Console.WriteLine(StdbYID.Name);
            StdbYID.Name = "ALi";
            StdbYID.Age = 25;

            StudentService.UpdateStudent(StdbYID);

            

            var list =  StudentService.GetSudents();
            
            foreach (var student in list)
            {
                Console.WriteLine($"Name {student.Name}  Age {student.Age}");
            }


        }
    }
}
