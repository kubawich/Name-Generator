namespace NameGen
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblWynik = new System.Windows.Forms.Label();
            this.btnGeneruj = new System.Windows.Forms.Button();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.btnAddName = new System.Windows.Forms.Button();
            this.btnAddSurname = new System.Windows.Forms.Button();
            this.SurnameBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblWynik
            // 
            this.lblWynik.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWynik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblWynik.Location = new System.Drawing.Point(69, 9);
            this.lblWynik.Name = "lblWynik";
            this.lblWynik.Size = new System.Drawing.Size(154, 23);
            this.lblWynik.TabIndex = 0;
            this.lblWynik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGeneruj
            // 
            this.btnGeneruj.Location = new System.Drawing.Point(69, 35);
            this.btnGeneruj.Name = "btnGeneruj";
            this.btnGeneruj.Size = new System.Drawing.Size(154, 23);
            this.btnGeneruj.TabIndex = 1;
            this.btnGeneruj.Text = "Generuj";
            this.btnGeneruj.UseVisualStyleBackColor = true;
            this.btnGeneruj.Click += new System.EventHandler(this.StartGenerate);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(12, 103);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(108, 20);
            this.NameBox.TabIndex = 2;
            // 
            // btnAddName
            // 
            this.btnAddName.Location = new System.Drawing.Point(12, 129);
            this.btnAddName.Name = "btnAddName";
            this.btnAddName.Size = new System.Drawing.Size(108, 23);
            this.btnAddName.TabIndex = 3;
            this.btnAddName.Text = "Dodaj Imię";
            this.btnAddName.UseVisualStyleBackColor = true;
            this.btnAddName.Click += new System.EventHandler(this.AddName);
            // 
            // btnAddSurname
            // 
            this.btnAddSurname.Location = new System.Drawing.Point(163, 129);
            this.btnAddSurname.Name = "btnAddSurname";
            this.btnAddSurname.Size = new System.Drawing.Size(109, 23);
            this.btnAddSurname.TabIndex = 4;
            this.btnAddSurname.Text = "Dodaj Nazwisko";
            this.btnAddSurname.UseVisualStyleBackColor = true;
            this.btnAddSurname.Click += new System.EventHandler(this.AddSurname);
            // 
            // SurnameBox
            // 
            this.SurnameBox.Location = new System.Drawing.Point(163, 103);
            this.SurnameBox.Name = "SurnameBox";
            this.SurnameBox.Size = new System.Drawing.Size(108, 20);
            this.SurnameBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(284, 172);
            this.Controls.Add(this.SurnameBox);
            this.Controls.Add(this.btnAddSurname);
            this.Controls.Add(this.btnAddName);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.btnGeneruj);
            this.Controls.Add(this.lblWynik);
            this.Name = "Form1";
            this.Text = "Name Generator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblWynik;
        private System.Windows.Forms.Button btnGeneruj;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Button btnAddName;
        private System.Windows.Forms.Button btnAddSurname;
        private System.Windows.Forms.TextBox SurnameBox;
    }
}

