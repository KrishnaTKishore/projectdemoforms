using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace projectdemoforms
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dell\source\repos\projecttrial\projecttrial\Database1.mdf;Integrated Security = True");
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Show_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            
                int dis = 0, tim = 0, sum = 0, temp = 1;
                double sum1;
               
                int[] a = new int[100];
               
                    Console.WriteLine("Enter the distance travelled");
                    dis = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter the time of cab booking in 24 hr format");
                    tim = Convert.ToInt32(Console.ReadLine());
                    if (dis <= 3 && dis > 0)

                        sum = 50;
                    else if (dis > 3)
                        sum = 50 + ((dis - 3) * 20);
                    else
                    { Console.WriteLine("Wrong input");Close(); }
                    if ((tim > 7 && tim < 9) || (tim > 18 && tim < 21))
                    {
                        sum1 = sum + sum * 0.5;
                        Console.WriteLine("the sum amt was {0} but due to high demand the price has risen to {1}", sum, sum1);
                    }
                    else
                        Console.WriteLine("the total ride amount is " + sum);
                  


                    a[temp] = sum;
                    temp++;
               




            
            cmd.CommandText = "Insert into Table1 values('" + Distance_travelled.Text + "','" + Time_of_booking.Text + "','" + sum+ "')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("saved");
        }
    }
}
