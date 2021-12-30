﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StudentsDiary
{
    public partial class Main : Form
    {
        private FileHelper<List<Student>> _fileHelper = 
            new FileHelper<List<Student>>(Program.FilePath);
        public Main()
        {
            InitializeComponent();
            RefreshDiary();
            SetColumnsHeader();            
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
            dgvDiary.Columns[7].HeaderText = "Język obcy";
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var addEditStudent = new AddEditStudent();
            addEditStudent.ShowDialog();
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
                var students = _fileHelper.DeserializeFromFile();
                students.RemoveAll(s => s.Id == Convert.ToInt32(selectedStudent.Cells[0].Value));

                _fileHelper.SerializeToFile(students);
                dgvDiary.DataSource = students;
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDiary();
        }
    }
}
