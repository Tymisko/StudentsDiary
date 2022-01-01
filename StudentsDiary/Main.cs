using StudentsDiary.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace StudentsDiary
{
    public partial class Main : Form
    {
        private readonly List<Group> _groups;
        public Main()
        {
            InitializeComponent();
            _groups = GroupsHelper.GetGroups("Wszyscy");
            
            InitGroupsCombobox();
            RefreshDiary();

            SetColumnsHeader();
            HideColumns();

            if (IsMaximize)
                WindowState = FormWindowState.Maximized;
        }

        private readonly FileHelper<List<Student>> _fileHelper =
            new FileHelper<List<Student>>(Program.FilePath);              

        public bool IsMaximize 
        { 
            get
            {
                return Settings.Default.IsMaximize;
            }
            set
            {
                Settings.Default.IsMaximize = value;
            }
        }        

        private void HideColumns()
        {
            dgvDiary.Columns[nameof(Student.Group)].Visible = false;
        }

        private void InitGroupsCombobox()
        {
            cmbGroupFilter.DataSource = _groups;
            cmbGroupFilter.DisplayMember = "Name";
            cmbGroupFilter.ValueMember = "Id";
        }

        private void RefreshDiary()
        {
            var students = _fileHelper.DeserializeFromFile();

            // Apply group filter if any selected
            Group selectedGroup = cmbGroupFilter.SelectedItem as Group;
            if (selectedGroup.Name != "Wszyscy")
                students.RemoveAll(s => s.Group.Id != selectedGroup.Id);

            dgvDiary.DataSource = students;
        }

        private void SetColumnsHeader()
        {
            dgvDiary.Columns[nameof(Student.Id)].HeaderText = "Numer";
            dgvDiary.Columns[nameof(Student.FirstName)].HeaderText = "Imie";
            dgvDiary.Columns[nameof(Student.LastName)].HeaderText = "Nazwisko";
            dgvDiary.Columns[nameof(Student.Comments)].HeaderText = "Uwagi";
            dgvDiary.Columns[nameof(Student.Math)].HeaderText = "Matematyka";
            dgvDiary.Columns[nameof(Student.Technology)].HeaderText = "Technologia";
            dgvDiary.Columns[nameof(Student.Physics)].HeaderText = "Fizyka";
            dgvDiary.Columns[nameof(Student.PolishLang)].HeaderText = "Język polski";
            dgvDiary.Columns[nameof(Student.ForeignLang)].HeaderText = "Język obcy";
            dgvDiary.Columns[nameof(Student.AdditionalClasses)].HeaderText = "Zajęcia Dodatkowe";
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var addEditStudent = new AddEditStudent();
            addEditStudent.FormClosed += AddEditStudent_FormClosed;
            addEditStudent.ShowDialog();
        }

        private void AddEditStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshDiary();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dgvDiary.SelectedRows.Count == 0)
            {
                MessageBox.Show("Proszę zaznacz ucznia, którego dane chcesz edytować", "Błąd", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return; 
            }

            var addEditStudent = new AddEditStudent(Convert.ToInt32(dgvDiary.SelectedRows[0].Cells[0].Value));
            addEditStudent.FormClosed += AddEditStudent_FormClosed;
            addEditStudent.ShowDialog();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDiary.SelectedRows.Count == 0)
            {
                MessageBox.Show("Proszę zaznacz ucznia, którego chcesz usunąć", "Błąd", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            var selectedStudent = dgvDiary.SelectedRows[0];

            var confirmDelete = MessageBox.Show(
                $"Czy na pewno chccesz usunąć ucznia {selectedStudent.Cells[1].Value} {selectedStudent.Cells[2].Value}?",
                "Usuwanie ucznia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (confirmDelete == DialogResult.OK)
            {
                DeleteStudent(Convert.ToInt32(selectedStudent.Cells[0].Value));
                RefreshDiary();
            }
        }

        private void DeleteStudent(int id)
        {
            var students = _fileHelper.DeserializeFromFile();
            students.RemoveAll(s => s.Id == id);
            _fileHelper.SerializeToFile(students);
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDiary();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                IsMaximize = true;
            else
                IsMaximize = false;

            Settings.Default.Save();
        }

        private void CmbGroupFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshDiary();
        }
    }
}
