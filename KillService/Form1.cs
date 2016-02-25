using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KillService
{
    public partial class Form1 : Form
    {
        public static labelstate _gllabelstate;
        
        //static System.Timers.Timer timer = new System.Timers.Timer();
        public Form1()
        {
            InitializeComponent();
            _gllabelstate = new labelstate();
            for (int i = 0; i < service11.process.Length; i++)
            {
                listBox1.Items.Add(service11.process[i].ProcessName);
            }
            timer1.Start();
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += Timer1_Tick;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (_gllabelstate.isTriggered()){
                    listBox2.Items.Clear();
                    label1.Text = "已刷新";
                }

                service11.GetProcessEvent();
                
                for (int n = 0; n < service11.process.Length &&_gllabelstate.isNotTriggered(); n++)
                {
                    if (!service11.processname.Contains(service11.process[n].ProcessName) && listBox2.Items.IndexOf(service11.process[n].ProcessName)<0)
                    {
                        listBox2.Items.Add(service11.process[n].ProcessName);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("错误:" + ex);
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            service11.GetProcessEvent();
            try
            {
                System.IO.FileStream testfile = new System.IO.FileStream("C:\\Users\\elite\\Desktop\\test.txt", System.IO.FileMode.OpenOrCreate);
                System.IO.StreamWriter sw = new System.IO.StreamWriter(testfile);
                for (int i = 0; i < service11.process.Length; i++)
                {
                    Console.WriteLine(service11.process[i].ProcessName);
                    sw.Write(service11.process[i].ProcessName+"\n ");
                }
                sw.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("错误"+ex);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            清除按钮.Visible = 触发模式.Checked;


        }

        private void 清除按钮_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            label1.Text = "已刷新";
            _gllabelstate.rest_trigger();
        }
    }
    public class labelstate
    {
        public static bool triggered;
        public bool isTriggered()
        {
            return triggered;
        }
        public bool isNotTriggered()
        {
            return !triggered;
        }
        public void triggerit()
        {
            triggered = true;
        }
        public void rest_trigger()
        {
            triggered = false;
        }
    }
}
