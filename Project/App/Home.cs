using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace App
{
    public partial class Home : Form
    {
        SqlConnection sqlConnection = null;
        string connection = "Data Source=DESKTOP-2PT5DI6;Initial Catalog=PROJECT;Integrated Security=True";
        public Home()
        {
            InitializeComponent();
        }

    }
}
