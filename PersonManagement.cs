using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using PersonManagementUI.Helpers;
using PersonManagementUI.Person;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PersonManagementUI
{
    public partial class PersonManagement : Form
    {
        private static string baseUrl = "https://localhost:44308/api/";

        private static string userToken = string.Empty;
   

     WaitFormFunctions waitform = new WaitFormFunctions(); // initialize wait form helper

        public PersonManagement(string token) // pass token for authorization through constructor parameter
        {
            InitializeComponent();
            userToken = token;
        }

        public void RetrieveData() 
        {
            try 
            {
                IEnumerable<Persons> persons = null;

                HttpClient client = new HttpClient();

                client.BaseAddress = new Uri(baseUrl);
                client.DefaultRequestHeaders.Add("Authorization","Bearer " + userToken);
                var getData = client.GetAsync("person");

                getData.Wait();

                var readData = getData.Result;

                if (readData.IsSuccessStatusCode) 
                {
                    var showData = readData.Content.ReadAsAsync<IList<Persons>>();
                    showData.Wait();

                    persons = showData.Result;
                    listViewPersons.Items.Clear();

                    foreach (var person in persons)
                    {

                        ListViewItem item = new ListViewItem(person.IdPerson.ToString());

                        item.SubItems.Add(person.Name);
                        item.SubItems.Add(person.Surname);
                        item.SubItems.Add(person.DateofBirth.ToShortDateString());
                        item.SubItems.Add(person.Phone.ToString());
                        item.SubItems.Add(person.Gender);
                        item.SubItems.Add(person.IsEmployed.ToString());
                        item.SubItems.Add(GetMaritalStatus(person.IdMaritalstatus));
                        item.SubItems.Add(person.PlaceofBirth);

                        listViewPersons.Items.Add(item);


                    }


                }
            
            }
            catch(Exception ex) {

                throw ex;
            
            }
        
        }

        private void getDetails() 
        {
            if (listViewPersons.SelectedItems.Count > 0)
            {

                foreach (ListViewItem item in listViewPersons.Items)
                {
                    if (item.Selected)
                    {

                        int id = int.Parse(item.SubItems[0].Text);
                        HttpClient client = new HttpClient();

                        client.BaseAddress = new Uri(baseUrl);
                        client.DefaultRequestHeaders.Add("Authorization", "Bearer " + userToken);
                        var getData = client.GetAsync("person/" + id);

                        getData.Wait();

                        var readData = getData.Result;

                        if (readData.IsSuccessStatusCode)
                        {
                            var showData = readData.Content.ReadAsAsync<Persons>();
                            showData.Wait();

                            var person = showData.Result;

                            txt_IdPerson.Text = person.IdPerson.ToString();
                            txt_Name.Text = person.Name;
                            txt_Surname.Text = person.Surname;
                            dtofBirth.Text = person.DateofBirth.ToShortDateString();
                            txt_Phone.Text = person.Phone.ToString();
                            if (person.Gender == "M")
                                radioButtonM.Checked = true;
                            else radioButtonF.Checked = true;
                            chk_IsEmployeed.Checked = person.IsEmployed;
                            cmb_MaritalStatus.Text = GetMaritalStatus(person.IdMaritalstatus);
                            txt_PlaceofBirth.Text = person.PlaceofBirth;

                        }

                    }
                }
            }
        }

        private string GetMaritalStatus(int id)
        {

            try
            {
                HttpClient client = new HttpClient();

                client.BaseAddress = new Uri(baseUrl);

                var getData = client.GetAsync("maritalstatus/" + id);

                getData.Wait();

                var readData = getData.Result;

                if (readData.IsSuccessStatusCode)
                {
                    var showData = readData.Content.ReadAsAsync<MaritalStatuses>();
                    showData.Wait();

                    var status = showData.Result;
                    return status.MaritalStatus;
                }

                return string.Empty;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<string> SavePerson()
        {
            var person = RetrievePersonData();

            var inputJson = JsonConvert.SerializeObject(person);

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + userToken);
                using (HttpContent inputContent = new StringContent(inputJson, Encoding.UTF8, "application/json"))
                {

                    using (HttpResponseMessage response = await client.PostAsync(baseUrl + "person", inputContent))
                    {

                        using (HttpContent content = response.Content)

                        {

                            string data = await content.ReadAsStringAsync();

                            if (data != null)
                            {
                                return data;
                            }
                        }

                    }
                }

            }

            return string.Empty;

        }

        public async Task<string> UpdatePerson(int id)
        {
            var person = RetrievePersonData();

            var inputJson = JsonConvert.SerializeObject(person);

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + userToken);
                using (HttpContent inputContent = new StringContent(inputJson, Encoding.UTF8, "application/json"))
                {

                    using (HttpResponseMessage response = await client.PutAsync(baseUrl + "person/" + id, inputContent))
                    {
                        if (response.IsSuccessStatusCode)
                        {

                            using (HttpContent content = response.Content)

                            {

                                string data = await content.ReadAsStringAsync();

                                if (data != null)
                                {
                                    return data;
                                }
                            }

                        }
                        else 
                        {
                            waitform.Close();
                            MessageBox.Show("You are not authorized to amend person", "Operation failed");
                        }
                    }
                }

            }

            return string.Empty;

        }

        public async Task<string> DeletePerson(int id)
        {


            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + userToken);
                using (HttpResponseMessage response = await client.DeleteAsync(baseUrl + "person/" + id))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        using (HttpContent content = response.Content)

                        {

                            string data = await content.ReadAsStringAsync();

                            if (data != null)
                            {
                                return data;
                            }
                        }

                    }
                    else
                    {
                        waitform.Close();
                        MessageBox.Show("You are not authorized to delete person", "Operation failed");
                    }
                }

            }

            return string.Empty;
        }

        private bool ValidateForSaving()
        {
            bool isValid = false;
            if (Regex.IsMatch(txt_Phone.Text, "^[0-9]*$"))
                isValid = true;
            return isValid;
        }

        private void ClearFields()
        { 
            txt_IdPerson.Text = string.Empty;
            txt_Name.Text = string.Empty;
            txt_Surname.Text = string.Empty;
            dtofBirth.Value = DateTime.Now;
            txt_Phone.Text = string.Empty;
            radioButtonM.Checked = false;
            radioButtonF.Checked = false;
            chk_IsEmployeed.Checked = false;
            cmb_MaritalStatus.SelectedIndex = 0;
            txt_PlaceofBirth.Text = string.Empty;
        
        }

        private Persons RetrievePersonData()
        {
            try
            {
                Persons person = new Persons();
                if(!string.IsNullOrEmpty(txt_IdPerson.Text))
                person.IdPerson = int.Parse(txt_IdPerson.Text);
                person.Name = txt_Name.Text;
                person.Surname = txt_Surname.Text;
                person.DateofBirth = dtofBirth.Value;
                person.Phone = int.Parse(txt_Phone.Text);
                person.Gender = radioButtonM.Checked ? person.Gender = "M" : person.Gender = "F";
                person.IsEmployed = chk_IsEmployeed.Checked;
                person.IdMaritalstatus = int.Parse(cmb_MaritalStatus.SelectedValue.ToString());
                person.PlaceofBirth = txt_PlaceofBirth.Text;

                return person;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private async void FillCombo()
        {
            try
            {

                IEnumerable<MaritalStatuses> maritalStatus = null;

                HttpClient client = new HttpClient();

                client.BaseAddress = new Uri(baseUrl);

                var getData = await client.GetAsync("maritalstatus");


                if (getData.IsSuccessStatusCode)
                {
                    var showData = await getData.Content.ReadAsAsync<IList<MaritalStatuses>>();

                    maritalStatus = showData;
                    cmb_MaritalStatus.Items.Clear();

                    cmb_MaritalStatus.DataSource = maritalStatus;
                    cmb_MaritalStatus.ValueMember = "Idmaritalstatus";
                    cmb_MaritalStatus.DisplayMember = "MaritalStatus";

                }

            }
            catch (Exception ex)
            {

                throw ex;

            }
        }
        private void btn_SearchPersons_Click(object sender, EventArgs e)
        {
            waitform.Show(this);
            RetrieveData();
            waitform.Close();
        }


        private void btn_Ok_Click(object sender, EventArgs e)
        {

            getDetails();

        }

        private void listViewPersons_DoubleClick(object sender, EventArgs e)
        {
            getDetails();
        }

        private async void btn_Save_Click(object sender, EventArgs e)
        {
            if (ValidateForSaving())
            {
                waitform.Show(this);
                Thread.Sleep(3000); // added to simulate a longer delay since in localhost the execution of methods is fast
                if (!string.IsNullOrEmpty(txt_IdPerson.Text)) // if person Id is null or zero add new person or else update
                {
                    await UpdatePerson(int.Parse(txt_IdPerson.Text));
                }
                else
                {
                    await SavePerson();
                }
                RetrieveData();
                ClearFields();
                waitform.Close();

            }
            else 
            {
                MessageBox.Show("The phone number should contain only numbers!!!", "Validation error");
            }

        }

        private void PersonManagement_Load(object sender, EventArgs e)
        {
            FillCombo();
        }

        private async void btn_Delete_Click(object sender, EventArgs e)
        {
            waitform.Show(this);
            Thread.Sleep(3000); // added to simulate a longer delay since in localhost the execution of methods is fast
            if (!string.IsNullOrEmpty(txt_IdPerson.Text)) // if person Id not null delete the person
            {
              await  DeletePerson(int.Parse(txt_IdPerson.Text));
            }
            RetrieveData();
            ClearFields();
            waitform.Close();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
