using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class Form1 : Form
    {
        string sqlcon = @"Data Source=DESKTOP-2PT5DI6;Initial Catalog=PROJECT;Integrated Security=True";
        SqlConnection sqlConnection= null;
        public Form1()
        {
            InitializeComponent();
        }
    }
}
