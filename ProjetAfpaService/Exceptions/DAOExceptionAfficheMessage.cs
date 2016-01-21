using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetAfpaService.Exceptions
{
    class DAOExceptionAfficheMessage : DAOException
    {
        public DAOExceptionAfficheMessage():base()
        {

        }
        public DAOExceptionAfficheMessage(string message):base(message)
        {

        }
        public DAOExceptionAfficheMessage(string message, Exception Inner) : base(message, Inner)
        {

        }
    }
}
