﻿using Acme.Commom.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL.Entities
{
    public static class LoggingService
    {
        public static void WriteToFile(List<ILoggable> itemsLog)
        {
            foreach (var item in itemsLog)
            {
                Console.WriteLine(item.Log());
            }
        }
    }
}
