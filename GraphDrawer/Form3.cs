using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphDrawer
{
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void generaterButton_Click(object sender, EventArgs e)
        {
            Button node = new Button
            {

                //ボタンの上の連中から情報を取ってくる、座標とサイズは適当
                Name = nodeName.Text,
                Text = description.Text,
                Location = new Point(120, 220),
                Size = new Size(40, 40)
            };

            node.Click += new EventHandler(node_Click);

            Controls.Add(node);

            nodeName.Text = "";
            description.Text = "";
        }


        //他の空間がクリックされたら表示を戻すにはどうしたらいいだろう
        private void node_Click(object sender, EventArgs e)
        {
            informationNodeName.Text = ((Button)sender).Name;
            informationDescription.Text = ((Button)sender).Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void informationDescription_Click(object sender, EventArgs e)
        {

        }
    }
}
