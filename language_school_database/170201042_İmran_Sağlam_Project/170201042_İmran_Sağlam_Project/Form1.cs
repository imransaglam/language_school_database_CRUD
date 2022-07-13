using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _170201042_İmran_Sağlam_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'school_DataSet1.Take_Course' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.take_CourseTableAdapter.Fill(this.school_DataSet1.Take_Course);
            // TODO: Bu kod satırı 'school_DataSet1.School' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.schoolTableAdapter.Fill(this.school_DataSet1.School);
            // TODO: Bu kod satırı 'school_DataSet1.Participant' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.participantTableAdapter.Fill(this.school_DataSet1.Participant);
            // TODO: Bu kod satırı 'school_DataSet1.Client' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.clientTableAdapter.Fill(this.school_DataSet1.Client);
            // TODO: Bu kod satırı 'school_DataSet1.Course' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.courseTableAdapter.Fill(this.school_DataSet1.Course);
            // TODO: Bu kod satırı 'school_DataSet1.Teacher' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.teacherTableAdapter.Fill(this.school_DataSet1.Teacher);

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int School_ID;
            int.TryParse(comboBox1.SelectedValue.ToString(), out School_ID);
            this.teacherTableAdapter.Insert(textBox1.Text, textBox2.Text, textBox3.Text, School_ID);
            this.teacherTableAdapter.Fill(this.school_DataSet1.Teacher);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.schoolTableAdapter.InsertQuery(textBox28.Text, textBox29.Text);
            this.schoolTableAdapter.Fill(this.school_DataSet1.School);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int  School_ID,Teacher_ID;
            int.TryParse(textBox4.Text, out Teacher_ID);
            int.TryParse(comboBox2.SelectedValue.ToString(), out School_ID);
            this.teacherTableAdapter.UpdateQuery(textBox5.Text, textBox6.Text, textBox7.Text,School_ID ,Teacher_ID);
            this.teacherTableAdapter.Fill(this.school_DataSet1.Teacher);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int School_ID;
            int.TryParse(textBox4.Text, out School_ID);
            textBox5.Text = this.teacherTableAdapter.ScalarQuery1(School_ID);
            textBox6.Text = this.teacherTableAdapter.ScalarQuery2(School_ID);
            textBox7.Text = this.teacherTableAdapter.ScalarQuery3(School_ID).ToString();
            comboBox2.SelectedValue = this.teacherTableAdapter.ScalarQuery4(School_ID);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int Teacher_ID;
            int.TryParse(textBox4.Text, out Teacher_ID);
            this.teacherTableAdapter.DeleteQuery(Teacher_ID);
            this.teacherTableAdapter.Fill(this.school_DataSet1.Teacher);

            this.courseTableAdapter.Update_Delete_Query(Teacher_ID);
            this.courseTableAdapter.Fill(this.school_DataSet1.Course);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int Teacher_ID;
            int.TryParse(comboBox3.SelectedValue.ToString(), out Teacher_ID);
            int.TryParse(comboBox9.SelectedValue.ToString(), out Teacher_ID);

            this.courseTableAdapter.InsertQuery(textBox8.Text, textBox9.Text, textBox10.Text, Teacher_ID);
            this.courseTableAdapter.Fill(this.school_DataSet1.Course);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int School_ID;
            int.TryParse(comboBox5.SelectedValue.ToString(), out School_ID);
            this.clientTableAdapter.InsertQuery(textBox15.Text, textBox16.Text, textBox17.Text,School_ID);
            this.clientTableAdapter.Fill(this.school_DataSet1.Client);

        }

        private void button13_Click(object sender, EventArgs e)
        {
            int Client_ID;
            int.TryParse(comboBox7.SelectedValue.ToString(), out Client_ID);
            this.participantTableAdapter.InsertQuery(textBox22.Text, textBox23.Text, Client_ID);
            this.participantTableAdapter.Fill(this.school_DataSet1.Participant);

        }

        private void button21_Click(object sender, EventArgs e)
        {
            int Course_ID, Participant_ID;
            int.TryParse(textBox33.Text, out Course_ID);
            int.TryParse(textBox34.Text, out Participant_ID);

            this.take_CourseTableAdapter.InsertQuery(Course_ID, Participant_ID);
            this.take_CourseTableAdapter.Fill(this.school_DataSet1.Take_Course);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int Teacher_ID;
            int.TryParse(textBox11.Text, out Teacher_ID);
            textBox12.Text = this.courseTableAdapter.ScalarQuery1(Teacher_ID);
            textBox13.Text = this.courseTableAdapter.ScalarQuery2(Teacher_ID);
            textBox14.Text = this.courseTableAdapter.ScalarQuery3(Teacher_ID).ToString();
            comboBox4.SelectedValue = this.courseTableAdapter.ScalarQuery4(Teacher_ID);

        }

        private void button10_Click(object sender, EventArgs e)
        {
            int School_ID;
            int.TryParse(textBox18.Text, out School_ID);
            textBox19.Text = this.clientTableAdapter.ScalarQuery1(School_ID);
            textBox20.Text = this.clientTableAdapter.ScalarQuery2(School_ID);
            textBox21.Text = this.clientTableAdapter.ScalarQuery3(School_ID).ToString();
            comboBox6.SelectedValue = this.clientTableAdapter.ScalarQuery4(School_ID);


        }

        private void button14_Click(object sender, EventArgs e)
        {
            int participant_ID;
            int.TryParse(textBox24.Text, out participant_ID);
            textBox25.Text = this.participantTableAdapter.ScalarQuery1(participant_ID);
            textBox26.Text = this.participantTableAdapter.ScalarQuery2(participant_ID);
           
            comboBox8.SelectedValue = this.participantTableAdapter.ScalarQuery3(participant_ID);

        }

        private void button18_Click(object sender, EventArgs e)
        {
            int School_ID;
            int.TryParse(textBox30.Text, out School_ID);
            textBox31.Text = this.schoolTableAdapter.ScalarQuery1(School_ID);
            textBox32.Text = this.schoolTableAdapter.ScalarQuery2(School_ID);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {
            int TC_ID;
            int.TryParse(textBox35.Text, out TC_ID);
            textBox36.Text = this.take_CourseTableAdapter.ScalarQuery1(TC_ID).ToString();
            textBox37.Text = this.take_CourseTableAdapter.ScalarQuery(TC_ID).ToString();

        }

        private void button19_Click(object sender, EventArgs e)
        {
             int School_ID;
            int.TryParse(textBox30.Text, out School_ID);
            this.schoolTableAdapter.UpdateQuery(textBox31.Text,textBox32.Text,School_ID);
            this.schoolTableAdapter.Fill(this.school_DataSet1.School);


        }

        private void button7_Click(object sender, EventArgs e)
        {
            int Teacher_ID,Course_ID;
            int.TryParse(textBox11.Text, out Course_ID);
            int.TryParse(comboBox4.SelectedValue.ToString(), out Teacher_ID);
            int.TryParse(comboBox10.SelectedValue.ToString(), out Teacher_ID);

            this.courseTableAdapter.UpdateQuery(textBox12.Text, textBox13.Text, textBox14.Text, Teacher_ID,Course_ID);
            this.courseTableAdapter.Fill(this.school_DataSet1.Course);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int Client_ID,School_ID;
            int.TryParse(textBox18.Text, out Client_ID);
            int.TryParse(comboBox6.SelectedValue.ToString(), out School_ID);
            this.clientTableAdapter.UpdateQuery(textBox19.Text, textBox20.Text, textBox21.Text, School_ID,Client_ID);
            this.clientTableAdapter.Fill(this.school_DataSet1.Client);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int Client_ID,Participant_ID;
            int.TryParse(textBox24.Text, out Participant_ID);
            int.TryParse(comboBox8.SelectedValue.ToString(), out Client_ID);
            this.participantTableAdapter.UpdateQuery(textBox25.Text, textBox26.Text, Client_ID,Participant_ID);
            this.participantTableAdapter.Fill(this.school_DataSet1.Participant);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            int Course_ID, Participant_ID,Take_Course_ID;
            int.TryParse(textBox36.Text, out Course_ID);
            int.TryParse(textBox37.Text, out Participant_ID);
            int.TryParse(textBox35.Text, out Take_Course_ID);
            this.take_CourseTableAdapter.UpdateQuery(Course_ID, Participant_ID, Take_Course_ID);
            this.take_CourseTableAdapter.Fill(this.school_DataSet1.Take_Course);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            int Take_Course_ID;
            int.TryParse(textBox35.Text, out Take_Course_ID);
            this.take_CourseTableAdapter.DeleteQuery(Take_Course_ID);
            this.take_CourseTableAdapter.Fill(this.school_DataSet1.Take_Course);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int Course_ID;
            int.TryParse(textBox11.Text, out Course_ID);
            this.courseTableAdapter.DeleteQuery(Course_ID);
            this.courseTableAdapter.Fill(this.school_DataSet1.Course);

            this.take_CourseTableAdapter.Update_Delete_Query1(Course_ID);
            this.take_CourseTableAdapter.Fill(this.school_DataSet1.Take_Course);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int Client_ID;
            int.TryParse(textBox18.Text, out Client_ID);
            this.clientTableAdapter.DeleteQuery(Client_ID);
            this.clientTableAdapter.Fill(this.school_DataSet1.Client);

            this.participantTableAdapter.Update_Delete_Query(Client_ID);
            this.participantTableAdapter.Fill(this.school_DataSet1.Participant);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            int Participant_ID;
            int.TryParse(textBox24.Text, out Participant_ID);
            this.participantTableAdapter.DeleteQuery(Participant_ID);
            this.participantTableAdapter.Fill(this.school_DataSet1.Participant);

            this.take_CourseTableAdapter.Update_Delete_Query2(Participant_ID);
            this.take_CourseTableAdapter.Fill(this.school_DataSet1.Take_Course);



        }

        private void button20_Click(object sender, EventArgs e)
        {
            int School_ID;
            int.TryParse(textBox30.Text, out School_ID);
            this.schoolTableAdapter.DeleteQuery(School_ID);
            this.schoolTableAdapter.Fill(this.school_DataSet1.School);

            this.teacherTableAdapter.Update_Delete_Query(School_ID);
            this.teacherTableAdapter.Fill(this.school_DataSet1.Teacher);

            this.clientTableAdapter.Update_Delete_Query(School_ID);
            this.clientTableAdapter.Fill(this.school_DataSet1.Client);
        }
    } 
}
