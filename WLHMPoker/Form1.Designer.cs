namespace WLHMPoker
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbCard1 = new System.Windows.Forms.Label();
            this.lbTrick = new System.Windows.Forms.Label();
            this.lbCard2 = new System.Windows.Forms.Label();
            this.lbCard3 = new System.Windows.Forms.Label();
            this.lbCard4 = new System.Windows.Forms.Label();
            this.lbCard5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbHighCard = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(50, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 262);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hand";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbCard1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbTrick, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbCard2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbCard3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbCard4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbCard5, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label9, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbHighCard, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(347, 243);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cards";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(242, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Trick";
            // 
            // lbCard1
            // 
            this.lbCard1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCard1.AutoSize = true;
            this.lbCard1.Location = new System.Drawing.Point(69, 44);
            this.lbCard1.Name = "lbCard1";
            this.lbCard1.Size = new System.Drawing.Size(35, 13);
            this.lbCard1.TabIndex = 0;
            this.lbCard1.Text = "label1";
            // 
            // lbTrick
            // 
            this.lbTrick.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTrick.AutoSize = true;
            this.lbTrick.Location = new System.Drawing.Point(242, 44);
            this.lbTrick.Name = "lbTrick";
            this.lbTrick.Size = new System.Drawing.Size(35, 13);
            this.lbTrick.TabIndex = 0;
            this.lbTrick.Text = "label1";
            // 
            // lbCard2
            // 
            this.lbCard2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCard2.AutoSize = true;
            this.lbCard2.Location = new System.Drawing.Point(69, 78);
            this.lbCard2.Name = "lbCard2";
            this.lbCard2.Size = new System.Drawing.Size(35, 13);
            this.lbCard2.TabIndex = 0;
            this.lbCard2.Text = "label1";
            // 
            // lbCard3
            // 
            this.lbCard3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCard3.AutoSize = true;
            this.lbCard3.Location = new System.Drawing.Point(69, 112);
            this.lbCard3.Name = "lbCard3";
            this.lbCard3.Size = new System.Drawing.Size(35, 13);
            this.lbCard3.TabIndex = 0;
            this.lbCard3.Text = "label1";
            // 
            // lbCard4
            // 
            this.lbCard4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCard4.AutoSize = true;
            this.lbCard4.Location = new System.Drawing.Point(69, 146);
            this.lbCard4.Name = "lbCard4";
            this.lbCard4.Size = new System.Drawing.Size(35, 13);
            this.lbCard4.TabIndex = 0;
            this.lbCard4.Text = "label1";
            // 
            // lbCard5
            // 
            this.lbCard5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCard5.AutoSize = true;
            this.lbCard5.Location = new System.Drawing.Point(69, 180);
            this.lbCard5.Name = "lbCard5";
            this.lbCard5.Size = new System.Drawing.Size(35, 13);
            this.lbCard5.TabIndex = 0;
            this.lbCard5.Text = "label1";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(228, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "High Card";
            // 
            // lbHighCard
            // 
            this.lbHighCard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbHighCard.AutoSize = true;
            this.lbHighCard.Location = new System.Drawing.Point(242, 146);
            this.lbHighCard.Name = "lbHighCard";
            this.lbHighCard.Size = new System.Drawing.Size(35, 13);
            this.lbHighCard.TabIndex = 0;
            this.lbHighCard.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(325, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Draw Hand";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(53, 336);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "New Deal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 390);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbCard1;
        private System.Windows.Forms.Label lbTrick;
        private System.Windows.Forms.Label lbCard2;
        private System.Windows.Forms.Label lbCard3;
        private System.Windows.Forms.Label lbCard4;
        private System.Windows.Forms.Label lbCard5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbHighCard;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

