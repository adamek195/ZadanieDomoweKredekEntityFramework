﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamBednorzZadanieDomowe4.ViewModels
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public string PatientFirstName { get; set; }
        public string PatientLastName { get; set; }
        public string OrderDish { get; set; }
    }
}
