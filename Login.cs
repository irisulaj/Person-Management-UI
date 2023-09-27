using Newtonsoft.Json;
using PersonManagementUI.Helpers;
using PersonManagementUI.Person;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonManagementUI
{
    public partial class Login : Form
    {
        WaitFormFunctions waitform = new WaitFormFunctions();

        static string baseUrl = "https://localhost:44308/api/";
        public Login()
        {
            InitializeComponent();
        }


        private async Task<string> LoginUser(string username, string password)
        {
            waitform.Show(this);

            UserLogin user = new UserLogin{ Username = username, Password = password};
            var inputJson = JsonConvert.SerializeObject(user);

            using (HttpClient client = new HttpClient())
            {
                using (HttpContent inputContent = new StringContent(inputJson, Encoding.UTF8, "application/json"))
                {

                    using (HttpResponseMessage response = await client.PostAsync(baseUrl + "login", inputContent))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            using (HttpContent content = response.Content)

                            {

                                string data =  content.ReadAsStringAsync().Result;

                                if (data != null)
                                {
                                    waitform.Close();
                                    return data;
                                }
                            }
                        }
                        else
                        {
                            waitform.Close();
                            MessageBox.Show("Invalid Credentials were inserted!!!", "Login failed");
                        }

                    }
                }
            }
            return string.Empty;
        }


        // Hash password

        private string EncryptPassword(string password) 
        {
            string hashPassword = BitConverter.ToString(MD5.Create().ComputeHash(Encoding.ASCII.GetBytes(password))).Replace("-", "");
            return hashPassword;
        }

        private async void btn_LogIn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_UserName.Text) && !string.IsNullOrEmpty(txt_Password.Text))
            {
                string hashPassword = EncryptPassword(txt_Password.Text);
                var token = await LoginUser(txt_UserName.Text, hashPassword);
                if (!string.IsNullOrEmpty(token.ToString()))
                {
                    PersonManagement pmanagement = new PersonManagement(token.ToString());
                    pmanagement.Show();
                }
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Please enter username and password!!!", "Login failed");
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
