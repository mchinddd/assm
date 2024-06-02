using food.widge;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace food
{
    public partial class frmmain : Form
    {
        private System.Windows.Forms.Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        private const string placeholderText = "Search here...";
        public frmmain()
        {
            InitializeComponent();
            random = new Random();
            this.MouseDown += new MouseEventHandler(frmmain_MouseDown);
            textBox1.Text = placeholderText;
        }
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColors.Colors.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColors.Colors.Count);
            }
            tempIndex = index;
            string color = ThemeColors.Colors[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActiveButton(object btnsender)
        {
            if (btnsender != null)
            {
                if (currentButton != (System.Windows.Forms.Button)btnsender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (System.Windows.Forms.Button)btnsender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in pnlitems.Controls)
            {
                if (previousBtn.GetType() == typeof(System.Windows.Forms.Button))
                {
                    previousBtn.BackColor = Color.White;
                    previousBtn.ForeColor = Color.Black;
                }
            }
        }


        private void frmmain_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
            this.MouseMove += new MouseEventHandler(frmmain_MouseMove);
            this.MouseUp += new MouseEventHandler(frmmain_MouseUp);
        }
        private void frmmain_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void frmmain_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
            this.MouseMove -= new MouseEventHandler(frmmain_MouseUp);
            this.MouseUp -= new MouseEventHandler(frmmain_MouseUp);
        }

        private void frmmain_Load(object sender, EventArgs e)
        {
            Label titleLabel = new Label();
            titleLabel.Text = "MChind's Restaurant";
            titleLabel.ForeColor = Color.White;
            titleLabel.Font = new Font("Arial", 10, FontStyle.Bold);
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(32, 15);
            pnlbar.Controls.Add(titleLabel);

            Label menuButton = new Label();
            menuButton.Text = "≡";
            //menuButton.Dock = DockStyle.Left;
            menuButton.Font = new Font("Arial", 18);
            //menuButton.Location = new Point(10,0);
            menuButton.Padding = new Padding(10, 6, 0, 0);
            menuButton.FlatStyle = FlatStyle.Flat;
            //menuButton.FlatAppearance.BorderSize = 0;
            menuButton.Width = 30;
            menuButton.Height = pnlbar.Height;
            menuButton.ForeColor = Color.White;
            pnlbar.Controls.Add(menuButton);


            System.Windows.Forms.Button minimizeButton = new System.Windows.Forms.Button();
            minimizeButton.Text = "−";
            minimizeButton.Dock = DockStyle.Right;
            minimizeButton.Width = 40;
            minimizeButton.FlatStyle = FlatStyle.Flat;
            minimizeButton.FlatAppearance.BorderSize = 0;
            minimizeButton.ForeColor = Color.White;
            minimizeButton.Click += frmmain_MinimumSizeChanged;
            pnlbar.Controls.Add(minimizeButton);

            System.Windows.Forms.Button phongto = new System.Windows.Forms.Button();
            phongto.Text = "☐";
            phongto.Dock = DockStyle.Right;
            phongto.Width = 40;
            phongto.FlatStyle = FlatStyle.Flat;
            phongto.FlatAppearance.BorderSize = 0;
            phongto.ForeColor = Color.White;
            phongto.Click += frmmain_MaximumSizeChanged;
            pnlbar.Controls.Add(phongto);

            System.Windows.Forms.Button closeButton = new System.Windows.Forms.Button();
            closeButton.Text = "X";
            closeButton.Dock = DockStyle.Right;
            closeButton.Width = 40;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.ForeColor = Color.White;
            closeButton.Click += CloseButton_Click;
            pnlbar.Controls.Add(closeButton);

        }

        private void frmmain_MaximumSizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void pnlbar_Paint(object sender, PaintEventArgs e)
        {
            pnlbar.BackColor = Color.Orange;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmmain_MinimumSizeChanged(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void spl_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void AddItem(string name, double cost, categories category, string ico)
        {
            flowLayoutPanel1.Controls.Add(new widget()
            {
                Title = name,
                Cost = cost,
                Category = category,
                Ico = Image.FromFile("icons/" + ico),

            });
        }

        private void frmmain_Shown(object sender, EventArgs e)
        {
            AddItem("Soup", 100, categories.Food, "soup.jpg");
            AddItem("Hamburger", 50, categories.Food, "hamburger.jpg");
            AddItem("Pizaa", 60, categories.Food, "pizza.jpg");
            AddItem("Fried rice", 30, categories.Food, "soup.jpg");
            AddItem("Soup", 100, categories.Food, "soup.jpg");

            AddItem("Drink", 20, categories.ColdDrinks, "drinks.jpg");
            AddItem("Beer", 15, categories.ColdDrinks, "beer.jpg");
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = placeholderText;
                textBox1.ForeColor = Color.Gray;
            }
        }


        private void textBox1_Enter_1(object sender, EventArgs e)
        {
            if (textBox1.Text == placeholderText)
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in flowLayoutPanel1.Controls)
            {
                var wdg = (widget)item;
                wdg.Visible = wdg.lblhum.Text.ToLower().Contains(textBox1.Text.Trim().ToLower());
            }
        }

        //private void OpenChildForm(Form childForm , object btnSender)
        //{
        //    if (activeForm != null)
        //    {
        //        activeForm.Close();
        //    }
        //    ActiveButton(btnSender);
        //    activeForm = childForm;
        //    childForm.TopLevel = false;
        //    childForm.FormBorderStyle = FormBorderStyle.None;
        //    childForm.Dock = DockStyle.Fill;
        //    this.pnlchild.Controls.Add(childForm);
        //    childForm.BringToFront();
        //    childForm.Show();
        //}
    }
}
