namespace PhoneBookApplication
{
    partial class contactdetailfom
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.searchNumber = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.phoneNumbertxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addresstxt = new System.Windows.Forms.TextBox();
            this.infoblock = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.contactBookDataSet = new PhoneBookApplication.ContactBookDataSet();
            this.contactDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactDetailsTableAdapter = new PhoneBookApplication.ContactBookDataSetTableAdapters.ContactDetailsTableAdapter();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.infoblock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contactBookDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.phoneNumberDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.contactDetailsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(14, 236);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(575, 125);
            this.dataGridView1.TabIndex = 12;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(495, 372);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 28);
            this.button3.TabIndex = 14;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(394, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 28);
            this.button1.TabIndex = 13;
            this.button1.Text = "New";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(26, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Search Number :";
            // 
            // searchNumber
            // 
            this.searchNumber.Location = new System.Drawing.Point(133, 205);
            this.searchNumber.Name = "searchNumber";
            this.searchNumber.Size = new System.Drawing.Size(293, 20);
            this.searchNumber.TabIndex = 16;
            this.searchNumber.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(495, 205);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // phoneNumbertxt
            // 
            this.phoneNumbertxt.Location = new System.Drawing.Point(121, 12);
            this.phoneNumbertxt.Name = "phoneNumbertxt";
            this.phoneNumbertxt.Size = new System.Drawing.Size(221, 20);
            this.phoneNumbertxt.TabIndex = 0;
            this.phoneNumbertxt.TextChanged += new System.EventHandler(this.phoneNumbertxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(17, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Phone Number :";
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(121, 38);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(293, 20);
            this.nametxt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(17, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Full Name :";
            // 
            // emailtxt
            // 
            this.emailtxt.Location = new System.Drawing.Point(121, 64);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(356, 20);
            this.emailtxt.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(17, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(17, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Address :";
            // 
            // addresstxt
            // 
            this.addresstxt.Location = new System.Drawing.Point(121, 90);
            this.addresstxt.Multiline = true;
            this.addresstxt.Name = "addresstxt";
            this.addresstxt.Size = new System.Drawing.Size(440, 67);
            this.addresstxt.TabIndex = 8;
            // 
            // infoblock
            // 
            this.infoblock.BackColor = System.Drawing.Color.Transparent;
            this.infoblock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.infoblock.Controls.Add(this.addresstxt);
            this.infoblock.Controls.Add(this.label4);
            this.infoblock.Controls.Add(this.label3);
            this.infoblock.Controls.Add(this.emailtxt);
            this.infoblock.Controls.Add(this.label2);
            this.infoblock.Controls.Add(this.nametxt);
            this.infoblock.Controls.Add(this.label1);
            this.infoblock.Controls.Add(this.phoneNumbertxt);
            this.infoblock.Enabled = false;
            this.infoblock.Location = new System.Drawing.Point(12, 12);
            this.infoblock.Name = "infoblock";
            this.infoblock.Size = new System.Drawing.Size(578, 169);
            this.infoblock.TabIndex = 9;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(293, 372);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(95, 28);
            this.button5.TabIndex = 18;
            this.button5.Text = "Delete";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // contactBookDataSet
            // 
            this.contactBookDataSet.DataSetName = "ContactBookDataSet";
            this.contactBookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contactDetailsBindingSource
            // 
            this.contactDetailsBindingSource.DataMember = "ContactDetails";
            this.contactDetailsBindingSource.DataSource = this.contactBookDataSet;
            // 
            // contactDetailsTableAdapter
            // 
            this.contactDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // contactdetailfom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PhoneBookApplication.Properties.Resources._3080399_contact_wallpapers;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(603, 420);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.searchNumber);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.infoblock);
            this.Name = "contactdetailfom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Book Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.infoblock.ResumeLayout(false);
            this.infoblock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contactBookDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox searchNumber;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox phoneNumbertxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addresstxt;
        private System.Windows.Forms.Panel infoblock;
        private System.Windows.Forms.Button button5;
        private ContactBookDataSet contactBookDataSet;
        private System.Windows.Forms.BindingSource contactDetailsBindingSource;
        private ContactBookDataSetTableAdapters.ContactDetailsTableAdapter contactDetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
    }
}

