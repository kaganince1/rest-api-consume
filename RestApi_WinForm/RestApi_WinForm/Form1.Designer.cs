namespace RestApi_WinForm
{
    partial class Form1
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
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.txtboxSurname = new System.Windows.Forms.TextBox();
            this.txtboxAge = new System.Windows.Forms.TextBox();
            this.txtboxLocation = new System.Windows.Forms.TextBox();
            this.btnGet = new System.Windows.Forms.Button();
            this.txtboxIdGet = new System.Windows.Forms.TextBox();
            this.txtboxDelete = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtboxUpId = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblConnStr = new System.Windows.Forms.Label();
            this.lblRootHost = new System.Windows.Forms.Label();
            this.txtboxConnStr = new System.Windows.Forms.TextBox();
            this.txtboxHostStr = new System.Windows.Forms.TextBox();
            this.lblInfoConn = new System.Windows.Forms.Label();
            this.lblInfoHost = new System.Windows.Forms.Label();
            this.dgvSonuc = new System.Windows.Forms.DataGridView();
            this.btnGetAll = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblIdGet = new System.Windows.Forms.Label();
            this.lblIdDelete = new System.Windows.Forms.Label();
            this.lblUpLocation = new System.Windows.Forms.Label();
            this.lblUpAge = new System.Windows.Forms.Label();
            this.lblUpSurname = new System.Windows.Forms.Label();
            this.lblUpName = new System.Windows.Forms.Label();
            this.txtboxUpLocation = new System.Windows.Forms.TextBox();
            this.txtboxUpAge = new System.Windows.Forms.TextBox();
            this.txtboxUpSurname = new System.Windows.Forms.TextBox();
            this.txtboxUpName = new System.Windows.Forms.TextBox();
            this.lblUpId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSonuc)).BeginInit();
            this.SuspendLayout();
            // 
            // txtboxName
            // 
            this.txtboxName.Location = new System.Drawing.Point(75, 127);
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.Size = new System.Drawing.Size(100, 20);
            this.txtboxName.TabIndex = 0;
            // 
            // txtboxSurname
            // 
            this.txtboxSurname.Location = new System.Drawing.Point(75, 153);
            this.txtboxSurname.Name = "txtboxSurname";
            this.txtboxSurname.Size = new System.Drawing.Size(100, 20);
            this.txtboxSurname.TabIndex = 1;
            // 
            // txtboxAge
            // 
            this.txtboxAge.Location = new System.Drawing.Point(75, 179);
            this.txtboxAge.Name = "txtboxAge";
            this.txtboxAge.Size = new System.Drawing.Size(100, 20);
            this.txtboxAge.TabIndex = 2;
            // 
            // txtboxLocation
            // 
            this.txtboxLocation.Location = new System.Drawing.Point(75, 205);
            this.txtboxLocation.Name = "txtboxLocation";
            this.txtboxLocation.Size = new System.Drawing.Size(100, 20);
            this.txtboxLocation.TabIndex = 3;
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(640, 172);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(75, 23);
            this.btnGet.TabIndex = 4;
            this.btnGet.Text = "Get";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // txtboxIdGet
            // 
            this.txtboxIdGet.Location = new System.Drawing.Point(534, 175);
            this.txtboxIdGet.Name = "txtboxIdGet";
            this.txtboxIdGet.Size = new System.Drawing.Size(100, 20);
            this.txtboxIdGet.TabIndex = 5;
            // 
            // txtboxDelete
            // 
            this.txtboxDelete.Location = new System.Drawing.Point(534, 204);
            this.txtboxDelete.Name = "txtboxDelete";
            this.txtboxDelete.Size = new System.Drawing.Size(100, 20);
            this.txtboxDelete.TabIndex = 8;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(640, 201);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(181, 202);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtboxUpId
            // 
            this.txtboxUpId.Location = new System.Drawing.Point(313, 102);
            this.txtboxUpId.Name = "txtboxUpId";
            this.txtboxUpId.Size = new System.Drawing.Size(100, 20);
            this.txtboxUpId.TabIndex = 11;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(419, 204);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblConnStr
            // 
            this.lblConnStr.AutoSize = true;
            this.lblConnStr.Location = new System.Drawing.Point(13, 13);
            this.lblConnStr.Name = "lblConnStr";
            this.lblConnStr.Size = new System.Drawing.Size(94, 13);
            this.lblConnStr.TabIndex = 12;
            this.lblConnStr.Text = "Connection String:";
            // 
            // lblRootHost
            // 
            this.lblRootHost.AutoSize = true;
            this.lblRootHost.Location = new System.Drawing.Point(72, 52);
            this.lblRootHost.Name = "lblRootHost";
            this.lblRootHost.Size = new System.Drawing.Size(35, 13);
            this.lblRootHost.TabIndex = 13;
            this.lblRootHost.Text = "Host: ";
            // 
            // txtboxConnStr
            // 
            this.txtboxConnStr.Location = new System.Drawing.Point(113, 10);
            this.txtboxConnStr.Name = "txtboxConnStr";
            this.txtboxConnStr.Size = new System.Drawing.Size(535, 20);
            this.txtboxConnStr.TabIndex = 14;
            // 
            // txtboxHostStr
            // 
            this.txtboxHostStr.Location = new System.Drawing.Point(113, 49);
            this.txtboxHostStr.Name = "txtboxHostStr";
            this.txtboxHostStr.Size = new System.Drawing.Size(200, 20);
            this.txtboxHostStr.TabIndex = 15;
            // 
            // lblInfoConn
            // 
            this.lblInfoConn.AutoSize = true;
            this.lblInfoConn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblInfoConn.Location = new System.Drawing.Point(110, 33);
            this.lblInfoConn.Name = "lblInfoConn";
            this.lblInfoConn.Size = new System.Drawing.Size(538, 13);
            this.lblInfoConn.TabIndex = 16;
            this.lblInfoConn.Text = "Example of connection string: Data Source = .; Initial Catalog = AdventureWorks20" +
    "17; Integrated Security = True";
            // 
            // lblInfoHost
            // 
            this.lblInfoHost.AutoSize = true;
            this.lblInfoHost.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblInfoHost.Location = new System.Drawing.Point(110, 72);
            this.lblInfoHost.Name = "lblInfoHost";
            this.lblInfoHost.Size = new System.Drawing.Size(207, 13);
            this.lblInfoHost.TabIndex = 17;
            this.lblInfoHost.Text = "Example of host:  https://localhost:44344/";
            // 
            // dgvSonuc
            // 
            this.dgvSonuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSonuc.Location = new System.Drawing.Point(6, 233);
            this.dgvSonuc.Name = "dgvSonuc";
            this.dgvSonuc.Size = new System.Drawing.Size(544, 205);
            this.dgvSonuc.TabIndex = 18;
            // 
            // btnGetAll
            // 
            this.btnGetAll.Location = new System.Drawing.Point(556, 251);
            this.btnGetAll.Name = "btnGetAll";
            this.btnGetAll.Size = new System.Drawing.Size(75, 23);
            this.btnGetAll.TabIndex = 19;
            this.btnGetAll.Text = "Get All";
            this.btnGetAll.UseVisualStyleBackColor = true;
            this.btnGetAll.Click += new System.EventHandler(this.btnGetAll_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(31, 130);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 20;
            this.lblName.Text = "Name:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(17, 156);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(52, 13);
            this.lblSurname.TabIndex = 21;
            this.lblSurname.Text = "Surname:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(39, 182);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(29, 13);
            this.lblAge.TabIndex = 22;
            this.lblAge.Text = "Age:";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(18, 207);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(51, 13);
            this.lblLocation.TabIndex = 23;
            this.lblLocation.Text = "Location:";
            // 
            // lblIdGet
            // 
            this.lblIdGet.AutoSize = true;
            this.lblIdGet.Location = new System.Drawing.Point(509, 178);
            this.lblIdGet.Name = "lblIdGet";
            this.lblIdGet.Size = new System.Drawing.Size(19, 13);
            this.lblIdGet.TabIndex = 24;
            this.lblIdGet.Text = "Id:";
            // 
            // lblIdDelete
            // 
            this.lblIdDelete.AutoSize = true;
            this.lblIdDelete.Location = new System.Drawing.Point(509, 207);
            this.lblIdDelete.Name = "lblIdDelete";
            this.lblIdDelete.Size = new System.Drawing.Size(19, 13);
            this.lblIdDelete.TabIndex = 25;
            this.lblIdDelete.Text = "Id:";
            // 
            // lblUpLocation
            // 
            this.lblUpLocation.AutoSize = true;
            this.lblUpLocation.Location = new System.Drawing.Point(256, 209);
            this.lblUpLocation.Name = "lblUpLocation";
            this.lblUpLocation.Size = new System.Drawing.Size(51, 13);
            this.lblUpLocation.TabIndex = 33;
            this.lblUpLocation.Text = "Location:";
            // 
            // lblUpAge
            // 
            this.lblUpAge.AutoSize = true;
            this.lblUpAge.Location = new System.Drawing.Point(277, 184);
            this.lblUpAge.Name = "lblUpAge";
            this.lblUpAge.Size = new System.Drawing.Size(29, 13);
            this.lblUpAge.TabIndex = 32;
            this.lblUpAge.Text = "Age:";
            // 
            // lblUpSurname
            // 
            this.lblUpSurname.AutoSize = true;
            this.lblUpSurname.Location = new System.Drawing.Point(255, 158);
            this.lblUpSurname.Name = "lblUpSurname";
            this.lblUpSurname.Size = new System.Drawing.Size(52, 13);
            this.lblUpSurname.TabIndex = 31;
            this.lblUpSurname.Text = "Surname:";
            // 
            // lblUpName
            // 
            this.lblUpName.AutoSize = true;
            this.lblUpName.Location = new System.Drawing.Point(268, 132);
            this.lblUpName.Name = "lblUpName";
            this.lblUpName.Size = new System.Drawing.Size(38, 13);
            this.lblUpName.TabIndex = 30;
            this.lblUpName.Text = "Name:";
            // 
            // txtboxUpLocation
            // 
            this.txtboxUpLocation.Location = new System.Drawing.Point(313, 207);
            this.txtboxUpLocation.Name = "txtboxUpLocation";
            this.txtboxUpLocation.Size = new System.Drawing.Size(100, 20);
            this.txtboxUpLocation.TabIndex = 29;
            // 
            // txtboxUpAge
            // 
            this.txtboxUpAge.Location = new System.Drawing.Point(313, 181);
            this.txtboxUpAge.Name = "txtboxUpAge";
            this.txtboxUpAge.Size = new System.Drawing.Size(100, 20);
            this.txtboxUpAge.TabIndex = 28;
            // 
            // txtboxUpSurname
            // 
            this.txtboxUpSurname.Location = new System.Drawing.Point(313, 155);
            this.txtboxUpSurname.Name = "txtboxUpSurname";
            this.txtboxUpSurname.Size = new System.Drawing.Size(100, 20);
            this.txtboxUpSurname.TabIndex = 27;
            // 
            // txtboxUpName
            // 
            this.txtboxUpName.Location = new System.Drawing.Point(313, 129);
            this.txtboxUpName.Name = "txtboxUpName";
            this.txtboxUpName.Size = new System.Drawing.Size(100, 20);
            this.txtboxUpName.TabIndex = 26;
            // 
            // lblUpId
            // 
            this.lblUpId.AutoSize = true;
            this.lblUpId.Location = new System.Drawing.Point(287, 105);
            this.lblUpId.Name = "lblUpId";
            this.lblUpId.Size = new System.Drawing.Size(19, 13);
            this.lblUpId.TabIndex = 34;
            this.lblUpId.Text = "Id:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 450);
            this.Controls.Add(this.lblUpId);
            this.Controls.Add(this.lblUpLocation);
            this.Controls.Add(this.lblUpAge);
            this.Controls.Add(this.lblUpSurname);
            this.Controls.Add(this.lblUpName);
            this.Controls.Add(this.txtboxUpLocation);
            this.Controls.Add(this.txtboxUpAge);
            this.Controls.Add(this.txtboxUpSurname);
            this.Controls.Add(this.txtboxUpName);
            this.Controls.Add(this.lblIdDelete);
            this.Controls.Add(this.lblIdGet);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnGetAll);
            this.Controls.Add(this.dgvSonuc);
            this.Controls.Add(this.lblInfoHost);
            this.Controls.Add(this.lblInfoConn);
            this.Controls.Add(this.txtboxHostStr);
            this.Controls.Add(this.txtboxConnStr);
            this.Controls.Add(this.lblRootHost);
            this.Controls.Add(this.lblConnStr);
            this.Controls.Add(this.txtboxUpId);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtboxDelete);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtboxIdGet);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.txtboxLocation);
            this.Controls.Add(this.txtboxAge);
            this.Controls.Add(this.txtboxSurname);
            this.Controls.Add(this.txtboxName);
            this.Name = "Form1";
            this.Text = "RestApi";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSonuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxName;
        private System.Windows.Forms.TextBox txtboxSurname;
        private System.Windows.Forms.TextBox txtboxAge;
        private System.Windows.Forms.TextBox txtboxLocation;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.TextBox txtboxIdGet;
        private System.Windows.Forms.TextBox txtboxDelete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtboxUpId;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblConnStr;
        private System.Windows.Forms.Label lblRootHost;
        private System.Windows.Forms.TextBox txtboxConnStr;
        private System.Windows.Forms.TextBox txtboxHostStr;
        private System.Windows.Forms.Label lblInfoConn;
        private System.Windows.Forms.Label lblInfoHost;
        private System.Windows.Forms.DataGridView dgvSonuc;
        private System.Windows.Forms.Button btnGetAll;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblIdGet;
        private System.Windows.Forms.Label lblIdDelete;
        private System.Windows.Forms.Label lblUpLocation;
        private System.Windows.Forms.Label lblUpAge;
        private System.Windows.Forms.Label lblUpSurname;
        private System.Windows.Forms.Label lblUpName;
        private System.Windows.Forms.TextBox txtboxUpLocation;
        private System.Windows.Forms.TextBox txtboxUpAge;
        private System.Windows.Forms.TextBox txtboxUpSurname;
        private System.Windows.Forms.TextBox txtboxUpName;
        private System.Windows.Forms.Label lblUpId;
    }
}

