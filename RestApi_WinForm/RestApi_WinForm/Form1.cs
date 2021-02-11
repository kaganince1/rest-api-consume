using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using Newtonsoft.Json;
using System.Security.Cryptography;

namespace RestApi_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnGetAll_Click(object sender, EventArgs e)
        {
            if (txtboxHostStr.Text.Length == 0 || txtboxConnStr.Text.Length == 0)
            {
                MessageBox.Show("Please enter requested textboxes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var client = new RestClient(txtboxHostStr.Text);
                var request = new RestRequest("api/Deneme?connStr=" + txtboxConnStr.Text, Method.GET);
                var result = client.Execute(request).Content;
                DataSet ds = (DataSet)JsonConvert.DeserializeObject(result, (typeof(DataSet)));
                dgvSonuc.DataSource = ds.Tables[0];
            }
        }
        private void btnGet_Click(object sender, EventArgs e)
        {
            if (txtboxHostStr.Text.Length == 0 || txtboxConnStr.Text.Length == 0 || txtboxIdGet.Text.Length == 0)
            {
                MessageBox.Show("Please enter requested textboxes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var client = new RestClient(txtboxHostStr.Text);
                var request = new RestRequest("api/Deneme/" + int.Parse(txtboxIdGet.Text) + "?connStr=" + txtboxConnStr.Text, Method.GET);
                var result = client.Execute(request).Content;
                DataSet ds = (DataSet)JsonConvert.DeserializeObject(result, (typeof(DataSet)));
                dgvSonuc.DataSource = ds.Tables[0];
                txtboxIdGet.Text = "";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtboxHostStr.Text.Length == 0 || txtboxConnStr.Text.Length == 0 || txtboxDelete.Text.Length == 0)
            {
                MessageBox.Show("Please enter requested textboxes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var client = new RestClient(txtboxHostStr.Text);
                var request = new RestRequest("api/Deneme/" + int.Parse(txtboxDelete.Text) + "?connStr=" + txtboxConnStr.Text, Method.DELETE);
                client.Execute(request);
                txtboxDelete.Text = "";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtboxHostStr.Text.Length == 0 || txtboxConnStr.Text.Length == 0 || txtboxName.Text.Length == 0 || txtboxSurname.Text.Length == 0 || txtboxAge.Text.Length == 0 || txtboxLocation.Text.Length == 0)
            {
                MessageBox.Show("Please enter requested textboxes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var client = new RestClient(txtboxHostStr.Text);
                var request = new RestRequest("api/Deneme?name=" + txtboxName.Text + "&surname=" + txtboxSurname.Text + "&age=" + int.Parse(txtboxAge.Text) + "&location=" + txtboxLocation.Text + "&connStr=" + txtboxConnStr.Text, Method.POST);
                client.Execute(request);
                txtboxName.Text = "";
                txtboxSurname.Text = "";
                txtboxAge.Text = "";
                txtboxLocation.Text = "";
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtboxUpId.Text.Length == 0 || txtboxHostStr.Text.Length == 0 || txtboxConnStr.Text.Length == 0 || txtboxUpName.Text.Length == 0 || txtboxUpSurname.Text.Length == 0 || txtboxUpAge.Text.Length == 0 || txtboxUpLocation.Text.Length == 0)
            {
                MessageBox.Show("Please enter requested textboxes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var client = new RestClient(txtboxHostStr.Text);
                var request = new RestRequest("api/Deneme/" + int.Parse(txtboxUpId.Text) + "?name=" + txtboxUpName.Text + "&surname=" + txtboxUpSurname.Text + "&age=" + int.Parse(txtboxUpAge.Text) + "&location=" + txtboxUpLocation.Text + "&connStr=" + txtboxConnStr.Text, Method.PUT);
                client.Execute(request);
                txtboxUpId.Text = "";
                txtboxUpName.Text = "";
                txtboxUpSurname.Text = "";
                txtboxUpAge.Text = "";
                txtboxUpLocation.Text = "";
            }
        }
    }
}
