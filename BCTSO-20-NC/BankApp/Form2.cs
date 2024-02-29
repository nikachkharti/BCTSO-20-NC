using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void syncBtn_Click(object sender, EventArgs e)
        {
            long result = Sum(1000000000);
            MessageBox.Show($"Result = {result}");
        }

        private async void asyncBtn_Click(object sender, EventArgs e)
        {
            #region კარგი ვარიანტი
            asyncBtn.Enabled = false;
            long result = await Task.Run(() => Sum(1000000000)); // ასინქრონულობა + მრავალნაკადურობა
            MessageBox.Show($"Result = {result}");
            asyncBtn.Enabled = true;
            #endregion

            //var task = Task.Run(()=>Sum(1000000000));
            //task.Wait();
            //long result = task.Result;

            //var task = Task.Run(() => Sum(1000000000));
            //long result = task.GetAwaiter().GetResult();

            MessageBox.Show($"Result = {result}");

        }


        private long Sum(long number)
        {
            long result = 0;

            for (int i = 0; i < number; i++)
            {
                result += i;
            }

            return result;
        }

    }
}
