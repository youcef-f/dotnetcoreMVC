using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebApplicationMVC;
using WebApplicationMVC.Models;

namespace WebApplicationMVC.Models
{

    [Route("/api/students")]
    public class StudentRestService : Controller
    {
        private MyDBContext dbService;
        public StudentRestService(MyDBContext dBContext)
        {
            this.dbService = dBContext;
        }


        [HttpGet]
        public IEnumerable<Student> list()
        {
            return dbService.Students;
        }



        [HttpPost]
        public Student Save([FromBody]Student student)
        {
            dbService.Students.Add(student);
            dbService.SaveChanges();
            return student;
        }

        [HttpGet("{studId}")]
        public Student getOnet(long studId)
        {
            return dbService.Students.FirstOrDefault(student => student.StudentId==studId);
        }



        [HttpDelete("{studId}")]
        public void deleteOne(long studId)
        {
            Student student = dbService.Students.FirstOrDefault(student => student.StudentId==studId);

             dbService.Students.Remove(student);
             dbService.SaveChanges();
        }


        [HttpPut("{studId}")]
        public Student deleteOne([FromBody]Student studentRest, long studId)
        {
            studentRest.StudentId = studId ;
             dbService.Students.Update(studentRest);
             dbService.SaveChanges();

             return studentRest;
        }


    }
}