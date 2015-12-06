using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Threadmy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void a(object flag)
        {
            int timer = (int)flag;
            while (progressBar1.Value < 100)
            {
                progressBar1.Increment(2);
                Thread.Sleep(timer);
            }
        }
        void b(object flag)
        {
            int timer = (int)flag;
            while (progressBar2.Value < 100)
            {
                progressBar2.Increment(2);
                Thread.Sleep(timer);
            }
        }
        void c(object flag)
        {
            int timer = (int)flag;
            while (progressBar3.Value < 100)
            {
                progressBar3.Increment(2);
                Thread.Sleep(timer);
            }
        }
        void d(object flag)
        {
            int timer = (int)flag;
            while (progressBar4.Value < 100)
            {
                progressBar4.Increment(2);
                Thread.Sleep(timer);
            }
        }
        void e(object flag)
        {
            int timer = (int)flag;
            while (progressBar5.Value < 100)
            {
                progressBar5.Increment(2);
                Thread.Sleep(timer);
            }
        }
        void f(object flag)
        {
            int timer = (int)flag;
            while (progressBar6.Value < 100)
            {
                progressBar6.Increment(2);
                Thread.Sleep(timer);
            }
        }
        void g(object flag)
        {
            int timer = (int)flag;
            while (progressBar7.Value < 100)
            {
                progressBar7.Increment(2);
                Thread.Sleep(timer);
            }
        }
        void h(object flag)
        {
            int timer = (int)flag;
            while (progressBar8.Value < 100)
            {
                progressBar8.Increment(2);
                Thread.Sleep(timer);
            }
        }
        void i(object flag)
        {
            int timer = (int)flag;
            while (progressBar9.Value < 100)
            {
                progressBar9.Increment(2);
                Thread.Sleep(timer);
            }
        }
        void mainn()
        {
            Thread a_thread = new Thread(a);
            a_thread.Name = "Potok a";
            Thread b_thread = new Thread(b);
            b_thread.Name = "Potok b";
            Thread c_thread = new Thread(c);
            c_thread.Name = "Potok c";
            Thread d_thread = new Thread(d);
            d_thread.Name = "Potok d";
            Thread e_thread = new Thread(e);
            e_thread.Name = "Potok e";
            Thread f_thread = new Thread(f);
            f_thread.Name = "Potok f";
            Thread g_thread = new Thread(g);
            g_thread.Name = "Potok g";
            Thread h_thread = new Thread(h);
            h_thread.Name = "Potok h";
            Thread i_thread = new Thread(i);
            i_thread.Name = "Potok i";
            
            a_thread.Start(100);
            
            b_thread.Start(300);

            c_thread.Start(500);

            a_thread.Join();

            e_thread.Start(200);

            i_thread.Start(300);

            b_thread.Join();

            e_thread.Join();

            f_thread.Start(100);

            d_thread.Start(200);

            f_thread.Join();

            i_thread.Join();

            g_thread.Start(100);

            g_thread.Join();

            d_thread.Join();

            c_thread.Join();

            h_thread.Start(200);
             
        } 

        
        //static object locker = new object();
        
       
        
            
       
        private void Form1_Load(object sender, EventArgs e)
        {

            label1.Text = "thread a";
            label2.Text = "thread b";
            label3.Text = "thread c";
            label4.Text = "thread d";
            label5.Text = "thread e";
            label6.Text = "thread f";
            label7.Text = "thread g";
            label8.Text = "thread h";
            label9.Text = "thread i";
            button1.Text = "START";
           
            

        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar2.Value = 0;
            progressBar3.Value = 0;
            progressBar4.Value = 0;
            progressBar5.Value = 0;
            progressBar6.Value = 0;
            progressBar7.Value = 0;
            progressBar8.Value = 0;
            progressBar9.Value = 0;
            Thread main_thread = new Thread(mainn);
            main_thread.Start();   
        }
    }
}
