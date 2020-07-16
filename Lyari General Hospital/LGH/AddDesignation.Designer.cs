namespace LGH
{
    partial class AddDesignation
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
            this.txtdesignation = new System.Windows.Forms.TextBox();
            this.btndesignationadd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtdesignation
            // 
            this.txtdesignation.Location = new System.Drawing.Point(163, 45);
            this.txtdesignation.Name = "txtdesignation";
            this.txtdesignation.Size = new System.Drawing.Size(239, 20);
            this.txtdesignation.TabIndex = 0;
            this.txtdesignation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdesignation_KeyPress);
            // 
            // btndesignationadd
            // 
            this.btndesignationadd.Location = new System.Drawing.Point(421, 40);
            this.btndesignationadd.Name = "btndesignationadd";
            this.btndesignationadd.Size = new System.Drawing.Size(75, 29);
            this.btndesignationadd.TabIndex = 1;
            this.btndesignationadd.Text = "Add";
            this.btndesignationadd.UseVisualStyleBackColor = true;
            this.btndesignationadd.Click += new System.EventHandler(this.btndesignationadd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Designation Name";
            // 
            // AddDesignation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 129);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btndesignationadd);
            this.Controls.Add(this.txtdesignation);
            this.Name = "AddDesignation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddDesignation";
            this.Load += new System.EventHandler(this.AddDesignation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtdesignation;
        private System.Windows.Forms.Button btndesignationadd;
        private System.Windows.Forms.Label label1;
    }
}