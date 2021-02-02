namespace AVL
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
            this.components = new System.ComponentModel.Container();
            this.valueBox = new System.Windows.Forms.TextBox();
            this.InsertBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.Find = new System.Windows.Forms.Button();
            this.InOrder = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Status = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.meaningBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // valueBox
            // 
            this.valueBox.Location = new System.Drawing.Point(55, 37);
            this.valueBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.valueBox.Name = "valueBox";
            this.valueBox.Size = new System.Drawing.Size(164, 22);
            this.valueBox.TabIndex = 0;
            // 
            // InsertBtn
            // 
            this.InsertBtn.Location = new System.Drawing.Point(485, 37);
            this.InsertBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InsertBtn.Name = "InsertBtn";
            this.InsertBtn.Size = new System.Drawing.Size(100, 28);
            this.InsertBtn.TabIndex = 1;
            this.InsertBtn.Text = "Insert";
            this.InsertBtn.UseVisualStyleBackColor = true;
            this.InsertBtn.Click += new System.EventHandler(this.InsertBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(608, 37);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(100, 28);
            this.deleteBtn.TabIndex = 2;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // Find
            // 
            this.Find.Location = new System.Drawing.Point(737, 37);
            this.Find.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(100, 28);
            this.Find.TabIndex = 3;
            this.Find.Text = "Find";
            this.Find.UseVisualStyleBackColor = true;
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // InOrder
            // 
            this.InOrder.Location = new System.Drawing.Point(873, 37);
            this.InOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InOrder.Name = "InOrder";
            this.InOrder.Size = new System.Drawing.Size(100, 28);
            this.InOrder.TabIndex = 4;
            this.InOrder.Text = "InOrder";
            this.InOrder.UseVisualStyleBackColor = true;
            this.InOrder.Click += new System.EventHandler(this.InOrder_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(16, 90);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1821, 788);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.Location = new System.Drawing.Point(941, 778);
            this.Status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(85, 29);
            this.Status.TabIndex = 6;
            this.Status.Text = "Status";
            this.Status.TextChanged += new System.EventHandler(this.Status_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 7000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // meaningBox
            // 
            this.meaningBox.Location = new System.Drawing.Point(228, 37);
            this.meaningBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.meaningBox.Name = "meaningBox";
            this.meaningBox.Size = new System.Drawing.Size(164, 22);
            this.meaningBox.TabIndex = 7;
            this.meaningBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1800, 838);
            this.Controls.Add(this.meaningBox);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.InOrder);
            this.Controls.Add(this.Find);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.InsertBtn);
            this.Controls.Add(this.valueBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox valueBox;
        private System.Windows.Forms.Button InsertBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.Button InOrder;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label Status;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox meaningBox;
    }
}

