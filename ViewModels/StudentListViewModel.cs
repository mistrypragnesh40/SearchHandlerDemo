using SearchHandlerDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchHandlerDemo.ViewModels
{
    public class StudentListViewModel
    {
        public static List<StudentModel> Students { get; private set; } = new List<StudentModel>();

        public StudentListViewModel()
        {

            Students.Add(new StudentModel
            {
                Email = "pragnesh@test.com",
                Name = "Pragnesh Mistry",
            });

            Students.Add(new StudentModel
            {
                Email = "Jharana@test.com",
                Name = "Jharana Pandya",
            });

            Students.Add(new StudentModel
            {
                Email = "vishal@test.com",
                Name = "Vishal Makwana",
            });

            Students.Add(new StudentModel
            {
                Email = "nirav@test.com",
                Name = "Nirav Tailor",
            });

            Students.Add(new StudentModel
            {
                Email = "ashwin@test.com",
                Name = "Ashwin Patel",
            });

            Students.Add(new StudentModel
            {
                Email = "rushikesh@test.com",
                Name = "Rushikesh Mistry",
            });

            Students.Add(new StudentModel
            {
                Email = "jignesh@test.com",
                Name = "Jignesh Patel",
            });

            Students.Add(new StudentModel
            {
                Email = "viral@test.com",
                Name = "Viral Patel",
            });

            Students.Add(new StudentModel
            {
                Email = "deep@test.com",
                Name = "Deep Patel",
            });

            Students.Add(new StudentModel
            {
                Email = "Ankit@test.com",
                Name = "Ankit Thakor",
            });

            Students.Add(new StudentModel
            {
                Email = "rahul@test.com",
                Name = "Rahul Bhatia",
            });
        }
    }
}
