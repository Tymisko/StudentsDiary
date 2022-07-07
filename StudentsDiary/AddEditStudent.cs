using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace StudentsDiary
{
    public partial class AddEditStudent : Form
    {
        private readonly List<Group> _groups;

        private Student _student;
        private int _studentId;

        private readonly FileHelper<List<Student>> _fileHelper =
            new FileHelper<List<Student>>(Program.FilePath);

        public AddEditStudent(int id = 0)
        {
            InitializeComponent();
            
            _groups = GroupsHelper.GetGroups("Brak");
            InitGroupsCombobox();

            _studentId = id;
            GetStudentData();

            tbFirstName.Select();
        }

        private void InitGroupsCombobox()
        {
            cmbGroup.DataSource = _groups;
            cmbGroup.DisplayMember = "Name";
            cmbGroup.ValueMember = "Id";
        }

        private void GetStudentData()
        {
            if (_studentId == 0) return;
            Text = "Edytowanie danych ucznia";

            var students = _fileHelper.DeserializeFromFile();
            _student = students.FirstOrDefault(s => s.Id == _studentId);

            if (_student == null)
                throw new Exception("Brak użytkownika o podanym Id");

            FillTextBoxes();
        }

        private void FillTextBoxes()
        {
            tbId.Text = _student.Id.ToString();
            tbFirstName.Text = _student.FirstName;
            tbLastName.Text = _student.LastName;
            tbMath.Text = _student.Math;
            tbTechnology.Text = _student.Technology;
            tbPhysics.Text = _student.Physics;
            tbPolishLang.Text = _student.PolishLang;
            tbForeignLang.Text = _student.ForeignLang;
            rtbComments.Text = _student.Comments;
            chbAdditionalClasses.Checked = _student.AdditionalClasses;
            cmbGroup.SelectedItem = _groups.FirstOrDefault(g => g.Id == _student.Group.Id);
        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            var students = _fileHelper.DeserializeFromFile();

            if (_studentId != 0)
                students.RemoveAll(s => s.Id == _studentId);
            else
                AssignIdToNewStudent(students);

            AddNewUserToList(students);

            _fileHelper.SerializeToFile(students);

            Close();
        }

        private void AddNewUserToList(List<Student> students)
        {
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
                AdditionalClasses = chbAdditionalClasses.Checked,
                Group = cmbGroup.SelectedItem as Group,
            };

            students.Add(student);
        }

        private void AssignIdToNewStudent(List<Student> students)
        {
            var studentWithHighestId =
                    students.OrderByDescending(s => s.Id).FirstOrDefault();

            _studentId = studentWithHighestId == null ?
                1 : studentWithHighestId.Id + 1;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}