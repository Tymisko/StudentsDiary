using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace StudentsDiary
{
    public partial class Main : Form
    {
        private string _filePath = Path.Combine(Environment.CurrentDirectory, "students.txt");
        public Main()
        {
            InitializeComponent();

        }

        public void SerializeToFile(List<Student> students)
        {
            var serializer = new XmlSerializer(typeof(List<Student>));
            using (var streamWriter = new StreamWriter(_filePath))
            {
                serializer.Serialize(streamWriter, students);
                streamWriter.Close();
            }
        }

        public List<Student> DeserializeFromFile()
        {
            if (!File.Exists(_filePath))
            {
                return new List<Student>();
            }

            var serializer = new XmlSerializer(typeof(List<Student>));

            using (var streamReader = new StreamReader(_filePath))
            {
                var students = (List<Student>) serializer.Deserialize(streamReader);
                streamReader.Close();
                return students;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var addEditStudent = new AddEditStudent();
            addEditStudent.ShowDialog();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            var students = DeserializeFromFile();
            dgvDiary.DataSource = students;
        }
    }
}
