using StudentsDiary.Properties;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StudentsDiary
{
    public partial class Main : Form
    {
        private FileHelper<List<Student>> _fileHelper = 
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

        public Main()
        {
            InitializeComponent();
            RefreshDiary();

            SetColumnsHeader();
            
            if(IsMaximize)
                WindowState = FormWindowState.Maximized;
        }

        private void RefreshDiary()
        {
            var students = _fileHelper.DeserializeFromFile();
            dgvDiary.DataSource = students;
        }

        private void SetColumnsHeader()
        {
            dgvDiary.Columns[0].HeaderText = "Numer";
            dgvDiary.Columns[1].HeaderText = "Imie";
            dgvDiary.Columns[2].HeaderText = "Nazwisko";
            dgvDiary.Columns[3].HeaderText = "Uwagi";
            dgvDiary.Columns[4].HeaderText = "Matematyka";
            dgvDiary.Columns[5].HeaderText = "Technologia";
            dgvDiary.Columns[6].HeaderText = "Fizyka";
            dgvDiary.Columns[7].HeaderText = "Język polski";
            dgvDiary.Columns[8].HeaderText = "Język obcy";
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
    }
}
