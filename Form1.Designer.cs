namespace WindowsFormsApplication1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.get = new System.Windows.Forms.RadioButton();
            this.post = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.respones_btn = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(180, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(180, 159);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(285, 81);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "a=value1&b=value2";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // get
            // 
            this.get.AutoSize = true;
            this.get.Location = new System.Drawing.Point(376, 87);
            this.get.Name = "get";
            this.get.Size = new System.Drawing.Size(58, 21);
            this.get.TabIndex = 2;
            this.get.TabStop = true;
            this.get.Text = "GET";
            this.get.UseVisualStyleBackColor = true;
            this.get.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // post
            // 
            this.post.AutoSize = true;
            this.post.Location = new System.Drawing.Point(376, 115);
            this.post.Name = "post";
            this.post.Size = new System.Drawing.Size(67, 21);
            this.post.TabIndex = 3;
            this.post.TabStop = true;
            this.post.Text = "POST";
            this.post.UseVisualStyleBackColor = true;
            this.post.CheckedChanged += new System.EventHandler(this.post_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "URL";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "DATA";
            // 
            // respones_btn
            // 
            this.respones_btn.Location = new System.Drawing.Point(254, 277);
            this.respones_btn.Name = "respones_btn";
            this.respones_btn.Size = new System.Drawing.Size(124, 42);
            this.respones_btn.TabIndex = 6;
            this.respones_btn.Text = "response";
            this.respones_btn.UseVisualStyleBackColor = true;
            this.respones_btn.Click += new System.EventHandler(this.respones_btn_Click);
            // 
            // result
            // 
            this.result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.result.Location = new System.Drawing.Point(177, 348);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(288, 244);
            this.result.TabIndex = 7;
            this.result.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox3
            // 
            this.textBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.textBox3.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.HideSelection = false;
            this.textBox3.Location = new System.Drawing.Point(177, 115);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(193, 15);
            this.textBox3.TabIndex = 9;
            this.textBox3.Text = "ex: http://www.google.com";
            this.textBox3.WordWrap = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 725);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.result);
            this.Controls.Add(this.respones_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.post);
            this.Controls.Add(this.get);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton get;
        private System.Windows.Forms.RadioButton post;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button respones_btn;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.TextBox textBox3;
    }
}

