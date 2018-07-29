namespace productDetails
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
            this.id = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.ename = new System.Windows.Forms.TextBox();
            this.lable = new System.Windows.Forms.Label();
            this.elable = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(235, 32);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(100, 20);
            this.id.TabIndex = 0;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(48, 35);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(65, 13);
            this.labelID.TabIndex = 1;
            this.labelID.Text = "Employee Id";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(48, 80);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(84, 13);
            this.name.TabIndex = 3;
            this.name.Text = "Employee Name";
            // 
            // ename
            // 
            this.ename.Location = new System.Drawing.Point(235, 77);
            this.ename.Name = "ename";
            this.ename.Size = new System.Drawing.Size(100, 20);
            this.ename.TabIndex = 2;
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Location = new System.Drawing.Point(57, 126);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(82, 13);
            this.lable.TabIndex = 4;
            this.lable.Text = "Employee Lable";
            // 
            // elable
            // 
            this.elable.Location = new System.Drawing.Point(235, 126);
            this.elable.Name = "elable";
            this.elable.Size = new System.Drawing.Size(100, 20);
            this.elable.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 349);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.elable);
            this.Controls.Add(this.lable);
            this.Controls.Add(this.name);
            this.Controls.Add(this.ename);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.id);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox ename;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.TextBox elable;
        private System.Windows.Forms.Button button1;
    }
}

