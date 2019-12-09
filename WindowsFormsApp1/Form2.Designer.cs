namespace WindowsFormsApp1
{
    partial class Form2
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
            this.textBox_howMenyRooms = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_toForm3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(556, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "First things first how meny rooms are we going to do?";

            // 
            // textBox_howMenyRooms
            // 
            this.textBox_howMenyRooms.Location = new System.Drawing.Point(631, 29);
            this.textBox_howMenyRooms.Name = "textBox_howMenyRooms";
            this.textBox_howMenyRooms.Size = new System.Drawing.Size(83, 22);
            this.textBox_howMenyRooms.TabIndex = 1;
            this.textBox_howMenyRooms.TextChanged += new System.EventHandler(this.TextBox_howMenyRooms_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "WE CAN ONLY DO UP TO 4 ROOMS";
            // 
            // button_toForm3
            // 
            this.button_toForm3.Location = new System.Drawing.Point(693, 71);
            this.button_toForm3.Name = "button_toForm3";
            this.button_toForm3.Size = new System.Drawing.Size(95, 36);
            this.button_toForm3.TabIndex = 3;
            this.button_toForm3.Text = "CONTINUE";
            this.button_toForm3.UseVisualStyleBackColor = true;
            this.button_toForm3.Click += new System.EventHandler(this.Button_toForm3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 119);
            this.Controls.Add(this.button_toForm3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_howMenyRooms);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_howMenyRooms;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_toForm3;
    }
}