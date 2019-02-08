using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace PhoneBookApplication
{
    public partial class contactdetailfom : Form
    {
        //LinkedList<string> ll = new LinkedList<string>();
        ContactBookEntities viewdata = new ContactBookEntities();
        
        public contactdetailfom()
        {

            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Linklist l1 = new Linklist();

                l1.Add(phoneNumbertxt.Text);
                l1.Add(nametxt.Text);
                l1.Add(emailtxt.Text);
                l1.Add(addresstxt.Text);



                l1.Save(l1);

                //var data = new ContactBookEntities();
                //var personDetails = new ContactDetail()
                //{
                //    PhoneNumber = phoneNumbertxt.Text,
                //    Name = ll.First.Next.Value,
                //    Email = ll.First.Next.Next.Value,
                //    Address = ll.Last.Value
                //};


                //data.ContactDetails.Add(personDetails);
                //data.SaveChanges();




                viewdata.SaveChanges();
                this.contactDetailsTableAdapter.Fill(this.contactBookDataSet.ContactDetails);

            }
            catch(Exception)
            {
                MessageBox.Show("This Number is Already Exist");
           }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            infoblock.Enabled = true;
            phoneNumbertxt.Clear();
            nametxt.Clear();
            emailtxt.Clear();
            addresstxt.Clear();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'contactBookDataSet.ContactDetails' table. You can move, or remove it, as needed.
            this.contactDetailsTableAdapter.Fill(this.contactBookDataSet.ContactDetails);


            //dataGridView1.DataSource = viewdata.ContactDetails.ToList();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = viewdata.ContactDetails.ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           // dataGridView1.DataSource = viewdata.ContactDetails.Where(x => x.PhoneNumber.Contains(searchNumber.Text));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool flag = false;
            int a = 0;

            //var stud = (from s in context.ContactDetails
            //            where s.PhoneNumber == "03362076131"
            //            select s).FirstOrDefault();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (a < dataGridView1.RowCount - 1)
                {
                    if (row.Cells[0].Value.ToString() == searchNumber.Text)
                    {
                        MessageBox.Show("This Contact Is Already Exist");

                        flag = true;
                        break;
                    }
                }
                a++;
                
            }
            if (flag == false)
                MessageBox.Show("This Number is not Save in the PhoneBook Please Press New button to save the number");


        }

        private void phoneNumbertxt_TextChanged(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int rowNumber = dataGridView1.CurrentCell.RowIndex;
            string rowItem = (string)dataGridView1[0, rowNumber].Value;

            

            //foreach (DataGridViewRow row in dataGridView1.SelectedColumns)
            //{
            //    string removeData = row.Cells[0].Value.ToString();

            //}
            // 

            var context = new ContactBookEntities();
            var employer = new ContactDetail { PhoneNumber = rowItem };
            context.ContactDetails.Attach(employer);
            context.ContactDetails.Remove(employer);
            context.SaveChanges();

            dataGridView1.Rows.RemoveAt(rowNumber);

            //var context = new ContactBookEntities();
            //var phoneNumber = context.ContactDetails.Find("Anas");
            //context.ContactDetails.Remove(phoneNumber);



            //var stud = (from s in context.ContactDetails
            //            where s.PhoneNumber == "03362076131"
            //            select s).FirstOrDefault();

            //context.ContactDetails.Remove(stud);
            //context.SaveChanges();


            //var employer = new ContactDetail { PhoneNumber = "03362076131" };
            //context.ContactDetails.Attach(employer);
            //context.ContactDetails.Remove(employer);
            //context.SaveChanges();

        }
    }
}
 