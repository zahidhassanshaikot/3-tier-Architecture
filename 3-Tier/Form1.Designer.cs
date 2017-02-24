namespace _3_Tier
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
            this.lblEmpname = new System.Windows.Forms.Label();
            this.lblEmpid = new System.Windows.Forms.Label();
            this.lblDept = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEname = new System.Windows.Forms.TextBox();
            this.txtContactno = new System.Windows.Forms.TextBox();
            this.txtEid = new System.Windows.Forms.TextBox();
            this.cmbDept = new System.Windows.Forms.ComboBox();
            this.Cmbloc = new System.Windows.Forms.ComboBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEmpname
            // 
            this.lblEmpname.AutoSize = true;
            this.lblEmpname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpname.Location = new System.Drawing.Point(34, 18);
            this.lblEmpname.Name = "lblEmpname";
            this.lblEmpname.Size = new System.Drawing.Size(80, 17);
            this.lblEmpname.TabIndex = 0;
            this.lblEmpname.Text = "EmpName";
            // 
            // lblEmpid
            // 
            this.lblEmpid.AutoSize = true;
            this.lblEmpid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpid.Location = new System.Drawing.Point(34, 70);
            this.lblEmpid.Name = "lblEmpid";
            this.lblEmpid.Size = new System.Drawing.Size(54, 17);
            this.lblEmpid.TabIndex = 1;
            this.lblEmpid.Text = "EmpID";
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDept.Location = new System.Drawing.Point(34, 130);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(92, 17);
            this.lblDept.TabIndex = 2;
            this.lblDept.Text = "Department";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(40, 192);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(70, 17);
            this.lblLocation.TabIndex = 3;
            this.lblLocation.Text = "Location";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "ContactNo";
            // 
            // txtEname
            // 
            this.txtEname.Location = new System.Drawing.Point(152, 18);
            this.txtEname.Name = "txtEname";
            this.txtEname.Size = new System.Drawing.Size(121, 20);
            this.txtEname.TabIndex = 5;
            // 
            // txtContactno
            // 
            this.txtContactno.Location = new System.Drawing.Point(152, 252);
            this.txtContactno.Name = "txtContactno";
            this.txtContactno.Size = new System.Drawing.Size(121, 20);
            this.txtContactno.TabIndex = 6;
            // 
            // txtEid
            // 
            this.txtEid.Location = new System.Drawing.Point(152, 70);
            this.txtEid.Name = "txtEid";
            this.txtEid.Size = new System.Drawing.Size(121, 20);
            this.txtEid.TabIndex = 7;
            // 
            // cmbDept
            // 
            this.cmbDept.FormattingEnabled = true;
            this.cmbDept.Location = new System.Drawing.Point(152, 130);
            this.cmbDept.Name = "cmbDept";
            this.cmbDept.Size = new System.Drawing.Size(121, 21);
            this.cmbDept.TabIndex = 8;
            // 
            // Cmbloc
            // 
            this.Cmbloc.FormattingEnabled = true;
            this.Cmbloc.Location = new System.Drawing.Point(152, 192);
            this.Cmbloc.Name = "Cmbloc";
            this.Cmbloc.Size = new System.Drawing.Size(121, 21);
            this.Cmbloc.TabIndex = 9;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(134, 304);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 10;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 351);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.Cmbloc);
            this.Controls.Add(this.cmbDept);
            this.Controls.Add(this.txtEid);
            this.Controls.Add(this.txtContactno);
            this.Controls.Add(this.txtEname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblDept);
            this.Controls.Add(this.lblEmpid);
            this.Controls.Add(this.lblEmpname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmpname;
        private System.Windows.Forms.Label lblEmpid;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEname;
        private System.Windows.Forms.TextBox txtContactno;
        private System.Windows.Forms.TextBox txtEid;
        private System.Windows.Forms.ComboBox cmbDept;
        private System.Windows.Forms.ComboBox Cmbloc;
        private System.Windows.Forms.Button btnRegister;
    }
}

