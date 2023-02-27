using System.Collections.Generic;
using System;
using System.Data;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace project2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		List<String> x = new List<string>();
		List<String> y = new List<string>();
		List<String> t = new List<string>();
		List<String> z = new List<string>();
		List<String> a = new List<string>();
		List<String> b = new List<string>();


		private void Form1_Load(object sender, EventArgs e)
		{
			Timer timer1 = new Timer();
			timer1.Interval = 100;
			timer1.Start();
		}


		private void uiBtn_ReadCsv_Click(object sender, EventArgs e)
		{
			StreamReader file = new StreamReader("AddressSpace.csv");

			DataTable table = new DataTable();
			table.Columns.Add("Tag Name");
			table.Columns.Add("Data Type");
			table.Columns.Add("AccessRights");
			table.Columns.Add("Simulated");

			while (!file.EndOfStream)
			{
				string line = file.ReadLine();
				string[] data = line.Split(',');
				table.Rows.Add(data[0], data[1], data[2], data[3]);

				x.Add(data[0]);
				y.Add(data[1]);
				t.Add(data[2]);
				z.Add(data[3]);
			}
			uiGridView_CSV.DataSource = table;
			uiGridView_CSV.ReadOnly = true; //수정 불가능
			uiGridView_CSV.AllowUserToOrderColumns = false;
		}
		private void uiBtn_ReadCsv2_Click(object sender, EventArgs e)
		{
			StreamReader file = new StreamReader("ValueSpace.csv");

			DataTable table = new DataTable();
			table.Columns.Add("");
			table.Columns.Add("");
			table.Columns.Add("");
			table.Columns.Add("");
			table.Columns.Add("");
			table.Columns.Add("");

			while (!file.EndOfStream)
			{
				string line = file.ReadLine();
				string[] data = line.Split(',');
				table.Rows.Add(data[0], data[1], data[2], data[3], data[4], data[5]);

				x.Add(data[0]);
				y.Add(data[1]);
				t.Add(data[2]);
				z.Add(data[3]);
				a.Add(data[4]);
				b.Add(data[5]);
			}
			uiGridView_CSV.DataSource = table;
			uiGridView_CSV.ReadOnly = true; //수정 불가능
			uiGridView_CSV.AllowUserToOrderColumns = false;
		}

        private void btnCSV_Save_Click(object sender, EventArgs e)
        {
			ExportToCSV();
        }

		private void ExportToCSV()
		{
			SaveFileDialog saveFileDialog = GetCsvSave();
			if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				Save_Csv(saveFileDialog.FileName, uiGridView_CSV, true);

            }
		}

		private SaveFileDialog GetCsvSave()
		{
			SaveFileDialog saveDialog = new SaveFileDialog();
			saveDialog.CheckPathExists= true;
			saveDialog.AddExtension= true;
			saveDialog.ValidateNames= true;

			string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
			string filepath = Path.GetDirectoryName(path);

			saveDialog.InitialDirectory= filepath;

			saveDialog.DefaultExt = ".csv";
			saveDialog.Filter = "csv (*.csv) | *.csv";
			saveDialog.FileName = "expert".ToString();

			return saveDialog;
		}

		private void Save_Csv(string fileName, DataGridView dgview, bool header)
		{
			string delimiter = ",";
			FileStream fs = new FileStream(fileName, System.IO.FileMode.Create, System.IO.FileAccess.Write);
			StreamWriter csvExport = new StreamWriter(fs, System.Text.Encoding.UTF8);

			if (dgview.Rows.Count == 0) return;

			if (header)
			{
				for (int i = 0; i < dgview.Columns.Count; i++)
				{
					csvExport.Write(dgview.Columns[i].HeaderText);
					if (i != dgview.Columns.Count - 1)
					{
						csvExport.Write(delimiter);
					}
				}
            }
            csvExport.Write(csvExport.NewLine);

			foreach (DataGridViewRow row in dgview.Rows)
			{
				if (!row.IsNewRow)
				{
					for (int i = 0; i < dgview.Columns.Count; i++)
					{
						csvExport.Write(row.Cells[i].Value);
						if (i != dgview.Columns.Count - 1)
						{
							csvExport.Write(delimiter);
						}
					}
					csvExport.Write(csvExport.NewLine);
				}
			}
			csvExport.Flush();
			csvExport.Close();
			fs.Close();

			MessageBox.Show("CSV 파일 저장 완료!");
        }
    }
}