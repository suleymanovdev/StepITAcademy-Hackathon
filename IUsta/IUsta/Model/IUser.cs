using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUsta.Model
{
    internal interface IUser
    {
        int ID { get; set; }
        string Name { get; set; }
        string Surname { get; set; }
        string Email {get; set; }
        string Photo { get; set; }
        string Nickname { get; set; }
        string Password { get; set; }
    }
}
