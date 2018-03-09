using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace GraphDrawer
{
    public partial class Form4 : Form
    {
        class Node
        {
            string name;
            string description;
            List<string> tags;
            Point location;
            Size size;

            public Node()
            {
                name = "";
                description = "";
                tags = null;
                location = new Point(0, 0);
                size = new Size(0, 0);
            }

            public Node(string name, string description, List<string> tags, Point location, Size size)
            {
                this.name = name;
                this.description = description;
                this.tags = tags;
                this.location = location;
                this.size = size;
            }

            //クリック取りてえ
            public void Draw()
            {
            }

            public bool AddTag(string tagName)
            {
                if(tags.Contains(tagName) == false)
                {
                    tags.Add(tagName);
                    return true;
                }
                else
                {
                    return false;
                }
            }

            private bool IsCursorInNode(Point mousePoint)
            {
                return (mousePoint.X >= location.X && mousePoint.X <= location.X + size.Width) && (mousePoint.Y >= location.Y && mousePoint.Y <= location.Y + size.Height);
            }

            public override string ToString()
            {
                string status;

                status = "{\"" + name + "\", \"" + description + "\", " + tags.ToString() + ", " + location.ToString() + ", " + size.ToString() +  "}";

                return status;
            }

        }

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        { 
        }

        private void nodeGenerator_Click(object sender, EventArgs e)
        {
            Button node = new Button
            {
                //ボタンの上の連中から情報を取ってくる、座標とサイズは適当
                Name = nodeName.Text,
                Text = description.Text,
                Location = new Point(140, 260),
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
        
    }

}
