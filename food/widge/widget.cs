using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace food.widge
{
    public enum categories { Food, Alcohol, ColdDrinks, HotDrinks, Desserts }
    public partial class widget : UserControl

    {
        private categories _category;
        private double _cost;

        public event EventHandler OnSelect = null;
        public widget()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OnSelect?.Invoke(this, e);
        }
        
        public categories Category {  get => _category; set=>_category=value; }
        public string Title { get => lblhum.Text ; set => lblhum.Text = value; }
        public double Cost { get => _cost; set { _cost = value;label2.Text = _cost.ToString("F2")+"VND"; } }
        public Image Ico { get=>pictureBox1.Image; set=>pictureBox1.Image = value; }
    }
}
