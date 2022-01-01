using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace StudentsDiary
{
    public partial class AddEditStudent : Form
    {
        private Student _student;
        private int _studentId;
        private List<Group> _groups = new List<Group>();

        private FileHelper<List<Student>> _fileHelper =
            new FileHelper<List<Student>>(Program.FilePath);

        public AddEditStudent(int id = 0)
        {
            InitializeComponent();
            LoadGroupsId();

            _studentId = id;
            GetStudentData();

            tbFirstName.Select();
        }

        private void LoadGroupsId()
        {
            _groups.Add(new Group(1));
            _groups.Add(new Group(2));
            _groups.Add(new Group(3));

            var groupsId = new List<int>();
            foreach (var group in _groups)
            {
                groupsId.Add(group.Id);
            }

            cbGroupId.DataSource = groupsId;
        }

        private void GetStudentData()
        {
            if (_studentId != 0)
            {
                Text = "Edytowanie danych ucznia";

                var students = _fileHelper.DeserializeFromFile();
                _student = students.FirstOrDefault(s => s.Id == _studentId);

                if (_student == null)
                    throw new Exception("Brak użytkownika o podanym Id");

                FillTextBoxes();                
            }
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
            cbGroupId.SelectedItem = _student.GroupId;
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
                GroupId = (int)cbGroupId.SelectedItem,
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