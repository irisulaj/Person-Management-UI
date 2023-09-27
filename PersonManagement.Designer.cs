namespace PersonManagementUI
{
    partial class PersonManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelPerson = new System.Windows.Forms.Panel();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.label_Username = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.lbl_IdPerson = new System.Windows.Forms.Label();
            this.txt_IdPerson = new System.Windows.Forms.TextBox();
            this.txt_PlaceofBirth = new System.Windows.Forms.TextBox();
            this.cmb_MaritalStatus = new System.Windows.Forms.ComboBox();
            this.chk_IsEmployeed = new System.Windows.Forms.CheckBox();
            this.radioButtonF = new System.Windows.Forms.RadioButton();
            this.radioButtonM = new System.Windows.Forms.RadioButton();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.dtofBirth = new System.Windows.Forms.DateTimePicker();
            this.txt_Surname = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.lbl_PlaceofBirth = new System.Windows.Forms.Label();
            this.lbl_MaritalStatus = new System.Windows.Forms.Label();
            this.lbl_Employed = new System.Windows.Forms.Label();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.lbl_Phone = new System.Windows.Forms.Label();
            this.lbl_Dob = new System.Windows.Forms.Label();
            this.lbl_Surname = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.listViewPersons = new System.Windows.Forms.ListView();
            this.personID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.personName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.personSurname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.personDOB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.personPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.personGender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.employmentStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.personMaritalStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.personPlaceofBirth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_SearchPersons = new System.Windows.Forms.Button();
            this.panelPerson.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPerson
            // 
            this.panelPerson.Controls.Add(this.btn_Logout);
            this.panelPerson.Controls.Add(this.label_Username);
            this.panelPerson.Controls.Add(this.btn_Delete);
            this.panelPerson.Controls.Add(this.lbl_IdPerson);
            this.panelPerson.Controls.Add(this.txt_IdPerson);
            this.panelPerson.Controls.Add(this.txt_PlaceofBirth);
            this.panelPerson.Controls.Add(this.cmb_MaritalStatus);
            this.panelPerson.Controls.Add(this.chk_IsEmployeed);
            this.panelPerson.Controls.Add(this.radioButtonF);
            this.panelPerson.Controls.Add(this.radioButtonM);
            this.panelPerson.Controls.Add(this.txt_Phone);
            this.panelPerson.Controls.Add(this.dtofBirth);
            this.panelPerson.Controls.Add(this.txt_Surname);
            this.panelPerson.Controls.Add(this.txt_Name);
            this.panelPerson.Controls.Add(this.lbl_PlaceofBirth);
            this.panelPerson.Controls.Add(this.lbl_MaritalStatus);
            this.panelPerson.Controls.Add(this.lbl_Employed);
            this.panelPerson.Controls.Add(this.lbl_Gender);
            this.panelPerson.Controls.Add(this.lbl_Phone);
            this.panelPerson.Controls.Add(this.lbl_Dob);
            this.panelPerson.Controls.Add(this.lbl_Surname);
            this.panelPerson.Controls.Add(this.lbl_Name);
            this.panelPerson.Controls.Add(this.btn_Save);
            this.panelPerson.Controls.Add(this.btn_Ok);
            this.panelPerson.Controls.Add(this.listViewPersons);
            this.panelPerson.Controls.Add(this.btn_SearchPersons);
            this.panelPerson.Location = new System.Drawing.Point(1, -1);
            this.panelPerson.Name = "panelPerson";
            this.panelPerson.Size = new System.Drawing.Size(1454, 738);
            this.panelPerson.TabIndex = 0;
            // 
            // btn_Logout
            // 
            this.btn_Logout.Location = new System.Drawing.Point(1308, 463);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(104, 44);
            this.btn_Logout.TabIndex = 43;
            this.btn_Logout.Text = "Log Out";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.Location = new System.Drawing.Point(1010, 24);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(0, 16);
            this.label_Username.TabIndex = 42;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(1104, 463);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(104, 44);
            this.btn_Delete.TabIndex = 40;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // lbl_IdPerson
            // 
            this.lbl_IdPerson.AutoSize = true;
            this.lbl_IdPerson.Location = new System.Drawing.Point(69, 72);
            this.lbl_IdPerson.Name = "lbl_IdPerson";
            this.lbl_IdPerson.Size = new System.Drawing.Size(20, 16);
            this.lbl_IdPerson.TabIndex = 39;
            this.lbl_IdPerson.Text = "ID";
            // 
            // txt_IdPerson
            // 
            this.txt_IdPerson.Enabled = false;
            this.txt_IdPerson.Location = new System.Drawing.Point(109, 66);
            this.txt_IdPerson.Name = "txt_IdPerson";
            this.txt_IdPerson.Size = new System.Drawing.Size(280, 22);
            this.txt_IdPerson.TabIndex = 38;
            // 
            // txt_PlaceofBirth
            // 
            this.txt_PlaceofBirth.Location = new System.Drawing.Point(109, 419);
            this.txt_PlaceofBirth.Name = "txt_PlaceofBirth";
            this.txt_PlaceofBirth.Size = new System.Drawing.Size(280, 22);
            this.txt_PlaceofBirth.TabIndex = 37;
            // 
            // cmb_MaritalStatus
            // 
            this.cmb_MaritalStatus.FormattingEnabled = true;
            this.cmb_MaritalStatus.Location = new System.Drawing.Point(109, 379);
            this.cmb_MaritalStatus.Name = "cmb_MaritalStatus";
            this.cmb_MaritalStatus.Size = new System.Drawing.Size(280, 24);
            this.cmb_MaritalStatus.TabIndex = 36;
            // 
            // chk_IsEmployeed
            // 
            this.chk_IsEmployeed.AutoSize = true;
            this.chk_IsEmployeed.Location = new System.Drawing.Point(109, 340);
            this.chk_IsEmployeed.Name = "chk_IsEmployeed";
            this.chk_IsEmployeed.Size = new System.Drawing.Size(18, 17);
            this.chk_IsEmployeed.TabIndex = 35;
            this.chk_IsEmployeed.UseVisualStyleBackColor = true;
            // 
            // radioButtonF
            // 
            this.radioButtonF.AutoSize = true;
            this.radioButtonF.Location = new System.Drawing.Point(353, 299);
            this.radioButtonF.Name = "radioButtonF";
            this.radioButtonF.Size = new System.Drawing.Size(36, 20);
            this.radioButtonF.TabIndex = 34;
            this.radioButtonF.TabStop = true;
            this.radioButtonF.Text = "F";
            this.radioButtonF.UseVisualStyleBackColor = true;
            // 
            // radioButtonM
            // 
            this.radioButtonM.AutoSize = true;
            this.radioButtonM.Location = new System.Drawing.Point(109, 299);
            this.radioButtonM.Name = "radioButtonM";
            this.radioButtonM.Size = new System.Drawing.Size(39, 20);
            this.radioButtonM.TabIndex = 33;
            this.radioButtonM.TabStop = true;
            this.radioButtonM.Text = "M";
            this.radioButtonM.UseVisualStyleBackColor = true;
            // 
            // txt_Phone
            // 
            this.txt_Phone.Location = new System.Drawing.Point(109, 256);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(280, 22);
            this.txt_Phone.TabIndex = 32;
            // 
            // dtofBirth
            // 
            this.dtofBirth.Location = new System.Drawing.Point(109, 209);
            this.dtofBirth.Name = "dtofBirth";
            this.dtofBirth.Size = new System.Drawing.Size(280, 22);
            this.dtofBirth.TabIndex = 31;
            // 
            // txt_Surname
            // 
            this.txt_Surname.Location = new System.Drawing.Point(109, 159);
            this.txt_Surname.Name = "txt_Surname";
            this.txt_Surname.Size = new System.Drawing.Size(280, 22);
            this.txt_Surname.TabIndex = 30;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(109, 114);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(280, 22);
            this.txt_Name.TabIndex = 29;
            // 
            // lbl_PlaceofBirth
            // 
            this.lbl_PlaceofBirth.AutoSize = true;
            this.lbl_PlaceofBirth.Location = new System.Drawing.Point(5, 422);
            this.lbl_PlaceofBirth.Name = "lbl_PlaceofBirth";
            this.lbl_PlaceofBirth.Size = new System.Drawing.Size(85, 16);
            this.lbl_PlaceofBirth.TabIndex = 28;
            this.lbl_PlaceofBirth.Text = "Place of Birth";
            // 
            // lbl_MaritalStatus
            // 
            this.lbl_MaritalStatus.AutoSize = true;
            this.lbl_MaritalStatus.Location = new System.Drawing.Point(2, 382);
            this.lbl_MaritalStatus.Name = "lbl_MaritalStatus";
            this.lbl_MaritalStatus.Size = new System.Drawing.Size(87, 16);
            this.lbl_MaritalStatus.TabIndex = 27;
            this.lbl_MaritalStatus.Text = "Marital Status";
            // 
            // lbl_Employed
            // 
            this.lbl_Employed.AutoSize = true;
            this.lbl_Employed.Location = new System.Drawing.Point(7, 341);
            this.lbl_Employed.Name = "lbl_Employed";
            this.lbl_Employed.Size = new System.Drawing.Size(82, 16);
            this.lbl_Employed.TabIndex = 26;
            this.lbl_Employed.Text = "Is Employed";
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Location = new System.Drawing.Point(37, 301);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(52, 16);
            this.lbl_Gender.TabIndex = 25;
            this.lbl_Gender.Text = "Gender";
            // 
            // lbl_Phone
            // 
            this.lbl_Phone.AutoSize = true;
            this.lbl_Phone.Location = new System.Drawing.Point(43, 262);
            this.lbl_Phone.Name = "lbl_Phone";
            this.lbl_Phone.Size = new System.Drawing.Size(46, 16);
            this.lbl_Phone.TabIndex = 24;
            this.lbl_Phone.Text = "Phone";
            // 
            // lbl_Dob
            // 
            this.lbl_Dob.AutoSize = true;
            this.lbl_Dob.Location = new System.Drawing.Point(11, 215);
            this.lbl_Dob.Name = "lbl_Dob";
            this.lbl_Dob.Size = new System.Drawing.Size(79, 16);
            this.lbl_Dob.TabIndex = 23;
            this.lbl_Dob.Text = "Date of Birth";
            // 
            // lbl_Surname
            // 
            this.lbl_Surname.AutoSize = true;
            this.lbl_Surname.Location = new System.Drawing.Point(28, 162);
            this.lbl_Surname.Name = "lbl_Surname";
            this.lbl_Surname.Size = new System.Drawing.Size(61, 16);
            this.lbl_Surname.TabIndex = 22;
            this.lbl_Surname.Text = "Surname";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(45, 117);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(44, 16);
            this.lbl_Name.TabIndex = 21;
            this.lbl_Name.Text = "Name";
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(297, 463);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(104, 44);
            this.btn_Save.TabIndex = 20;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Ok
            // 
            this.btn_Ok.Location = new System.Drawing.Point(918, 465);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(131, 43);
            this.btn_Ok.TabIndex = 3;
            this.btn_Ok.Text = "OK";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // listViewPersons
            // 
            this.listViewPersons.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.personID,
            this.personName,
            this.personSurname,
            this.personDOB,
            this.personPhone,
            this.personGender,
            this.employmentStatus,
            this.personMaritalStatus,
            this.personPlaceofBirth});
            this.listViewPersons.FullRowSelect = true;
            this.listViewPersons.HideSelection = false;
            this.listViewPersons.Location = new System.Drawing.Point(427, 69);
            this.listViewPersons.MultiSelect = false;
            this.listViewPersons.Name = "listViewPersons";
            this.listViewPersons.Size = new System.Drawing.Size(985, 372);
            this.listViewPersons.TabIndex = 1;
            this.listViewPersons.UseCompatibleStateImageBehavior = false;
            this.listViewPersons.View = System.Windows.Forms.View.Details;
            this.listViewPersons.DoubleClick += new System.EventHandler(this.listViewPersons_DoubleClick);
            // 
            // personID
            // 
            this.personID.Text = "Person ID";
            this.personID.Width = 76;
            // 
            // personName
            // 
            this.personName.Text = "Name";
            this.personName.Width = 82;
            // 
            // personSurname
            // 
            this.personSurname.Text = "Surname";
            this.personSurname.Width = 97;
            // 
            // personDOB
            // 
            this.personDOB.Text = "Date of Birth";
            this.personDOB.Width = 119;
            // 
            // personPhone
            // 
            this.personPhone.Text = "Phone Number";
            this.personPhone.Width = 106;
            // 
            // personGender
            // 
            this.personGender.Text = "Gender";
            // 
            // employmentStatus
            // 
            this.employmentStatus.Text = "Is Employed";
            this.employmentStatus.Width = 88;
            // 
            // personMaritalStatus
            // 
            this.personMaritalStatus.Text = "MaritalStatus";
            this.personMaritalStatus.Width = 101;
            // 
            // personPlaceofBirth
            // 
            this.personPlaceofBirth.Text = "Place of Birth";
            this.personPlaceofBirth.Width = 99;
            // 
            // btn_SearchPersons
            // 
            this.btn_SearchPersons.Location = new System.Drawing.Point(723, 464);
            this.btn_SearchPersons.Name = "btn_SearchPersons";
            this.btn_SearchPersons.Size = new System.Drawing.Size(150, 43);
            this.btn_SearchPersons.TabIndex = 0;
            this.btn_SearchPersons.Text = "Search";
            this.btn_SearchPersons.UseVisualStyleBackColor = true;
            this.btn_SearchPersons.Click += new System.EventHandler(this.btn_SearchPersons_Click);
            // 
            // PersonManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1453, 736);
            this.Controls.Add(this.panelPerson);
            this.Name = "PersonManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonManagement";
            this.Load += new System.EventHandler(this.PersonManagement_Load);
            this.panelPerson.ResumeLayout(false);
            this.panelPerson.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPerson;
        private System.Windows.Forms.Button btn_SearchPersons;
        private System.Windows.Forms.ListView listViewPersons;
        private System.Windows.Forms.ColumnHeader personID;
        private System.Windows.Forms.ColumnHeader personName;
        private System.Windows.Forms.ColumnHeader personSurname;
        private System.Windows.Forms.ColumnHeader personDOB;
        private System.Windows.Forms.ColumnHeader personPhone;
        private System.Windows.Forms.ColumnHeader personGender;
        private System.Windows.Forms.ColumnHeader employmentStatus;
        private System.Windows.Forms.ColumnHeader personMaritalStatus;
        private System.Windows.Forms.ColumnHeader personPlaceofBirth;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Label lbl_IdPerson;
        private System.Windows.Forms.TextBox txt_IdPerson;
        private System.Windows.Forms.TextBox txt_PlaceofBirth;
        private System.Windows.Forms.ComboBox cmb_MaritalStatus;
        private System.Windows.Forms.CheckBox chk_IsEmployeed;
        private System.Windows.Forms.RadioButton radioButtonF;
        private System.Windows.Forms.RadioButton radioButtonM;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.DateTimePicker dtofBirth;
        private System.Windows.Forms.TextBox txt_Surname;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label lbl_PlaceofBirth;
        private System.Windows.Forms.Label lbl_MaritalStatus;
        private System.Windows.Forms.Label lbl_Employed;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Label lbl_Phone;
        private System.Windows.Forms.Label lbl_Dob;
        private System.Windows.Forms.Label lbl_Surname;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Label label_Username;
    }
}

