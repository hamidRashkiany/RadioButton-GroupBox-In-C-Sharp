
namespace J15RadioButton
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
            this.label1 = new System.Windows.Forms.Label();
            this.rdoRed = new System.Windows.Forms.RadioButton();
            this.rdoBlue = new System.Windows.Forms.RadioButton();
            this.rdoGreen = new System.Windows.Forms.RadioButton();
            this.btnChangeColor = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoVioletColor = new System.Windows.Forms.RadioButton();
            this.rdoOrange = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please select one color:";
            // 
            // rdoRed
            // 
            this.rdoRed.AutoSize = true;
            this.rdoRed.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoRed.Location = new System.Drawing.Point(6, 28);
            this.rdoRed.Name = "rdoRed";
            this.rdoRed.Size = new System.Drawing.Size(83, 22);
            this.rdoRed.TabIndex = 1;
            this.rdoRed.TabStop = true;
            this.rdoRed.Text = "Red Color";
            this.rdoRed.UseVisualStyleBackColor = true;
            // 
            // rdoBlue
            // 
            this.rdoBlue.AutoSize = true;
            this.rdoBlue.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBlue.Location = new System.Drawing.Point(6, 63);
            this.rdoBlue.Name = "rdoBlue";
            this.rdoBlue.Size = new System.Drawing.Size(87, 22);
            this.rdoBlue.TabIndex = 2;
            this.rdoBlue.TabStop = true;
            this.rdoBlue.Text = "Blue Color";
            this.rdoBlue.UseVisualStyleBackColor = true;
            this.rdoBlue.CheckedChanged += new System.EventHandler(this.rdoBlue_CheckedChanged);
            // 
            // rdoGreen
            // 
            this.rdoGreen.AutoSize = true;
            this.rdoGreen.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoGreen.Location = new System.Drawing.Point(6, 102);
            this.rdoGreen.Name = "rdoGreen";
            this.rdoGreen.Size = new System.Drawing.Size(93, 22);
            this.rdoGreen.TabIndex = 3;
            this.rdoGreen.TabStop = true;
            this.rdoGreen.Text = "Green Color";
            this.rdoGreen.UseVisualStyleBackColor = true;
            // 
            // btnChangeColor
            // 
            this.btnChangeColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeColor.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeColor.Location = new System.Drawing.Point(15, 201);
            this.btnChangeColor.Name = "btnChangeColor";
            this.btnChangeColor.Size = new System.Drawing.Size(96, 23);
            this.btnChangeColor.TabIndex = 4;
            this.btnChangeColor.Text = "Change Color";
            this.btnChangeColor.UseVisualStyleBackColor = true;
            this.btnChangeColor.Click += new System.EventHandler(this.btnChangeColor_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoRed);
            this.groupBox1.Controls.Add(this.rdoBlue);
            this.groupBox1.Controls.Add(this.rdoGreen);
            this.groupBox1.Location = new System.Drawing.Point(15, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 139);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Background Color Form";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoOrange);
            this.groupBox2.Controls.Add(this.rdoVioletColor);
            this.groupBox2.Location = new System.Drawing.Point(221, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Label Color";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // rdoVioletColor
            // 
            this.rdoVioletColor.AutoSize = true;
            this.rdoVioletColor.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoVioletColor.Location = new System.Drawing.Point(3, 33);
            this.rdoVioletColor.Name = "rdoVioletColor";
            this.rdoVioletColor.Size = new System.Drawing.Size(94, 22);
            this.rdoVioletColor.TabIndex = 0;
            this.rdoVioletColor.TabStop = true;
            this.rdoVioletColor.Text = "Violet Color";
            this.rdoVioletColor.UseVisualStyleBackColor = true;
            this.rdoVioletColor.CheckedChanged += new System.EventHandler(this.rdoVioletColor_CheckedChanged);
            // 
            // rdoOrange
            // 
            this.rdoOrange.AutoSize = true;
            this.rdoOrange.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoOrange.Location = new System.Drawing.Point(3, 56);
            this.rdoOrange.Name = "rdoOrange";
            this.rdoOrange.Size = new System.Drawing.Size(99, 22);
            this.rdoOrange.TabIndex = 1;
            this.rdoOrange.TabStop = true;
            this.rdoOrange.Text = "Orange Color";
            this.rdoOrange.UseVisualStyleBackColor = true;
            this.rdoOrange.CheckedChanged += new System.EventHandler(this.rdoOrange_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 260);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnChangeColor);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoRed;
        private System.Windows.Forms.RadioButton rdoBlue;
        private System.Windows.Forms.RadioButton rdoGreen;
        private System.Windows.Forms.Button btnChangeColor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoOrange;
        private System.Windows.Forms.RadioButton rdoVioletColor;
    }
}

