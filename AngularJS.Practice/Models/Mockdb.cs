using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularJS.Practice.Models
{
    public class Mockdb
    {

        public Users[] Creatuserdb()
        {
            var users = new[]
            {

                new Users() {Name = "mohamed", Address = "97 moustafa kamel st flaming", Userid = 1},
                new Users() {Name = "Ali", Address = "99 moustafa kamel st flaming", Userid = 2},
                new Users() {Name = "Mhamoud", Address = "901 moustafa kamel st flaming", Userid = 3},
                new Users() {Name = "Amr", Address = "95 moustafa kamel st flaming", Userid = 4},
                new Users() {Name = "Shahin", Address = "9989 moustafa kamel st flaming", Userid = 5}



            };
            return users;
        }
        public Jobs[] Creatjobsdb()
        {
            var jobs = new[]
            {

                new Jobs() {Name = "Manager", Description = "hahahhahahah", Jobid = 1},
                new Jobs() {Name = "Accountant", Description = "hahahhahahah", Jobid = 2},
                new Jobs() {Name = "CEO", Description = "hahahhahahah", Jobid = 3},
                new Jobs() {Name = "Seales", Description = "hahahhahahah", Jobid = 4},
                new Jobs() {Name = "Office boy", Description = "hahahhahahah", Jobid = 5}



            };
            return jobs;
        }
    }




}