namespace food
{
    partial class frmmain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlbar = new Panel();
            pnlitems = new Panel();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            spl = new SplitContainer();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button7 = new Button();
            panel1 = new Panel();
            button8 = new Button();
            label2 = new Label();
            label1 = new Label();
            lblhum = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            pnlitems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)spl).BeginInit();
            spl.Panel1.SuspendLayout();
            spl.Panel2.SuspendLayout();
            spl.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlbar
            // 
            pnlbar.Dock = DockStyle.Top;
            pnlbar.Location = new Point(0, 0);
            pnlbar.Name = "pnlbar";
            pnlbar.Size = new Size(1116, 52);
            pnlbar.TabIndex = 0;
            pnlbar.Paint += pnlbar_Paint;
            // 
            // pnlitems
            // 
            pnlitems.Controls.Add(button6);
            pnlitems.Controls.Add(button5);
            pnlitems.Controls.Add(button4);
            pnlitems.Controls.Add(button3);
            pnlitems.Controls.Add(button2);
            pnlitems.Controls.Add(button1);
            pnlitems.Dock = DockStyle.Left;
            pnlitems.Location = new Point(0, 52);
            pnlitems.Name = "pnlitems";
            pnlitems.Size = new Size(135, 506);
            pnlitems.TabIndex = 1;
            // 
            // button6
            // 
            button6.Dock = DockStyle.Top;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Location = new Point(0, 300);
            button6.Name = "button6";
            button6.Size = new Size(135, 60);
            button6.TabIndex = 5;
            button6.Text = "Desserts";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Top;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(0, 240);
            button5.Name = "button5";
            button5.Size = new Size(135, 60);
            button5.TabIndex = 4;
            button5.Text = "Hot Drinks";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Top;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(0, 180);
            button4.Name = "button4";
            button4.Size = new Size(135, 60);
            button4.TabIndex = 3;
            button4.Text = "Cold Drinks";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Top;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(0, 120);
            button3.Name = "button3";
            button3.Size = new Size(135, 60);
            button3.TabIndex = 2;
            button3.Text = "Alcohol";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(0, 60);
            button2.Name = "button2";
            button2.Size = new Size(135, 60);
            button2.TabIndex = 1;
            button2.Text = "Food";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(135, 60);
            button1.TabIndex = 0;
            button1.Text = "All Items";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // spl
            // 
            spl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            spl.Location = new Point(135, 91);
            spl.Name = "spl";
            // 
            // spl.Panel1
            // 
            spl.Panel1.AutoScroll = true;
            spl.Panel1.Controls.Add(flowLayoutPanel1);
            spl.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // spl.Panel2
            // 
            spl.Panel2.Controls.Add(button7);
            spl.Panel2.Controls.Add(panel1);
            spl.Panel2.Controls.Add(lblhum);
            spl.Panel2.Paint += spl_Panel2_Paint;
            spl.Size = new Size(981, 467);
            spl.SplitterDistance = 603;
            spl.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(603, 467);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(252, 236, 239);
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.ForeColor = Color.Blue;
            button7.Location = new Point(223, 30);
            button7.Name = "button7";
            button7.Size = new Size(107, 42);
            button7.TabIndex = 4;
            button7.Text = "Clear All";
            button7.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(button8);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 348);
            panel1.Name = "panel1";
            panel1.Size = new Size(368, 116);
            panel1.TabIndex = 5;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(255, 128, 0);
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.ForeColor = Color.White;
            button8.Location = new Point(3, 65);
            button8.Name = "button8";
            button8.Size = new Size(357, 51);
            button8.TabIndex = 5;
            button8.Text = "Pay";
            button8.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(271, 11);
            label2.Name = "label2";
            label2.Size = new Size(68, 28);
            label2.TabIndex = 4;
            label2.Text = "0VND";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 11);
            label1.Name = "label1";
            label1.Size = new Size(59, 28);
            label1.TabIndex = 3;
            label1.Text = "Total";
            label1.Click += label1_Click;
            // 
            // lblhum
            // 
            lblhum.AutoSize = true;
            lblhum.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblhum.Location = new Point(22, 13);
            lblhum.Name = "lblhum";
            lblhum.Size = new Size(143, 28);
            lblhum.TabIndex = 2;
            lblhum.Text = "Current Order";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(135, 52);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(597, 40);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.Enter += textBox1_Enter_1;
            textBox1.Leave += textBox1_Leave;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.Location = new Point(738, 52);
            label3.Name = "label3";
            label3.Size = new Size(378, 40);
            label3.TabIndex = 4;
            // 
            // frmmain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1116, 558);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(spl);
            Controls.Add(pnlitems);
            Controls.Add(pnlbar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmmain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MChind's Restaurant";
            MaximumSizeChanged += frmmain_MaximumSizeChanged;
            MinimumSizeChanged += frmmain_MinimumSizeChanged;
            Load += frmmain_Load;
            Shown += frmmain_Shown;
            MouseDown += frmmain_MouseDown;
            MouseMove += frmmain_MouseMove;
            MouseUp += frmmain_MouseUp;
            pnlitems.ResumeLayout(false);
            spl.Panel1.ResumeLayout(false);
            spl.Panel2.ResumeLayout(false);
            spl.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)spl).EndInit();
            spl.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlbar;
        private Panel pnlitems;
        private Button button1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button6;
        private Button button5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private SplitContainer spl;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button7;
        private Label lblhum;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Button button8;
        private TextBox textBox1;
        private Label label3;
    }
}
