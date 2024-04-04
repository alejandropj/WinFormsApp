using NorthwindCustomersAPJ.Models;
using NorthwindCustomersAPJ.Services;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnLoad_Click(object sender, EventArgs e)
        {
            ServiceNorthwind service = new ServiceNorthwind();
            CustomersList list = await service.GetCustomersListAsync();
            foreach(Customer c in list.Customers)
            {
                this.lstCustomers.Items.Add(c.Name);
            }
        }
    }
}
