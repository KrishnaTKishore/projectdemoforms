namespace projectdemoforms
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
            this.Show = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Distance_travelled = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.Time_of_booking = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Show
            // 
            this.Show.Location = new System.Drawing.Point(407, 53);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(93, 25);
            this.Show.TabIndex = 0;
            this.Show.Text = "show";
            this.Show.UseVisualStyleBackColor = true;
            this.Show.Click += new System.EventHandler(this.Show_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(49, 197);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(451, 220);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(407, 84);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(93, 23);
            this.update.TabIndex = 3;
            this.update.Text = "update";
            this.update.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(407, 122);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(93, 23);
            this.delete.TabIndex = 4;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(168, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Distance_travelled
            // 
            this.Distance_travelled.AutoSize = true;
            this.Distance_travelled.Location = new System.Drawing.Point(46, 36);
            this.Distance_travelled.Name = "Distance_travelled";
            this.Distance_travelled.Size = new System.Drawing.Size(95, 13);
            this.Distance_travelled.TabIndex = 8;
            this.Distance_travelled.Text = "Distance_travelled";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(407, 161);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(93, 23);
            this.Add.TabIndex = 11;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Time_of_booking
            // 
            this.Time_of_booking.Location = new System.Drawing.Point(168, 69);
            this.Time_of_booking.Name = "Time_of_booking";
            this.Time_of_booking.Size = new System.Drawing.Size(100, 20);
            this.Time_of_booking.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Time_of_booking";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Time_of_booking);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Distance_travelled);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Show);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Show;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Distance_travelled;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox Time_of_booking;
        private System.Windows.Forms.Label label1;
    }
}

