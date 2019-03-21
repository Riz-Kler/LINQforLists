namespace FormUI
{
    partial class Dashboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.allPeopleDropdown = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.filteredPeopleList = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.updatePersonButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.yearsExperiencePicker = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.yearsExperiencePicker)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Linq 101 Demo";
            // 
            // allPeopleDropdown
            // 
            this.allPeopleDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allPeopleDropdown.FormattingEnabled = true;
            this.allPeopleDropdown.Location = new System.Drawing.Point(46, 141);
            this.allPeopleDropdown.Name = "allPeopleDropdown";
            this.allPeopleDropdown.Size = new System.Drawing.Size(121, 24);
            this.allPeopleDropdown.TabIndex = 1;
            this.allPeopleDropdown.SelectedIndexChanged += new System.EventHandler(this.allPeopleDropdown_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "All People";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // filteredPeopleList
            // 
            this.filteredPeopleList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filteredPeopleList.FormattingEnabled = true;
            this.filteredPeopleList.ItemHeight = 16;
            this.filteredPeopleList.Location = new System.Drawing.Point(549, 193);
            this.filteredPeopleList.Name = "filteredPeopleList";
            this.filteredPeopleList.Size = new System.Drawing.Size(183, 132);
            this.filteredPeopleList.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(544, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Filtered List";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // updatePersonButton
            // 
            this.updatePersonButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatePersonButton.Location = new System.Drawing.Point(178, 357);
            this.updatePersonButton.Name = "updatePersonButton";
            this.updatePersonButton.Size = new System.Drawing.Size(126, 45);
            this.updatePersonButton.TabIndex = 5;
            this.updatePersonButton.Text = "Update";
            this.updatePersonButton.UseVisualStyleBackColor = true;
            this.updatePersonButton.Click += new System.EventHandler(this.updatePersonButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Years Experience";
            // 
            // yearsExperiencePicker
            // 
            this.yearsExperiencePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearsExperiencePicker.Location = new System.Drawing.Point(46, 245);
            this.yearsExperiencePicker.Name = "yearsExperiencePicker";
            this.yearsExperiencePicker.Size = new System.Drawing.Size(120, 23);
            this.yearsExperiencePicker.TabIndex = 7;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.yearsExperiencePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.updatePersonButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.filteredPeopleList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.allPeopleDropdown);
            this.Controls.Add(this.label1);
            this.Name = "Dashboard";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.yearsExperiencePicker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox allPeopleDropdown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox filteredPeopleList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button updatePersonButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown yearsExperiencePicker;
    }
}

