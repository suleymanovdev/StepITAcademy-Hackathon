using IUsta.Data;
using IUsta.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace IUsta
{
    public partial class Admin : Form
    {
        DataContext dataContext;

        public Admin()
        {
            InitializeComponent();
            dataContext = new DataContext();
            foreach (Order order in dataContext.orders)
            {
                listBox1.Items.Add(order);
            }
            foreach (Master master in dataContext.masters)
            {
                listBox2.Items.Add(master);
            }
            foreach (Customer customer in dataContext.customers)
            {
                listBox3.Items.Add(customer);
            }
        }
    }
}
