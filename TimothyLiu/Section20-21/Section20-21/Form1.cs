using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Section20_21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // 方法一
            this.btnMybtn1.Click += MybtnClicked;
            this.btnMybtn2.Click += MybtnClicked;

            // 方法二 拉姆达表达式
            /* this.btnMybtn1.Click += (sender, e) =>
                {
                    txtMsg.Text = "Btn1Method2 Used";
                };  */

            // 方法三 匿名方法
            /* this.btnMybtn1.Click += delegate(object sender, EventArgs e)
            {
                txtMsg.Text = "Btn1Method3 Used";
            }; */

            // 方法四 设计器订阅同一事件
        }

        private void MybtnClicked(object sender, EventArgs e)
        {
            if (sender == this.btnMybtn1)
                txtMsg.Text = "Btn1 Clicked !";
            if (sender == this.btnMybtn2)
                txtMsg.Text = "Btn2 Clicked !";
        }
    }
}
