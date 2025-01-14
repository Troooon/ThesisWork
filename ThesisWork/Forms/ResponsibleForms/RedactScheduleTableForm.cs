﻿using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThesisWork.Models;
using ThesisWork.Parsers;
using ThesisWork.Repository;
using ThesisWork.ViewModels;

namespace ThesisWork.Forms.ResponsibleForms
{
    public partial class RedactScheduleTableForm : Form
    {
        PracticeRepository practiceRepository = new PracticeRepository();
        ScheduleRepository scheduleRepository = new ScheduleRepository();
        CompetenceRepository competenceRepository = new CompetenceRepository();
        string fileName;
        
        public RedactScheduleTableForm()
        {
            
            InitializeComponent();
            


        }

        private void ChangeTable_Click(object sender, EventArgs e)
        {
            ScheduleRepository scheduleRepository = new ScheduleRepository();
            DataTableCollection data;
            using (var stream = File.Open(fileName, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {

                    DataSet result = reader.AsDataSet();
                    data = result.Tables;
                    DataTable BakTable = data[0];
                    ScheduleParser.ParseScheduleFromExcel(data[0].Rows, practiceRepository, scheduleRepository, competenceRepository);
                }


            }
            practiceRepository.Save();
            scheduleRepository.Save();
            competenceRepository.Save();


        }

        private  void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog FileDialog = new OpenFileDialog();
            FileDialog.Filter = "Excel 97-15.0 WorkBook|*.xls*";

        
            if (FileDialog.ShowDialog() == DialogResult.OK)
            {
                using (var stream = File.Open(FileDialog.FileName, FileMode.Open, FileAccess.Read))
                {
                    textFileName.Text = FileDialog.FileName;
                    fileName = FileDialog.FileName;
                }
            }

        }

        private void RedactScheduleTableForm_Load(object sender, EventArgs e)
        {
            PracticeSchedule.ReadOnly = false;
            PracticeSchedule.DataSource = scheduleRepository.SelectAll().ToList();
        }
    }
}
