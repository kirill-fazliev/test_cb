using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace TestCB
{
    public partial class Form1 : Form
    {
        private enum EditState
        {
            none,
            edit,
            add

        }
        private OleDbConnection connection;
        private EditState editState = EditState.none;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DatabasesLoad();
            FillDataGridView();
            FillComboboxTypeFilter();
            FillComboboxTypePZN();
            FillComboboxTypeREG();
            FillComboboxTypeTNP();
            FillComboboxTypeUER();

            SetUpTextboxes();
        }

        private void SetUpTextboxes()
        {
            textBoxREAL.MaxLength = 4;

            textBoxIND.MaxLength = 6;
            textBoxNNP.MaxLength = 25;
            textBoxADR.MaxLength = 30;
            textBoxRKC.MaxLength = 9;
            textBoxNAMEP.MaxLength = 45;
            textBoxNAMEN.MaxLength = 30;
            textBoxNEWNUM.MaxLength = 9;
            textBoxTELEF.MaxLength = 25;
            textBoxREGN.MaxLength = 9;
            textBoxOKPO.MaxLength = 8;
        }

        private void DatabasesLoad()
        {
            if (!CheckDatabasesExists())
            {
                folderBrowserDialog.SelectedPath = Properties.Settings.Default.PathToDatabase;
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    if (CheckDatabasesExists())
                    {
                        Properties.Settings.Default.PathToDatabase = folderBrowserDialog.SelectedPath;
                        Properties.Settings.Default.Save();
                    }
                    else
                    {
                        MessageBox.Show("Can't load dsatabase");
                        Application.Exit();
                    }

                }
            }

            string constr = Properties.Settings.Default.ConnectionString + Properties.Settings.Default.PathToDatabase + "\";";
            connection = new OleDbConnection(constr);

        }

        private bool CheckDatabasesExists()
        {
            List<string> databasesNames = new List<string> { "BNKSEEK.DBF", "UER.DBF", "PZN.DBF", "TNP.DBF", "REG.DBF", "REAL.DBF" };
            foreach (var databaseName in databasesNames)
            {
                var path = Path.Combine(Properties.Settings.Default.PathToDatabase, databaseName);
                if (!File.Exists(path))
                {
                    return false;
                }
            }
            return true;
        }

        private void FillComboboxTypeFilter()
        {
            var sqlQuery = "select * from PZN.DBF";
            OleDbCommand command = new OleDbCommand(sqlQuery, connection);
            connection.Open();
            DataTable table1 = new DataTable();

            table1.Load(command.ExecuteReader());
            connection.Close();
            var row = table1.NewRow();
            table1.Rows.InsertAt(row, 0);
            comboBoxTypeFilter.DataSource = table1;
            comboBoxTypeFilter.ValueMember = "PZN";
            comboBoxTypeFilter.DisplayMember = "NAME";
        }

        private void FillComboboxTypePZN()
        {
            var sqlQuery = "select * from PZN.DBF";
            OleDbCommand command = new OleDbCommand(sqlQuery, connection);
            connection.Open();
            DataTable table1 = new DataTable();

            table1.Load(command.ExecuteReader());
            connection.Close();
            comboBoxPZN.DataSource = table1;
            comboBoxPZN.ValueMember = "PZN";
            comboBoxPZN.DisplayMember = "NAME";
        }

        private void FillComboboxTypeTNP()
        {
            var sqlQuery = "select * from TNP.DBF";
            OleDbCommand command = new OleDbCommand(sqlQuery, connection);
            connection.Open();
            DataTable table1 = new DataTable();

            table1.Load(command.ExecuteReader());
            connection.Close();
            comboBoxTNP.DataSource = table1;
            comboBoxTNP.ValueMember = "TNP";
            comboBoxTNP.DisplayMember = "FULLNAME";
        }

        private void FillComboboxTypeUER()
        {
            var sqlQuery = "select * from UER.DBF";
            OleDbCommand command = new OleDbCommand(sqlQuery, connection);
            connection.Open();
            DataTable table1 = new DataTable();

            table1.Load(command.ExecuteReader());
            connection.Close();
            comboBoxUER.DataSource = table1;
            comboBoxUER.ValueMember = "UER";
            comboBoxUER.DisplayMember = "UERNAME";
        }

        private void FillComboboxTypeREG()
        {
            var sqlQuery = "select * from REG.DBF";
            OleDbCommand command = new OleDbCommand(sqlQuery, connection);
            connection.Open();
            DataTable table1 = new DataTable();

            table1.Load(command.ExecuteReader());
            connection.Close();
            comboBoxREG.DataSource = table1;
            comboBoxREG.ValueMember = "RGN";
            comboBoxREG.DisplayMember = "NAME";
        }



        private void FillDataGridView()
        {
            var sqlQuery = @"select
  t1.VKEY,
  t1.REAL,
  t3.UERNAME as UER_NAME,
  t2.NAME as PZN_NAME,
  t5.NAME as RGN_NAME,
  t1.IND,
  t4.FULLNAME as FULL_NAME,
  t1.NNP,
  t1.ADR,
  t1.RKC,
  t1.NAMEP,
  t1.NEWNUM,
  t1.TELEF,
  t1.REGN,
  t1.OKPO,
  t1.DT_IZM,
  t1.DATE_IN,
  t1.DATE_CH
from
  (((BNKSEEK.DBF as t1
  LEFT JOIN UER.DBF as t3
  ON t1.UER = t3.UER)
  LEFT JOIN PZN.DBF as t2
  ON t1.PZN = t2.PZN)
  LEFT JOIN TNP.DBF as t4
  ON t1.TNP = t4.TNP)
  LEFT JOIN REG.DBF as t5
  ON t1.RGN = t5.RGN";

            sqlQuery = AppendFilters(sqlQuery);

            OleDbCommand command = new OleDbCommand(sqlQuery, connection);
            connection.Open();
            DataTable table = new DataTable();
            table.Load(command.ExecuteReader());
            connection.Close();

            dataGridViewDB.DataSource = table;
            dataGridViewDB.Columns["VKEY"].Visible = false;
            dataGridViewDB.Refresh();
            dataGridViewDB.Update();
        }



        private void MaskedTextBoxBIK_TextChanged(object sender, EventArgs e)
        {
        }

        private void ButtonFilter_Click(object sender, EventArgs e)
        {
            FillDataGridView();
        }

        private string AppendFilters(string sqlQuery)
        {
            bool findByBIK = !maskedTextBoxBIKFilter.Text.Contains(" ") && maskedTextBoxBIKFilter.Text.Length == 9;
            bool findByRegion = !maskedTextBoxRegionFilter.Text.Contains(" ") && maskedTextBoxRegionFilter.Text.Length == 2;
            bool findByType = false;
            if (comboBoxTypeFilter.SelectedItem != null)
            {
                findByType = comboBoxTypeFilter.SelectedIndex != 0;
            }

            if (findByBIK || findByRegion || findByType)
            {
                sqlQuery += " WHERE ";
            }
            if (findByBIK)
            {
                sqlQuery += " t1.RKC = \"" + maskedTextBoxBIKFilter.Text + "\" ";
            }


            if (findByRegion)
            {
                if (findByBIK)
                {
                    sqlQuery += " AND ";
                }
                sqlQuery += " t1.RGN = \"" + maskedTextBoxRegionFilter.Text + "\" ";
            }


            if (findByType)
            {
                if (findByBIK || findByRegion)
                {
                    sqlQuery += " AND ";
                }

                sqlQuery += " t1.PZN = \"" + comboBoxTypeFilter.SelectedValue.ToString() + "\" ";
            }

            return sqlQuery;
        }

        private void DataGridViewDB_SelectionChanged(object sender, EventArgs e)
        {
            if (sender is DataGridView dgv)
            {
                if (dgv.CurrentRow != null && dgv.CurrentRow.Index != dgv.RowCount - 1)
                {
                    buttonDelete.Enabled = true;
                    buttonChange.Enabled = true;
                }
                else
                {
                    buttonDelete.Enabled = false;
                    buttonChange.Enabled = false;

                }
            }
        }



        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            var sqlQuery = "delete * from BNKSEEK.DBF WHERE VKEY = \"" + dataGridViewDB.CurrentRow.Cells["VKEY"].Value.ToString() + "\"";
            OleDbCommand command = new OleDbCommand(sqlQuery, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            FillDataGridView();

        }

        private void ButtonChange_Click(object sender, EventArgs e)
        {

            var currentRow = dataGridViewDB.SelectedRows[0];
            textBoxREAL.Text = currentRow.Cells["REAL"].Value.ToString();
            textBoxIND.Text = currentRow.Cells["IND"].Value.ToString();
            textBoxNNP.Text = currentRow.Cells["NNP"].Value.ToString();
            textBoxADR.Text = currentRow.Cells["ADR"].Value.ToString();
            textBoxRKC.Text = currentRow.Cells["RKC"].Value.ToString();
            textBoxNAMEP.Text = currentRow.Cells["NAMEP"].Value.ToString();
            textBoxNAMEN.Text = currentRow.Cells["NAMEP"].Value.ToString();
            textBoxNEWNUM.Text = currentRow.Cells["NEWNUM"].Value.ToString();
            textBoxTELEF.Text = currentRow.Cells["TELEF"].Value.ToString();
            textBoxREGN.Text = currentRow.Cells["REGN"].Value.ToString();
            textBoxOKPO.Text = currentRow.Cells["OKPO"].Value.ToString();
            textBoxDT_IZM.Text = currentRow.Cells["DT_IZM"].Value.ToString();
            textBoxDATE_IN.Text = currentRow.Cells["DATE_IN"].Value.ToString();
            textBoxDATE_CH.Text = currentRow.Cells["DATE_CH"].Value.ToString();

            SelectActualValue(comboBoxPZN, currentRow.Cells["PZN_NAME"].Value.ToString());
            SelectActualValue(comboBoxREG, currentRow.Cells["RGN_NAME"].Value.ToString());
            SelectActualValue(comboBoxTNP, currentRow.Cells["FULL_NAME"].Value.ToString());
            SelectActualValue(comboBoxUER, currentRow.Cells["UER_NAME"].Value.ToString());

            panelEdit.Visible = true;
            dataGridViewDB.Enabled = false;

            editState = EditState.edit;

        }

        private void SelectActualValue(ComboBox comboBox, string selectedtext)
        {
            comboBox.SelectedIndex = comboBox.FindStringExact(selectedtext);
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {

            ClearInput();
            panelEdit.Visible = true;
            dataGridViewDB.Enabled = false;
            editState = EditState.add;
            textBoxDATE_IN.Enabled = false;
        }

        private void ClearInput()
        {
            textBoxREAL.Clear();
            textBoxREAL.Clear();
            textBoxIND.Clear();
            textBoxNNP.Clear();
            textBoxADR.Clear();
            textBoxRKC.Clear();
            textBoxNAMEP.Clear();
            textBoxNEWNUM.Clear();
            textBoxTELEF.Clear();
            textBoxREGN.Clear();
            textBoxOKPO.Clear();
            textBoxDT_IZM.Clear();
            textBoxDATE_IN.Clear();
            textBoxDATE_CH.Clear();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            panelEdit.Visible = false;
            dataGridViewDB.Enabled = true;
            editState = EditState.none;
            ClearInput();
            textBoxDATE_IN.Enabled = true;
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            panelEdit.Visible = false;

            switch (editState)
            {
                case EditState.add:
                    AddData();
                    FillDataGridView();
                    break;
                case EditState.edit:
                    UpdateData();
                    FillDataGridView();
                    break;
                default:
                    break;

            }
            ClearInput();
            editState = EditState.none;
            dataGridViewDB.Enabled = true;
            textBoxDATE_IN.Enabled = true;
        }

        private void AddData()
        {
            try
            {
                var sqlQuery = "INSERT INTO BNKSEEK.DBF (VKEY, UER, PZN,    RGN,  IND,  TNP,  NNP,  ADR,  RKC,  NAMEP,  NEWNUM,  SROK,  TELEF,  REGN,  OKPO, DT_IZM, DATE_IN, DATE_CH ) " +
                                                    "VALUES (@vkey, @uer, @pzn, @rgn, @ind, @tnp, @nnp, @adr, @rkc, @namep, @newnum, @srok, @telef, @regn, @okpo, NOW(), NOW(), NOW()) ";

                OleDbCommand command = new OleDbCommand(sqlQuery, connection);

                command.Parameters.Add("@vkey", SqlDbType.NChar);
                command.Parameters["@vkey"].Value = DateTime.Now.ToString().GetHashCode().ToString().Substring(0, 8);

                command.Parameters.Add("@uer", SqlDbType.NChar);
                command.Parameters["@uer"].Value = comboBoxUER.SelectedValue;

                command.Parameters.Add("@pzn", SqlDbType.NChar);
                command.Parameters["@pzn"].Value = comboBoxPZN.SelectedValue;

                command.Parameters.Add("@rgn", SqlDbType.NChar);
                command.Parameters["@rgn"].Value = comboBoxREG.SelectedValue;

                command.Parameters.Add("@ind", SqlDbType.NChar);
                command.Parameters["@ind"].Value = textBoxIND.Text;

                command.Parameters.Add("@tnp", SqlDbType.NChar);
                command.Parameters["@tnp"].Value = comboBoxTNP.SelectedValue == null ? DBNull.Value : comboBoxTNP.SelectedValue;

                command.Parameters.Add("@nnp", SqlDbType.NChar);
                command.Parameters["@nnp"].Value = textBoxNNP.Text;

                command.Parameters.Add("@adr", SqlDbType.NChar);
                command.Parameters["@adr"].Value = textBoxADR.Text;

                command.Parameters.Add("@rkc", SqlDbType.NChar);
                command.Parameters["@rkc"].Value = textBoxRKC.Text;

                command.Parameters.Add("@namep", SqlDbType.NChar);
                command.Parameters["@namep"].Value = textBoxNAMEP.Text;

                command.Parameters.Add("@newnum", SqlDbType.NChar);
                command.Parameters["@newnum"].Value = textBoxNEWNUM.Text;

                command.Parameters.Add("@srok", SqlDbType.NChar);
                command.Parameters["@srok"].Value = "00";

                command.Parameters.Add("@telef", SqlDbType.NChar);
                command.Parameters["@telef"].Value = textBoxTELEF.Text;

                command.Parameters.Add("@regn", SqlDbType.NChar);
                command.Parameters["@regn"].Value = textBoxREGN.Text;

                command.Parameters.Add("@okpo", SqlDbType.NChar);
                command.Parameters["@okpo"].Value = textBoxOKPO.Text;

                command.Parameters.Add("@datein", SqlDbType.Date);
                command.Parameters["@datein"].Value = textBoxDATE_IN.Text;

                command.Parameters.Add("@datech", SqlDbType.Date);
                command.Parameters["@datech"].Value = textBoxDATE_CH.Text == "" ? DBNull.Value : (object)textBoxDATE_CH.Text;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                FillDataGridView();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void UpdateData()
        {
            try
            {

                var sqlQuery = "UPDATE  BNKSEEK.DBF SET " +
      "UER = @uer," +
      "PZN = @pzn," +
      "RGN = @rgn," +
      "IND = @ind," +
      "TNP = @tnp," +
      "NNP = @nnp," +
      "ADR = @adr," +
      "RKC = @rkc," +
      "NAMEP = @namep," +
      "NEWNUM = @newnum," +
      "TELEF = @telef," +
      "REGN = @regn," +
      "OKPO = @okpo," +
      "DT_IZM = NOW(), " +
      "DATE_IN = @datein ," +
      "DATE_CH = @datech " +
      "WHERE VKEY = " + "\'" +
       dataGridViewDB.CurrentRow.Cells["VKEY"].Value.ToString() + "\'";
                OleDbCommand command = new OleDbCommand(sqlQuery, connection);

                command.Parameters.Add("@uer", SqlDbType.NChar);
                command.Parameters["@uer"].Value = comboBoxUER.SelectedValue;

                command.Parameters.Add("@pzn", SqlDbType.NChar);
                command.Parameters["@pzn"].Value = comboBoxPZN.SelectedValue;

                command.Parameters.Add("@rgn", SqlDbType.NChar);
                command.Parameters["@rgn"].Value = comboBoxREG.SelectedValue;

                command.Parameters.Add("@ind", SqlDbType.NChar);
                command.Parameters["@ind"].Value = textBoxIND.Text;

                command.Parameters.Add("@tnp", SqlDbType.NChar);
                command.Parameters["@tnp"].Value = comboBoxTNP.SelectedValue == null ? DBNull.Value : comboBoxTNP.SelectedValue;

                command.Parameters.Add("@nnp", SqlDbType.NChar);
                command.Parameters["@nnp"].Value = textBoxNNP.Text;

                command.Parameters.Add("@adr", SqlDbType.NChar);
                command.Parameters["@adr"].Value = textBoxADR.Text;

                command.Parameters.Add("@rkc", SqlDbType.NChar);
                command.Parameters["@rkc"].Value = textBoxRKC.Text;

                command.Parameters.Add("@namep", SqlDbType.NChar);
                command.Parameters["@namep"].Value = textBoxNAMEP.Text;

                command.Parameters.Add("@newnum", SqlDbType.NChar);
                command.Parameters["@newnum"].Value = textBoxNEWNUM.Text;

                command.Parameters.Add("@telef", SqlDbType.NChar);
                command.Parameters["@telef"].Value = textBoxTELEF.Text;

                command.Parameters.Add("@regn", SqlDbType.NChar);
                command.Parameters["@regn"].Value = textBoxREGN.Text;

                command.Parameters.Add("@okpo", SqlDbType.NChar);
                command.Parameters["@okpo"].Value = textBoxOKPO.Text;

                command.Parameters.Add("@datein", SqlDbType.Date);
                command.Parameters["@datein"].Value = textBoxDATE_IN.Text;

                command.Parameters.Add("@datech", SqlDbType.Date);
                command.Parameters["@datech"].Value = textBoxDATE_CH.Text == "" ? DBNull.Value : (object)textBoxDATE_CH.Text;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                FillDataGridView();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
    }

}