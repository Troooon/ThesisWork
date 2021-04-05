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

namespace ThesisWork.Forms.ResponsibleForms
{
    public partial class RedactScheduleTableForm : Form
    {
        public RedactScheduleTableForm()
        {
            InitializeComponent();
        }

        private void ChangeTable_Click(object sender, EventArgs e)
        {

        }
        
        private async void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog FileDialog = new OpenFileDialog();
            FileDialog.Filter = "Excel 97-15.0 WorkBook|*.xls*";

            DataTableCollection data;
            if (FileDialog.ShowDialog() == DialogResult.OK)
            {
                using (var stream = File.Open(FileDialog.FileName, FileMode.Open, FileAccess.Read))
                {



                    using (var reader = ExcelReaderFactory.CreateReader(stream))
                    {

                        
                        textFileName.Text = FileDialog.FileName;
                       
                        DataSet result = reader.AsDataSet();
                        data = result.Tables;
                        DataTable BakTable = data[0];

                        PracticeSchedule schedule = new PracticeSchedule();
                        await Task.Run(()=> ScheduleParser.ParseScheduleFromExcel(schedule, data[0].Rows));



                    }
                }
            }

        }
    }
}
