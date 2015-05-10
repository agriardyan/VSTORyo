using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Word = Microsoft.Office.Interop.Word;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Word;

namespace VSTORyo
{
    public partial class ThisAddIn
    {
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        public void openSelectedTemplate(string path)
        {
            this.Application.Documents.Add(path);
        }

        public void closeLastDocument()
        {
            this.Application.ActiveDocument.Close(Word.WdSaveOptions.wdPromptToSaveChanges);
        }

        public string readControlContent(int contentControlIndex)
        {
            return this.Application.ActiveDocument.ContentControls[contentControlIndex].Range.Text;
        }

        public void updateControlContent(int contentControlIndex,string updateText)
        {
            if (String.IsNullOrEmpty(updateText))
            {
                this.Application.ActiveDocument.ContentControls[contentControlIndex].Range.Text = "";
            }
            else
            {
                this.Application.ActiveDocument.ContentControls[contentControlIndex].Range.Text = updateText;
            }
            
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
