namespace LGH
{
    partial class AddSectionedpost
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
            this.comboBoxDesignation = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpost = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtdesignationid = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(77, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose Designation";
            // 
            // comboBoxDesignation
            // 
            this.comboBoxDesignation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxDesignation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxDesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDesignation.FormattingEnabled = true;
            this.comboBoxDesignation.Location = new System.Drawing.Point(264, 49);
            this.comboBoxDesignation.Name = "comboBoxDesignation";
            this.comboBoxDesignation.Size = new System.Drawing.Size(304, 24);
            this.comboBoxDesignation.TabIndex = 1;
            this.comboBoxDesignation.SelectedIndexChanged += new System.EventHandler(this.comboBoxDesignation_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "No.of Post";
            // 
            // txtpost
            // 
            this.txtpost.Location = new System.Drawing.Point(264, 100);
            this.txtpost.Name = "txtpost";
            this.txtpost.Size = new System.Drawing.Size(100, 20);
            this.txtpost.TabIndex = 3;
            this.txtpost.TextChanged += new System.EventHandler(this.txtpost_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(323, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtdesignationid
            // 
            this.txtdesignationid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdesignationid.Location = new System.Drawing.Point(574, 49);
            this.txtdesignationid.Name = "txtdesignationid";
            this.txtdesignationid.ReadOnly = true;
            this.txtdesignationid.Size = new System.Drawing.Size(60, 22);
            this.txtdesignationid.TabIndex = 5;
            // 
            // AddSectionedpost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 235);
            this.Controls.Add(this.txtdesignationid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtpost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxDesignation);
            this.Controls.Add(this.label1);
            this.Name = "AddSectionedpost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddSectionedpost";
            this.Load += new System.EventHandler(this.AddSectionedpost_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxDesignation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpost;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtdesignationid;
    }
}