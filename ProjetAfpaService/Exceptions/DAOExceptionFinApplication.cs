using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetAfpaService.Exceptions
{
    class DAOExceptionFinApplication : DAOException
    {
        public DAOExceptionFinApplication():base()
        {

        }
        public DAOExceptionFinApplication(string message):base(message)
        {

        }
        public DAOExceptionFinApplication(string message, Exception Inner) : base(message, Inner)
        {

        }
    }
}
