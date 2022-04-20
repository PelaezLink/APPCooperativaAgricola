﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarongISW.BusinessLogic.Services
{
    class ServiceException : Exception
    {
        public ServiceException()
        {
        }

        public ServiceException(string message): base(message)
        {
        }

        public ServiceException(string message, Exception inner): base(message, inner)
        {
        }

    }
}
