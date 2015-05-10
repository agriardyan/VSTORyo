using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using VSTORyo.src.com.vstoryo.form.aktaJaminanKendaraan;
using System.IO;

namespace VSTORyo
{
    public partial class VSTORyoRibbon
    {
        private void VSTORyoRibbon_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private string getResourcePath()
        {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\res\";
            return path;
        }

        private void closeLastDocument()
        {
            Globals.ThisAddIn.closeLastDocument();
        }

        private void buttonAktaJaminanKendaraan_Click(object sender, RibbonControlEventArgs e)
        {
            closeLastDocument();
            //Globals.ThisAddIn.openSelectedTemplate(@"C:\Users\tars\Documents\Custom Office Templates\SAMPLEAKTA5.dotx");
            Globals.ThisAddIn.openSelectedTemplate(getResourcePath() + "SAMPLEAKTA6.dotx");
            new FormInisialisasiAkta().Show();
        }
    }
}
