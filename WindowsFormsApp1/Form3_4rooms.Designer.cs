namespace WindowsFormsApp1
{
    partial class Form3_4rooms
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
            this.label_width = new System.Windows.Forms.Label();
            this.label_length = new System.Windows.Forms.Label();
            this.textBox_width = new System.Windows.Forms.TextBox();
            this.textBox_length = new System.Windows.Forms.TextBox();
            this.label_room1 = new System.Windows.Forms.Label();
            this.label_room2 = new System.Windows.Forms.Label();
            this.label_room3 = new System.Windows.Forms.Label();
            this.label_room4 = new System.Windows.Forms.Label();
            this.button_Calculate = new System.Windows.Forms.Button();
            this.textBox_results = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_room1SqFt = new System.Windows.Forms.TextBox();
            this.textBox_room2SqFt = new System.Windows.Forms.TextBox();
            this.textBox_room4SqFt = new System.Windows.Forms.TextBox();
            this.textBox_room3SqFt = new System.Windows.Forms.TextBox();
            this.button_nextRoom = new System.Windows.Forms.Button();
            this.button_room4Next = new System.Windows.Forms.Button();
            this.button_room3Next = new System.Windows.Forms.Button();
            this.button_room2Next = new System.Windows.Forms.Button();
            this.button_done = new System.Windows.Forms.Button();
            this.textbox_totalSqFt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_width
            // 
            this.label_width.AutoSize = true;
            this.label_width.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_width.Location = new System.Drawing.Point(13, 28);
            this.label_width.Name = "label_width";
            this.label_width.Size = new System.Drawing.Size(306, 26);
            this.label_width.TabIndex = 0;
            this.label_width.Text = "What is the width of the room?";
            // 
            // label_length
            // 
            this.label_length.AutoSize = true;
            this.label_length.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_length.Location = new System.Drawing.Point(13, 93);
            this.label_length.Name = "label_length";
            this.label_length.Size = new System.Drawing.Size(314, 26);
            this.label_length.TabIndex = 1;
            this.label_length.Text = "What is the length of the room?";
            // 
            // textBox_width
            // 
            this.textBox_width.Location = new System.Drawing.Point(363, 32);
            this.textBox_width.Name = "textBox_width";
            this.textBox_width.Size = new System.Drawing.Size(100, 22);
            this.textBox_width.TabIndex = 2;
            this.textBox_width.TextChanged += new System.EventHandler(this.TextBox_width_TextChanged);
            // 
            // textBox_length
            // 
            this.textBox_length.Location = new System.Drawing.Point(363, 93);
            this.textBox_length.Name = "textBox_length";
            this.textBox_length.Size = new System.Drawing.Size(100, 22);
            this.textBox_length.TabIndex = 3;
            // 
            // label_room1
            // 
            this.label_room1.AutoSize = true;
            this.label_room1.Location = new System.Drawing.Point(18, 204);
            this.label_room1.Name = "label_room1";
            this.label_room1.Size = new System.Drawing.Size(57, 17);
            this.label_room1.TabIndex = 4;
            this.label_room1.Text = "Room 1";
            // 
            // label_room2
            // 
            this.label_room2.AutoSize = true;
            this.label_room2.Location = new System.Drawing.Point(200, 204);
            this.label_room2.Name = "label_room2";
            this.label_room2.Size = new System.Drawing.Size(57, 17);
            this.label_room2.TabIndex = 5;
            this.label_room2.Text = "Room 2";
            // 
            // label_room3
            // 
            this.label_room3.AutoSize = true;
            this.label_room3.Location = new System.Drawing.Point(18, 279);
            this.label_room3.Name = "label_room3";
            this.label_room3.Size = new System.Drawing.Size(57, 17);
            this.label_room3.TabIndex = 6;
            this.label_room3.Text = "Room 3";
            // 
            // label_room4
            // 
            this.label_room4.AutoSize = true;
            this.label_room4.Location = new System.Drawing.Point(200, 279);
            this.label_room4.Name = "label_room4";
            this.label_room4.Size = new System.Drawing.Size(57, 17);
            this.label_room4.TabIndex = 7;
            this.label_room4.Text = "Room 4";
            // 
            // button_Calculate
            // 
            this.button_Calculate.Location = new System.Drawing.Point(474, 67);
            this.button_Calculate.Name = "button_Calculate";
            this.button_Calculate.Size = new System.Drawing.Size(75, 23);
            this.button_Calculate.TabIndex = 8;
            this.button_Calculate.Text = "Calculate";
            this.button_Calculate.UseVisualStyleBackColor = true;
            this.button_Calculate.Click += new System.EventHandler(this.Button_Calculate_Click);
            // 
            // textBox_results
            // 
            this.textBox_results.Location = new System.Drawing.Point(579, 68);
            this.textBox_results.Name = "textBox_results";
            this.textBox_results.Size = new System.Drawing.Size(100, 22);
            this.textBox_results.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(686, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Sq ft.";
            // 
            // textBox_room1SqFt
            // 
            this.textBox_room1SqFt.Location = new System.Drawing.Point(18, 224);
            this.textBox_room1SqFt.Name = "textBox_room1SqFt";
            this.textBox_room1SqFt.Size = new System.Drawing.Size(54, 22);
            this.textBox_room1SqFt.TabIndex = 11;
            // 
            // textBox_room2SqFt
            // 
            this.textBox_room2SqFt.Location = new System.Drawing.Point(203, 224);
            this.textBox_room2SqFt.Name = "textBox_room2SqFt";
            this.textBox_room2SqFt.Size = new System.Drawing.Size(54, 22);
            this.textBox_room2SqFt.TabIndex = 12;
            // 
            // textBox_room4SqFt
            // 
            this.textBox_room4SqFt.Location = new System.Drawing.Point(203, 313);
            this.textBox_room4SqFt.Name = "textBox_room4SqFt";
            this.textBox_room4SqFt.Size = new System.Drawing.Size(54, 22);
            this.textBox_room4SqFt.TabIndex = 13;
            // 
            // textBox_room3SqFt
            // 
            this.textBox_room3SqFt.Location = new System.Drawing.Point(18, 313);
            this.textBox_room3SqFt.Name = "textBox_room3SqFt";
            this.textBox_room3SqFt.Size = new System.Drawing.Size(54, 22);
            this.textBox_room3SqFt.TabIndex = 14;
            // 
            // button_nextRoom
            // 
            this.button_nextRoom.Location = new System.Drawing.Point(579, 96);
            this.button_nextRoom.Name = "button_nextRoom";
            this.button_nextRoom.Size = new System.Drawing.Size(100, 38);
            this.button_nextRoom.TabIndex = 15;
            this.button_nextRoom.Text = "Room 1";
            this.button_nextRoom.UseVisualStyleBackColor = true;
            this.button_nextRoom.Click += new System.EventHandler(this.Button_nextRoom_Click);
            // 
            // button_room4Next
            // 
            this.button_room4Next.Location = new System.Drawing.Point(579, 228);
            this.button_room4Next.Name = "button_room4Next";
            this.button_room4Next.Size = new System.Drawing.Size(100, 38);
            this.button_room4Next.TabIndex = 16;
            this.button_room4Next.Text = "Room 4";
            this.button_room4Next.UseVisualStyleBackColor = true;
            this.button_room4Next.Click += new System.EventHandler(this.Button_room4Next_Click);
            // 
            // button_room3Next
            // 
            this.button_room3Next.Location = new System.Drawing.Point(579, 184);
            this.button_room3Next.Name = "button_room3Next";
            this.button_room3Next.Size = new System.Drawing.Size(100, 38);
            this.button_room3Next.TabIndex = 17;
            this.button_room3Next.Text = "Room 3";
            this.button_room3Next.UseVisualStyleBackColor = true;
            this.button_room3Next.Click += new System.EventHandler(this.Button_room3Next_Click);
            // 
            // button_room2Next
            // 
            this.button_room2Next.Location = new System.Drawing.Point(579, 140);
            this.button_room2Next.Name = "button_room2Next";
            this.button_room2Next.Size = new System.Drawing.Size(100, 38);
            this.button_room2Next.TabIndex = 18;
            this.button_room2Next.Text = "Room 2";
            this.button_room2Next.UseVisualStyleBackColor = true;
            this.button_room2Next.Click += new System.EventHandler(this.Button_room2Next_Click);
            // 
            // button_done
            // 
            this.button_done.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button_done.ForeColor = System.Drawing.Color.Silver;
            this.button_done.Location = new System.Drawing.Point(579, 272);
            this.button_done.Name = "button_done";
            this.button_done.Size = new System.Drawing.Size(100, 38);
            this.button_done.TabIndex = 19;
            this.button_done.Text = "Done";
            this.button_done.UseVisualStyleBackColor = false;
            this.button_done.Click += new System.EventHandler(this.Button_done_Click);
            // 
            // textbox_totalSqFt
            // 
            this.textbox_totalSqFt.Location = new System.Drawing.Point(579, 316);
            this.textbox_totalSqFt.Name = "textbox_totalSqFt";
            this.textbox_totalSqFt.Size = new System.Drawing.Size(100, 22);
            this.textbox_totalSqFt.TabIndex = 20;
            this.textbox_totalSqFt.TextChanged += new System.EventHandler(this.Textbox_totalSqFt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(488, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Total SqFt =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "After you enter the width and length";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(340, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Press the calculate button and then what room it was";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textbox_totalSqFt);
            this.Controls.Add(this.button_done);
            this.Controls.Add(this.button_room2Next);
            this.Controls.Add(this.button_room3Next);
            this.Controls.Add(this.button_room4Next);
            this.Controls.Add(this.button_nextRoom);
            this.Controls.Add(this.textBox_room3SqFt);
            this.Controls.Add(this.textBox_room4SqFt);
            this.Controls.Add(this.textBox_room2SqFt);
            this.Controls.Add(this.textBox_room1SqFt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_results);
            this.Controls.Add(this.button_Calculate);
            this.Controls.Add(this.label_room4);
            this.Controls.Add(this.label_room3);
            this.Controls.Add(this.label_room2);
            this.Controls.Add(this.label_room1);
            this.Controls.Add(this.textBox_length);
            this.Controls.Add(this.textBox_width);
            this.Controls.Add(this.label_length);
            this.Controls.Add(this.label_width);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_width;
        private System.Windows.Forms.Label label_length;
        private System.Windows.Forms.TextBox textBox_width;
        private System.Windows.Forms.TextBox textBox_length;
        private System.Windows.Forms.Label label_room1;
        private System.Windows.Forms.Label label_room2;
        private System.Windows.Forms.Label label_room3;
        private System.Windows.Forms.Label label_room4;
        private System.Windows.Forms.Button button_Calculate;
        private System.Windows.Forms.TextBox textBox_results;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_room1SqFt;
        private System.Windows.Forms.TextBox textBox_room2SqFt;
        private System.Windows.Forms.TextBox textBox_room4SqFt;
        private System.Windows.Forms.TextBox textBox_room3SqFt;
        private System.Windows.Forms.Button button_nextRoom;
        private System.Windows.Forms.Button button_room4Next;
        private System.Windows.Forms.Button button_room3Next;
        private System.Windows.Forms.Button button_room2Next;
        private System.Windows.Forms.Button button_done;
        private System.Windows.Forms.TextBox textbox_totalSqFt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}