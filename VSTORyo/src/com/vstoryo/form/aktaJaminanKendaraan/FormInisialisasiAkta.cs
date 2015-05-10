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
using VSTORyo.src.com.vstoryo.helper.aktaJaminanKendaraan;

namespace VSTORyo.src.com.vstoryo.form.aktaJaminanKendaraan
{
    public partial class FormInisialisasiAkta : Form
    {
        public FormInisialisasiAkta()
        {
            InitializeComponent();
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.CustomFormat = "dddd, d-MM-yyyy, HH:mm";
            dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            textBoxNomorAkta.Text = Globals.ThisAddIn.readControlContent(1);
            textBoxNotaris.Text = Globals.ThisAddIn.readControlContent(7);
            textBoxKota.Text = Globals.ThisAddIn.readControlContent(8);
        }

        private void fillInTheBlank()
        {
            Globals.ThisAddIn.updateControlContent(1, textBoxNomorAkta.Text);

            Globals.ThisAddIn.updateControlContent(2, DateTimeHandler.getDayFromDateTimeHandler(dateTimePicker1, true));
            Globals.ThisAddIn.updateControlContent(3, DateTimeHandler.getTanggalFromDateTimeHandler(dateTimePicker1, true));
            Globals.ThisAddIn.updateControlContent(4, DateTimeHandler.readTanggalInIndonesia(dateTimePicker1, true));
            Globals.ThisAddIn.updateControlContent(5, DateTimeHandler.getHourFromDateTimeHandler(dateTimePicker1, true));
            Globals.ThisAddIn.updateControlContent(6, DateTimeHandler.readHourInIndonesia(dateTimePicker1, true));
            Globals.ThisAddIn.updateControlContent(7, textBoxNotaris.Text);
            Globals.ThisAddIn.updateControlContent(8, textBoxKota.Text);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            fillInTheBlank();
            new FormPihakFiducia().Show();
            //this.Hide();
            this.Dispose();
            
        }
    }
}
