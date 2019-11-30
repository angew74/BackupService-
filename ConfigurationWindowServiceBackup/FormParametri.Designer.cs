namespace ConfigurationWindowServiceBackup
{
    partial class FormParametri
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabCtlParametri = new System.Windows.Forms.TabControl();
            this.tabPageFile = new System.Windows.Forms.TabPage();
            this.buttonOK = new System.Windows.Forms.Button();
            this.textBoxFile = new System.Windows.Forms.TextBox();
            this.labelText = new System.Windows.Forms.Label();
            this.tabPageGoogleDrive = new System.Windows.Forms.TabPage();
            this.tabPageCartella = new System.Windows.Forms.TabPage();
            this.btnOKCartella = new System.Windows.Forms.Button();
            this.textBoxCartella = new System.Windows.Forms.TextBox();
            this.labelCartella = new System.Windows.Forms.Label();
            this.listViewFiles = new System.Windows.Forms.ListView();
            this.labelErrore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabCtlParametri.SuspendLayout();
            this.tabPageFile.SuspendLayout();
            this.tabPageGoogleDrive.SuspendLayout();
            this.tabPageCartella.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCtlParametri
            // 
            this.tabCtlParametri.Controls.Add(this.tabPageFile);
            this.tabCtlParametri.Controls.Add(this.tabPageGoogleDrive);
            this.tabCtlParametri.Controls.Add(this.tabPageCartella);
            this.tabCtlParametri.Location = new System.Drawing.Point(3, 12);
            this.tabCtlParametri.Name = "tabCtlParametri";
            this.tabCtlParametri.SelectedIndex = 0;
            this.tabCtlParametri.Size = new System.Drawing.Size(1433, 203);
            this.tabCtlParametri.TabIndex = 0;
            // 
            // tabPageFile
            // 
            this.tabPageFile.Controls.Add(this.buttonOK);
            this.tabPageFile.Controls.Add(this.textBoxFile);
            this.tabPageFile.Controls.Add(this.labelText);
            this.tabPageFile.Location = new System.Drawing.Point(4, 29);
            this.tabPageFile.Name = "tabPageFile";
            this.tabPageFile.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFile.Size = new System.Drawing.Size(1425, 170);
            this.tabPageFile.TabIndex = 0;
            this.tabPageFile.Text = "Gestione File";
            this.tabPageFile.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(1323, 18);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 29);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // textBoxFile
            // 
            this.textBoxFile.Location = new System.Drawing.Point(130, 21);
            this.textBoxFile.Name = "textBoxFile";
            this.textBoxFile.Size = new System.Drawing.Size(1187, 26);
            this.textBoxFile.TabIndex = 1;
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Location = new System.Drawing.Point(21, 21);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(101, 20);
            this.labelText.TabIndex = 0;
            this.labelText.Text = "Percorso File";
            // 
            // tabPageGoogleDrive
            // 
            this.tabPageGoogleDrive.Controls.Add(this.label1);
            this.tabPageGoogleDrive.Location = new System.Drawing.Point(4, 29);
            this.tabPageGoogleDrive.Name = "tabPageGoogleDrive";
            this.tabPageGoogleDrive.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGoogleDrive.Size = new System.Drawing.Size(1425, 170);
            this.tabPageGoogleDrive.TabIndex = 1;
            this.tabPageGoogleDrive.Text = "Gestione Google Drive";
            this.tabPageGoogleDrive.UseVisualStyleBackColor = true;
            // 
            // tabPageCartella
            // 
            this.tabPageCartella.Controls.Add(this.btnOKCartella);
            this.tabPageCartella.Controls.Add(this.textBoxCartella);
            this.tabPageCartella.Controls.Add(this.labelCartella);
            this.tabPageCartella.Location = new System.Drawing.Point(4, 29);
            this.tabPageCartella.Name = "tabPageCartella";
            this.tabPageCartella.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCartella.Size = new System.Drawing.Size(1429, 67);
            this.tabPageCartella.TabIndex = 2;
            this.tabPageCartella.Text = "Gestione Cartella";
            this.tabPageCartella.UseVisualStyleBackColor = true;
            // 
            // btnOKCartella
            // 
            this.btnOKCartella.Location = new System.Drawing.Point(1337, 20);
            this.btnOKCartella.Name = "btnOKCartella";
            this.btnOKCartella.Size = new System.Drawing.Size(75, 27);
            this.btnOKCartella.TabIndex = 2;
            this.btnOKCartella.Text = "OK";
            this.btnOKCartella.UseVisualStyleBackColor = true;
            this.btnOKCartella.Click += new System.EventHandler(this.btnOKCartella_Click);
            // 
            // textBoxCartella
            // 
            this.textBoxCartella.Location = new System.Drawing.Point(99, 13);
            this.textBoxCartella.Name = "textBoxCartella";
            this.textBoxCartella.Size = new System.Drawing.Size(1214, 26);
            this.textBoxCartella.TabIndex = 1;
            // 
            // labelCartella
            // 
            this.labelCartella.AutoSize = true;
            this.labelCartella.Location = new System.Drawing.Point(18, 20);
            this.labelCartella.Name = "labelCartella";
            this.labelCartella.Size = new System.Drawing.Size(63, 20);
            this.labelCartella.TabIndex = 0;
            this.labelCartella.Text = "Cartella";
            // 
            // listViewFiles
            // 
            this.listViewFiles.HideSelection = false;
            this.listViewFiles.Location = new System.Drawing.Point(3, 244);
            this.listViewFiles.Name = "listViewFiles";
            this.listViewFiles.Size = new System.Drawing.Size(1433, 345);
            this.listViewFiles.TabIndex = 3;
            this.listViewFiles.UseCompatibleStateImageBehavior = false;
            this.listViewFiles.SelectedIndexChanged += new System.EventHandler(this.listViewFiles_SelectedIndexChanged);
            // 
            // labelErrore
            // 
            this.labelErrore.AutoSize = true;
            this.labelErrore.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.labelErrore.Location = new System.Drawing.Point(37, 407);
            this.labelErrore.Name = "labelErrore";
            this.labelErrore.Size = new System.Drawing.Size(0, 20);
            this.labelErrore.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // FormParametri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1760, 601);
            this.Controls.Add(this.listViewFiles);
            this.Controls.Add(this.labelErrore);
            this.Controls.Add(this.tabCtlParametri);
            this.Name = "FormParametri";
            this.Text = "Form Inserimento Parametri";
            this.tabCtlParametri.ResumeLayout(false);
            this.tabPageFile.ResumeLayout(false);
            this.tabPageFile.PerformLayout();
            this.tabPageGoogleDrive.ResumeLayout(false);
            this.tabPageGoogleDrive.PerformLayout();
            this.tabPageCartella.ResumeLayout(false);
            this.tabPageCartella.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabCtlParametri;
        private System.Windows.Forms.TabPage tabPageFile;
        private System.Windows.Forms.TabPage tabPageGoogleDrive;
        private System.Windows.Forms.ListView listViewFiles;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.TextBox textBoxFile;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.TabPage tabPageCartella;
        private System.Windows.Forms.Button btnOKCartella;
        private System.Windows.Forms.TextBox textBoxCartella;
        private System.Windows.Forms.Label labelCartella;
        private System.Windows.Forms.Label labelErrore;
        private System.Windows.Forms.Label label1;
    }
}

