using BLL.interfaces;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.managers
{
    public class FacultyManager : IFacultyManager
    {
        private IFacultyDBA FacultyDBA { get; }
        public FacultyManager(IFacultyDBA facultyDBA)
        {
            FacultyDBA = facultyDBA;
        }

        public User GetUserByUsername(string username)
        {
            return FacultyDBA.GetUserByUsername(username);
        }
    }
}
