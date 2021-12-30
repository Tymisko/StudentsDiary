using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace StudentsDiary
{
    public partial class AddEditStudent : Form
    {
        private FileHelper<List<Student>> _fileHelper =
            new FileHelper<List<Student>>(Program.FilePath);
        private int _studentId;

        public AddEditStudent(int id = 0)
        {
            InitializeComponent();
            _studentId = id;

            if (id != 0)
            {
                var students = _fileHelper.DeserializeFromFile();
                var student = students.FirstOrDefault(s => s.Id == id);

                if (student == null)
                    throw new Exception("Brak użytkownika o podanym Id");

                Text = "Edytowanie danych ucznia";
                tbId.Text = student.Id.ToString();
                tbFirstName.Text = student.FirstName;
                tbLastName.Text = student.LastName;
                tbMath.Text = student.Math;
                tbTechnology.Text = student.Technology;
                tbPhysics.Text = student.Physics;
                tbPolishLang.Text = student.PolishLang;
                tbForeignLang.Text = student.ForeignLang;
                rtbComments.Text = student.Comments;
            }

            tbFirstName.Select();
        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            var students = _fileHelper.DeserializeFromFile();

            if (_studentId != 0)
            {
                students.RemoveAll(s => s.Id == _studentId);
            }
            else
            {
                var studentWithHighestId = students.OrderByDescending(s => s.Id).FirstOrDefault();
                
                _studentId = studentWithHighestId == null ?
                    1 : studentWithHighestId.Id + 1;
            }

            var student = new Student
            {
                Id = _studentId,
                FirstName = tbFirstName.Text,
                LastName = tbLastName.Text,
                Math = tbMath.Text,
                Technology = tbTechnology.Text,
                Physics = tbPhysics.Text,
                PolishLang = tbPolishLang.Text,
                ForeignLang = tbForeignLang.Text,
                Comments = rtbComments.Text,
            };

            students.Add(student);

            _fileHelper.SerializeToFile(students);

            Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}