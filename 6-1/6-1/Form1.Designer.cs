namespace _6_1
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
            this.height_label = new System.Windows.Forms.Label();
            this.height = new System.Windows.Forms.TextBox();
            this.weight_label = new System.Windows.Forms.Label();
            this.weight = new System.Windows.Forms.TextBox();
            this.bmi_label = new System.Windows.Forms.Label();
            this.nbmi_label = new System.Windows.Forms.Label();
            this.bmi = new System.Windows.Forms.Label();
            this.nbmi = new System.Windows.Forms.Label();
            this.bmi_standard = new System.Windows.Forms.Label();
            this.nbmi_standard = new System.Windows.Forms.Label();
            this.send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // height_label
            // 
            this.height_label.AutoSize = true;
            this.height_label.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.height_label.Location = new System.Drawing.Point(12, 14);
            this.height_label.Name = "height_label";
            this.height_label.Size = new System.Drawing.Size(84, 20);
            this.height_label.TabIndex = 0;
            this.height_label.Text = "身高(cm)";
            // 
            // height
            // 
            this.height.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.height.Location = new System.Drawing.Point(142, 12);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(144, 31);
            this.height.TabIndex = 1;
            // 
            // weight_label
            // 
            this.weight_label.AutoSize = true;
            this.weight_label.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.weight_label.Location = new System.Drawing.Point(12, 66);
            this.weight_label.Name = "weight_label";
            this.weight_label.Size = new System.Drawing.Size(79, 20);
            this.weight_label.TabIndex = 2;
            this.weight_label.Text = "體重(kg)";
            // 
            // weight
            // 
            this.weight.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.weight.Location = new System.Drawing.Point(142, 67);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(144, 31);
            this.weight.TabIndex = 3;
            // 
            // bmi_label
            // 
            this.bmi_label.AutoSize = true;
            this.bmi_label.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bmi_label.Location = new System.Drawing.Point(12, 133);
            this.bmi_label.Name = "bmi_label";
            this.bmi_label.Size = new System.Drawing.Size(45, 20);
            this.bmi_label.TabIndex = 4;
            this.bmi_label.Text = "BMI";
            // 
            // nbmi_label
            // 
            this.nbmi_label.AutoSize = true;
            this.nbmi_label.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.nbmi_label.Location = new System.Drawing.Point(12, 185);
            this.nbmi_label.Name = "nbmi_label";
            this.nbmi_label.Size = new System.Drawing.Size(93, 20);
            this.nbmi_label.TabIndex = 5;
            this.nbmi_label.Text = "NEW BMI";
            // 
            // bmi
            // 
            this.bmi.AutoSize = true;
            this.bmi.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bmi.Location = new System.Drawing.Point(142, 133);
            this.bmi.Name = "bmi";
            this.bmi.Size = new System.Drawing.Size(18, 20);
            this.bmi.TabIndex = 6;
            this.bmi.Text = "0";
            // 
            // nbmi
            // 
            this.nbmi.AutoSize = true;
            this.nbmi.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.nbmi.Location = new System.Drawing.Point(142, 185);
            this.nbmi.Name = "nbmi";
            this.nbmi.Size = new System.Drawing.Size(18, 20);
            this.nbmi.TabIndex = 7;
            this.nbmi.Text = "0";
            // 
            // bmi_standard
            // 
            this.bmi_standard.AutoSize = true;
            this.bmi_standard.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bmi_standard.Location = new System.Drawing.Point(334, 133);
            this.bmi_standard.Name = "bmi_standard";
            this.bmi_standard.Size = new System.Drawing.Size(18, 20);
            this.bmi_standard.TabIndex = 8;
            this.bmi_standard.Text = "0";
            // 
            // nbmi_standard
            // 
            this.nbmi_standard.AutoSize = true;
            this.nbmi_standard.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.nbmi_standard.Location = new System.Drawing.Point(334, 185);
            this.nbmi_standard.Name = "nbmi_standard";
            this.nbmi_standard.Size = new System.Drawing.Size(18, 20);
            this.nbmi_standard.TabIndex = 9;
            this.nbmi_standard.Text = "0";
            // 
            // send
            // 
            this.send.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.send.Location = new System.Drawing.Point(331, 14);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(139, 84);
            this.send.TabIndex = 10;
            this.send.Text = "送出";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(482, 255);
            this.Controls.Add(this.send);
            this.Controls.Add(this.nbmi_standard);
            this.Controls.Add(this.bmi_standard);
            this.Controls.Add(this.nbmi);
            this.Controls.Add(this.bmi);
            this.Controls.Add(this.nbmi_label);
            this.Controls.Add(this.bmi_label);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.weight_label);
            this.Controls.Add(this.height);
            this.Controls.Add(this.height_label);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "計算BMI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label height_label;
        private System.Windows.Forms.TextBox height;
        private System.Windows.Forms.Label weight_label;
        private System.Windows.Forms.TextBox weight;
        private System.Windows.Forms.Label bmi_label;
        private System.Windows.Forms.Label nbmi_label;
        private System.Windows.Forms.Label bmi;
        private System.Windows.Forms.Label nbmi;
        private System.Windows.Forms.Label bmi_standard;
        private System.Windows.Forms.Label nbmi_standard;
        private System.Windows.Forms.Button send;
    }
}

