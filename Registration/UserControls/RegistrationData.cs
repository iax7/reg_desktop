﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registration
{
    public partial class RegistrationData : UserControl
    {
        public RegistrationData()
        {
            InitializeComponent();
            grdGuests.AutoGenerateColumns = false;
            grdFood.AutoGenerateColumns = false;
        }
    }
}
