namespace NameSearchDemo
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
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.NamesListBox = new System.Windows.Forms.ListBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.SearchNameTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.LoadNamesButton = new System.Windows.Forms.Button();
            this.LoadSaveGrpBx = new System.Windows.Forms.GroupBox();
            this.SaveNameButton = new System.Windows.Forms.Button();
            this.SearchNameGrpBx = new System.Windows.Forms.GroupBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.LoadSaveGrpBx.SuspendLayout();
            this.SearchNameGrpBx.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.Location = new System.Drawing.Point(202, 9);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(120, 23);
            this.HeaderLabel.TabIndex = 0;
            this.HeaderLabel.Text = "Names Demo";
            // 
            // NamesListBox
            // 
            this.NamesListBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamesListBox.FormattingEnabled = true;
            this.NamesListBox.ItemHeight = 18;
            this.NamesListBox.Location = new System.Drawing.Point(49, 75);
            this.NamesListBox.Name = "NamesListBox";
            this.NamesListBox.Size = new System.Drawing.Size(474, 130);
            this.NamesListBox.TabIndex = 1;
            this.NamesListBox.SelectedIndexChanged += new System.EventHandler(this.NamesListBox_SelectedIndexChanged);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(15, 34);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(96, 16);
            this.SearchLabel.TabIndex = 2;
            this.SearchLabel.Text = "Search Name: ";
            // 
            // SearchNameTextBox
            // 
            this.SearchNameTextBox.Location = new System.Drawing.Point(117, 31);
            this.SearchNameTextBox.Name = "SearchNameTextBox";
            this.SearchNameTextBox.Size = new System.Drawing.Size(151, 22);
            this.SearchNameTextBox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // LoadNamesButton
            // 
            this.LoadNamesButton.Location = new System.Drawing.Point(35, 23);
            this.LoadNamesButton.Name = "LoadNamesButton";
            this.LoadNamesButton.Size = new System.Drawing.Size(108, 39);
            this.LoadNamesButton.TabIndex = 5;
            this.LoadNamesButton.Text = "Load Names";
            this.LoadNamesButton.UseVisualStyleBackColor = true;
            this.LoadNamesButton.Click += new System.EventHandler(this.LoadNamesButton_Click);
            // 
            // LoadSaveGrpBx
            // 
            this.LoadSaveGrpBx.Controls.Add(this.SaveNameButton);
            this.LoadSaveGrpBx.Controls.Add(this.LoadNamesButton);
            this.LoadSaveGrpBx.Location = new System.Drawing.Point(49, 224);
            this.LoadSaveGrpBx.Name = "LoadSaveGrpBx";
            this.LoadSaveGrpBx.Size = new System.Drawing.Size(177, 137);
            this.LoadSaveGrpBx.TabIndex = 6;
            this.LoadSaveGrpBx.TabStop = false;
            this.LoadSaveGrpBx.Text = "Load and Save";
            // 
            // SaveNameButton
            // 
            this.SaveNameButton.Location = new System.Drawing.Point(35, 68);
            this.SaveNameButton.Name = "SaveNameButton";
            this.SaveNameButton.Size = new System.Drawing.Size(108, 37);
            this.SaveNameButton.TabIndex = 6;
            this.SaveNameButton.Text = "Import Names";
            this.SaveNameButton.UseVisualStyleBackColor = true;
            this.SaveNameButton.Click += new System.EventHandler(this.SaveNameButton_Click);
            // 
            // SearchNameGrpBx
            // 
            this.SearchNameGrpBx.Controls.Add(this.SearchButton);
            this.SearchNameGrpBx.Controls.Add(this.SearchLabel);
            this.SearchNameGrpBx.Controls.Add(this.SearchNameTextBox);
            this.SearchNameGrpBx.Location = new System.Drawing.Point(232, 224);
            this.SearchNameGrpBx.Name = "SearchNameGrpBx";
            this.SearchNameGrpBx.Size = new System.Drawing.Size(291, 137);
            this.SearchNameGrpBx.TabIndex = 7;
            this.SearchNameGrpBx.TabStop = false;
            this.SearchNameGrpBx.Text = "Search";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(80, 68);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(138, 32);
            this.SearchButton.TabIndex = 4;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // OutputLabel
            // 
            this.OutputLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.OutputLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputLabel.Location = new System.Drawing.Point(143, 374);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(280, 67);
            this.OutputLabel.TabIndex = 8;
            this.OutputLabel.Text = "Status will be updated here";
            this.OutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 464);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.SearchNameGrpBx);
            this.Controls.Add(this.LoadSaveGrpBx);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NamesListBox);
            this.Controls.Add(this.HeaderLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.LoadSaveGrpBx.ResumeLayout(false);
            this.SearchNameGrpBx.ResumeLayout(false);
            this.SearchNameGrpBx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.ListBox NamesListBox;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.TextBox SearchNameTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button LoadNamesButton;
        private System.Windows.Forms.GroupBox LoadSaveGrpBx;
        private System.Windows.Forms.Button SaveNameButton;
        private System.Windows.Forms.GroupBox SearchNameGrpBx;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label OutputLabel;
    }
}

