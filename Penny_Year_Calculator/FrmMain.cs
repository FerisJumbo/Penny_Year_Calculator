using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;
using System.IO;

namespace Penny_Year_Calculator
{
    public partial class FrmMain : Form
    {
        public StreamWriter FileInteraction;
        public String SelectedFileName;

        public List<Penny> PennyList = new List<Penny>();

        public FrmMain()
        {
            InitializeComponent();
        }

        private void UpdateListBox()
        {
            lboxPennies.Items.Clear();

            double AverageNumber = 0;
            double Phat = 0;

            foreach (Penny penny in PennyList)
            {
                lboxPennies.Items.Add(penny.Year);
                penny.Over2000();
                AverageNumber = AverageNumber + penny.Year;
                if (penny.IsOver2000 == true)
                {
                    Phat++;
                }
            }

            AverageNumber = (Math.Round(AverageNumber / PennyList.Count));
            Phat = Math.Round((Phat / PennyList.Count), 2);

            txtNumberTotal.Text = PennyList.Count.ToString();
            txtAverage.Text = AverageNumber.ToString();
            txtPhat.Text = Phat.ToString();

        }

        private void btnAddPenny_Click(object sender, EventArgs e)
        {
            Penny SomePenny = new Penny(Convert.ToInt32(txtAddPennyAmount.Text));
            PennyList.Add(SomePenny);

            UpdateListBox();

            txtAddPennyAmount.Text = "";
        }

        private void btnRemovePenny_Click(object sender, EventArgs e)
        {
            int pennyyear = Convert.ToInt32(lboxPennies.SelectedItem.ToString());

            foreach (Penny penny in PennyList)
            {
                if (penny.Year == pennyyear)
                {
                    PennyList.Remove(penny);
                    break;
                }
                else { }
            }

            UpdateListBox();
        }

        private void btnPennyModify_Click(object sender, EventArgs e)
        {
            int pennyyear = Convert.ToInt32(lboxPennies.SelectedItem.ToString());

            foreach (Penny penny in PennyList)
            {
                if (penny.Year == pennyyear)
                {
                    penny.Year = Convert.ToInt32(txtModifyYear.Text);
                    break;
                }
                else { }
            }

            UpdateListBox();

            txtModifyYear.Text = "";
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            btnSaveNClear.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            PennyList.Clear();

            UpdateListBox();

            txtNumberTotal.Text = "";
            txtAverage.Text = "";
            txtPhat.Text = "";
        }

        private void txtAdditionKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Penny SomePenny = new Penny(Convert.ToInt32(txtAddPennyAmount.Text));
                PennyList.Add(SomePenny);

                UpdateListBox();

                txtAddPennyAmount.Text = "";
            }
        }

        private void txtModifyKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int pennyyear = Convert.ToInt32(lboxPennies.SelectedItem.ToString());

                foreach (Penny penny in PennyList)
                {
                    if (penny.Year == pennyyear)
                    {
                        penny.Year = Convert.ToInt32(txtModifyYear.Text);
                        break;
                    }
                    else { }
                }

                UpdateListBox();

                txtModifyYear.Text = "";
            }
        }

        private String StatOutputPrint()
        {
            StringBuilder StringMaker = new StringBuilder();
            

            StringMaker.AppendLine("____________________");
            StringMaker.AppendLine($"Number of Items: {txtNumberTotal.Text}");
            StringMaker.AppendLine($"Average Year: {txtAverage.Text}");
            StringMaker.AppendLine($"P-Hat: {txtPhat.Text}");
            StringMaker.AppendLine("____________________\n");

            return StringMaker.ToString();
        }

        private void btnSaveNClear_Click(object sender, EventArgs e)
        {
            FileInteraction = File.AppendText(SelectedFileName);
            FileInteraction.WriteLine(StatOutputPrint());
            FileInteraction.Close();

            PennyList.Clear();

            UpdateListBox();

            txtNumberTotal.Text = "";
            txtAverage.Text = "";
            txtPhat.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FileInteraction = File.AppendText(SelectedFileName);
            FileInteraction.WriteLine(StatOutputPrint());
            FileInteraction.Close();
        }

        private void btnBrowseFiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd1 = new OpenFileDialog();

            if (fd1.ShowDialog().Equals(DialogResult.OK))
            {
                SelectedFileName = fd1.FileName;

                btnSave.Enabled = true;
                btnSaveNClear.Enabled = true;
            }
        }
    }
}
