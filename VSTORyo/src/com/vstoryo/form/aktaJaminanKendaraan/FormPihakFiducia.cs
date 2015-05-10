using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VSTORyo.src.com.vstoryo.helper;

namespace VSTORyo.src.com.vstoryo.form.aktaJaminanKendaraan
{
    public partial class FormPihakFiducia : Form
    {
        public FormPihakFiducia()
        {
            InitializeComponent();

            //dateTimePicker1PF.ShowUpDown = true;
            dateTimePicker1PF.CustomFormat = "d-MM-yyyy";
            dateTimePicker1PF.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            //dateTimePicker2PF.ShowUpDown = true;
            dateTimePicker2PF.CustomFormat = "d-MM-yyyy";
            dateTimePicker2PF.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            //dateTimePicker1PNF.ShowUpDown = true;
            dateTimePicker1PNF.CustomFormat = "d-MM-yyyy";
            dateTimePicker1PNF.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            //dateTimePicker2PNF.ShowUpDown = true;
            dateTimePicker2PNF.CustomFormat = "d-MM-yyyy";
            dateTimePicker2PNF.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            //dateTimePicker1PMF.ShowUpDown = true;
            dateTimePicker1PMF.CustomFormat = "d-MM-yyyy";
            dateTimePicker1PMF.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            //dateTimePicker2PMF.ShowUpDown = true;
            dateTimePicker2PMF.CustomFormat = "d-MM-yyyy";
            dateTimePicker2PMF.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            //dateTimePicker1Saksi1.ShowUpDown = true;
            dateTimePicker1Saksi1.CustomFormat = "d-MM-yyyy";
            dateTimePicker1Saksi1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            //dateTimePicker2Saksi1.ShowUpDown = true;
            dateTimePicker2Saksi1.CustomFormat = "d-MM-yyyy";
            dateTimePicker2Saksi1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            //dateTimePicker1Saksi2.ShowUpDown = true;
            dateTimePicker1Saksi2.CustomFormat = "d-MM-yyyy";
            dateTimePicker1Saksi2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            //dateTimePicker2Saksi2.ShowUpDown = true;
            dateTimePicker2Saksi2.CustomFormat = "d-MM-yyyy";
            dateTimePicker2Saksi2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;


            textBoxGelarPF.Text = Globals.ThisAddIn.readControlContent(9);
            textBoxNamaPF.Text = Globals.ThisAddIn.readControlContent(10);
            textBoxKotaKelahiranPF.Text = Globals.ThisAddIn.readControlContent(11);
            textBoxNomorKTPPF.Text = Globals.ThisAddIn.readControlContent(14);
            textBoxProfesiPF.Text = Globals.ThisAddIn.readControlContent(17);
            textBoxTempatTinggalPF.Text = Globals.ThisAddIn.readControlContent(18);
        }

        private void fillInTheBlank()
        {
            /**
             * PF   : Pemberi fiducia (pihak pertama)
             * PNF  : Penyetuju fiducia
             * PMF  : Penerima fiducia (pihak kedua)
             **/

            // Pemberi fiducia
            Globals.ThisAddIn.updateControlContent(9, textBoxGelarPF.Text);
            Globals.ThisAddIn.updateControlContent(10, textBoxNamaPF.Text);
            Globals.ThisAddIn.updateControlContent(11, textBoxKotaKelahiranPF.Text);
            Globals.ThisAddIn.updateControlContent(12, DateTimeHandler.readTanggalInIndonesia(dateTimePicker1PF, false));
            Globals.ThisAddIn.updateControlContent(13, DateTimeHandler.getTanggalFromDateTimeHandler(dateTimePicker1PF, false));
            Globals.ThisAddIn.updateControlContent(14, textBoxNomorKTPPF.Text);
            Globals.ThisAddIn.updateControlContent(15, DateTimeHandler.readTanggalInIndonesia(dateTimePicker2PF, false));
            Globals.ThisAddIn.updateControlContent(16, DateTimeHandler.getTanggalFromDateTimeHandler(dateTimePicker2PF, false));
            Globals.ThisAddIn.updateControlContent(17, textBoxProfesiPF.Text);
            Globals.ThisAddIn.updateControlContent(18, textBoxTempatTinggalPF.Text);

            // Relasi pemberi fiducia dengan penyetuju pemberian fiducia
            Globals.ThisAddIn.updateControlContent(19, textBoxRelasiPFPNF.Text);

            // Penyetuju fiducia
            Globals.ThisAddIn.updateControlContent(20, textBoxGelarPNF.Text);
            Globals.ThisAddIn.updateControlContent(21, textBoxNamaPNF.Text);
            Globals.ThisAddIn.updateControlContent(22, textBoxKotaKelahiranPNF.Text);
            Globals.ThisAddIn.updateControlContent(23, DateTimeHandler.readTanggalInIndonesia(dateTimePicker1PNF, false));
            Globals.ThisAddIn.updateControlContent(24, DateTimeHandler.getTanggalFromDateTimeHandler(dateTimePicker1PNF, false));
            Globals.ThisAddIn.updateControlContent(25, textBoxNomorKTPPNF.Text);
            Globals.ThisAddIn.updateControlContent(26, DateTimeHandler.readTanggalInIndonesia(dateTimePicker2PNF, false));
            Globals.ThisAddIn.updateControlContent(27, DateTimeHandler.getTanggalFromDateTimeHandler(dateTimePicker2PNF, false));
            Globals.ThisAddIn.updateControlContent(28, textBoxProfesiPNF.Text);
            Globals.ThisAddIn.updateControlContent(29, textBoxTempatTinggalPNF.Text);

            // Debugging purpose
            MessageBox.Show("pmf "+dateTimePicker1PMF.Text);
            MessageBox.Show("pmf split " + DateTimeHandler.split(dateTimePicker1PMF.Text, false)[0] + "-" + DateTimeHandler.split(dateTimePicker1PMF.Text, false)[0]);

            // Penerima fiducia
            Globals.ThisAddIn.updateControlContent(30, textBoxGelarPMF.Text);
            Globals.ThisAddIn.updateControlContent(31, textBoxNamaPMF.Text);
            Globals.ThisAddIn.updateControlContent(32, textBoxKotaKelahiranPMF.Text);
            Globals.ThisAddIn.updateControlContent(33, DateTimeHandler.readTanggalInIndonesia(dateTimePicker1PMF, false));
            Globals.ThisAddIn.updateControlContent(34, DateTimeHandler.getTanggalFromDateTimeHandler(dateTimePicker1PMF, false));
            Globals.ThisAddIn.updateControlContent(35, textBoxNomorKTPPMF.Text);
            Globals.ThisAddIn.updateControlContent(36, DateTimeHandler.readTanggalInIndonesia(dateTimePicker2PMF, false));
            Globals.ThisAddIn.updateControlContent(37, DateTimeHandler.getTanggalFromDateTimeHandler(dateTimePicker2PMF, false));
            Globals.ThisAddIn.updateControlContent(38, textBoxProfesiPMF.Text);
            Globals.ThisAddIn.updateControlContent(39, textBoxKedudukanInstansiPMF.Text);
            Globals.ThisAddIn.updateControlContent(40, textBoxTempatTinggalPMF.Text);

        }

        private void buttonNextTab_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPagePenyetujuFiducia;
        }

        private void buttonNextTab2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPagePenerimaFiducia;
        }

        private void buttonNextTab3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPageSaksi1;
        }

        private void buttonNextTab4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPageSaksi2;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            fillInTheBlank();
            this.Dispose();
        }

        private void buttonBackTab_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPagePemberiFiducia;
        }
        
        private void buttonBackTab2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPagePenyetujuFiducia;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            new FormInisialisasiAkta().Show();
            this.Dispose();
        }

        private void buttonBackTab3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPagePenerimaFiducia;
        }

        private void buttonBackTab4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPageSaksi1;
        }

    }
}
