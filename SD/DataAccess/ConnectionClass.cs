﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace DataAccess
{
    public class ConnectionClass
    {
        public  PicDoEntities entities { get; set; }

        public ConnectionClass()
        {
            entities = new PicDoEntities();
        }
    }
}
