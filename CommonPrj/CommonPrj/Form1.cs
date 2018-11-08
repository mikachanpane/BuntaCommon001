using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CommonPrj
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// クリック時
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            //当該チェック処理
            if (this.ChkReadOnly(textBox1)) return;

            //宣言
            //必要情報
            List<string> infList = new List<string>();
            //DataTableを生成
            DataTable dt = new DataTable();

            //DataTableの中身から重複行を除去し、結果をバインドする

        }
    }
}
