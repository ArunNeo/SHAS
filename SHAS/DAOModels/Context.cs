﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SHAS.DAOModels
{
    public class Context : DbContext
    {
        public Context()
            : base("SHAS")
        {

        }
        public DbSet<UserLoginDAO> UserLoginDAO {get ;set;}

    }
}