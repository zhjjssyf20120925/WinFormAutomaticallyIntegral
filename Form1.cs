using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFormAutomaticallyIntegral
{
    public partial class frmMain : Form
    {
        #region [  成员变量  ]

        /// <summary>
        /// 获取或者设置一个值  用于判断当前是否自动关闭软件
        /// 默认自动关闭，只有在获取积分失败的情况下才会失效。
        /// </summary>
        private bool isCloseForm = true;
        #endregion

        #region [  私有方法  ]

        #endregion

        #region [  成员方法  ]
        /// <summary>
        /// 构造函数
        /// </summary>
        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        /// <summary>
        /// 新增网站信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddInfo_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 更新网站信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 删除网站信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteInfo_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 开始执行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 标记下次软件启动自动执行积分获取
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbAutoAction_CheckedChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 软件关闭之前
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cbAutoAction.CheckState == CheckState.Checked)
            {
                if (MessageBox.Show("获取积分结束,是否关闭软件?", "提示!", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.Cancel)
                {

                }
            }
        }
        #endregion
    }
}
