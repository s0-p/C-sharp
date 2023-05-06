using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp
{
    static class Program
    {
        static Form form;
        static Button button;
        static void ClickEvent(object sender, EventArgs e)
        {
            MessageBox.Show("당신은 죽었습니다.");
        }
        static void CreateWindow()
        {
            form = new Form();
            form.Width = 600;
            form.Height = 400;
            form.BackColor = Color.AliceBlue;

            button = new Button();
            button.Width = 200;
            button.Height = 70;
            button.Text = "절대 누르지 마시오";
            button.BackColor = Color.BlueViolet;
            button.Location = new Point((form.Width - button.Width) / 2, (form.Height - button.Height) / 2);
            button.Click += ClickEvent;
            form.Controls.Add(button);
            form.ShowDialog();
        }
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            CreateWindow();
        }
    }
}
