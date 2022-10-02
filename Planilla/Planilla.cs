using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Planilla
{
    public partial class Planilla : Form
    {
        //String cadena;
        //System.IO.Ports.SerialPort Port;
        //bool Isclosed = false;
        public Planilla()
        {
            InitializeComponent();
            //Port = new System.IO.Ports.SerialPort();
            //Port.PortName = "COM3";
            //Port.BaudRate = 9600;
            //Port.ReadTimeout = 500;
    
            /*try
            {
                Port.Open();
            }
            catch
            {

            }*/
        }
        /*private void escuchar()
        {
            while (!Isclosed)
            {
                try
                {
                    cadena = Port.ReadLine();
                    di(cadena);
                }
                catch
                {

                }
            }
        }
        //// logica arduino 
        void di(String c)
        {
            pun1.Invoke(new MethodInvoker(
                        delegate
                        {
                            if (t1.Text == "")
                            {
                                t1.Text = c;
                            }
                            else if (t1.Text == "X")
                            {
                                t2.Text = "X";
                            }
                            else if (t2.Text == "")
                            {
                                t2.Text =c;
                            }
                        }));
        }*/
        public Planilla (int num,String tju1,String tju2,String tju3,String tju4,String tju5,String tju6)
        {
            InitializeComponent();
            if (num==1)
            {
                ju1.Visible = true;
                lb1.Text = tju1;
            }
            if (num == 2)
            {
                ju1.Visible = true;
                ju2.Visible = true;
                lb1.Text = tju1;
                lb2.Text = tju2;
            }
            if (num == 3)
            {
                ju1.Visible = true;
                ju2.Visible = true;
                ju3.Visible = true;
                lb1.Text = tju1;
                lb2.Text = tju2;
                lb3.Text = tju3;
            }
            if (num == 4)
            {
                ju1.Visible = true;
                ju2.Visible = true;
                ju3.Visible = true;
                ju4.Visible = true;
                lb1.Text = tju1;
                lb2.Text = tju2;
                lb3.Text = tju3;
                lb4.Text = tju4;
            }
            if (num == 5)
            {
                ju1.Visible = true;
                ju2.Visible = true;
                ju3.Visible = true;
                ju4.Visible = true;
                ju5.Visible = true;
                lb1.Text = tju1;
                lb2.Text = tju2;
                lb3.Text = tju3;
                lb4.Text = tju4;
                lb5.Text = tju5;
            }
            if (num == 6)
            {
                ju1.Visible = true;
                ju2.Visible = true;
                ju3.Visible = true;
                ju4.Visible = true;
                ju5.Visible = true;
                ju6.Visible = true;
                lb1.Text = tju1;
                lb2.Text = tju2;
                lb3.Text = tju3;
                lb4.Text = tju4;
                lb5.Text = tju5;
                lb6.Text = tju6;
            }
        }
        //////// logica groupbox 
        public void t1_Leave(object sender, EventArgs e)
        {
            if (t1.Text == "X")
            {
                t2.Text = "X";
                t1.Enabled = false;
                t2.Enabled = false;
                if (ju2.Visible==true)
                {
                    tt1.Enabled = true;
                    tt2.Enabled = true;
                }
                else
                {
                    t3.Enabled = true;
                    t4.Enabled = true;
                }
            }
            else
            {
                t1.Enabled = false;
                if (ju2.Visible == true)
                {
                    t3.Enabled = false;
                }
                else
                {
                    t3.Enabled = true;
                }
            }
        }

        private void t2_Leave(object sender, EventArgs e)
        {
            if (!(t1.Text == "X") && !(t2.Text == "X") && !(t2.Text=="/"))
            {
                int p1, p2, sum;
                p1 = Convert.ToInt32(t1.Text);
                p2 = Convert.ToInt32(t2.Text);
                sum = p1 + p2;
                if (sum == 10)
                {
                    t2.Text = "/";
                    t2.Enabled = false;
                    tp1.Text = "";
                    if (ju2.Visible == true)
                    {
                        tt1.Enabled = true;
                        tt2.Enabled = true;
                        t4.Enabled = false;
                    }
                    else
                    {
                        t4.Enabled = true;
                    }
                }
                if (sum > 10)
                {
                    MessageBox.Show("La suma no puede ser mayor a 10");
                    t1.Enabled = true;
                    t1.Text = "";
                    t2.Text = "";
                }
                else
                {
                    if (!(t2.Text == "/"))
                    {
                        tp1.Text = Convert.ToString(sum);
                        pun1.Text = Convert.ToString(sum);
                        t2.Enabled = false;
                        if (ju2.Visible == true)
                        {
                            tt1.Enabled = true;
                            tt2.Enabled = true;
                            t4.Enabled = false;
                        }
                        else
                        {
                            t4.Enabled = true;
                        }
                    }
                    else
                    {
                        tp1.Text = "";
                    }
                }
            }
        }

        private void t3_Leave(object sender, EventArgs e)
        {
            int p, sum;
            if (t3.Text == "X")
            {
                t4.Text = "X";
                t3.Enabled = false;
                t4.Enabled = false;
                if (ju2.Visible==true)
                {
                    tt3.Enabled = true;
                    tt4.Enabled = true;
                }
                else {
                    t5.Enabled = true;
                    t6.Enabled = true;
                }
            }
            else
            {
                t3.Enabled = false;
                if (ju2.Enabled == true)
                {
                    t5.Enabled = false;
                }
                else
                {
                    t5.Enabled = true;
                }
            }
            if (t2.Text == "/" && t3.Text == "X")
            {
                sum = 20;
                tp1.Text = Convert.ToString(sum);
                pun1.Text = Convert.ToString(sum);
                if (ju2.Visible==true)
                {
                    t5.Enabled = false;
                }
                else {
                    t5.Enabled = true;
                }
            }
            else if (t2.Text == "/")
            {
                p = Convert.ToInt32(t3.Text);
                sum = 10 + p;
                tp1.Text = Convert.ToString(sum);
                pun1.Text = Convert.ToString(sum);
                t4.Enabled = true;
            }
        }
        private void t4_Leave(object sender, EventArgs e)
        {
            if (!(t3.Text == "X") && !(t4.Text == "X") && !(t4.Text == "/"))
            {
                int p1, p2, p3, sum, sumt;
                p1 = Convert.ToInt32(t3.Text);
                p2 = Convert.ToInt32(t4.Text);
                sum = p1 + p2;
                if (sum == 10)
                {
                    t4.Text = "/";
                    t4.Enabled = false;
                    t3.Enabled = false;
                    tp2.Text = "";
                    if (ju2.Visible == true)
                    {
                        tt3.Enabled = true;
                        tt4.Enabled = true;
                    }
                    else
                    {
                        t5.Enabled = true;
                        t6.Enabled = true;
                    }
                }
                if (sum > 10)
                {
                    MessageBox.Show("La suma no puede ser mayor a 10");
                    t3.Enabled = true;
                    t3.Text = "";
                    t4.Text = "";
                }
                if (t2.Text == "X" && !(t4.Text == "X"))
                {
                    int sumq;
                    sumt = 10 + sum;
                    tp1.Text = Convert.ToString(sumt);
                    sumq = Convert.ToInt32(tp1.Text) + sum;
                    if (sum == 10)
                    {
                        tp2.Text = "";
                        pun1.Text = tp1.Text;
                    }
                    else
                    {
                        tp2.Text = Convert.ToString(sumq);
                        pun1.Text = Convert.ToString(sumq);
                    }
                    t4.Enabled = false;
                    if (ju2.Visible == true)
                    {
                        tt3.Enabled = true;
                        tt4.Enabled = true;
                    }
                    else
                    {
                        t6.Enabled = true;
                    }
                }
                else
                {
                    if (!(t4.Text == "/"))
                    {
                        p3 = Convert.ToInt32(tp1.Text);
                        sumt = p3 + sum;
                        tp2.Text = Convert.ToString(sumt);
                        pun1.Text = Convert.ToString(sumt);
                        t4.Enabled = false;
                        if (ju2.Visible == true)
                        {
                            tt3.Enabled = true;
                            tt4.Enabled = true;
                        }
                        else
                        {
                            t6.Enabled = true;
                        }
                    }
                    else
                    {
                        tp2.Text = "";
                    }
                }
                
            }
        }

        private void t5_Leave(object sender, EventArgs e)
        {
            if (t5.Text == "X")
            {
                t6.Text = "X";
                t5.Enabled = false;
                t6.Enabled = false;
                if (ju2.Visible == true)
                {
                    tt5.Enabled = true;
                    tt6.Enabled = true;
                }
                else
                {
                    t7.Enabled = true;
                    t8.Enabled = true;
                }
            }
            else
            {
                t5.Enabled = false;
                if (ju2.Enabled == true)
                {
                    t7.Enabled = false;
                }
                else
                {
                    t7.Enabled = true;
                }
            }
            if (t4.Text == "/" && t5.Text == "X")
            {
                int sum,sum2,p;
                sum = 20;
                p = Convert.ToInt32(tp1.Text);
                sum2 = sum + p;
                tp2.Text = Convert.ToString(sum2);
                pun1.Text = Convert.ToString(sum2);
            }
            else if (t4.Text == "/")
            {
                int p, p2, sum;
                p = Convert.ToInt32(t5.Text);
                p2 = Convert.ToInt32(tp1.Text);
                sum = p2 + 10 + p;
                tp2.Text = Convert.ToString(sum);
                pun1.Text = Convert.ToString(sum);
            }
            if (t1.Text == "X" && t3.Text == "X" && !(t5.Text == "X"))
            {
                int p, sum;
                p = Convert.ToInt32(t5.Text);
                sum = 20 + p;
                tp1.Text = Convert.ToString(sum);
                pun1.Text = Convert.ToString(sum);
            }
            else if (t1.Text=="X" && t3.Text=="X" && t5.Text=="X")
            {
                int sum;
                sum = 30;
                tp1.Text = Convert.ToString(sum);
                pun1.Text = Convert.ToString(sum);
            }
        }

        private void t6_Leave(object sender, EventArgs e)
        {
            if (!(t5.Text == "X") && !(t6.Text == "X") && !(t6.Text == "/"))
            {
                int p1, p2, p3, sum, sumt;
                p1 = Convert.ToInt32(t5.Text);
                p2 = Convert.ToInt32(t6.Text);
                sum = p1 + p2;
                if (sum == 10)
                {
                    t6.Text = "/";
                    t6.Enabled = false;
                    t5.Enabled = false;
                    tp3.Text = "";
                    if (ju2.Visible == true)
                    {
                        tt5.Enabled = true;
                        tt6.Enabled = true;
                    }
                    else
                    {
                        t7.Enabled = true;
                        t8.Enabled = true;
                    }
                }
                if (sum > 10)
                {
                    MessageBox.Show("La suma no puede ser mayor a 10");
                    t5.Enabled = true;
                    t5.Text = "";
                    t6.Text = "";
                }
                if (t4.Text == "X")
                {
                    int sum1, p,t,sum2;
                    p = Convert.ToInt32(tp1.Text);
                    sum1 = 10 + sum+p;
                    tp2.Text = Convert.ToString(sum1);
                    pun1.Text = Convert.ToString(sum1);
                    t6.Enabled = false;
                    if (ju2.Visible==true)
                    {
                        t8.Enabled = false;
                    }
                    else
                    {
                        t8.Enabled = true;
                    }
                    
                    t = Convert.ToInt32(tp2.Text);
                    sum2 = t + sum;
                    if (sum == 10)
                    {
                        tp3.Text = "";
                        pun1.Text = tp2.Text;
                    }
                    else
                    {
                        tp3.Text = Convert.ToString(sum2);
                        pun1.Text = Convert.ToString(sum2);
                    }
                }
                else
                {
                    if (!(t6.Text == "/"))
                    {
                        p3 = Convert.ToInt32(tp2.Text);
                        sumt = p3 + sum;
                        tp3.Text = Convert.ToString(sumt);
                        pun1.Text = Convert.ToString(sumt);
                        t6.Enabled = false;
                        if (ju2.Visible == true)
                        {
                            tt5.Enabled = true;
                            tt6.Enabled = true;
                        }
                        else
                        {
                            t8.Enabled = true;
                        }
                    }
                    else
                    {
                        tp3.Text = "";
                    }
                }
            }
        }

        private void t7_Leave(object sender, EventArgs e)
        {
            if (t7.Text == "X")
            {
                t8.Text = "X";
                t7.Enabled = false;
                t8.Enabled = false;
                if (ju2.Visible == true)
                {
                    tt7.Enabled = true;
                    tt8.Enabled = true;
                }
                else
                {
                    t9.Enabled = true;
                    t10.Enabled = true;
                }
                
            }
            else
            {
                t7.Enabled = false;
                if (ju2.Enabled == true)
                {
                    t9.Enabled = false;
                }
                else
                {
                    t9.Enabled = true;
                }
            }
            if (t6.Text == "/" && t7.Text == "X")
            {
                int sum, sum2, p;
                sum = 20;
                p = Convert.ToInt32(tp2.Text);
                sum2 = sum + p;
                tp3.Text = Convert.ToString(sum2);
                pun1.Text = Convert.ToString(sum2);
            }
            else if (t6.Text == "/")
            {
                int p, p2, sum;
                p = Convert.ToInt32(t7.Text);
                p2 = Convert.ToInt32(tp2.Text);
                sum = p2 + 10 + p;
                tp3.Text = Convert.ToString(sum);
                pun1.Text = Convert.ToString(sum);
            }
            if (t3.Text == "X" && t5.Text == "X" && !(t7.Text == "X"))
            {
                int p,c, sum;
                p = Convert.ToInt32(t7.Text);
                c = Convert.ToInt32(tp1.Text);
                sum = 20 + p+c;
                tp2.Text = Convert.ToString(sum);
                pun1.Text = Convert.ToString(sum);
            }
            else if (t3.Text == "X" && t5.Text == "X" && t7.Text == "X")
            {
                int sum,p;
                p = Convert.ToInt32(tp1.Text);
                sum = 30+p;
                tp2.Text = Convert.ToString(sum);
                pun1.Text = Convert.ToString(sum);
            }
        }

        private void t8_Leave(object sender, EventArgs e)
        {
            if (!(t7.Text == "X") && !(t8.Text == "X") && !(t8.Text == "/"))
            {
                int p1, p2, p3, sum, sumt;
                p1 = Convert.ToInt32(t7.Text);
                p2 = Convert.ToInt32(t8.Text);
                sum = p1 + p2;
                if (sum == 10)
                {
                    t8.Text = "/";
                    t8.Enabled = false;
                    t7.Enabled = false;
                    tp4.Text = "";
                    if (ju2.Visible == true)
                    {
                        tt7.Enabled = true;
                        tt8.Enabled = true;
                    }
                    else
                    {
                        t9.Enabled = true;
                        t10.Enabled = true;
                    }
                }
                if (sum > 10)
                {
                    MessageBox.Show("La suma no puede ser mayor a 10");
                    t7.Enabled = true;
                    t7.Text = "";
                    t8.Text = "";
                }
                if (t6.Text == "X")
                {
                    int sum1, p, t, sum2;
                    p = Convert.ToInt32(tp2.Text);
                    sum1 = 10 + sum + p;
                    tp3.Text = Convert.ToString(sum1);
                    pun1.Text = Convert.ToString(sum1);
                    t8.Enabled = false;
                    if (ju2.Visible == true)
                    {
                        t10.Enabled = false;
                    }
                    else
                    {
                        t10.Enabled = true;
                    }
                    t = Convert.ToInt32(tp3.Text);
                    sum2 = t + sum;
                    if (sum == 10)
                    {
                        tp4.Text = "";
                        pun1.Text = tp3.Text;
                    }
                    else
                    {
                        tp4.Text = Convert.ToString(sum2);
                        pun1.Text = Convert.ToString(sum2);
                    }
                }
                else
                {
                    if (!(t8.Text == "/"))
                    {
                        p3 = Convert.ToInt32(tp3.Text);
                        sumt = p3 + sum;
                        tp4.Text = Convert.ToString(sumt);
                        pun1.Text = Convert.ToString(sumt);
                        t8.Enabled = false;
                        if (ju2.Visible == true)
                        {
                            tt7.Enabled = true;
                            tt8.Enabled = true;
                        }
                        else
                        {
                            t9.Enabled = true;
                            t10.Enabled = true;
                        }
                    }
                    else
                    {
                        tp4.Text = "";
                    }
                }
            }
        }

        private void t9_Leave(object sender, EventArgs e)
        {
            if (t9.Text == "X")
            {
                t10.Text = "X";
                t9.Enabled = false;
                t10.Enabled = false;
                if (ju2.Visible == true)
                {
                    tt9.Enabled = true;
                    tt10.Enabled = true;
                }
                else
                {
                    t11.Enabled = true;
                    t12.Enabled = true;
                }
                
            }
            else
            {
                t9.Enabled = false;
                if (ju2.Enabled == true)
                {
                    t11.Enabled = false;
                }
                else
                {
                    t11.Enabled = true;
                }
            }
            if (t8.Text == "/" && t9.Text == "X")
            {
                int sum, sum2, p;
                sum = 20;
                p = Convert.ToInt32(tp3.Text);
                sum2 = sum + p;
                tp4.Text = Convert.ToString(sum2);
                pun1.Text = Convert.ToString(sum2);
            }
            else if (t8.Text == "/")
            {
                int p, p2, sum;
                p = Convert.ToInt32(t9.Text);
                p2 = Convert.ToInt32(tp3.Text);
                sum = p2 + 10 + p;
                tp4.Text = Convert.ToString(sum);
                pun1.Text = Convert.ToString(sum);
            }
            if (t5.Text == "X" && t7.Text == "X" && !(t9.Text == "X"))
            {
                int p,c, sum;
                p = Convert.ToInt32(t9.Text);
                c = Convert.ToInt32(tp2.Text);
                sum = 20 + p+c;
                tp3.Text = Convert.ToString(sum);
                pun1.Text = Convert.ToString(sum);
            }
            else if (t5.Text == "X" && t7.Text == "X" && t9.Text == "X")
            {
                int sum, p;
                p = Convert.ToInt32(tp2.Text);
                sum = 30 + p;
                tp3.Text = Convert.ToString(sum);
                pun1.Text = Convert.ToString(sum);
            }
        }

        private void t10_Leave(object sender, EventArgs e)
        {
            if (!(t9.Text == "X") && !(t10.Text == "X") && !(t10.Text == "/"))
            {
                int p1, p2, p3, sum, sumt;
                p1 = Convert.ToInt32(t9.Text);
                p2 = Convert.ToInt32(t10.Text);
                sum = p1 + p2;
                if (sum == 10)
                {
                    t10.Text = "/";
                    t10.Enabled = false;
                    t9.Enabled = false;
                    tp5.Text = "";
                    if (ju2.Visible == true)
                    {
                        tt9.Enabled = true;
                        tt10.Enabled = true;
                    }
                    else
                    {
                        t11.Enabled = true;
                        t12.Enabled = true;
                    }
                }
                if (sum > 10)
                {
                    MessageBox.Show("La suma no puede ser mayor a 10");
                    t9.Enabled = true;
                    t9.Text = "";
                    t10.Text = "";
                }
                if (t8.Text == "X")
                {
                    int sum1, p, t, sum2;
                    p = Convert.ToInt32(tp3.Text);
                    sum1 = 10 + sum + p;
                    tp4.Text = Convert.ToString(sum1);
                    pun1.Text = Convert.ToString(sum1);
                    t10.Enabled = false;
                    if (ju2.Visible == true)
                    {
                        t12.Enabled = false;
                    }
                    else
                    {
                        t12.Enabled = true;
                    }
                    t = Convert.ToInt32(tp4.Text);
                    sum2 = t + sum;
                    if (sum == 10)
                    {
                        tp5.Text = "";
                        pun1.Text = tp4.Text;
                    }
                    else
                    {
                        tp5.Text = Convert.ToString(sum2);
                        pun1.Text = Convert.ToString(sum2);
                    }
                }
                else
                {
                    if (!(t10.Text == "/"))
                    {
                        p3 = Convert.ToInt32(tp4.Text);
                        sumt = p3 + sum;
                        tp5.Text = Convert.ToString(sumt);
                        pun1.Text = Convert.ToString(sumt);
                        t10.Enabled = false;
                        if (ju2.Visible == true)
                        {
                            tt9.Enabled = true;
                            tt10.Enabled = true;
                        }
                        else
                        {
                            t11.Enabled = true;
                            t12.Enabled = true;
                        }
                    }
                    else
                    {
                        tp5.Text = "";
                    }
                }
            }
        }

        private void t11_Leave(object sender, EventArgs e)
        {
            if (t11.Text == "X")
            {
                t12.Text = "X";
                t11.Enabled = false;
                t12.Enabled = false;
                if (ju2.Visible == true)
                {
                    tt11.Enabled = true;
                    tt12.Enabled = true;
                }
                else
                {
                    t11.Enabled = false;
                    if (ju2.Enabled == true)
                    {
                        t13.Enabled = false;
                    }
                    else
                    {
                        t13.Enabled = true;
                    }
                }
            }
            else
            {
                t11.Enabled = false;
                if (ju2.Enabled == true)
                {
                    t13.Enabled = false;
                }
                else
                {
                    t13.Enabled = true;
                }
            }
            if (t10.Text == "/" && t11.Text == "X")
            {
                int sum, sum2, p;
                sum = 20;
                p = Convert.ToInt32(tp4.Text);
                sum2 = sum + p;
                tp5.Text = Convert.ToString(sum2);
                pun1.Text = Convert.ToString(sum2);
            }
            else if (t10.Text == "/")
            {
                int p, p2, sum;
                p = Convert.ToInt32(t11.Text);
                p2 = Convert.ToInt32(tp4.Text);
                sum = p2 + 10 + p;
                tp5.Text = Convert.ToString(sum);
                pun1.Text = Convert.ToString(sum);
            }
            if (t7.Text == "X" && t9.Text == "X" && !(t11.Text == "X"))
            {
                int p,c, sum;
                p = Convert.ToInt32(t11.Text);
                c = Convert.ToInt32(tp3.Text);
                sum = 20 + p+c;
                tp4.Text = Convert.ToString(sum);
                pun1.Text = Convert.ToString(sum);
            }
            else if (t7.Text == "X" && t9.Text == "X" && t11.Text == "X")
            {
                int sum, p;
                p = Convert.ToInt32(tp3.Text);
                sum = 30 + p;
                tp4.Text = Convert.ToString(sum);
                pun1.Text = Convert.ToString(sum);
            }
        }

        private void t12_Leave(object sender, EventArgs e)
        {
            if (!(t11.Text == "X") && !(t12.Text == "X") && !(t12.Text == "/"))
            {
                int p1, p2, p3, sum, sumt;
                p1 = Convert.ToInt32(t11.Text);
                p2 = Convert.ToInt32(t12.Text);
                sum = p1 + p2;
                if (sum == 10)
                {
                    t12.Text = "/";
                    t12.Enabled = false;
                    t11.Enabled = false;
                    tp6.Text = "";
                    if (ju2.Visible == true)
                    {
                        tt11.Enabled = true;
                        tt12.Enabled = true;
                    }
                    else
                    {
                        t13.Enabled = true;
                        t14.Enabled = true;
                    }
                }
                if (sum > 10)
                {
                    MessageBox.Show("La suma no puede ser mayor a 10");
                    t11.Enabled = true;
                    t11.Text = "";
                    t12.Text = "";
                }
                if (t10.Text == "X")
                {
                    int sum1, p, t, sum2;
                    p = Convert.ToInt32(tp4.Text);
                    sum1 = 10 + sum + p;
                    tp5.Text = Convert.ToString(sum1);
                    pun1.Text = Convert.ToString(sum1);
                    t12.Enabled = false;
                    if (ju2.Visible == true)
                    {
                        t14.Enabled = false;
                    }
                    else
                    {
                        t14.Enabled = true;
                    }
                    t = Convert.ToInt32(tp5.Text);
                    sum2 = t + sum;
                    if (sum == 10)
                    {
                        tp6.Text = "";
                        pun1.Text = tp5.Text;
                    }
                    else
                    {
                        tp6.Text = Convert.ToString(sum2);
                        pun1.Text = Convert.ToString(sum2);
                    }
                }
                else
                {
                    if (!(t12.Text == "/"))
                    {
                        p3 = Convert.ToInt32(tp5.Text);
                        sumt = p3 + sum;
                        tp6.Text = Convert.ToString(sumt);
                        pun1.Text = Convert.ToString(sumt);
                        t12.Enabled = false;
                        if (ju2.Visible == true)
                        {
                            tt11.Enabled = true;
                            tt12.Enabled = true;
                        }
                        else
                        {
                            t13.Enabled = true;
                            t14.Enabled = true;
                        }
                    }
                    else
                    {
                        tp6.Text = "";
                    }
                }
            }
        }

        private void t13_Leave(object sender, EventArgs e)
        {
            if (t13.Text == "X")
            {
                t14.Text = "X";
                t13.Enabled = false;
                t14.Enabled = false;
                if (ju2.Visible == true)
                {
                    tt13.Enabled = true;
                    tt14.Enabled = true;
                }
                else
                {
                    t15.Enabled = true;
                    t16.Enabled = true;
                }
            }
            else
            {
                t13.Enabled = false;
                if (ju2.Enabled == true)
                {
                    t15.Enabled = false;
                }
                else
                {
                    t15.Enabled = true;
                }
            }
            if (t12.Text == "/" && t13.Text == "X")
            {
                int sum, sum2, p;
                sum = 20;
                p = Convert.ToInt32(tp5.Text);
                sum2 = sum + p;
                tp6.Text = Convert.ToString(sum2);
                pun1.Text = Convert.ToString(sum2);
            }
            else if (t12.Text == "/")
            {
                int p, p2, sum;
                p = Convert.ToInt32(t13.Text);
                p2 = Convert.ToInt32(tp5.Text);
                sum = p2 + 10 + p;
                tp6.Text = Convert.ToString(sum);
                pun1.Text = Convert.ToString(sum);
            }
            if (t9.Text == "X" && t11.Text == "X" && !(t13.Text == "X"))
            {
                int p,c, sum;
                p = Convert.ToInt32(t13.Text);
                c = Convert.ToInt32(tp4.Text);
                sum = 20 + p + c;
                tp5.Text = Convert.ToString(sum);
                pun1.Text = Convert.ToString(sum);
            }
            else if (t9.Text == "X" && t11.Text == "X" && t13.Text == "X")
            {
                int sum, p;
                p = Convert.ToInt32(tp4.Text);
                sum = 30 + p;
                tp5.Text = Convert.ToString(sum);
                pun1.Text = Convert.ToString(sum);
            }
        }

        private void t14_Leave(object sender, EventArgs e)
        {
            if (!(t13.Text == "X") && !(t14.Text == "X") && !(t14.Text == "/"))
            {
                int p1, p2, p3, sum, sumt;
                p1 = Convert.ToInt32(t13.Text);
                p2 = Convert.ToInt32(t14.Text);
                sum = p1 + p2;
                if (sum == 10)
                {
                    t14.Text = "/";
                    t14.Enabled = false;
                    t13.Enabled = false;
                    tp7.Text = "";
                    if (ju2.Visible == true)
                    {
                        tt13.Enabled = true;
                        tt14.Enabled = true;
                    }
                    else
                    {
                        t15.Enabled = true;
                        t16.Enabled = true;
                    }
                }
                if (sum > 10)
                {
                    MessageBox.Show("La suma no puede ser mayor a 10");
                    t13.Enabled = true;
                    t13.Text = "";
                    t14.Text = "";
                }
                if (t12.Text == "X")
                {
                    int sum1, p, t, sum2;
                    p = Convert.ToInt32(tp5.Text);
                    sum1 = 10 + sum + p;
                    tp6.Text = Convert.ToString(sum1);
                    pun1.Text = Convert.ToString(sum1);
                    t14.Enabled = false;
                    if (ju2.Visible == true)
                    {
                        t16.Enabled = false;
                    }
                    else
                    {
                        t16.Enabled = true;
                    }
                    t = Convert.ToInt32(tp6.Text);
                    sum2 = t + sum;
                    if (sum == 10)
                    {
                        tp7.Text = "";
                        pun1.Text = tp6.Text;
                    }
                    else
                    {
                        tp7.Text = Convert.ToString(sum2);
                        pun1.Text = Convert.ToString(sum2);
                    }
                }
                else
                {
                    if (!(t14.Text == "/"))
                    {
                        p3 = Convert.ToInt32(tp6.Text);
                        sumt = p3 + sum;
                        tp7.Text = Convert.ToString(sumt);
                        pun1.Text = Convert.ToString(sumt);
                        t14.Enabled = false;
                        if (ju2.Visible == true)
                        {
                            tt13.Enabled = true;
                            tt14.Enabled = true;
                        }
                        else
                        {
                            t15.Enabled = true;
                            t16.Enabled = true;
                        }
                    }
                    else
                    {
                        tp7.Text = "";
                    }
                }
            }
        }

        private void t15_Leave(object sender, EventArgs e)
        {
            if (t15.Text == "X")
            {
                t16.Text = "X";
                t15.Enabled = false;
                t16.Enabled = false;
                if (ju2.Visible == true)
                {
                    tt15.Enabled = true;
                    tt16.Enabled = true;
                }
                else
                {
                    t17.Enabled = true;
                    t18.Enabled = true;
                }
            }
            else
            {
                t15.Enabled = false;
                if (ju2.Enabled == true)
                {
                    t17.Enabled = false;
                }
                else
                {
                    t17.Enabled = true;
                }
            }
            if (t14.Text == "/" && t15.Text == "X")
            {
                int sum, sum2, p;
                sum = 20;
                p = Convert.ToInt32(tp6.Text);
                sum2 = sum + p;
                tp7.Text = Convert.ToString(sum2);
                pun1.Text = Convert.ToString(sum2);
            }
            else if (t14.Text == "/")
            {
                int p, p2, sum;
                p = Convert.ToInt32(t15.Text);
                p2 = Convert.ToInt32(tp6.Text);
                sum = p2 + 10 + p;
                tp7.Text = Convert.ToString(sum);
                pun1.Text = Convert.ToString(sum);
            }
            if (t11.Text == "X" && t13.Text == "X" && !(t15.Text == "X"))
            {
                int p,c, sum;
                p = Convert.ToInt32(t15.Text);
                c = Convert.ToInt32(tp5.Text);
                sum = 20 + p + c;
                tp6.Text = Convert.ToString(sum);
                pun1.Text = Convert.ToString(sum);
            }
            else if (t11.Text == "X" && t13.Text == "X" && t15.Text == "X")
            {
                int sum, p;
                p = Convert.ToInt32(tp5.Text);
                sum = 30 + p;
                tp6.Text = Convert.ToString(sum);
                pun1.Text = Convert.ToString(sum);
            }
        }

        private void t16_Leave(object sender, EventArgs e)
        {
            if (!(t15.Text == "X") && !(t16.Text == "X") && !(t16.Text == "/"))
            {
                int p1, p2, p3, sum, sumt;
                p1 = Convert.ToInt32(t15.Text);
                p2 = Convert.ToInt32(t16.Text);
                sum = p1 + p2;
                if (sum == 10)
                {
                    t16.Text = "/";
                    t16.Enabled = false;
                    t15.Enabled = false;
                    tp8.Text = "";
                    if (ju2.Visible == true)
                    {
                        tt15.Enabled = true;
                        tt16.Enabled = true;
                    }
                    else
                    {
                        t17.Enabled = true;
                        t18.Enabled = true;
                    }
                }
                if (sum > 10)
                {
                    MessageBox.Show("La suma no puede ser mayor a 10");
                    t15.Enabled = true;
                    t15.Text = "";
                    t16.Text = "";
                }
                if (t14.Text == "X")
                {
                    int sum1, p, t, sum2;
                    p = Convert.ToInt32(tp6.Text);
                    sum1 = 10 + sum + p;
                    tp7.Text = Convert.ToString(sum1);
                    pun1.Text = Convert.ToString(sum1);
                    t16.Enabled = false;
                    if (ju2.Visible == true)
                    {
                        t18.Enabled = false;
                    }
                    else
                    {
                        t18.Enabled = true;
                    }
                    t = Convert.ToInt32(tp7.Text);
                    sum2 = t + sum;
                    if (sum == 10)
                    {
                        tp8.Text = "";
                        pun1.Text = tp7.Text;
                    }
                    else
                    {
                        tp8.Text = Convert.ToString(sum2);
                        pun1.Text = Convert.ToString(sum2);
                    }
                }
                else
                {
                    if (!(t16.Text == "/"))
                    {
                        p3 = Convert.ToInt32(tp7.Text);
                        sumt = p3 + sum;
                        tp8.Text = Convert.ToString(sumt);
                        pun1.Text = Convert.ToString(sumt);
                        t16.Enabled = false;
                        if (ju2.Visible == true)
                        {
                            tt15.Enabled = true;
                            tt16.Enabled = true;
                        }
                        else
                        {
                            t17.Enabled = true;
                            t18.Enabled = true;
                        }
                    }
                    else
                    {
                        tp8.Text = "";
                    }
                }
            }
        }

        private void t17_Leave(object sender, EventArgs e)
        {
            if (t17.Text == "X")
            {
                t18.Text = "X";
                t17.Enabled = false;
                t18.Enabled = false;
                if (ju2.Visible == true)
                {
                    tt17.Enabled = true;
                    tt18.Enabled = true;
                }
                else
                {
                    t19.Enabled = true;
                    t20.Enabled = true;
                }
            }
            else
            {
                t17.Enabled = false;
                if (ju2.Enabled == true)
                {
                    t19.Enabled = false;
                }
                else
                {
                    t19.Enabled = true;
                }
            }
            if (t16.Text == "/" && t17.Text == "X")
            {
                int sum, sum2, p;
                sum = 20;
                p = Convert.ToInt32(tp7.Text);
                sum2 = sum + p;
                tp8.Text = Convert.ToString(sum2);
                pun1.Text = Convert.ToString(sum2);
            }
            else if (t16.Text == "/")
            {
                int p, p2, sum;
                p = Convert.ToInt32(t17.Text);
                p2 = Convert.ToInt32(tp7.Text);
                sum = p2 + 10 + p;
                tp8.Text = Convert.ToString(sum);
                pun1.Text = Convert.ToString(sum);
            }
            if (t13.Text == "X" && t15.Text == "X" && !(t17.Text == "X"))
            {
                int p,c, sum;
                p = Convert.ToInt32(t17.Text);
                c = Convert.ToInt32(tp6.Text);
                sum = 20 + p + c;
                tp7.Text = Convert.ToString(sum);
                pun1.Text = Convert.ToString(sum);
            }
            else if (t13.Text == "X" && t15.Text == "X" && t17.Text == "X")
            {
                int sum, p;
                p = Convert.ToInt32(tp6.Text);
                sum = 30 + p;
                tp7.Text = Convert.ToString(sum);
                pun1.Text = Convert.ToString(sum);
            }
        }

        private void t18_Leave(object sender, EventArgs e)
        {
            if (!(t17.Text == "X") && !(t18.Text == "X") && !(t18.Text == "/"))
            {
                int p1, p2, p3, sum, sumt;
                p1 = Convert.ToInt32(t17.Text);
                p2 = Convert.ToInt32(t18.Text);
                sum = p1 + p2;
                if (sum == 10)
                {
                    t18.Text = "/";
                    t18.Enabled = false;
                    t17.Enabled = false;
                    tp9.Text = "";
                    if (ju2.Visible == true)
                    {
                        tt17.Enabled = true;
                        tt18.Enabled = true;
                    }
                    else
                    {
                        t19.Enabled = true;
                        t20.Enabled = true;
                    }
                }
                if (sum > 10)
                {
                    MessageBox.Show("La suma no puede ser mayor a 10");
                    t17.Enabled = true;
                    t17.Text = "";
                    t18.Text = "";
                }
                if (t16.Text == "X")
                {
                    int sum1, p, t, sum2;
                    p = Convert.ToInt32(tp7.Text);
                    sum1 = 10 + sum + p;
                    tp8.Text = Convert.ToString(sum1);
                    pun1.Text = Convert.ToString(sum1);
                    t18.Enabled = false;
                    if (ju2.Visible == true)
                    {
                        t20.Enabled = false;
                    }
                    else
                    {
                        t20.Enabled = true;
                    }
                    t = Convert.ToInt32(tp8.Text);
                    sum2 = t + sum;
                    if (sum == 10)
                    {
                        tp9.Text = "";
                        pun1.Text = tp8.Text;
                    }
                    else
                    {
                        tp9.Text = Convert.ToString(sum2);
                        pun1.Text = Convert.ToString(sum2);
                    }
                }
                else
                {
                    if (!(t18.Text == "/"))
                    {
                        p3 = Convert.ToInt32(tp8.Text);
                        sumt = p3 + sum;
                        tp9.Text = Convert.ToString(sumt);
                        pun1.Text = Convert.ToString(sumt);
                        t18.Enabled = false;
                        if (ju2.Visible == true)
                        {
                            tt17.Enabled = true;
                            tt18.Enabled = true;
                        }
                        else
                        {
                            t19.Enabled = true;
                            t20.Enabled = true;
                        }
                    }
                    else
                    {
                        tp9.Text = "";
                    }
                }
            }
        }

        private void t19_Leave(object sender, EventArgs e)
        {
            if (t19.Text=="X")
            {
                t21.Enabled = true;
                t19.Enabled = false;
            }
            else
            {
                t19.Enabled = false;
                t21.Enabled = true;
            }
            if (t18.Text == "/" && t19.Text == "X")
            {
                int sum, sum2, p;
                sum = 20;
                p = Convert.ToInt32(tp8.Text);
                sum2 = sum + p;
                tp9.Text = Convert.ToString(sum2);
                pun1.Text = Convert.ToString(sum2);
                t20.Enabled = true;
            }
            else if (t18.Text == "/")
            {
                int p, p2, sum;
                p = Convert.ToInt32(t19.Text);
                p2 = Convert.ToInt32(tp8.Text);
                sum = p2 + 10 + p;
                tp9.Text = Convert.ToString(sum);
                pun1.Text = Convert.ToString(sum);
            }
            if (t15.Text == "X" && t17.Text == "X" && !(t19.Text == "X"))
            {
                int p,c, sum;
                p = Convert.ToInt32(t19.Text);
                c = Convert.ToInt32(tp7.Text);
                sum = 20 + p + c;
                tp8.Text = Convert.ToString(sum);
                pun1.Text = Convert.ToString(sum);
            }
            if (t15.Text == "X" && t17.Text == "X" && t19.Text == "X")
            {
                int sum, p;
                p = Convert.ToInt32(tp7.Text);
                sum = 30 + p;
                tp8.Text = Convert.ToString(sum);
                pun1.Text = Convert.ToString(sum);
            }
        }

        private void t20_Leave(object sender, EventArgs e)
        {
            
            if (t20.Text == "X")
            {
                t21.Enabled = true;
                t20.Enabled = false;
                tp10.Text = "";
            }
            else if (t20.Text == "/")
            {
                t20.Enabled = false;
                t21.Enabled = true;
            }
            else
            {
                if (!(t19.Text=="X"))
                {
                    int p1, p2, p3, sum, sumt;
                    p1 = Convert.ToInt32(t19.Text);
                    p2 = Convert.ToInt32(t20.Text);
                    sum = p1 + p2;
                    if (sum == 10)
                    {
                        t20.Text = "/";
                        t20.Enabled = false;
                        tp10.Text = "";
                        t21.Enabled = true;
                    }
                    if (sum > 10)
                    {
                        MessageBox.Show("La suma no puede ser mayor a 10");
                        t17.Enabled = true;
                        t17.Text = "";
                        t18.Text = "";
                    }
                    if (t18.Text == "X")
                    {
                        int sum1, p, t, sum2;
                        p = Convert.ToInt32(tp8.Text);
                        sum1 = 10 + sum + p;
                        tp9.Text = Convert.ToString(sum1);
                        pun1.Text = Convert.ToString(sum1);
                        t20.Enabled = false;
                        t = Convert.ToInt32(tp9.Text);
                        sum2 = t + sum;
                        if (sum == 10)
                        {
                            tp10.Text = "";
                            pun1.Text = tp9.Text;
                        }
                        else
                        {
                            tp10.Text = Convert.ToString(sum2);
                            pun1.Text = Convert.ToString(sum2);
                            t21.Enabled = false;
                            if (ju2.Visible == true)
                            {
                                tt19.Enabled = true;
                                tt20.Enabled = true;
                            }
                            else
                            {
                                MessageBox.Show("Fin del juego");
                            }

                        }
                    }
                    else
                    {
                        if (!(t20.Text == "/")) {
                            t21.Enabled = false;
                            p3 = Convert.ToInt32(tp9.Text);
                            sumt = p3 + sum;
                            tp10.Text = Convert.ToString(sumt);
                            pun1.Text = Convert.ToString(sumt);
                            t19.Enabled = false;
                            t20.Enabled = false;

                            if (ju2.Visible == true)
                            {
                                tt19.Enabled = true;
                                tt20.Enabled = true;
                            }
                            else
                            {
                                MessageBox.Show("Fin del juego");
                            }
                        }
                        else
                        {
                            tp10.Text = "";
                            t21.Enabled = true;
                        }
                    }
                }
                else
                {
                    t20.Enabled = false;
                }
            }
            if (t17.Text == "X" && t19.Text == "X" && t20.Text == "X")
            {
                int sum, p;
                p = Convert.ToInt32(tp8.Text);
                sum = 30 + p;
                tp9.Text = Convert.ToString(sum);
                pun1.Text = Convert.ToString(sum);
            }
            else if (t17.Text == "X" && t19.Text == "X" && !(t20.Text == "X"))
            {
                int sum, p,y;
                y = Convert.ToInt32(t20.Text);
                p = Convert.ToInt32(tp8.Text);
                sum = 20 + p+y;
                tp9.Text = Convert.ToString(sum);
                pun1.Text = Convert.ToString(sum);
            }
        }

        private void t21_TextChanged(object sender, EventArgs e)
        {
            int p,sum,pp;
            if (t19.Text == "X" && t20.Text == "X" && t21.Text == "X")
            {
                p = Convert.ToInt32(tp9.Text);
                sum = p + 30;
                tp10.Text = Convert.ToString(sum);
                pun1.Text = Convert.ToString(sum);
                if (ju2.Visible == true)
                {
                    t21.Enabled = false;
                    tt19.Enabled = true;
                    tt20.Enabled = true;
                }
                else
                {
                    t21.Enabled = false;
                    MessageBox.Show("Fin del juego");
                }
            }
            if (t20.Text=="/")
            {
                if (t21.Text=="X")
                {
                    p = Convert.ToInt32(tp9.Text);
                    sum = p + 20;
                    tp10.Text = Convert.ToString(sum);
                    pun1.Text = Convert.ToString(sum);
                    if (ju2.Visible == true)
                    {
                        t21.Enabled = false;
                        tt19.Enabled = true;
                        tt20.Enabled = true;
                    }
                    else
                    {
                        t21.Enabled = false;
                        MessageBox.Show("Fin del juego");
                    }
                }
                else
                {
                    p = Convert.ToInt32(tp9.Text);
                    pp= Convert.ToInt32(t21.Text);
                    sum = p + 10 + pp;
                    tp10.Text = Convert.ToString(sum);
                    pun1.Text = Convert.ToString(sum);
                    if (ju2.Visible == true)
                    {
                        t21.Enabled = false;
                        tt19.Enabled = true;
                        tt20.Enabled = true;
                    }
                    else
                    {
                        t21.Enabled = false;
                        MessageBox.Show("Fin del juego");
                    }
                }

            }
            if(t19.Text=="X" && !(t20.Text == "X"))
            {
                int c,p1,sump,sumpp,d;
                c = Convert.ToInt32(t20.Text);
                p1 = Convert.ToInt32(t21.Text);
                d = Convert.ToInt32(tp9.Text);
                sump = c + p1;
                if (sump>10)
                {
                    MessageBox.Show("la suma no puede ser mayor a 10");
                    t20.Enabled = true;
                    t20.Text = "";
                    t21.Enabled = true;
                    t21.Text = "";
                }
                else
                {
                    sumpp = sump + 10 + d;
                    tp10.Text = Convert.ToString(sumpp);
                    pun1.Text = Convert.ToString(sumpp);
                    t21.Enabled = false;
                    if (ju2.Visible == true)
                    {
                        tt19.Enabled = true;
                        tt20.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Fin del juego");
                    }
                }
            }
        }

        /////// logica groupbox 2
        private void tt1_TextChanged(object sender, EventArgs e)
        {
            if (tt1.Text == "X")
            {
                tt2.Text = "X";
                tt1.Enabled = false;
                tt2.Enabled = false;
                if (ju3.Visible==true)
                {
                    tq1.Enabled = true;
                    tq2.Enabled = true;
                }
                else
                {
                    t3.Enabled = true;
                    t4.Enabled = true;
                }
            }
            else
            {
                tt1.Enabled = false;
            }
        }

        private void tt2_TextChanged(object sender, EventArgs e)
        {
            if (!(tt1.Text == "X") && !(tt2.Text == "X") && !(tt2.Text == "/"))
            {
                int p1, p2, sum;
                p1 = Convert.ToInt32(tt1.Text);
                p2 = Convert.ToInt32(tt2.Text);
                sum = p1 + p2;
                if (sum == 10)
                {
                    tt2.Text = "/";
                    tt2.Enabled = false;
                    ttp1.Text = "";
                    if (ju3.Visible == true)
                    {
                        tq1.Enabled = true;
                        tq2.Enabled = true;
                    }
                    else
                    {
                        t3.Enabled = true;
                        t4.Enabled = true;
                    }
                }
                if (sum > 10)
                {
                    MessageBox.Show("La suma no puede ser mayor a 10");
                    tt1.Enabled = true;
                    tt1.Text = "";
                    tt2.Text = "";
                }
                else
                {
                    if (!(tt2.Text == "/"))
                    {
                        ttp1.Text = Convert.ToString(sum);
                        pun2.Text = Convert.ToString(sum);
                        tt2.Enabled = false;
                        if (ju3.Visible == true)
                        {
                            tq1.Enabled = true;
                            tq2.Enabled = true;
                        }
                        else
                        {
                            t3.Enabled = true;
                            t4.Enabled = true;
                        }
                    }
                    else
                    {
                        ttp1.Text = "";
                    }
                }
            }
        }

        private void tt3_TextChanged(object sender, EventArgs e)
        {
            int p, sum;
            if (tt3.Text == "X")
            {
                tt4.Text = "X";
                tt3.Enabled = false;
                tt4.Enabled = false;
                if (ju3.Visible == true)
                {
                    tq3.Enabled = true;
                    tq4.Enabled = true;
                }
                else
                {
                    t5.Enabled = true;
                    t6.Enabled = true;
                }
            }
            else
            {
                tt3.Enabled = false;
                if (ju3.Enabled == true)
                {
                    tq5.Enabled = false;
                }
                else
                {
                    t5.Enabled = true;
                }
            }
            if (tt2.Text == "/" && tt3.Text == "X")
            {
                sum = 20;
                ttp1.Text = Convert.ToString(sum);
                pun2.Text = Convert.ToString(sum);
            }
            else if (tt2.Text == "/")
            {
                p = Convert.ToInt32(tt3.Text);
                sum = 10 + p;
                ttp1.Text = Convert.ToString(sum);
                pun2.Text = Convert.ToString(sum);
                tt4.Enabled = true;
            }
        }

        private void tt4_TextChanged(object sender, EventArgs e)
        {
            if (!(tt3.Text == "X") && !(tt4.Text == "X") && !(tt4.Text == "/"))
            {
                int p1, p2, p3, sum, sumt;
                p1 = Convert.ToInt32(tt3.Text);
                p2 = Convert.ToInt32(tt4.Text);
                sum = p1 + p2;
                if (sum == 10)
                {
                    tt4.Text = "/";
                    tt4.Enabled = false;
                    tt3.Enabled = false;
                    ttp2.Text = "";
                    if (ju3.Visible == true)
                    {
                        tq3.Enabled = true;
                        tq4.Enabled = true;
                    }
                    else
                    {
                        t5.Enabled = true;
                        t6.Enabled = true;
                    }
                }
                if (sum > 10)
                {
                    MessageBox.Show("La suma no puede ser mayor a 10");
                    tt3.Enabled = true;
                    tt3.Text = "";
                    tt4.Text = "";
                }
                if (tt2.Text == "X" && !(tt4.Text == "X"))
                {
                    int sumq;
                    sumt = 10 + sum;
                    ttp1.Text = Convert.ToString(sumt);
                    sumq = Convert.ToInt32(ttp1.Text) + sum;
                    if (sum == 10)
                    {
                        ttp2.Text = "";
                        pun2.Text = ttp1.Text;
                    }
                    else
                    {
                        ttp2.Text = Convert.ToString(sumq);
                        pun2.Text = Convert.ToString(sumq);
                    }
                    tt4.Enabled = false;
                    if (ju3.Visible == true)
                    {
                        tq3.Enabled = true;
                        tq4.Enabled = true;
                    }
                    else
                    {
                        t5.Enabled = true;
                        t6.Enabled = true;
                    }
                }
                else
                {
                    if (!(tt4.Text == "/"))
                    {
                        p3 = Convert.ToInt32(ttp1.Text);
                        sumt = p3 + sum;
                        ttp2.Text = Convert.ToString(sumt);
                        pun2.Text = Convert.ToString(sumt);
                        tt4.Enabled = false;
                        if (ju3.Visible == true)
                        {
                            tq3.Enabled = true;
                            tq4.Enabled = true;
                        }
                        else
                        {
                            t5.Enabled = true;
                            t6.Enabled = true;
                        }
                    }
                    else
                    {
                        ttp2.Text = "";
                    }
                }

            }
        }

        private void tt5_TextChanged(object sender, EventArgs e)
        {
            if (tt5.Text == "X")
            {
                tt6.Text = "X";
                tt5.Enabled = false;
                tt6.Enabled = false;
                if (ju3.Visible == true)
                {
                    tq5.Enabled = true;
                    tq6.Enabled = true;
                }
                else
                {
                    t7.Enabled = true;
                    t8.Enabled = true;
                }
            }
            else
            {
                tt5.Enabled = false;
            }
            if (tt4.Text == "/" && tt5.Text == "X")
            {
                int sum, sum2, p;
                sum = 20;
                p = Convert.ToInt32(ttp1.Text);
                sum2 = sum + p;
                ttp2.Text = Convert.ToString(sum2);
                pun2.Text = Convert.ToString(sum2);
            }
            else if (tt4.Text == "/")
            {
                int p, p2, sum;
                p = Convert.ToInt32(tt5.Text);
                p2 = Convert.ToInt32(ttp1.Text);
                sum = p2 + 10 + p;
                ttp2.Text = Convert.ToString(sum);
                pun2.Text = Convert.ToString(sum);
            }
            if (tt1.Text == "X" && tt3.Text == "X" && !(tt5.Text == "X"))
            {
                int p, sum;
                p = Convert.ToInt32(tt5.Text);
                sum = 20 + p;
                ttp1.Text = Convert.ToString(sum);
                pun2.Text = Convert.ToString(sum);
            }
            else if (tt1.Text == "X" && tt3.Text == "X" && tt5.Text == "X")
            {
                int sum;
                sum = 30;
                ttp1.Text = Convert.ToString(sum);
                pun2.Text = Convert.ToString(sum);
            }
        }

        private void tt6_TextChanged(object sender, EventArgs e)
        {
            if (!(tt5.Text == "X") && !(tt6.Text == "X") && !(tt6.Text == "/"))
            {
                int p1, p2, p3, sum, sumt;
                p1 = Convert.ToInt32(tt5.Text);
                p2 = Convert.ToInt32(tt6.Text);
                sum = p1 + p2;
                if (sum == 10)
                {
                    tt6.Text = "/";
                    tt6.Enabled = false;
                    tt5.Enabled = false;
                    ttp3.Text = "";
                    if (ju3.Visible == true)
                    {
                        tq5.Enabled = true;
                        tq6.Enabled = true;
                    }
                    else
                    {
                        t7.Enabled = true;
                        t8.Enabled = true;
                    }
                }
                if (sum > 10)
                {
                    MessageBox.Show("La suma no puede ser mayor a 10");
                    tt5.Enabled = true;
                    tt5.Text = "";
                    tt6.Text = "";
                }
                if (tt4.Text == "X")
                {
                    int sum1, p, t, sum2;
                    p = Convert.ToInt32(ttp1.Text);
                    sum1 = 10 + sum + p;
                    ttp2.Text = Convert.ToString(sum1);
                    pun2.Text = Convert.ToString(sum1);
                    tt6.Enabled = false;
                    

                    t = Convert.ToInt32(ttp2.Text);
                    sum2 = t + sum;
                    if (sum == 10)
                    {
                        ttp3.Text = "";
                        pun2.Text = ttp2.Text;
                    }
                    else
                    {
                        ttp3.Text = Convert.ToString(sum2);
                        pun2.Text = Convert.ToString(sum2);
                    }
                }
                else
                {
                    if (!(tt6.Text == "/"))
                    {
                        p3 = Convert.ToInt32(ttp2.Text);
                        sumt = p3 + sum;
                        ttp3.Text = Convert.ToString(sumt);
                        pun2.Text = Convert.ToString(sumt);
                        tt6.Enabled = false;
                        if (ju3.Visible == true)
                        {
                            tq5.Enabled = true;
                            tq6.Enabled = true;
                        }
                        else
                        {
                            t7.Enabled = true;
                            t8.Enabled = true;
                        }
                    }
                    else
                    {
                        ttp3.Text = "";
                    }
                }
            }
        }

        private void tt7_TextChanged(object sender, EventArgs e)
        {
            if (tt7.Text == "X")
            {
                tt8.Text = "X";
                tt7.Enabled = false;
                tt8.Enabled = false;
                if (ju3.Visible == true)
                {
                    tq7.Enabled = true;
                    tq8.Enabled = true;
                }
                else
                {
                    t9.Enabled = true;
                    t10.Enabled = true;
                }

            }
            else
            {
                tt7.Enabled = false;
                if (ju3.Enabled == true)
                {
                    tq9.Enabled = false;
                }
                else
                {
                    t9.Enabled = true;
                }
            }
            if (tt6.Text == "/" && tt7.Text == "X")
            {
                int sum, sum2, p;
                sum = 20;
                p = Convert.ToInt32(ttp2.Text);
                sum2 = sum + p;
                ttp3.Text = Convert.ToString(sum2);
                pun2.Text = Convert.ToString(sum2);
            }
            else if (tt6.Text == "/")
            {
                int p, p2, sum;
                p = Convert.ToInt32(tt7.Text);
                p2 = Convert.ToInt32(ttp2.Text);
                sum = p2 + 10 + p;
                ttp3.Text = Convert.ToString(sum);
                pun2.Text = Convert.ToString(sum);
            }
            if (tt3.Text == "X" && tt5.Text == "X" && !(tt7.Text == "X"))
            {
                int p, c, sum;
                p = Convert.ToInt32(tt7.Text);
                c = Convert.ToInt32(ttp1.Text);
                sum = 20 + p + c;
                ttp2.Text = Convert.ToString(sum);
                pun2.Text = Convert.ToString(sum);
            }
            else if (tt3.Text == "X" && tt5.Text == "X" && tt7.Text == "X")
            {
                int sum, p;
                p = Convert.ToInt32(ttp1.Text);
                sum = 30 + p;
                ttp2.Text = Convert.ToString(sum);
                pun2.Text = Convert.ToString(sum);
            }
        }

        private void tt8_TextChanged(object sender, EventArgs e)
        {
            if (!(tt7.Text == "X") && !(tt8.Text == "X") && !(tt8.Text == "/"))
            {
                int p1, p2, p3, sum, sumt;
                p1 = Convert.ToInt32(tt7.Text);
                p2 = Convert.ToInt32(tt8.Text);
                sum = p1 + p2;
                if (sum == 10)
                {
                    tt8.Text = "/";
                    tt8.Enabled = false;
                    tt7.Enabled = false;
                    ttp4.Text = "";
                    if (ju3.Visible == true)
                    {
                        tq7.Enabled = true;
                        tq8.Enabled = true;
                    }
                    else
                    {
                        t9.Enabled = true;
                        t10.Enabled = true;
                    }
                }
                if (sum > 10)
                {
                    MessageBox.Show("La suma no puede ser mayor a 10");
                    tt7.Enabled = true;
                    tt7.Text = "";
                    tt8.Text = "";
                }
                if (tt6.Text == "X")
                {
                    int sum1, p, t, sum2;
                    p = Convert.ToInt32(ttp2.Text);
                    sum1 = 10 + sum + p;
                    ttp3.Text = Convert.ToString(sum1);
                    pun2.Text = Convert.ToString(sum1);
                    tt8.Enabled = false;
                    t = Convert.ToInt32(ttp3.Text);
                    sum2 = t + sum;
                    if (sum == 10)
                    {
                        ttp4.Text = "";
                        pun2.Text = ttp3.Text;
                    }
                    else
                    {
                        ttp4.Text = Convert.ToString(sum2);
                        pun2.Text = Convert.ToString(sum2);
                    }
                }
                else
                {
                    if (!(tt8.Text == "/"))
                    {
                        p3 = Convert.ToInt32(ttp3.Text);
                        sumt = p3 + sum;
                        ttp4.Text = Convert.ToString(sumt);
                        pun2.Text = Convert.ToString(sumt);
                        tt8.Enabled = false;
                        if (ju3.Visible == true)
                        {
                            tq7.Enabled = true;
                            tq8.Enabled = true;
                        }
                        else
                        {
                            t9.Enabled = true;
                            t10.Enabled = true;
                        }
                    }
                    else
                    {
                        ttp4.Text = "";
                    }
                }
            }
        }

        private void tt9_TextChanged(object sender, EventArgs e)
        {
            if (tt9.Text == "X")
            {
                tt10.Text = "X";
                tt9.Enabled = false;
                tt10.Enabled = false;
                if (ju3.Visible == true)
                {
                    tq9.Enabled = true;
                    tq10.Enabled = true;
                }
                else
                {
                    t11.Enabled = true;
                    t12.Enabled = true;
                }

            }
            else
            {
                tt9.Enabled = false;
            }
            if (tt8.Text == "/" && tt9.Text == "X")
            {
                int sum, sum2, p;
                sum = 20;
                p = Convert.ToInt32(ttp3.Text);
                sum2 = sum + p;
                ttp4.Text = Convert.ToString(sum2);
                pun2.Text = Convert.ToString(sum2);
            }
            else if (tt8.Text == "/")
            {
                int p, p2, sum;
                p = Convert.ToInt32(tt9.Text);
                p2 = Convert.ToInt32(ttp3.Text);
                sum = p2 + 10 + p;
                ttp4.Text = Convert.ToString(sum);
                pun2.Text = Convert.ToString(sum);
            }
            if (tt5.Text == "X" && tt7.Text == "X" && !(tt9.Text == "X"))
            {
                int p, c, sum;
                p = Convert.ToInt32(tt9.Text);
                c = Convert.ToInt32(ttp2.Text);
                sum = 20 + p + c;
                ttp3.Text = Convert.ToString(sum);
                pun2.Text = Convert.ToString(sum);
            }
            else if (tt5.Text == "X" && tt7.Text == "X" && tt9.Text == "X")
            {
                int sum, p;
                p = Convert.ToInt32(ttp2.Text);
                sum = 30 + p;
                ttp3.Text = Convert.ToString(sum);
                pun2.Text = Convert.ToString(sum);
            }
        }

        private void tt10_TextChanged(object sender, EventArgs e)
        {
            if (!(tt9.Text == "X") && !(tt10.Text == "X") && !(tt10.Text == "/"))
            {
                int p1, p2, p3, sum, sumt;
                p1 = Convert.ToInt32(tt9.Text);
                p2 = Convert.ToInt32(tt10.Text);
                sum = p1 + p2;
                if (sum == 10)
                {
                    tt10.Text = "/";
                    tt10.Enabled = false;
                    tt9.Enabled = false;
                    ttp5.Text = "";
                    if (ju3.Visible == true)
                    {
                        tq9.Enabled = true;
                        tq10.Enabled = true;
                    }
                    else
                    {
                        t11.Enabled = true;
                        t12.Enabled = true;
                    }
                }
                if (sum > 10)
                {
                    MessageBox.Show("La suma no puede ser mayor a 10");
                    tt9.Enabled = true;
                    tt9.Text = "";
                    tt10.Text = "";
                }
                if (tt8.Text == "X")
                {
                    int sum1, p, t, sum2;
                    p = Convert.ToInt32(ttp3.Text);
                    sum1 = 10 + sum + p;
                    ttp4.Text = Convert.ToString(sum1);
                    pun2.Text = Convert.ToString(sum1);
                    tt10.Enabled = false;
                    t = Convert.ToInt32(ttp4.Text);
                    sum2 = t + sum;
                    if (sum == 10)
                    {
                        ttp5.Text = "";
                        pun2.Text = ttp4.Text;
                    }
                    else
                    {
                        ttp5.Text = Convert.ToString(sum2);
                        pun2.Text = Convert.ToString(sum2);
                    }
                }
                else
                {
                    if (!(tt10.Text == "/"))
                    {
                        p3 = Convert.ToInt32(ttp4.Text);
                        sumt = p3 + sum;
                        ttp5.Text = Convert.ToString(sumt);
                        pun2.Text = Convert.ToString(sumt);
                        tt10.Enabled = false;
                        if (ju3.Visible == true)
                        {
                            tq9.Enabled = true;
                            tq10.Enabled = true;
                        }
                        else
                        {
                            t11.Enabled = true;
                            t12.Enabled = true;
                        }
                    }
                    else
                    {
                        ttp5.Text = "";
                    }
                }
            }
        }

        private void tt11_TextChanged(object sender, EventArgs e)
        {
            if (tt11.Text == "X")
            {
                tt12.Text = "X";
                tt11.Enabled = false;
                tt12.Enabled = false;
                if (ju3.Visible == true)
                {
                    tq11.Enabled = true;
                    tq12.Enabled = true;
                }
                else
                {
                    t13.Enabled = true;
                    t14.Enabled = true;
                }
            }
            else
            {
                tt11.Enabled = false;
                
            }
            if (tt10.Text == "/" && tt11.Text == "X")
            {
                int sum, sum2, p;
                sum = 20;
                p = Convert.ToInt32(ttp4.Text);
                sum2 = sum + p;
                ttp5.Text = Convert.ToString(sum2);
                pun2.Text = Convert.ToString(sum2);
            }
            else if (tt10.Text == "/")
            {
                int p, p2, sum;
                p = Convert.ToInt32(tt11.Text);
                p2 = Convert.ToInt32(ttp4.Text);
                sum = p2 + 10 + p;
                ttp5.Text = Convert.ToString(sum);
                pun2.Text = Convert.ToString(sum);
            }
            if (tt7.Text == "X" && tt9.Text == "X" && !(tt11.Text == "X"))
            {
                int p, c, sum;
                p = Convert.ToInt32(tt11.Text);
                c = Convert.ToInt32(ttp3.Text);
                sum = 20 + p + c;
                ttp4.Text = Convert.ToString(sum);
                pun2.Text = Convert.ToString(sum);
            }
            else if (tt7.Text == "X" && tt9.Text == "X" && tt11.Text == "X")
            {
                int sum, p;
                p = Convert.ToInt32(ttp3.Text);
                sum = 30 + p;
                ttp4.Text = Convert.ToString(sum);
                pun2.Text = Convert.ToString(sum);
            }
        }

        private void tt12_TextChanged(object sender, EventArgs e)
        {
            if (!(tt11.Text == "X") && !(tt12.Text == "X") && !(tt12.Text == "/"))
            {
                int p1, p2, p3, sum, sumt;
                p1 = Convert.ToInt32(tt11.Text);
                p2 = Convert.ToInt32(tt12.Text);
                sum = p1 + p2;
                if (sum == 10)
                {
                    tt12.Text = "/";
                    tt12.Enabled = false;
                    tt11.Enabled = false;
                    ttp6.Text = "";
                    if (ju3.Visible == true)
                    {
                        tq11.Enabled = true;
                        tq12.Enabled = true;
                    }
                    else
                    {
                        t13.Enabled = true;
                        t14.Enabled = true;
                    }
                }
                if (sum > 10)
                {
                    MessageBox.Show("La suma no puede ser mayor a 10");
                    tt11.Enabled = true;
                    tt11.Text = "";
                    tt12.Text = "";
                }
                if (tt10.Text == "X")
                {
                    int sum1, p, t, sum2;
                    p = Convert.ToInt32(ttp4.Text);
                    sum1 = 10 + sum + p;
                    ttp5.Text = Convert.ToString(sum1);
                    pun2.Text = Convert.ToString(sum1);
                    tt12.Enabled = false;
                    t = Convert.ToInt32(ttp5.Text);
                    sum2 = t + sum;
                    if (sum == 10)
                    {
                        ttp6.Text = "";
                        pun2.Text = ttp5.Text;
                    }
                    else
                    {
                        ttp6.Text = Convert.ToString(sum2);
                        pun2.Text = Convert.ToString(sum2);
                    }
                }
                else
                {
                    if (!(tt12.Text == "/"))
                    {
                        p3 = Convert.ToInt32(ttp5.Text);
                        sumt = p3 + sum;
                        ttp6.Text = Convert.ToString(sumt);
                        pun2.Text = Convert.ToString(sumt);
                        tt12.Enabled = false;
                        if (ju3.Visible == true)
                        {
                            tq11.Enabled = true;
                            tq12.Enabled = true;
                        }
                        else
                        {
                            t13.Enabled = true;
                            t14.Enabled = true;
                        }
                    }
                    else
                    {
                        ttp6.Text = "";
                    }
                }
            }
        }

        private void tt13_TextChanged(object sender, EventArgs e)
        {
            if (tt13.Text == "X")
            {
                tt14.Text = "X";
                tt13.Enabled = false;
                tt14.Enabled = false;
                if (ju3.Visible == true)
                {
                    tq13.Enabled = true;
                    tq14.Enabled = true;
                }
                else
                {
                    t15.Enabled = true;
                    t16.Enabled = true;
                }
            }
            else
            {
                tt13.Enabled = false;
            }
            if (tt12.Text == "/" && tt13.Text == "X")
            {
                int sum, sum2, p;
                sum = 20;
                p = Convert.ToInt32(ttp5.Text);
                sum2 = sum + p;
                ttp6.Text = Convert.ToString(sum2);
                pun2.Text = Convert.ToString(sum2);
            }
            else if (tt12.Text == "/")
            {
                int p, p2, sum;
                p = Convert.ToInt32(tt13.Text);
                p2 = Convert.ToInt32(ttp5.Text);
                sum = p2 + 10 + p;
                ttp6.Text = Convert.ToString(sum);
                pun2.Text = Convert.ToString(sum);
            }
            if (tt9.Text == "X" && tt11.Text == "X" && !(tt13.Text == "X"))
            {
                int p, c, sum;
                p = Convert.ToInt32(tt13.Text);
                c = Convert.ToInt32(ttp4.Text);
                sum = 20 + p + c;
                ttp5.Text = Convert.ToString(sum);
                pun2.Text = Convert.ToString(sum);
            }
            else if (tt9.Text == "X" && tt11.Text == "X" && tt13.Text == "X")
            {
                int sum, p;
                p = Convert.ToInt32(ttp4.Text);
                sum = 30 + p;
                ttp5.Text = Convert.ToString(sum);
                pun2.Text = Convert.ToString(sum);
            }

        }

        private void tt14_TextChanged(object sender, EventArgs e)
        {
            if (!(tt13.Text == "X") && !(tt14.Text == "X") && !(tt14.Text == "/"))
            {
                int p1, p2, p3, sum, sumt;
                p1 = Convert.ToInt32(tt13.Text);
                p2 = Convert.ToInt32(tt14.Text);
                sum = p1 + p2;
                if (sum == 10)
                {
                    tt14.Text = "/";
                    tt14.Enabled = false;
                    tt13.Enabled = false;
                    ttp7.Text = "";
                    if (ju3.Visible == true)
                    {
                        tq13.Enabled = true;
                        tq14.Enabled = true;
                    }
                    else
                    {
                        t15.Enabled = true;
                        t16.Enabled = true;
                    }
                }
                if (sum > 10)
                {
                    MessageBox.Show("La suma no puede ser mayor a 10");
                    tt13.Enabled = true;
                    tt13.Text = "";
                    tt14.Text = "";
                }
                if (tt12.Text == "X")
                {
                    int sum1, p, t, sum2;
                    p = Convert.ToInt32(ttp5.Text);
                    sum1 = 10 + sum + p;
                    ttp6.Text = Convert.ToString(sum1);
                    pun2.Text = Convert.ToString(sum1);
                    tt14.Enabled = false;
                    if (ju3.Visible == true)
                    {
                        tt16.Enabled = false;
                    }
                    else
                    {
                        t16.Enabled = true;
                    }
                    t = Convert.ToInt32(ttp6.Text);
                    sum2 = t + sum;
                    if (sum == 10)
                    {
                        ttp7.Text = "";
                        pun2.Text = ttp6.Text;
                    }
                    else
                    {
                        ttp7.Text = Convert.ToString(sum2);
                        pun2.Text = Convert.ToString(sum2);
                    }
                }
                else
                {
                    if (!(tt14.Text == "/"))
                    {
                        p3 = Convert.ToInt32(ttp6.Text);
                        sumt = p3 + sum;
                        ttp7.Text = Convert.ToString(sumt);
                        pun2.Text = Convert.ToString(sumt);
                        tt14.Enabled = false;
                        if (ju3.Visible == true)
                        {
                            tq13.Enabled = true;
                            tq14.Enabled = true;
                        }
                        else
                        {
                            t15.Enabled = true;
                            t16.Enabled = true;
                        }
                    }
                    else
                    {
                        ttp7.Text = "";
                    }
                }
            }
        }

        private void tt15_TextChanged(object sender, EventArgs e)
        {
            if (tt15.Text == "X")
            {
                tt16.Text = "X";
                tt15.Enabled = false;
                tt16.Enabled = false;
                if (ju3.Visible == true)
                {
                    tq15.Enabled = true;
                    tq16.Enabled = true;
                }
                else
                {
                    t17.Enabled = true;
                    t18.Enabled = true;
                }
            }
            else
            {
                tt15.Enabled = false;
            }
            if (tt14.Text == "/" && tt15.Text == "X")
            {
                int sum, sum2, p;
                sum = 20;
                p = Convert.ToInt32(ttp6.Text);
                sum2 = sum + p;
                ttp7.Text = Convert.ToString(sum2);
                pun2.Text = Convert.ToString(sum2);
            }
            else if (tt14.Text == "/")
            {
                int p, p2, sum;
                p = Convert.ToInt32(tt15.Text);
                p2 = Convert.ToInt32(ttp6.Text);
                sum = p2 + 10 + p;
                ttp7.Text = Convert.ToString(sum);
                pun2.Text = Convert.ToString(sum);
            }
            if (tt11.Text == "X" && tt13.Text == "X" && !(tt15.Text == "X"))
            {
                int p, c, sum;
                p = Convert.ToInt32(tt15.Text);
                c = Convert.ToInt32(ttp5.Text);
                sum = 20 + p + c;
                ttp6.Text = Convert.ToString(sum);
                pun2.Text = Convert.ToString(sum);
            }
            else if (tt11.Text == "X" && tt13.Text == "X" && tt15.Text == "X")
            {
                int sum, p;
                p = Convert.ToInt32(ttp5.Text);
                sum = 30 + p;
                ttp6.Text = Convert.ToString(sum);
                pun2.Text = Convert.ToString(sum);
            }
        }

        private void tt16_TextChanged(object sender, EventArgs e)
        {
            if (!(tt15.Text == "X") && !(tt16.Text == "X") && !(tt16.Text == "/"))
            {
                int p1, p2, p3, sum, sumt;
                p1 = Convert.ToInt32(tt15.Text);
                p2 = Convert.ToInt32(tt16.Text);
                sum = p1 + p2;
                if (sum == 10)
                {
                    tt16.Text = "/";
                    tt16.Enabled = false;
                    tt15.Enabled = false;
                    ttp8.Text = "";
                    if (ju3.Visible == true)
                    {
                        tq15.Enabled = true;
                        tq16.Enabled = true;
                    }
                    else
                    {
                        t17.Enabled = true;
                        t18.Enabled = true;
                    }
                }
                if (sum > 10)
                {
                    MessageBox.Show("La suma no puede ser mayor a 10");
                    tt15.Enabled = true;
                    tt15.Text = "";
                    tt16.Text = "";
                }
                if (tt14.Text == "X")
                {
                    int sum1, p, t, sum2;
                    p = Convert.ToInt32(ttp6.Text);
                    sum1 = 10 + sum + p;
                    ttp7.Text = Convert.ToString(sum1);
                    pun2.Text = Convert.ToString(sum1);
                    tt16.Enabled = false;
                    if (ju3.Visible == true)
                    {
                        tt18.Enabled = false;
                    }
                    else
                    {
                        t18.Enabled = true;
                    }
                    t = Convert.ToInt32(ttp7.Text);
                    sum2 = t + sum;
                    if (sum == 10)
                    {
                        ttp8.Text = "";
                        pun2.Text = ttp7.Text;
                    }
                    else
                    {
                        ttp8.Text = Convert.ToString(sum2);
                        pun2.Text = Convert.ToString(sum2);
                    }
                }
                else
                {
                    if (!(tt16.Text == "/"))
                    {
                        p3 = Convert.ToInt32(ttp7.Text);
                        sumt = p3 + sum;
                        ttp8.Text = Convert.ToString(sumt);
                        pun2.Text = Convert.ToString(sumt);
                        tt16.Enabled = false;
                        if (ju3.Visible == true)
                        {
                            tq15.Enabled = true;
                            tq16.Enabled = true;
                        }
                        else
                        {
                            t17.Enabled = true;
                            t18.Enabled = true;
                        }
                    }
                    else
                    {
                        ttp8.Text = "";
                    }
                }
            }
        }

        private void tt17_TextChanged(object sender, EventArgs e)
        {
            if (tt17.Text == "X")
            {
                tt18.Text = "X";
                tt17.Enabled = false;
                tt18.Enabled = false;
                if (ju3.Visible == true)
                {
                    tq17.Enabled = true;
                    tq18.Enabled = true;
                }
                else
                {
                    t19.Enabled = true;
                    t20.Enabled = true;
                }
            }
            else
            {
                tt17.Enabled = false;
                if (ju3.Enabled == true)
                {
                    tt19.Enabled = false;
                }
                else
                {
                    t19.Enabled = true;
                }
            }
            if (tt16.Text == "/" && tt17.Text == "X")
            {
                int sum, sum2, p;
                sum = 20;
                p = Convert.ToInt32(ttp7.Text);
                sum2 = sum + p;
                ttp8.Text = Convert.ToString(sum2);
                pun2.Text = Convert.ToString(sum2);
            }
            else if (tt16.Text == "/")
            {
                int p, p2, sum;
                p = Convert.ToInt32(tt17.Text);
                p2 = Convert.ToInt32(ttp7.Text);
                sum = p2 + 10 + p;
                ttp8.Text = Convert.ToString(sum);
                pun2.Text = Convert.ToString(sum);
            }
            if (tt13.Text == "X" && tt15.Text == "X" && !(tt17.Text == "X"))
            {
                int p, c, sum;
                p = Convert.ToInt32(tt17.Text);
                c = Convert.ToInt32(ttp6.Text);
                sum = 20 + p + c;
                ttp7.Text = Convert.ToString(sum);
                pun2.Text = Convert.ToString(sum);
            }
            else if (tt13.Text == "X" && tt15.Text == "X" && tt17.Text == "X")
            {
                int sum, p;
                p = Convert.ToInt32(ttp6.Text);
                sum = 30 + p;
                ttp7.Text = Convert.ToString(sum);
                pun2.Text = Convert.ToString(sum);
            }
        }

        private void tt18_TextChanged(object sender, EventArgs e)
        {
            if (!(tt17.Text == "X") && !(tt18.Text == "X") && !(tt18.Text == "/"))
            {
                int p1, p2, p3, sum, sumt;
                p1 = Convert.ToInt32(tt17.Text);
                p2 = Convert.ToInt32(tt18.Text);
                sum = p1 + p2;
                if (sum == 10)
                {
                    tt18.Text = "/";
                    tt18.Enabled = false;
                    tt17.Enabled = false;
                    ttp9.Text = "";
                    if (ju3.Visible == true)
                    {
                        tq17.Enabled = true;
                        tq18.Enabled = true;
                    }
                    else
                    {
                        t19.Enabled = true;
                        t20.Enabled = true;
                    }
                }
                if (sum > 10)
                {
                    MessageBox.Show("La suma no puede ser mayor a 10");
                    tt17.Enabled = true;
                    tt17.Text = "";
                    tt18.Text = "";
                }
                if (tt16.Text == "X")
                {
                    int sum1, p, t, sum2;
                    p = Convert.ToInt32(ttp7.Text);
                    sum1 = 10 + sum + p;
                    ttp8.Text = Convert.ToString(sum1);
                    pun2.Text = Convert.ToString(sum1);
                    tt18.Enabled = false;
                    if (ju3.Visible == true)
                    {
                        tt20.Enabled = false;
                    }
                    else
                    {
                        t20.Enabled = true;
                    }
                    t = Convert.ToInt32(ttp8.Text);
                    sum2 = t + sum;
                    if (sum == 10)
                    {
                        ttp9.Text = "";
                        pun2.Text = ttp8.Text;
                    }
                    else
                    {
                        ttp9.Text = Convert.ToString(sum2);
                        pun2.Text = Convert.ToString(sum2);
                    }
                }
                else
                {
                    if (!(tt18.Text == "/"))
                    {
                        p3 = Convert.ToInt32(ttp8.Text);
                        sumt = p3 + sum;
                        ttp9.Text = Convert.ToString(sumt);
                        pun2.Text = Convert.ToString(sumt);
                        tt18.Enabled = false;
                        if (ju3.Visible == true)
                        {
                            tq17.Enabled = true;
                            tq18.Enabled = true;
                        }
                        else
                        {
                            t19.Enabled = true;
                            t20.Enabled = true;
                        }
                    }
                    else
                    {
                        ttp9.Text = "";
                    }
                }
            }
        }

        private void tt19_TextChanged(object sender, EventArgs e)
        {
            if (tt19.Text == "X")
            {
                tt21.Enabled = true;
                tt19.Enabled = false;
            }
            else
            {
                tt19.Enabled = false;
                tt21.Enabled = true;
            }
            if (tt18.Text == "/" && tt19.Text == "X")
            {
                int sum, sum2, p;
                sum = 20;
                p = Convert.ToInt32(ttp8.Text);
                sum2 = sum + p;
                ttp9.Text = Convert.ToString(sum2);
                pun2.Text = Convert.ToString(sum2);
                tt20.Enabled = true;
            }
            else if (tt18.Text == "/")
            {
                int p, p2, sum;
                p = Convert.ToInt32(tt19.Text);
                p2 = Convert.ToInt32(ttp8.Text);
                sum = p2 + 10 + p;
                ttp9.Text = Convert.ToString(sum);
                pun2.Text = Convert.ToString(sum);
            }
            if (tt15.Text == "X" && tt17.Text == "X" && !(tt19.Text == "X"))
            {
                int p, c, sum;
                p = Convert.ToInt32(tt19.Text);
                c = Convert.ToInt32(ttp7.Text);
                sum = 20 + p + c;
                ttp8.Text = Convert.ToString(sum);
                pun2.Text = Convert.ToString(sum);
            }
            if (tt15.Text == "X" && tt17.Text == "X" && tt19.Text == "X")
            {
                int sum, p;
                p = Convert.ToInt32(ttp7.Text);
                sum = 30 + p;
                ttp8.Text = Convert.ToString(sum);
                pun2.Text = Convert.ToString(sum);
            }
        }

        private void tt20_TextChanged(object sender, EventArgs e)
        {
            if (tt20.Text == "X")
            {
                tt21.Enabled = true;
                tt20.Enabled = false;
                ttp10.Text = "";
            }
            else if (tt20.Text == "/")
            {
                tt20.Enabled = false;
                tt21.Enabled = true;
            }
            else
            {
                if (!(tt19.Text=="X"))
                {
                    int p1, p2, p3, sum, sumt;
                    p1 = Convert.ToInt32(tt19.Text);
                    p2 = Convert.ToInt32(tt20.Text);
                    sum = p1 + p2;
                    if (sum == 10)
                    {
                        tt20.Text = "/";
                        tt20.Enabled = false;
                        ttp10.Text = "";
                        tt21.Enabled = true;
                    }
                    if (sum > 10)
                    {
                        MessageBox.Show("La suma no puede ser mayor a 10");
                        tt17.Enabled = true;
                        tt17.Text = "";
                        tt18.Text = "";
                    }
                    if (tt18.Text == "X")
                    {
                        int sum1, p, t, sum2;
                        p = Convert.ToInt32(ttp8.Text);
                        sum1 = 10 + sum + p;
                        ttp9.Text = Convert.ToString(sum1);
                        pun2.Text = Convert.ToString(sum1);
                        tt20.Enabled = false;
                        t = Convert.ToInt32(ttp9.Text);
                        sum2 = t + sum;
                        if (sum == 10)
                        {
                            ttp10.Text = "";
                            pun2.Text = ttp9.Text;
                        }
                        else
                        {
                            ttp10.Text = Convert.ToString(sum2);
                            pun2.Text = Convert.ToString(sum2);
                            tt21.Enabled = false;
                            if (ju3.Visible == true)
                            {
                                tq19.Enabled = true;
                                tq20.Enabled = true;
                            }
                            else
                            {
                                MessageBox.Show("Fin del juego");
                            }

                        }
                    }
                    else
                    {
                        if (!(tt20.Text == "/"))
                        {
                            tt21.Enabled = false;
                            p3 = Convert.ToInt32(ttp9.Text);
                            sumt = p3 + sum;
                            ttp10.Text = Convert.ToString(sumt);
                            pun2.Text = Convert.ToString(sumt);
                            tt19.Enabled = false;
                            tt20.Enabled = false;

                            if (ju3.Visible == true)
                            {
                                tq19.Enabled = true;
                                tq20.Enabled = true;
                            }
                            else
                            {
                                MessageBox.Show("Fin del juego");
                            }
                        }
                        else
                        {
                            ttp10.Text = "";
                            tt21.Enabled = true;
                        }
                    }
                }
                else
                {
                    tt20.Enabled = false;
                }
            }
            if (tt17.Text == "X" && tt19.Text == "X" && tt20.Text == "X")
            {
                int sum, p;
                p = Convert.ToInt32(ttp8.Text);
                sum = 30 + p;
                ttp9.Text = Convert.ToString(sum);
                pun2.Text = Convert.ToString(sum);
            }
            else if (tt17.Text == "X" && tt19.Text == "X" && !(tt20.Text == "X"))
            {
                int sum, p, y;
                y = Convert.ToInt32(tt20.Text);
                p = Convert.ToInt32(ttp8.Text);
                sum = 20 + p + y;
                ttp9.Text = Convert.ToString(sum);
                pun2.Text = Convert.ToString(sum);
            }
        }

        private void tt21_TextChanged(object sender, EventArgs e)
        {
            int p, sum, pp;
            if (tt19.Text == "X" && tt20.Text == "X" && tt21.Text == "X")
            {
                p = Convert.ToInt32(ttp9.Text);
                sum = p + 30;
                ttp10.Text = Convert.ToString(sum);
                pun2.Text = Convert.ToString(sum);
                tt21.Enabled = false;
                if (ju3.Visible == true)
                {
                    tq19.Enabled = true;
                    tq20.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Fin del juego");
                }
            }
            if (tt20.Text == "/")
            {
                if (tt21.Text == "X")
                {
                    p = Convert.ToInt32(ttp9.Text);
                    sum = p + 20;
                    ttp10.Text = Convert.ToString(sum);
                    pun2.Text = Convert.ToString(sum);
                    tt21.Enabled = false;
                    if (ju3.Visible == true)
                    {
                        tq19.Enabled = true;
                        tq20.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Fin del juego");
                    }
                }
                else
                {
                    p = Convert.ToInt32(ttp9.Text);
                    pp = Convert.ToInt32(tt21.Text);
                    sum = p + 10 + pp;
                    ttp10.Text = Convert.ToString(sum);
                    pun2.Text = Convert.ToString(sum);
                    if (ju3.Visible == true)
                    {
                        tt21.Enabled = false;
                        tq19.Enabled = true;
                        tq20.Enabled = true;
                    }
                    else
                    {
                        tt21.Enabled = false;
                        MessageBox.Show("Fin del juego");
                    }
                }

            }
            if (tt19.Text == "X" && !(tt20.Text == "X"))
            {
                int c, p1, sump, sumpp, d;
                c = Convert.ToInt32(tt20.Text);
                p1 = Convert.ToInt32(tt21.Text);
                d = Convert.ToInt32(ttp9.Text);
                sump = c + p1;
                if (sump > 10)
                {
                    MessageBox.Show("la suma no puede ser mayor a 10");
                    tt20.Enabled = true;
                    tt20.Text = "";
                    tt21.Enabled = true;
                    tt21.Text = "";
                }
                else
                {
                    sumpp = sump + 10 + d;
                    ttp10.Text = Convert.ToString(sumpp);
                    pun2.Text = Convert.ToString(sumpp);
                    tt21.Enabled = false;
                    if (ju3.Visible == true)
                    {
                        tq19.Enabled = true;
                        tq20.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Fin del juego");
                    }
                }
            }
        }
        /////////
        private void tq1_TextChanged(object sender, EventArgs e)
        {
            if (tq1.Text == "X")
            {
                tq2.Text = "X";
                tq1.Enabled = false;
                tq2.Enabled = false;
                if (ju4.Visible == true)
                {
                    tw1.Enabled = true;
                    tw2.Enabled = true;
                }
                else
                {
                    t3.Enabled = true;
                    t4.Enabled = true;
                }
            }
            else
            {
                tq1.Enabled = false;
            }
        }

        private void tq2_TextChanged(object sender, EventArgs e)
        {
            if (!(tq1.Text == "X") && !(tq2.Text == "X") && !(tq2.Text == "/"))
            {
                int p1, p2, sum;
                p1 = Convert.ToInt32(tq1.Text);
                p2 = Convert.ToInt32(tq2.Text);
                sum = p1 + p2;
                if (sum == 10)
                {
                    tq2.Text = "/";
                    tq2.Enabled = false;
                    tqp1.Text = "";
                    if (ju3.Visible == true)
                    {
                        tw1.Enabled = true;
                        tw2.Enabled = true;
                    }
                    else
                    {
                        t3.Enabled = true;
                        t4.Enabled = true;
                    }
                }
                if (sum > 10)
                {
                    MessageBox.Show("La suma no puede ser mayor a 10");
                    tq1.Enabled = true;
                    tq1.Text = "";
                    tq2.Text = "";
                }
                else
                {
                    if (!(tq2.Text == "/"))
                    {
                        tqp1.Text = Convert.ToString(sum);
                        pun3.Text = Convert.ToString(sum);
                        tq2.Enabled = false;
                        if (ju4.Visible == true)
                        {
                            tw1.Enabled = true;
                            tw2.Enabled = true;
                        }
                        else
                        {
                            t3.Enabled = true;
                            t4.Enabled = true;
                        }
                    }
                    else
                    {
                        tqp1.Text = "";
                    }
                }
            }
        }

        private void tq3_TextChanged(object sender, EventArgs e)
        {
            int p, sum;
            if (tq3.Text == "X")
            {
                tq4.Text = "X";
                tq3.Enabled = false;
                tq4.Enabled = false;
                if (ju4.Visible == true)
                {
                    tw3.Enabled = true;
                    tw4.Enabled = true;
                }
                else
                {
                    t5.Enabled = true;
                    t6.Enabled = true;
                }
            }
            else
            {
                tq3.Enabled = false;
                if (ju4.Enabled == true)
                {
                    tw5.Enabled = false;
                }
                else
                {
                    t5.Enabled = true;
                }
            }
            if (tq2.Text == "/" && tq3.Text == "X")
            {
                sum = 20;
                tqp1.Text = Convert.ToString(sum);
                pun3.Text = Convert.ToString(sum);
            }
            else if (tq2.Text == "/")
            {
                p = Convert.ToInt32(tq3.Text);
                sum = 10 + p;
                tqp1.Text = Convert.ToString(sum);
                pun3.Text = Convert.ToString(sum);
                tq4.Enabled = true;
            }
        }

        private void tq4_TextChanged(object sender, EventArgs e)
        {
            if (!(tq3.Text == "X") && !(tq4.Text == "X") && !(tq4.Text == "/"))
            {
                int p1, p2, p3, sum, sumt;
                p1 = Convert.ToInt32(tq3.Text);
                p2 = Convert.ToInt32(tq4.Text);
                sum = p1 + p2;
                if (sum == 10)
                {
                    tq4.Text = "/";
                    tq4.Enabled = false;
                    tq3.Enabled = false;
                    tqp2.Text = "";
                    if (ju4.Visible == true)
                    {
                        tw3.Enabled = true;
                        tw4.Enabled = true;
                    }
                    else
                    {
                        t5.Enabled = true;
                        t6.Enabled = true;
                    }
                }
                if (sum > 10)
                {
                    MessageBox.Show("La suma no puede ser mayor a 10");
                    tq3.Enabled = true;
                    tq3.Text = "";
                    tq4.Text = "";
                }
                if (tq2.Text == "X" && !(tq4.Text == "X"))
                {
                    int sumq;
                    sumt = 10 + sum;
                    tqp1.Text = Convert.ToString(sumt);
                    sumq = Convert.ToInt32(tqp1.Text) + sum;
                    if (sum == 10)
                    {
                        tqp2.Text = "";
                        pun3.Text = tqp1.Text;
                    }
                    else
                    {
                        tqp2.Text = Convert.ToString(sumq);
                        pun3.Text = Convert.ToString(sumq);
                    }
                    tq4.Enabled = false;
                    if (ju4.Visible == true)
                    {
                        tw3.Enabled = true;
                        tw4.Enabled = true;
                    }
                    else
                    {
                        t5.Enabled = true;
                        t6.Enabled = true;
                    }
                }
                else
                {
                    if (!(tq4.Text == "/"))
                    {
                        p3 = Convert.ToInt32(tqp1.Text);
                        sumt = p3 + sum;
                        tqp2.Text = Convert.ToString(sumt);
                        pun3.Text = Convert.ToString(sumt);
                        tq4.Enabled = false;
                        if (ju4.Visible == true)
                        {
                            tw3.Enabled = true;
                            tw4.Enabled = true;
                        }
                        else
                        {
                            t5.Enabled = true;
                            t6.Enabled = true;
                        }
                    }
                    else
                    {
                        tqp2.Text = "";
                    }
                }

            }
        }

        private void tq5_TextChanged(object sender, EventArgs e)
        {
            if (tq5.Text == "X")
            {
                tq6.Text = "X";
                tq5.Enabled = false;
                tq6.Enabled = false;
                if (ju4.Visible == true)
                {
                    tw5.Enabled = true;
                    tw6.Enabled = true;
                }
                else
                {
                    t7.Enabled = true;
                    t8.Enabled = true;
                }
            }
            else
            {
                tq5.Enabled = false;
            }
            if (tq4.Text == "/" && tq5.Text == "X")
            {
                int sum, sum2, p;
                sum = 20;
                p = Convert.ToInt32(tqp1.Text);
                sum2 = sum + p;
                tqp2.Text = Convert.ToString(sum2);
                pun3.Text = Convert.ToString(sum2);
            }
            else if (tq4.Text == "/")
            {
                int p, p2, sum;
                p = Convert.ToInt32(tq5.Text);
                p2 = Convert.ToInt32(tqp1.Text);
                sum = p2 + 10 + p;
                tqp2.Text = Convert.ToString(sum);
                pun3.Text = Convert.ToString(sum);
            }
            if (tq1.Text == "X" && tq3.Text == "X" && !(tq5.Text == "X"))
            {
                int p, sum;
                p = Convert.ToInt32(tq5.Text);
                sum = 20 + p;
                tqp1.Text = Convert.ToString(sum);
                pun3.Text = Convert.ToString(sum);
            }
            else if (tq1.Text == "X" && tq3.Text == "X" && tq5.Text == "X")
            {
                int sum;
                sum = 30;
                tqp1.Text = Convert.ToString(sum);
                pun3.Text = Convert.ToString(sum);
            }
        }

        private void tq6_TextChanged(object sender, EventArgs e)
        {
            if (!(tq5.Text == "X") && !(tq6.Text == "X") && !(tq6.Text == "/"))
            {
                int p1, p2, p3, sum, sumt;
                p1 = Convert.ToInt32(tq5.Text);
                p2 = Convert.ToInt32(tq6.Text);
                sum = p1 + p2;
                if (sum == 10)
                {
                    tq6.Text = "/";
                    tq6.Enabled = false;
                    tq5.Enabled = false;
                    tqp3.Text = "";
                    if (ju4.Visible == true)
                    {
                        tw5.Enabled = true;
                        tw6.Enabled = true;
                    }
                    else
                    {
                        t7.Enabled = true;
                        t8.Enabled = true;
                    }
                }
                if (sum > 10)
                {
                    MessageBox.Show("La suma no puede ser mayor a 10");
                    tq5.Enabled = true;
                    tq5.Text = "";
                    tq6.Text = "";
                }
                if (tq4.Text == "X")
                {
                    int sum1, p, t, sum2;
                    p = Convert.ToInt32(tqp1.Text);
                    sum1 = 10 + sum + p;
                    tqp2.Text = Convert.ToString(sum1);
                    pun3.Text = Convert.ToString(sum1);
                    tq6.Enabled = false;


                    t = Convert.ToInt32(tqp2.Text);
                    sum2 = t + sum;
                    if (sum == 10)
                    {
                        tqp3.Text = "";
                        pun3.Text = tqp2.Text;
                    }
                    else
                    {
                        tqp3.Text = Convert.ToString(sum2);
                        pun3.Text = Convert.ToString(sum2);
                    }
                }
                else
                {
                    if (!(tq6.Text == "/"))
                    {
                        p3 = Convert.ToInt32(tqp2.Text);
                        sumt = p3 + sum;
                        tqp3.Text = Convert.ToString(sumt);
                        pun3.Text = Convert.ToString(sumt);
                        tq6.Enabled = false;
                        if (ju4.Visible == true)
                        {
                            tw5.Enabled = true;
                            tw6.Enabled = true;
                        }
                        else
                        {
                            t7.Enabled = true;
                            t8.Enabled = true;
                        }
                    }
                    else
                    {
                        tqp3.Text = "";
                    }
                }
            }
        }

        private void tq7_TextChanged(object sender, EventArgs e)
        {
            if (tq7.Text == "X")
            {
                tq8.Text = "X";
                tq7.Enabled = false;
                tq8.Enabled = false;
                if (ju4.Visible == true)
                {
                    tw7.Enabled = true;
                    tw8.Enabled = true;
                }
                else
                {
                    t9.Enabled = true;
                    t10.Enabled = true;
                }

            }
            else
            {
                tq7.Enabled = false;
                if (ju4.Enabled == true)
                {
                    tw9.Enabled = false;
                }
                else
                {
                    t9.Enabled = true;
                }
            }
            if (tq6.Text == "/" && tq7.Text == "X")
            {
                int sum, sum2, p;
                sum = 20;
                p = Convert.ToInt32(tqp2.Text);
                sum2 = sum + p;
                tqp3.Text = Convert.ToString(sum2);
                pun3.Text = Convert.ToString(sum2);
            }
            else if (tq6.Text == "/")
            {
                int p, p2, sum;
                p = Convert.ToInt32(tq7.Text);
                p2 = Convert.ToInt32(tqp2.Text);
                sum = p2 + 10 + p;
                tqp3.Text = Convert.ToString(sum);
                pun3.Text = Convert.ToString(sum);
            }
            if (tq3.Text == "X" && tq5.Text == "X" && !(tq7.Text == "X"))
            {
                int p, c, sum;
                p = Convert.ToInt32(tq7.Text);
                c = Convert.ToInt32(tqp1.Text);
                sum = 20 + p + c;
                tqp2.Text = Convert.ToString(sum);
                pun3.Text = Convert.ToString(sum);
            }
            else if (tq3.Text == "X" && tq5.Text == "X" && tq7.Text == "X")
            {
                int sum, p;
                p = Convert.ToInt32(tqp1.Text);
                sum = 30 + p;
                tqp2.Text = Convert.ToString(sum);
                pun3.Text = Convert.ToString(sum);
            }
        }

        private void tq8_TextChanged(object sender, EventArgs e)
        {
            if (!(tq7.Text == "X") && !(tq8.Text == "X") && !(tq8.Text == "/"))
            {
                int p1, p2, p3, sum, sumt;
                p1 = Convert.ToInt32(tq7.Text);
                p2 = Convert.ToInt32(tq8.Text);
                sum = p1 + p2;
                if (sum == 10)
                {
                    tq8.Text = "/";
                    tq8.Enabled = false;
                    tq7.Enabled = false;
                    tqp4.Text = "";
                    if (ju4.Visible == true)
                    {
                        tw7.Enabled = true;
                        tw8.Enabled = true;
                    }
                    else
                    {
                        t9.Enabled = true;
                        t10.Enabled = true;
                    }
                }
                if (sum > 10)
                {
                    MessageBox.Show("La suma no puede ser mayor a 10");
                    tq7.Enabled = true;
                    tq7.Text = "";
                    tq8.Text = "";
                }
                if (tq6.Text == "X")
                {
                    int sum1, p, t, sum2;
                    p = Convert.ToInt32(tqp2.Text);
                    sum1 = 10 + sum + p;
                    tqp3.Text = Convert.ToString(sum1);
                    pun3.Text = Convert.ToString(sum1);
                    tq8.Enabled = false;
                    t = Convert.ToInt32(tqp3.Text);
                    sum2 = t + sum;
                    if (sum == 10)
                    {
                        tqp4.Text = "";
                        pun3.Text = tqp3.Text;
                    }
                    else
                    {
                        tqp4.Text = Convert.ToString(sum2);
                        pun3.Text = Convert.ToString(sum2);
                    }
                }
                else
                {
                    if (!(tq8.Text == "/"))
                    {
                        p3 = Convert.ToInt32(tqp3.Text);
                        sumt = p3 + sum;
                        tqp4.Text = Convert.ToString(sumt);
                        pun3.Text = Convert.ToString(sumt);
                        tq8.Enabled = false;
                        if (ju4.Visible == true)
                        {
                            tw7.Enabled = true;
                            tw8.Enabled = true;
                        }
                        else
                        {
                            t9.Enabled = true;
                            t10.Enabled = true;
                        }
                    }
                    else
                    {
                        tqp4.Text = "";
                    }
                }
            }
        }

        private void tq9_TextChanged(object sender, EventArgs e)
        {
            if (tq9.Text == "X")
            {
                tq10.Text = "X";
                tq9.Enabled = false;
                tq10.Enabled = false;
                if (ju4.Visible == true)
                {
                    tw9.Enabled = true;
                    tw10.Enabled = true;
                }
                else
                {
                    t11.Enabled = true;
                    t12.Enabled = true;
                }

            }
            else
            {
                tq9.Enabled = false;
            }
            if (tq8.Text == "/" && tq9.Text == "X")
            {
                int sum, sum2, p;
                sum = 20;
                p = Convert.ToInt32(tqp3.Text);
                sum2 = sum + p;
                tqp4.Text = Convert.ToString(sum2);
                pun3.Text = Convert.ToString(sum2);
            }
            else if (tq8.Text == "/")
            {
                int p, p2, sum;
                p = Convert.ToInt32(tq9.Text);
                p2 = Convert.ToInt32(tqp3.Text);
                sum = p2 + 10 + p;
                tqp4.Text = Convert.ToString(sum);
                pun3.Text = Convert.ToString(sum);
            }
            if (tq5.Text == "X" && tq7.Text == "X" && !(tq9.Text == "X"))
            {
                int p, c, sum;
                p = Convert.ToInt32(tq9.Text);
                c = Convert.ToInt32(tqp2.Text);
                sum = 20 + p + c;
                tqp3.Text = Convert.ToString(sum);
                pun3.Text = Convert.ToString(sum);
            }
            else if (tq5.Text == "X" && tq7.Text == "X" && tq9.Text == "X")
            {
                int sum, p;
                p = Convert.ToInt32(tqp2.Text);
                sum = 30 + p;
                tqp3.Text = Convert.ToString(sum);
                pun3.Text = Convert.ToString(sum);
            }
        }

        private void tq10_TextChanged(object sender, EventArgs e)
        {
            if (!(tq9.Text == "X") && !(tq10.Text == "X") && !(tq10.Text == "/"))
            {
                int p1, p2, p3, sum, sumt;
                p1 = Convert.ToInt32(tq9.Text);
                p2 = Convert.ToInt32(tq10.Text);
                sum = p1 + p2;
                if (sum == 10)
                {
                    tq10.Text = "/";
                    tq10.Enabled = false;
                    tq9.Enabled = false;
                    tqp5.Text = "";
                    if (ju4.Visible == true)
                    {
                        tw9.Enabled = true;
                        tw10.Enabled = true;
                    }
                    else
                    {
                        t11.Enabled = true;
                        t12.Enabled = true;
                    }
                }
                if (sum > 10)
                {
                    MessageBox.Show("La suma no puede ser mayor a 10");
                    tq9.Enabled = true;
                    tq9.Text = "";
                    tq10.Text = "";
                }
                if (tq8.Text == "X")
                {
                    int sum1, p, t, sum2;
                    p = Convert.ToInt32(tqp3.Text);
                    sum1 = 10 + sum + p;
                    tqp4.Text = Convert.ToString(sum1);
                    pun3.Text = Convert.ToString(sum1);
                    tq10.Enabled = false;
                    t = Convert.ToInt32(tqp4.Text);
                    sum2 = t + sum;
                    if (sum == 10)
                    {
                        tqp5.Text = "";
                        pun3.Text = tqp4.Text;
                    }
                    else
                    {
                        tqp5.Text = Convert.ToString(sum2);
                        pun3.Text = Convert.ToString(sum2);
                    }
                }
                else
                {
                    if (!(tq10.Text == "/"))
                    {
                        p3 = Convert.ToInt32(tqp4.Text);
                        sumt = p3 + sum;
                        tqp5.Text = Convert.ToString(sumt);
                        pun3.Text = Convert.ToString(sumt);
                        tq10.Enabled = false;
                        if (ju4.Visible == true)
                        {
                            tw9.Enabled = true;
                            tw10.Enabled = true;
                        }
                        else
                        {
                            t11.Enabled = true;
                            t12.Enabled = true;
                        }
                    }
                    else
                    {
                        tqp5.Text = "";
                    }
                }
            }
        }

        private void tq11_TextChanged(object sender, EventArgs e)
        {
            if (tq11.Text == "X")
            {
                tq12.Text = "X";
                tq11.Enabled = false;
                tq12.Enabled = false;
                if (ju4.Visible == true)
                {
                    tw11.Enabled = true;
                    tw12.Enabled = true;
                }
                else
                {
                    t13.Enabled = true;
                    t14.Enabled = true;
                }
            }
            else
            {
                tq11.Enabled = false;

            }
            if (tq10.Text == "/" && tq11.Text == "X")
            {
                int sum, sum2, p;
                sum = 20;
                p = Convert.ToInt32(tqp4.Text);
                sum2 = sum + p;
                tqp5.Text = Convert.ToString(sum2);
                pun3.Text = Convert.ToString(sum2);
            }
            else if (tq10.Text == "/")
            {
                int p, p2, sum;
                p = Convert.ToInt32(tq11.Text);
                p2 = Convert.ToInt32(tqp4.Text);
                sum = p2 + 10 + p;
                tqp5.Text = Convert.ToString(sum);
                pun3.Text = Convert.ToString(sum);
            }
            if (tq7.Text == "X" && tq9.Text == "X" && !(tq11.Text == "X"))
            {
                int p, c, sum;
                p = Convert.ToInt32(tq11.Text);
                c = Convert.ToInt32(tqp3.Text);
                sum = 20 + p + c;
                tqp4.Text = Convert.ToString(sum);
                pun3.Text = Convert.ToString(sum);
            }
            else if (tq7.Text == "X" && tq9.Text == "X" && tq11.Text == "X")
            {
                int sum, p;
                p = Convert.ToInt32(tqp3.Text);
                sum = 30 + p;
                tqp4.Text = Convert.ToString(sum);
                pun3.Text = Convert.ToString(sum);
            }
        }

        private void tq12_TextChanged(object sender, EventArgs e)
        {
            if (!(tq11.Text == "X") && !(tq12.Text == "X") && !(tq12.Text == "/"))
            {
                int p1, p2, p3, sum, sumt;
                p1 = Convert.ToInt32(tq11.Text);
                p2 = Convert.ToInt32(tq12.Text);
                sum = p1 + p2;
                if (sum == 10)
                {
                    tq12.Text = "/";
                    tq12.Enabled = false;
                    tq11.Enabled = false;
                    tqp6.Text = "";
                    if (ju4.Visible == true)
                    {
                        tw11.Enabled = true;
                        tw12.Enabled = true;
                    }
                    else
                    {
                        t13.Enabled = true;
                        t14.Enabled = true;
                    }
                }
                if (sum > 10)
                {
                    MessageBox.Show("La suma no puede ser mayor a 10");
                    tq11.Enabled = true;
                    tq11.Text = "";
                    tq12.Text = "";
                }
                if (tq10.Text == "X")
                {
                    int sum1, p, t, sum2;
                    p = Convert.ToInt32(tqp4.Text);
                    sum1 = 10 + sum + p;
                    tqp5.Text = Convert.ToString(sum1);
                    pun3.Text = Convert.ToString(sum1);
                    tq12.Enabled = false;
                    t = Convert.ToInt32(tqp5.Text);
                    sum2 = t + sum;
                    if (sum == 10)
                    {
                        tqp6.Text = "";
                        pun3.Text = tqp5.Text;
                    }
                    else
                    {
                        tqp6.Text = Convert.ToString(sum2);
                        pun3.Text = Convert.ToString(sum2);
                    }
                }
                else
                {
                    if (!(tq12.Text == "/"))
                    {
                        p3 = Convert.ToInt32(tqp5.Text);
                        sumt = p3 + sum;
                        tqp6.Text = Convert.ToString(sumt);
                        pun3.Text = Convert.ToString(sumt);
                        tq12.Enabled = false;
                        if (ju4.Visible == true)
                        {
                            tw11.Enabled = true;
                            tw12.Enabled = true;
                        }
                        else
                        {
                            t13.Enabled = true;
                            t14.Enabled = true;
                        }
                    }
                    else
                    {
                        tqp6.Text = "";
                    }
                }
            }
        }

        private void tq13_TextChanged(object sender, EventArgs e)
        {
            if (tq13.Text == "X")
            {
                tq14.Text = "X";
                tq13.Enabled = false;
                tq14.Enabled = false;
                if (ju4.Visible == true)
                {
                    tw13.Enabled = true;
                    tw14.Enabled = true;
                }
                else
                {
                    t15.Enabled = true;
                    t16.Enabled = true;
                }
            }
            else
            {
                tq13.Enabled = false;
            }
            if (tq12.Text == "/" && tq13.Text == "X")
            {
                int sum, sum2, p;
                sum = 20;
                p = Convert.ToInt32(tqp5.Text);
                sum2 = sum + p;
                tqp6.Text = Convert.ToString(sum2);
                pun3.Text = Convert.ToString(sum2);
            }
            else if (tq12.Text == "/")
            {
                int p, p2, sum;
                p = Convert.ToInt32(tq13.Text);
                p2 = Convert.ToInt32(tqp5.Text);
                sum = p2 + 10 + p;
                tqp6.Text = Convert.ToString(sum);
                pun3.Text = Convert.ToString(sum);
            }
            if (tq9.Text == "X" && tq11.Text == "X" && !(tq13.Text == "X"))
            {
                int p, c, sum;
                p = Convert.ToInt32(tq13.Text);
                c = Convert.ToInt32(tqp4.Text);
                sum = 20 + p + c;
                tqp5.Text = Convert.ToString(sum);
                pun3.Text = Convert.ToString(sum);
            }
            else if (tq9.Text == "X" && tq11.Text == "X" && tq13.Text == "X")
            {
                int sum, p;
                p = Convert.ToInt32(tqp4.Text);
                sum = 30 + p;
                tqp5.Text = Convert.ToString(sum);
                pun3.Text = Convert.ToString(sum);
            }
        }

        private void tq14_TextChanged(object sender, EventArgs e)
        {
            if (!(tq13.Text == "X") && !(tq14.Text == "X") && !(tq14.Text == "/"))
            {
                int p1, p2, p3, sum, sumt;
                p1 = Convert.ToInt32(tq13.Text);
                p2 = Convert.ToInt32(tq14.Text);
                sum = p1 + p2;
                if (sum == 10)
                {
                    tq14.Text = "/";
                    tq14.Enabled = false;
                    tq13.Enabled = false;
                    tqp7.Text = "";
                    if (ju4.Visible == true)
                    {
                        tw13.Enabled = true;
                        tw14.Enabled = true;
                    }
                    else
                    {
                        t15.Enabled = true;
                        t16.Enabled = true;
                    }
                }
                if (sum > 10)
                {
                    MessageBox.Show("La suma no puede ser mayor a 10");
                    tq13.Enabled = true;
                    tq13.Text = "";
                    tq14.Text = "";
                }
                if (tq12.Text == "X")
                {
                    int sum1, p, t, sum2;
                    p = Convert.ToInt32(tqp5.Text);
                    sum1 = 10 + sum + p;
                    tqp6.Text = Convert.ToString(sum1);
                    pun3.Text = Convert.ToString(sum1);
                    tq14.Enabled = false;
                    if (ju4.Visible == true)
                    {
                        tq16.Enabled = false;
                    }
                    else
                    {
                        t16.Enabled = true;
                    }
                    t = Convert.ToInt32(tqp6.Text);
                    sum2 = t + sum;
                    if (sum == 10)
                    {
                        tqp7.Text = "";
                        pun3.Text = tqp6.Text;
                    }
                    else
                    {
                        tqp7.Text = Convert.ToString(sum2);
                        pun3.Text = Convert.ToString(sum2);
                    }
                }
                else
                {
                    if (!(tq14.Text == "/"))
                    {
                        p3 = Convert.ToInt32(tqp6.Text);
                        sumt = p3 + sum;
                        tqp7.Text = Convert.ToString(sumt);
                        pun3.Text = Convert.ToString(sumt);
                        tq14.Enabled = false;
                        if (ju4.Visible == true)
                        {
                            tw13.Enabled = true;
                            tw14.Enabled = true;
                        }
                        else
                        {
                            t15.Enabled = true;
                            t16.Enabled = true;
                        }
                    }
                    else
                    {
                        tqp7.Text = "";
                    }
                }
            }
        }

        private void tq15_TextChanged(object sender, EventArgs e)
        {
            if (tq15.Text == "X")
            {
                tq16.Text = "X";
                tq15.Enabled = false;
                tq16.Enabled = false;
                if (ju4.Visible == true)
                {
                    tw15.Enabled = true;
                    tw16.Enabled = true;
                }
                else
                {
                    t17.Enabled = true;
                    t18.Enabled = true;
                }
            }
            else
            {
                tq15.Enabled = false;
            }
            if (tq14.Text == "/" && tq15.Text == "X")
            {
                int sum, sum2, p;
                sum = 20;
                p = Convert.ToInt32(tqp6.Text);
                sum2 = sum + p;
                tqp7.Text = Convert.ToString(sum2);
                pun3.Text = Convert.ToString(sum2);
            }
            else if (tq14.Text == "/")
            {
                int p, p2, sum;
                p = Convert.ToInt32(tq15.Text);
                p2 = Convert.ToInt32(tqp6.Text);
                sum = p2 + 10 + p;
                tqp7.Text = Convert.ToString(sum);
                pun3.Text = Convert.ToString(sum);
            }
            if (tq11.Text == "X" && tq13.Text == "X" && !(tq15.Text == "X"))
            {
                int p, c, sum;
                p = Convert.ToInt32(tq15.Text);
                c = Convert.ToInt32(tqp5.Text);
                sum = 20 + p + c;
                tqp6.Text = Convert.ToString(sum);
                pun3.Text = Convert.ToString(sum);
            }
            else if (tq11.Text == "X" && tq13.Text == "X" && tq15.Text == "X")
            {
                int sum, p;
                p = Convert.ToInt32(tqp5.Text);
                sum = 30 + p;
                tqp6.Text = Convert.ToString(sum);
                pun3.Text = Convert.ToString(sum);
            }
        }

        private void tq16_TextChanged(object sender, EventArgs e)
        {
            if (!(tq15.Text == "X") && !(tq16.Text == "X") && !(tq16.Text == "/"))
            {
                int p1, p2, p3, sum, sumt;
                p1 = Convert.ToInt32(tq15.Text);
                p2 = Convert.ToInt32(tq16.Text);
                sum = p1 + p2;
                if (sum == 10)
                {
                    tq16.Text = "/";
                    tq16.Enabled = false;
                    tq15.Enabled = false;
                    tqp8.Text = "";
                    if (ju4.Visible == true)
                    {
                        tw15.Enabled = true;
                        tw16.Enabled = true;
                    }
                    else
                    {
                        t17.Enabled = true;
                        t18.Enabled = true;
                    }
                }
                if (sum > 10)
                {
                    MessageBox.Show("La suma no puede ser mayor a 10");
                    tq15.Enabled = true;
                    tq15.Text = "";
                    tq16.Text = "";
                }
                if (tq14.Text == "X")
                {
                    int sum1, p, t, sum2;
                    p = Convert.ToInt32(tqp6.Text);
                    sum1 = 10 + sum + p;
                    tqp7.Text = Convert.ToString(sum1);
                    pun3.Text = Convert.ToString(sum1);
                    tq16.Enabled = false;
                    if (ju4.Visible == true)
                    {
                        tq18.Enabled = false;
                    }
                    else
                    {
                        t18.Enabled = true;
                    }
                    t = Convert.ToInt32(tqp7.Text);
                    sum2 = t + sum;
                    if (sum == 10)
                    {
                        tqp8.Text = "";
                        pun3.Text = tqp7.Text;
                    }
                    else
                    {
                        tqp8.Text = Convert.ToString(sum2);
                        pun3.Text = Convert.ToString(sum2);
                    }
                }
                else
                {
                    if (!(tq16.Text == "/"))
                    {
                        p3 = Convert.ToInt32(tqp7.Text);
                        sumt = p3 + sum;
                        tqp8.Text = Convert.ToString(sumt);
                        pun3.Text = Convert.ToString(sumt);
                        tq16.Enabled = false;
                        if (ju4.Visible == true)
                        {
                            tw15.Enabled = true;
                            tw16.Enabled = true;
                        }
                        else
                        {
                            t17.Enabled = true;
                            t18.Enabled = true;
                        }
                    }
                    else
                    {
                        tqp8.Text = "";
                    }
                }
            }
        }

        private void tq17_TextChanged(object sender, EventArgs e)
        {
            if (tq17.Text == "X")
            {
                tq18.Text = "X";
                tq17.Enabled = false;
                tq18.Enabled = false;
                if (ju4.Visible == true)
                {
                    tw17.Enabled = true;
                    tw18.Enabled = true;
                }
                else
                {
                    t19.Enabled = true;
                    t20.Enabled = true;
                }
            }
            else
            {
                tq17.Enabled = false;
                if (ju4.Enabled == true)
                {
                    tw19.Enabled = false;
                }
                else
                {
                    t19.Enabled = true;
                }
            }
            if (tq16.Text == "/" && tq17.Text == "X")
            {
                int sum, sum2, p;
                sum = 20;
                p = Convert.ToInt32(tqp7.Text);
                sum2 = sum + p;
                tqp8.Text = Convert.ToString(sum2);
                pun3.Text = Convert.ToString(sum2);
            }
            else if (tq16.Text == "/")
            {
                int p, p2, sum;
                p = Convert.ToInt32(tq17.Text);
                p2 = Convert.ToInt32(tqp7.Text);
                sum = p2 + 10 + p;
                tqp8.Text = Convert.ToString(sum);
                pun3.Text = Convert.ToString(sum);
            }
            if (tq13.Text == "X" && tq15.Text == "X" && !(tq17.Text == "X"))
            {
                int p, c, sum;
                p = Convert.ToInt32(tq17.Text);
                c = Convert.ToInt32(tqp6.Text);
                sum = 20 + p + c;
                tqp7.Text = Convert.ToString(sum);
                pun3.Text = Convert.ToString(sum);
            }
            else if (tq13.Text == "X" && tq15.Text == "X" && tq17.Text == "X")
            {
                int sum, p;
                p = Convert.ToInt32(tqp6.Text);
                sum = 30 + p;
                tqp7.Text = Convert.ToString(sum);
                pun3.Text = Convert.ToString(sum);
            }
        }

        private void tq18_TextChanged(object sender, EventArgs e)
        {
            if (!(tq17.Text == "X") && !(tq18.Text == "X") && !(tq18.Text == "/"))
            {
                int p1, p2, p3, sum, sumt;
                p1 = Convert.ToInt32(tq17.Text);
                p2 = Convert.ToInt32(tq18.Text);
                sum = p1 + p2;
                if (sum == 10)
                {
                    tq18.Text = "/";
                    tq18.Enabled = false;
                    tq17.Enabled = false;
                    tqp9.Text = "";
                    if (ju4.Visible == true)
                    {
                        tw17.Enabled = true;
                        tw18.Enabled = true;
                    }
                    else
                    {
                        t19.Enabled = true;
                        t20.Enabled = true;
                    }
                }
                if (sum > 10)
                {
                    MessageBox.Show("La suma no puede ser mayor a 10");
                    tq17.Enabled = true;
                    tq17.Text = "";
                    tq18.Text = "";
                }
                if (tq16.Text == "X")
                {
                    int sum1, p, t, sum2;
                    p = Convert.ToInt32(tqp7.Text);
                    sum1 = 10 + sum + p;
                    tqp8.Text = Convert.ToString(sum1);
                    pun3.Text = Convert.ToString(sum1);
                    tq18.Enabled = false;
                    if (ju4.Visible == true)
                    {
                        tq20.Enabled = false;
                    }
                    else
                    {
                        t20.Enabled = true;
                    }
                    t = Convert.ToInt32(tqp8.Text);
                    sum2 = t + sum;
                    if (sum == 10)
                    {
                        tqp9.Text = "";
                        pun3.Text = tqp8.Text;
                    }
                    else
                    {
                        tqp9.Text = Convert.ToString(sum2);
                        pun3.Text = Convert.ToString(sum2);
                    }
                }
                else
                {
                    if (!(tq18.Text == "/"))
                    {
                        p3 = Convert.ToInt32(tqp8.Text);
                        sumt = p3 + sum;
                        tqp9.Text = Convert.ToString(sumt);
                        pun3.Text = Convert.ToString(sumt);
                        tq18.Enabled = false;
                        if (ju4.Visible == true)
                        {
                            tw17.Enabled = true;
                            tw18.Enabled = true;
                        }
                        else
                        {
                            t19.Enabled = true;
                            t20.Enabled = true;
                        }
                    }
                    else
                    {
                        tqp9.Text = "";
                    }
                }
            }
        }

        private void tq19_TextChanged(object sender, EventArgs e)
        {
            if (tq19.Text == "X")
            {
                tq21.Enabled = true;
                tq19.Enabled = false;
            }
            else
            {
                tq19.Enabled = false;
                tq21.Enabled = true;
            }
            if (tq18.Text == "/" && tq19.Text == "X")
            {
                int sum, sum2, p;
                sum = 20;
                p = Convert.ToInt32(tqp8.Text);
                sum2 = sum + p;
                tqp9.Text = Convert.ToString(sum2);
                pun3.Text = Convert.ToString(sum2);
                tq20.Enabled = true;
            }
            else if (tq18.Text == "/")
            {
                int p, p2, sum;
                p = Convert.ToInt32(tq19.Text);
                p2 = Convert.ToInt32(tqp8.Text);
                sum = p2 + 10 + p;
                tqp9.Text = Convert.ToString(sum);
                pun3.Text = Convert.ToString(sum);
            }
            if (tq15.Text == "X" && tq17.Text == "X" && !(tq19.Text == "X"))
            {
                int p, c, sum;
                p = Convert.ToInt32(tq19.Text);
                c = Convert.ToInt32(tqp7.Text);
                sum = 20 + p + c;
                tqp8.Text = Convert.ToString(sum);
                pun3.Text = Convert.ToString(sum);
            }
            if (tq15.Text == "X" && tq17.Text == "X" && tq19.Text == "X")
            {
                int sum, p;
                p = Convert.ToInt32(tqp7.Text);
                sum = 30 + p;
                tqp8.Text = Convert.ToString(sum);
                pun3.Text = Convert.ToString(sum);
            }
        }

        private void tq20_TextChanged(object sender, EventArgs e)
        {
            if (tq20.Text == "X")
            {
                tq21.Enabled = true;
                tq20.Enabled = false;
                tqp10.Text = "";
            }
            else if (tq20.Text == "/")
            {
                tq20.Enabled = false;
                tq21.Enabled = true;
            }
            else
            {
                if (!(tq19.Text == "X"))
                {
                    int p1, p2, p3, sum, sumt;
                    p1 = Convert.ToInt32(tq19.Text);
                    p2 = Convert.ToInt32(tq20.Text);
                    sum = p1 + p2;
                    if (sum == 10)
                    {
                        tq20.Text = "/";
                        tq20.Enabled = false;
                        tqp10.Text = "";
                        tq21.Enabled = true;
                    }
                    if (sum > 10)
                    {
                        MessageBox.Show("La suma no puede ser mayor a 10");
                        tq17.Enabled = true;
                        tq17.Text = "";
                        tq18.Text = "";
                    }
                    if (tq18.Text == "X")
                    {
                        int sum1, p, t, sum2;
                        p = Convert.ToInt32(tqp8.Text);
                        sum1 = 10 + sum + p;
                        tqp9.Text = Convert.ToString(sum1);
                        pun3.Text = Convert.ToString(sum1);
                        tq20.Enabled = false;
                        t = Convert.ToInt32(tqp9.Text);
                        sum2 = t + sum;
                        if (sum == 10)
                        {
                            tqp10.Text = "";
                            pun3.Text = tqp9.Text;
                        }
                        else
                        {
                            tqp10.Text = Convert.ToString(sum2);
                            pun3.Text = Convert.ToString(sum2);
                            tq21.Enabled = false;
                            if (ju4.Visible == true)
                            {
                                tw19.Enabled = true;
                                tw20.Enabled = true;
                            }
                            else
                            {
                                MessageBox.Show("Fin del juego");
                            }

                        }
                    }
                    else
                    {
                        if (!(tq20.Text == "/"))
                        {
                            tq21.Enabled = false;
                            p3 = Convert.ToInt32(tqp9.Text);
                            sumt = p3 + sum;
                            tqp10.Text = Convert.ToString(sumt);
                            pun3.Text = Convert.ToString(sumt);
                            tq19.Enabled = false;
                            tq20.Enabled = false;

                            if (ju4.Visible == true)
                            {
                                tw19.Enabled = true;
                                tw20.Enabled = true;
                            }
                            else
                            {
                                MessageBox.Show("Fin del juego");
                            }
                        }
                        else
                        {
                            tqp10.Text = "";
                            tq21.Enabled = true;
                        }
                    }
                }
                else
                {
                    tq20.Enabled = false;
                }
            }
            if (tq17.Text == "X" && tq19.Text == "X" && tq20.Text == "X")
            {
                int sum, p;
                p = Convert.ToInt32(tqp8.Text);
                sum = 30 + p;
                tqp9.Text = Convert.ToString(sum);
                pun3.Text = Convert.ToString(sum);
            }
            else if (tq17.Text == "X" && tq19.Text == "X" && !(tq20.Text == "X"))
            {
                int sum, p, y;
                y = Convert.ToInt32(tq20.Text);
                p = Convert.ToInt32(tqp8.Text);
                sum = 20 + p + y;
                tqp9.Text = Convert.ToString(sum);
                pun3.Text = Convert.ToString(sum);
            }
        }

        private void tq21_TextChanged(object sender, EventArgs e)
        {
            int p, sum, pp;
            if (tq19.Text == "X" && tq20.Text == "X" && tq21.Text == "X")
            {
                p = Convert.ToInt32(tqp9.Text);
                sum = p + 30;
                tqp10.Text = Convert.ToString(sum);
                pun3.Text = Convert.ToString(sum);
                tq21.Enabled = false;
                if (ju4.Visible == true)
                {
                    tw19.Enabled = true;
                    tw20.Enabled = true;
                }
                else
                {
                    
                    MessageBox.Show("Fin del juego");
                }
            }
            if (tq20.Text == "/")
            {
                if (tq21.Text == "X")
                {
                    p = Convert.ToInt32(tqp9.Text);
                    sum = p + 20;
                    tqp10.Text = Convert.ToString(sum);
                    pun3.Text = Convert.ToString(sum);
                    tq21.Enabled = false;
                    if (ju4.Visible == true)
                    {
                        tw19.Enabled = true;
                        tw20.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Fin del juego");
                    }
                }
                else
                {
                    p = Convert.ToInt32(tqp9.Text);
                    pp = Convert.ToInt32(tq21.Text);
                    sum = p + 10 + pp;
                    tqp10.Text = Convert.ToString(sum);
                    pun3.Text = Convert.ToString(sum);
                    tq21.Enabled = false;
                    if (ju4.Visible == true)
                    {
                        tw19.Enabled = true;
                        tw20.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Fin del juego");
                    }
                }

            }
            if (tq19.Text == "X" && !(tq20.Text == "X"))
            {
                int c, p1, sump, sumpp, d;
                c = Convert.ToInt32(tq20.Text);
                p1 = Convert.ToInt32(tq21.Text);
                d = Convert.ToInt32(tqp9.Text);
                sump = c + p1;
                if (sump > 10)
                {
                    MessageBox.Show("la suma no puede ser mayor a 10");
                    tq20.Enabled = true;
                    tq20.Text = "";
                    tq21.Enabled = true;
                    tq21.Text = "";
                }
                else
                {
                    sumpp = sump + 10 + d;
                    tqp10.Text = Convert.ToString(sumpp);
                    pun3.Text = Convert.ToString(sumpp);
                    tq21.Enabled = false;
                    if (ju4.Visible == true)
                    {
                        tw19.Enabled = true;
                        tw20.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Fin del juego");
                    }
                }
            }
        }
        //////// 
        private void tw1_TextChanged(object sender, EventArgs e)
        {
            if (tw1.Text == "X")
            {
                tw2.Text = "X";
                tw1.Enabled = false;
                tw2.Enabled = false;
                if (ju5.Visible == true)
                {
                    te1.Enabled = true;
                    te2.Enabled = true;
                }
                else
                {
                    t3.Enabled = true;
                    t4.Enabled = true;
                }
            }
            else
            {
                tw1.Enabled = false;
            }
        }

        private void tw2_TextChanged(object sender, EventArgs e)
        {
            if (!(tw1.Text == "X") && !(tw2.Text == "X") && !(tw2.Text == "/"))
            {
                int p1, p2, sum;
                p1 = Convert.ToInt32(tw1.Text);
                p2 = Convert.ToInt32(tw2.Text);
                sum = p1 + p2;
                if (sum == 10)
                {
                    tw2.Text = "/";
                    tw2.Enabled = false;
                    twp1.Text = "";
                    if (ju5.Visible == true)
                    {
                        te1.Enabled = true;
                        te2.Enabled = true;
                    }
                    else
                    {
                        t3.Enabled = true;
                        t4.Enabled = true;
                    }
                }
                if (sum > 10)
                {
                    MessageBox.Show("La suma no puede ser mayor a 10");
                    tw1.Enabled = true;
                    tw1.Text = "";
                    tw2.Text = "";
                }
                else
                {
                    if (!(tw2.Text == "/"))
                    {
                        twp1.Text = Convert.ToString(sum);
                        pun4.Text = Convert.ToString(sum);
                        tw2.Enabled = false;
                        if (ju5.Visible == true)
                        {
                            te1.Enabled = true;
                            te2.Enabled = true;
                        }
                        else
                        {
                            t3.Enabled = true;
                            t4.Enabled = true;
                        }
                    }
                    else
                    {
                        twp1.Text = "";
                    }
                }
            }
        }

        private void tw3_TextChanged(object sender, EventArgs e)
        {
            int p, sum;
            if (tw3.Text == "X")
            {
                tw4.Text = "X";
                tw3.Enabled = false;
                tw4.Enabled = false;
                if (ju5.Visible == true)
                {
                    te3.Enabled = true;
                    te4.Enabled = true;
                }
                else
                {
                    t5.Enabled = true;
                    t6.Enabled = true;
                }
            }
            else
            {
                tw3.Enabled = false;
                if (ju5.Enabled == true)
                {
                    te5.Enabled = false;
                }
                else
                {
                    t5.Enabled = true;
                }
            }
            if (tw2.Text == "/" && tw3.Text == "X")
            {
                sum = 20;
                twp1.Text = Convert.ToString(sum);
                pun4.Text = Convert.ToString(sum);
            }
            else if (tw2.Text == "/")
            {
                p = Convert.ToInt32(tw3.Text);
                sum = 10 + p;
                twp1.Text = Convert.ToString(sum);
                pun4.Text = Convert.ToString(sum);
                tw4.Enabled = true;
            }
        }

        private void tw4_TextChanged(object sender, EventArgs e)
        {
            if (!(tw3.Text == "X") && !(tw4.Text == "X") && !(tw4.Text == "/"))
            {
                int p1, p2, p3, sum, sumt;
                p1 = Convert.ToInt32(tw3.Text);
                p2 = Convert.ToInt32(tw4.Text);
                sum = p1 + p2;
                if (sum == 10)
                {
                    tw4.Text = "/";
                    tw4.Enabled = false;
                    tw3.Enabled = false;
                    twp2.Text = "";
                    if (ju5.Visible == true)
                    {
                        te3.Enabled = true;
                        te4.Enabled = true;
                    }
                    else
                    {
                        t5.Enabled = true;
                        t6.Enabled = true;
                    }
                }
                if (sum > 10)
                {
                    MessageBox.Show("La suma no puede ser mayor a 10");
                    tw3.Enabled = true;
                    tw3.Text = "";
                    tw4.Text = "";
                }
                if (tw2.Text == "X" && !(tw4.Text == "X"))
                {
                    int sumq;
                    sumt = 10 + sum;
                    twp1.Text = Convert.ToString(sumt);
                    sumq = Convert.ToInt32(twp1.Text) + sum;
                    if (sum == 10)
                    {
                        twp2.Text = "";
                        pun4.Text = twp1.Text;
                    }
                    else
                    {
                        twp2.Text = Convert.ToString(sumq);
                        pun4.Text = Convert.ToString(sumq);
                    }
                    tw4.Enabled = false;
                    if (ju5.Visible == true)
                    {
                        te3.Enabled = true;
                        te4.Enabled = true;
                    }
                    else
                    {
                        t5.Enabled = true;
                        t6.Enabled = true;
                    }
                }
                else
                {
                    if (!(tw4.Text == "/"))
                    {
                        p3 = Convert.ToInt32(twp1.Text);
                        sumt = p3 + sum;
                        twp2.Text = Convert.ToString(sumt);
                        pun4.Text = Convert.ToString(sumt);
                        tw4.Enabled = false;
                        if (ju5.Visible == true)
                        {
                            te3.Enabled = true;
                            te4.Enabled = true;
                        }
                        else
                        {
                            t5.Enabled = true;
                            t6.Enabled = true;
                        }
                    }
                    else
                    {
                        twp2.Text = "";
                    }
                }
            }
        }

        private void tw5_TextChanged(object sender, EventArgs e)
        {
            if (tw5.Text == "X")
            {
                tw6.Text = "X";
                tw5.Enabled = false;
                tw6.Enabled = false;
                if (ju5.Visible == true)
                {
                    te5.Enabled = true;
                    te6.Enabled = true;
                }
                else
                {
                    t7.Enabled = true;
                    t8.Enabled = true;
                }
            }
            else
            {
                tw5.Enabled = false;
            }
            if (tw4.Text == "/" && tw5.Text == "X")
            {
                int sum, sum2, p;
                sum = 20;
                p = Convert.ToInt32(twp1.Text);
                sum2 = sum + p;
                twp2.Text = Convert.ToString(sum2);
                pun4.Text = Convert.ToString(sum2);
            }
            else if (tw4.Text == "/")
            {
                int p, p2, sum;
                p = Convert.ToInt32(tw5.Text);
                p2 = Convert.ToInt32(twp1.Text);
                sum = p2 + 10 + p;
                twp2.Text = Convert.ToString(sum);
                pun4.Text = Convert.ToString(sum);
            }
            if (tw1.Text == "X" && tw3.Text == "X" && !(tw5.Text == "X"))
            {
                int p, sum;
                p = Convert.ToInt32(tw5.Text);
                sum = 20 + p;
                twp1.Text = Convert.ToString(sum);
                pun4.Text = Convert.ToString(sum);
            }
            else if (tw1.Text == "X" && tw3.Text == "X" && tw5.Text == "X")
            {
                int sum;
                sum = 30;
                twp1.Text = Convert.ToString(sum);
                pun4.Text = Convert.ToString(sum);
            }
        }

        private void tw6_TextChanged(object sender, EventArgs e)
        {
            if (!(tw5.Text == "X") && !(tw6.Text == "X") && !(tw6.Text == "/"))
            {
                int p1, p2, p3, sum, sumt;
                p1 = Convert.ToInt32(tw5.Text);
                p2 = Convert.ToInt32(tw6.Text);
                sum = p1 + p2;
                if (sum == 10)
                {
                    tw6.Text = "/";
                    tw6.Enabled = false;
                    tw5.Enabled = false;
                    twp3.Text = "";
                    if (ju5.Visible == true)
                    {
                        te5.Enabled = true;
                        te6.Enabled = true;
                    }
                    else
                    {
                        t7.Enabled = true;
                        t8.Enabled = true;
                    }
                }
                if (sum > 10)
                {
                    MessageBox.Show("La suma no puede ser mayor a 10");
                    tw5.Enabled = true;
                    tw5.Text = "";
                    tw6.Text = "";
                }
                if (tw4.Text == "X")
                {
                    int sum1, p, t, sum2;
                    p = Convert.ToInt32(twp1.Text);
                    sum1 = 10 + sum + p;
                    twp2.Text = Convert.ToString(sum1);
                    pun4.Text = Convert.ToString(sum1);
                    tw6.Enabled = false;


                    t = Convert.ToInt32(twp2.Text);
                    sum2 = t + sum;
                    if (sum == 10)
                    {
                        twp3.Text = "";
                        pun4.Text = twp2.Text;
                    }
                    else
                    {
                        twp3.Text = Convert.ToString(sum2);
                        pun4.Text = Convert.ToString(sum2);
                    }
                }
                else
                {
                    if (!(tw6.Text == "/"))
                    {
                        p3 = Convert.ToInt32(twp2.Text);
                        sumt = p3 + sum;
                        twp3.Text = Convert.ToString(sumt);
                        pun4.Text = Convert.ToString(sumt);
                        tw6.Enabled = false;
                        if (ju5.Visible == true)
                        {
                            te5.Enabled = true;
                            te6.Enabled = true;
                        }
                        else
                        {
                            t7.Enabled = true;
                            t8.Enabled = true;
                        }
                    }
                    else
                    {
                        twp3.Text = "";
                    }
                }
            }
        }

        private void tw7_TextChanged(object sender, EventArgs e)
        {
            if (tw7.Text == "X")
            {
                tw8.Text = "X";
                tw7.Enabled = false;
                tw8.Enabled = false;
                if (ju5.Visible == true)
                {
                    te7.Enabled = true;
                    te8.Enabled = true;
                }
                else
                {
                    t9.Enabled = true;
                    t10.Enabled = true;
                }

            }
            else
            {
                tw7.Enabled = false;
                if (ju5.Enabled == true)
                {
                    te9.Enabled = false;
                }
                else
                {
                    t9.Enabled = true;
                }
            }
            if (tw6.Text == "/" && tw7.Text == "X")
            {
                int sum, sum2, p;
                sum = 20;
                p = Convert.ToInt32(twp2.Text);
                sum2 = sum + p;
                twp3.Text = Convert.ToString(sum2);
                pun4.Text = Convert.ToString(sum2);
            }
            else if (tw6.Text == "/")
            {
                int p, p2, sum;
                p = Convert.ToInt32(tw7.Text);
                p2 = Convert.ToInt32(twp2.Text);
                sum = p2 + 10 + p;
                twp3.Text = Convert.ToString(sum);
                pun4.Text = Convert.ToString(sum);
            }
            if (tw3.Text == "X" && tw5.Text == "X" && !(tw7.Text == "X"))
            {
                int p, c, sum;
                p = Convert.ToInt32(tw7.Text);
                c = Convert.ToInt32(twp1.Text);
                sum = 20 + p + c;
                twp2.Text = Convert.ToString(sum);
                pun4.Text = Convert.ToString(sum);
            }
            else if (tw3.Text == "X" && tw5.Text == "X" && tw7.Text == "X")
            {
                int sum, p;
                p = Convert.ToInt32(twp1.Text);
                sum = 30 + p;
                twp2.Text = Convert.ToString(sum);
                pun4.Text = Convert.ToString(sum);
            }
        }

        private void tw8_TextChanged(object sender, EventArgs e)
        {
            if (!(tw7.Text == "X") && !(tw8.Text == "X") && !(tw8.Text == "/"))
            {
                int p1, p2, p3, sum, sumt;
                p1 = Convert.ToInt32(tw7.Text);
                p2 = Convert.ToInt32(tw8.Text);
                sum = p1 + p2;
                if (sum == 10)
                {
                    tw8.Text = "/";
                    tw8.Enabled = false;
                    tw7.Enabled = false;
                    twp4.Text = "";
                    if (ju5.Visible == true)
                    {
                        te7.Enabled = true;
                        te8.Enabled = true;
                    }
                    else
                    {
                        t9.Enabled = true;
                        t10.Enabled = true;
                    }
                }
                if (sum > 10)
                {
                    MessageBox.Show("La suma no puede ser mayor a 10");
                    tw7.Enabled = true;
                    tw7.Text = "";
                    tw8.Text = "";
                }
                if (tw6.Text == "X")
                {
                    int sum1, p, t, sum2;
                    p = Convert.ToInt32(twp2.Text);
                    sum1 = 10 + sum + p;
                    twp3.Text = Convert.ToString(sum1);
                    pun4.Text = Convert.ToString(sum1);
                    tw8.Enabled = false;
                    t = Convert.ToInt32(twp3.Text);
                    sum2 = t + sum;
                    if (sum == 10)
                    {
                        twp4.Text = "";
                        pun4.Text = twp3.Text;
                    }
                    else
                    {
                        twp4.Text = Convert.ToString(sum2);
                        pun4.Text = Convert.ToString(sum2);
                    }
                }
                else
                {
                    if (!(tw8.Text == "/"))
                    {
                        p3 = Convert.ToInt32(twp3.Text);
                        sumt = p3 + sum;
                        twp4.Text = Convert.ToString(sumt);
                        pun4.Text = Convert.ToString(sumt);
                        tw8.Enabled = false;
                        if (ju5.Visible == true)
                        {
                            te7.Enabled = true;
                            te8.Enabled = true;
                        }
                        else
                        {
                            t9.Enabled = true;
                            t10.Enabled = true;
                        }
                    }
                    else
                    {
                        twp4.Text = "";
                    }
                }
            }
        
        }

        private void tw9_TextChanged(object sender, EventArgs e)
        {
            if (tw9.Text == "X")
            {
                tw10.Text = "X";
                tw9.Enabled = false;
                tw10.Enabled = false;
                if (ju5.Visible == true)
                {
                    te9.Enabled = true;
                    te10.Enabled = true;
                }
                else
                {
                    t11.Enabled = true;
                    t12.Enabled = true;
                }

            }
            else
            {
                tw9.Enabled = false;
            }
            if (tw8.Text == "/" && tw9.Text == "X")
            {
                int sum, sum2, p;
                sum = 20;
                p = Convert.ToInt32(twp3.Text);
                sum2 = sum + p;
                twp4.Text = Convert.ToString(sum2);
                pun4.Text = Convert.ToString(sum2);
            }
            else if (tw8.Text == "/")
            {
                int p, p2, sum;
                p = Convert.ToInt32(tw9.Text);
                p2 = Convert.ToInt32(twp3.Text);
                sum = p2 + 10 + p;
                twp4.Text = Convert.ToString(sum);
                pun4.Text = Convert.ToString(sum);
            }
            if (tw5.Text == "X" && tw7.Text == "X" && !(tw9.Text == "X"))
            {
                int p, c, sum;
                p = Convert.ToInt32(tw9.Text);
                c = Convert.ToInt32(twp2.Text);
                sum = 20 + p + c;
                twp3.Text = Convert.ToString(sum);
                pun4.Text = Convert.ToString(sum);
            }
            else if (tw5.Text == "X" && tw7.Text == "X" && tw9.Text == "X")
            {
                int sum, p;
                p = Convert.ToInt32(twp2.Text);
                sum = 30 + p;
                twp3.Text = Convert.ToString(sum);
                pun4.Text = Convert.ToString(sum);
            }
        }

        private void tw10_TextChanged(object sender, EventArgs e)
        {
            if (!(tw9.Text == "X") && !(tw10.Text == "X") && !(tw10.Text == "/"))
            {
                int p1, p2, p3, sum, sumt;
                p1 = Convert.ToInt32(tw9.Text);
                p2 = Convert.ToInt32(tw10.Text);
                sum = p1 + p2;
                if (sum == 10)
                {
                    tw10.Text = "/";
                    tw10.Enabled = false;
                    tw9.Enabled = false;
                    twp5.Text = "";
                    if (ju5.Visible == true)
                    {
                        te9.Enabled = true;
                        te10.Enabled = true;
                    }
                    else
                    {
                        t11.Enabled = true;
                        t12.Enabled = true;
                    }
                }
                if (sum > 10)
                {
                    MessageBox.Show("La suma no puede ser mayor a 10");
                    tw9.Enabled = true;
                    tw9.Text = "";
                    tw10.Text = "";
                }
                if (tw8.Text == "X")
                {
                    int sum1, p, t, sum2;
                    p = Convert.ToInt32(twp3.Text);
                    sum1 = 10 + sum + p;
                    twp4.Text = Convert.ToString(sum1);
                    pun4.Text = Convert.ToString(sum1);
                    tw10.Enabled = false;
                    t = Convert.ToInt32(twp4.Text);
                    sum2 = t + sum;
                    if (sum == 10)
                    {
                        twp5.Text = "";
                        pun4.Text = twp4.Text;
                    }
                    else
                    {
                        twp5.Text = Convert.ToString(sum2);
                        pun4.Text = Convert.ToString(sum2);
                    }
                }
                else
                {
                    if (!(tw10.Text == "/"))
                    {
                        p3 = Convert.ToInt32(twp4.Text);
                        sumt = p3 + sum;
                        twp5.Text = Convert.ToString(sumt);
                        pun4.Text = Convert.ToString(sumt);
                        tw10.Enabled = false;
                        if (ju5.Visible == true)
                        {
                            te9.Enabled = true;
                            te10.Enabled = true;
                        }
                        else
                        {
                            t11.Enabled = true;
                            t12.Enabled = true;
                        }
                    }
                    else
                    {
                        twp5.Text = "";
                    }
                }
            }
        }

        private void tw11_TextChanged(object sender, EventArgs e)
        {
            if (tw11.Text == "X")
            {
                tw12.Text = "X";
                tw11.Enabled = false;
                tw12.Enabled = false;
                if (ju5.Visible == true)
                {
                    te11.Enabled = true;
                    te12.Enabled = true;
                }
                else
                {
                    t13.Enabled = true;
                    t14.Enabled = true;
                }
            }
            else
            {
                tw11.Enabled = false;
            }
            if (tw10.Text == "/" && tw11.Text == "X")
            {
                int sum, sum2, p;
                sum = 20;
                p = Convert.ToInt32(twp4.Text);
                sum2 = sum + p;
                twp5.Text = Convert.ToString(sum2);
                pun4.Text = Convert.ToString(sum2);
            }
            else if (tw10.Text == "/")
            {
                int p, p2, sum;
                p = Convert.ToInt32(tw11.Text);
                p2 = Convert.ToInt32(twp4.Text);
                sum = p2 + 10 + p;
                twp5.Text = Convert.ToString(sum);
                pun4.Text = Convert.ToString(sum);
            }
            if (tw7.Text == "X" && tw9.Text == "X" && !(tw11.Text == "X"))
            {
                int p, c, sum;
                p = Convert.ToInt32(tw11.Text);
                c = Convert.ToInt32(twp3.Text);
                sum = 20 + p + c;
                twp4.Text = Convert.ToString(sum);
                pun4.Text = Convert.ToString(sum);
            }
            else if (tw7.Text == "X" && tw9.Text == "X" && tw11.Text == "X")
            {
                int sum, p;
                p = Convert.ToInt32(twp3.Text);
                sum = 30 + p;
                twp4.Text = Convert.ToString(sum);
                pun4.Text = Convert.ToString(sum);
            }
        }

        private void tw12_TextChanged(object sender, EventArgs e)
        {
            if (!(tw11.Text == "X") && !(tw12.Text == "X") && !(tw12.Text == "/"))
            {
                int p1, p2, p3, sum, sumt;
                p1 = Convert.ToInt32(tw11.Text);
                p2 = Convert.ToInt32(tw12.Text);
                sum = p1 + p2;
                if (sum == 10)
                {
                    tw12.Text = "/";
                    tw12.Enabled = false;
                    tw11.Enabled = false;
                    twp6.Text = "";
                    if (ju5.Visible == true)
                    {
                        te11.Enabled = true;
                        te12.Enabled = true;
                    }
                    else
                    {
                        t13.Enabled = true;
                        t14.Enabled = true;
                    }
                }
                if (sum > 10)
                {
                    MessageBox.Show("La suma no puede ser mayor a 10");
                    tw11.Enabled = true;
                    tw11.Text = "";
                    tw12.Text = "";
                }
                if (tw10.Text == "X")
                {
                    int sum1, p, t, sum2;
                    p = Convert.ToInt32(twp4.Text);
                    sum1 = 10 + sum + p;
                    twp5.Text = Convert.ToString(sum1);
                    pun4.Text = Convert.ToString(sum1);
                    tw12.Enabled = false;
                    t = Convert.ToInt32(twp5.Text);
                    sum2 = t + sum;
                    if (sum == 10)
                    {
                        twp6.Text = "";
                        pun4.Text = twp5.Text;
                    }
                    else
                    {
                        twp6.Text = Convert.ToString(sum2);
                        pun4.Text = Convert.ToString(sum2);
                    }
                }
                else
                {
                    if (!(tw12.Text == "/"))
                    {
                        p3 = Convert.ToInt32(twp5.Text);
                        sumt = p3 + sum;
                        twp6.Text = Convert.ToString(sumt);
                        pun4.Text = Convert.ToString(sumt);
                        tw12.Enabled = false;
                        if (ju5.Visible == true)
                        {
                            te11.Enabled = true;
                            te12.Enabled = true;
                        }
                        else
                        {
                            t13.Enabled = true;
                            t14.Enabled = true;
                        }
                    }
                    else
                    {
                        twp6.Text = "";
                    }
                }
            }
        }

        private void tw13_TextChanged(object sender, EventArgs e)
        {
            if (tw13.Text == "X")
            {
                tw14.Text = "X";
                tw13.Enabled = false;
                tw14.Enabled = false;
                if (ju5.Visible == true)
                {
                    te13.Enabled = true;
                    te14.Enabled = true;
                }
                else
                {
                    t15.Enabled = true;
                    t16.Enabled = true;
                }
            }
            else
            {
                tw13.Enabled = false;
            }
            if (tw12.Text == "/" && tw13.Text == "X")
            {
                int sum, sum2, p;
                sum = 20;
                p = Convert.ToInt32(twp5.Text);
                sum2 = sum + p;
                twp6.Text = Convert.ToString(sum2);
                pun4.Text = Convert.ToString(sum2);
            }
            else if (tw12.Text == "/")
            {
                int p, p2, sum;
                p = Convert.ToInt32(tw13.Text);
                p2 = Convert.ToInt32(twp5.Text);
                sum = p2 + 10 + p;
                twp6.Text = Convert.ToString(sum);
                pun4.Text = Convert.ToString(sum);
            }
            if (tw9.Text == "X" && tw11.Text == "X" && !(tw13.Text == "X"))
            {
                int p, c, sum;
                p = Convert.ToInt32(tw13.Text);
                c = Convert.ToInt32(twp4.Text);
                sum = 20 + p + c;
                twp5.Text = Convert.ToString(sum);
                pun4.Text = Convert.ToString(sum);
            }
            else if (tw9.Text == "X" && tw11.Text == "X" && tw13.Text == "X")
            {
                int sum, p;
                p = Convert.ToInt32(twp4.Text);
                sum = 30 + p;
                twp5.Text = Convert.ToString(sum);
                pun4.Text = Convert.ToString(sum);
            }
        }

        private void tw14_TextChanged(object sender, EventArgs e)
        {
            if (!(tw13.Text == "X") && !(tw14.Text == "X") && !(tw14.Text == "/"))
            {
                int p1, p2, p3, sum, sumt;
                p1 = Convert.ToInt32(tw13.Text);
                p2 = Convert.ToInt32(tw14.Text);
                sum = p1 + p2;
                if (sum == 10)
                {
                    tw14.Text = "/";
                    tw14.Enabled = false;
                    tw13.Enabled = false;
                    twp7.Text = "";
                    if (ju5.Visible == true)
                    {
                        te13.Enabled = true;
                        te14.Enabled = true;
                    }
                    else
                    {
                        t15.Enabled = true;
                        t16.Enabled = true;
                    }
                }
                if (sum > 10)
                {
                    MessageBox.Show("La suma no puede ser mayor a 10");
                    tw13.Enabled = true;
                    tw13.Text = "";
                    tw14.Text = "";
                }
                if (tw12.Text == "X")
                {
                    int sum1, p, t, sum2;
                    p = Convert.ToInt32(twp5.Text);
                    sum1 = 10 + sum + p;
                    twp6.Text = Convert.ToString(sum1);
                    pun4.Text = Convert.ToString(sum1);
                    tw14.Enabled = false;
                    if (ju5.Visible == true)
                    {
                        te16.Enabled = false;
                    }
                    else
                    {
                        t16.Enabled = true;
                    }
                    t = Convert.ToInt32(twp6.Text);
                    sum2 = t + sum;
                    if (sum == 10)
                    {
                        twp7.Text = "";
                        pun4.Text = twp6.Text;
                    }
                    else
                    {
                        twp7.Text = Convert.ToString(sum2);
                        pun4.Text = Convert.ToString(sum2);
                    }
                }
                else
                {
                    if (!(tw14.Text == "/"))
                    {
                        p3 = Convert.ToInt32(twp6.Text);
                        sumt = p3 + sum;
                        twp7.Text = Convert.ToString(sumt);
                        pun4.Text = Convert.ToString(sumt);
                        tw14.Enabled = false;
                        if (ju5.Visible == true)
                        {
                            te13.Enabled = true;
                            te14.Enabled = true;
                        }
                        else
                        {
                            t15.Enabled = true;
                            t16.Enabled = true;
                        }
                    }
                    else
                    {
                        twp7.Text = "";
                    }
                }
            }
        }

        private void tw15_TextChanged(object sender, EventArgs e)
        {
            if (tw15.Text == "X")
            {
                tw16.Text = "X";
                tw15.Enabled = false;
                tw16.Enabled = false;
                if (ju5.Visible == true)
                {
                    te15.Enabled = true;
                    te16.Enabled = true;
                }
                else
                {
                    t17.Enabled = true;
                    t18.Enabled = true;
                }
            }
            else
            {
                tw15.Enabled = false;
            }
            if (tw14.Text == "/" && tw15.Text == "X")
            {
                int sum, sum2, p;
                sum = 20;
                p = Convert.ToInt32(twp6.Text);
                sum2 = sum + p;
                twp7.Text = Convert.ToString(sum2);
                pun4.Text = Convert.ToString(sum2);
            }
            else if (tw14.Text == "/")
            {
                int p, p2, sum;
                p = Convert.ToInt32(tw15.Text);
                p2 = Convert.ToInt32(twp6.Text);
                sum = p2 + 10 + p;
                twp7.Text = Convert.ToString(sum);
                pun4.Text = Convert.ToString(sum);
            }
            if (tw11.Text == "X" && tw13.Text == "X" && !(tw15.Text == "X"))
            {
                int p, c, sum;
                p = Convert.ToInt32(tw15.Text);
                c = Convert.ToInt32(twp5.Text);
                sum = 20 + p + c;
                twp6.Text = Convert.ToString(sum);
                pun4.Text = Convert.ToString(sum);
            }
            else if (tw11.Text == "X" && tw13.Text == "X" && tw15.Text == "X")
            {
                int sum, p;
                p = Convert.ToInt32(twp5.Text);
                sum = 30 + p;
                twp6.Text = Convert.ToString(sum);
                pun4.Text = Convert.ToString(sum);
            }
        }

        private void tw16_TextChanged(object sender, EventArgs e)
        {
            if (!(tw15.Text == "X") && !(tw16.Text == "X") && !(tw16.Text == "/"))
            {
                int p1, p2, p3, sum, sumt;
                p1 = Convert.ToInt32(tw15.Text);
                p2 = Convert.ToInt32(tw16.Text);
                sum = p1 + p2;
                if (sum == 10)
                {
                    tw16.Text = "/";
                    tw16.Enabled = false;
                    tw15.Enabled = false;
                    twp8.Text = "";
                    if (ju5.Visible == true)
                    {
                        te15.Enabled = true;
                        te16.Enabled = true;
                    }
                    else
                    {
                        t17.Enabled = true;
                        t18.Enabled = true;
                    }
                }
                if (sum > 10)
                {
                    MessageBox.Show("La suma no puede ser mayor a 10");
                    tw15.Enabled = true;
                    tw15.Text = "";
                    tw16.Text = "";
                }
                if (tw14.Text == "X")
                {
                    int sum1, p, t, sum2;
                    p = Convert.ToInt32(twp6.Text);
                    sum1 = 10 + sum + p;
                    twp7.Text = Convert.ToString(sum1);
                    pun4.Text = Convert.ToString(sum1);
                    tw16.Enabled = false;
                    if (ju5.Visible == true)
                    {
                        te18.Enabled = false;
                    }
                    else
                    {
                        t18.Enabled = true;
                    }
                    t = Convert.ToInt32(twp7.Text);
                    sum2 = t + sum;
                    if (sum == 10)
                    {
                        twp8.Text = "";
                        pun4.Text = twp7.Text;
                    }
                    else
                    {
                        twp8.Text = Convert.ToString(sum2);
                        pun4.Text = Convert.ToString(sum2);
                    }
                }
                else
                {
                    if (!(tw16.Text == "/"))
                    {
                        p3 = Convert.ToInt32(twp7.Text);
                        sumt = p3 + sum;
                        twp8.Text = Convert.ToString(sumt);
                        pun4.Text = Convert.ToString(sumt);
                        tw16.Enabled = false;
                        if (ju5.Visible == true)
                        {
                            te15.Enabled = true;
                            te16.Enabled = true;
                        }
                        else
                        {
                            t17.Enabled = true;
                            t18.Enabled = true;
                        }
                    }
                    else
                    {
                        twp8.Text = "";
                    }
                }
            }
        }

        private void tw17_TextChanged(object sender, EventArgs e)
        {
            if (tw17.Text == "X")
            {
                tw18.Text = "X";
                tw17.Enabled = false;
                tw18.Enabled = false;
                if (ju5.Visible == true)
                {
                    te17.Enabled = true;
                    te18.Enabled = true;
                }
                else
                {
                    t19.Enabled = true;
                    t20.Enabled = true;
                }
            }
            else
            {
                tw17.Enabled = false;
                if (ju5.Enabled == true)
                {
                    te19.Enabled = false;
                }
                else
                {
                    t19.Enabled = true;
                }
            }
            if (tw16.Text == "/" && tw17.Text == "X")
            {
                int sum, sum2, p;
                sum = 20;
                p = Convert.ToInt32(twp7.Text);
                sum2 = sum + p;
                twp8.Text = Convert.ToString(sum2);
                pun4.Text = Convert.ToString(sum2);
            }
            else if (tw16.Text == "/")
            {
                int p, p2, sum;
                p = Convert.ToInt32(tw17.Text);
                p2 = Convert.ToInt32(twp7.Text);
                sum = p2 + 10 + p;
                twp8.Text = Convert.ToString(sum);
                pun4.Text = Convert.ToString(sum);
            }
            if (tw13.Text == "X" && tw15.Text == "X" && !(tw17.Text == "X"))
            {
                int p, c, sum;
                p = Convert.ToInt32(tw17.Text);
                c = Convert.ToInt32(twp6.Text);
                sum = 20 + p + c;
                twp7.Text = Convert.ToString(sum);
                pun4.Text = Convert.ToString(sum);
            }
            else if (tw13.Text == "X" && tw15.Text == "X" && tw17.Text == "X")
            {
                int sum, p;
                p = Convert.ToInt32(twp6.Text);
                sum = 30 + p;
                twp7.Text = Convert.ToString(sum);
                pun4.Text = Convert.ToString(sum);
            }
        }

        private void tw18_TextChanged(object sender, EventArgs e)
        {
            if (!(tw17.Text == "X") && !(tw18.Text == "X") && !(tw18.Text == "/"))
            {
                int p1, p2, p3, sum, sumt;
                p1 = Convert.ToInt32(tw17.Text);
                p2 = Convert.ToInt32(tw18.Text);
                sum = p1 + p2;
                if (sum == 10)
                {
                    tw18.Text = "/";
                    tw18.Enabled = false;
                    tw17.Enabled = false;
                    twp9.Text = "";
                    if (ju5.Visible == true)
                    {
                        te17.Enabled = true;
                        te18.Enabled = true;
                    }
                    else
                    {
                        t19.Enabled = true;
                        t20.Enabled = true;
                    }
                }
                if (sum > 10)
                {
                    MessageBox.Show("La suma no puede ser mayor a 10");
                    tw17.Enabled = true;
                    tw17.Text = "";
                    tw18.Text = "";
                }
                if (tw16.Text == "X")
                {
                    int sum1, p, t, sum2;
                    p = Convert.ToInt32(twp7.Text);
                    sum1 = 10 + sum + p;
                    twp8.Text = Convert.ToString(sum1);
                    pun4.Text = Convert.ToString(sum1);
                    tw18.Enabled = false;
                    if (ju5.Visible == true)
                    {
                        tw20.Enabled = false;
                    }
                    else
                    {
                        t20.Enabled = true;
                    }
                    t = Convert.ToInt32(twp8.Text);
                    sum2 = t + sum;
                    if (sum == 10)
                    {
                        twp9.Text = "";
                        pun4.Text = twp8.Text;
                    }
                    else
                    {
                        twp9.Text = Convert.ToString(sum2);
                        pun4.Text = Convert.ToString(sum2);
                    }
                }
                else
                {
                    if (!(tw18.Text == "/"))
                    {
                        p3 = Convert.ToInt32(twp8.Text);
                        sumt = p3 + sum;
                        twp9.Text = Convert.ToString(sumt);
                        pun4.Text = Convert.ToString(sumt);
                        tw18.Enabled = false;
                        if (ju5.Visible == true)
                        {
                            te17.Enabled = true;
                            te18.Enabled = true;
                        }
                        else
                        {
                            t19.Enabled = true;
                            t20.Enabled = true;
                        }
                    }
                    else
                    {
                        twp9.Text = "";
                    }
                }
            }
        }

        private void tw19_TextChanged(object sender, EventArgs e)
        {
            if (tw19.Text == "X")
            {
                tw21.Enabled = true;
                tw19.Enabled = false;
            }
            else
            {
                tw19.Enabled = false;
                tw21.Enabled = true;
            }
            if (tw18.Text == "/" && tw19.Text == "X")
            {
                int sum, sum2, p;
                sum = 20;
                p = Convert.ToInt32(twp8.Text);
                sum2 = sum + p;
                twp9.Text = Convert.ToString(sum2);
                pun4.Text = Convert.ToString(sum2);
                tw20.Enabled = true;
            }
            else if (tw18.Text == "/")
            {
                int p, p2, sum;
                p = Convert.ToInt32(tw19.Text);
                p2 = Convert.ToInt32(twp8.Text);
                sum = p2 + 10 + p;
                twp9.Text = Convert.ToString(sum);
                pun4.Text = Convert.ToString(sum);
            }
            if (tw15.Text == "X" && tw17.Text == "X" && !(tw19.Text == "X"))
            {
                int p, c, sum;
                p = Convert.ToInt32(tw19.Text);
                c = Convert.ToInt32(twp7.Text);
                sum = 20 + p + c;
                twp8.Text = Convert.ToString(sum);
                pun4.Text = Convert.ToString(sum);
            }
            if (tw15.Text == "X" && tw17.Text == "X" && tw19.Text == "X")
            {
                int sum, p;
                p = Convert.ToInt32(twp7.Text);
                sum = 30 + p;
                twp8.Text = Convert.ToString(sum);
                pun4.Text = Convert.ToString(sum);
            }
        }

        private void tw20_TextChanged(object sender, EventArgs e)
        {
            if (tw20.Text == "X")
            {
                tw21.Enabled = true;
                tw20.Enabled = false;
                twp10.Text = "";
            }
            else if (tw20.Text == "/")
            {
                tw20.Enabled = false;
                tw21.Enabled = true;
            }
            else
            {
                if (!(tw19.Text == "X"))
                {
                    int p1, p2, p3, sum, sumt;
                    p1 = Convert.ToInt32(tw19.Text);
                    p2 = Convert.ToInt32(tw20.Text);
                    sum = p1 + p2;
                    if (sum == 10)
                    {
                        tw20.Text = "/";
                        tw20.Enabled = false;
                        twp10.Text = "";
                        tw21.Enabled = true;
                    }
                    if (sum > 10)
                    {
                        MessageBox.Show("La suma no puede ser mayor a 10");
                        tw17.Enabled = true;
                        tw17.Text = "";
                        tw18.Text = "";
                    }
                    if (tw18.Text == "X")
                    {
                        int sum1, p, t, sum2;
                        p = Convert.ToInt32(twp8.Text);
                        sum1 = 10 + sum + p;
                        twp9.Text = Convert.ToString(sum1);
                        pun4.Text = Convert.ToString(sum1);
                        tw20.Enabled = false;
                        t = Convert.ToInt32(twp9.Text);
                        sum2 = t + sum;
                        if (sum == 10)
                        {
                            twp10.Text = "";
                            pun4.Text = twp9.Text;
                        }
                        else
                        {
                            twp10.Text = Convert.ToString(sum2);
                            pun4.Text = Convert.ToString(sum2);
                            tw21.Enabled = false;
                            if (ju5.Visible == true)
                            {
                                te19.Enabled = true;
                                te20.Enabled = true;
                            }
                            else
                            {
                                MessageBox.Show("Fin del juego");
                            }

                        }
                    }
                    else
                    {
                        if (!(tw20.Text == "/"))
                        {
                            tw21.Enabled = false;
                            p3 = Convert.ToInt32(twp9.Text);
                            sumt = p3 + sum;
                            twp10.Text = Convert.ToString(sumt);
                            pun4.Text = Convert.ToString(sumt);
                            tw19.Enabled = false;
                            tw20.Enabled = false;

                            if (ju5.Visible == true)
                            {
                                te19.Enabled = true;
                                te20.Enabled = true;
                            }
                            else
                            {
                                MessageBox.Show("Fin del juego");
                            }
                        }
                        else
                        {
                            twp10.Text = "";
                            tw21.Enabled = true;
                        }
                    }
                }
                else
                {
                    tw20.Enabled = false;
                }
            }
            if (tw17.Text == "X" && tw19.Text == "X" && tw20.Text == "X")
            {
                int sum, p;
                p = Convert.ToInt32(twp8.Text);
                sum = 30 + p;
                twp9.Text = Convert.ToString(sum);
                pun4.Text = Convert.ToString(sum);
            }
            else if (tw17.Text == "X" && tw19.Text == "X" && !(tw20.Text == "X"))
            {
                int sum, p, y;
                y = Convert.ToInt32(tw20.Text);
                p = Convert.ToInt32(twp8.Text);
                sum = 20 + p + y;
                twp9.Text = Convert.ToString(sum);
                pun4.Text = Convert.ToString(sum);
            }
        }

        private void tw21_TextChanged(object sender, EventArgs e)
        {
            int p, sum, pp;
            if (tw19.Text == "X" && tw20.Text == "X" && tw21.Text == "X")
            {
                p = Convert.ToInt32(twp9.Text);
                sum = p + 30;
                twp10.Text = Convert.ToString(sum);
                pun4.Text = Convert.ToString(sum);
                tw21.Enabled = false;
                if (ju5.Visible == true)
                {
                    te19.Enabled = true;
                    te20.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Fin del juego");
                }
            }
            if (tw20.Text == "/")
            {
                if (tw21.Text == "X")
                {
                    p = Convert.ToInt32(twp9.Text);
                    sum = p + 20;
                    twp10.Text = Convert.ToString(sum);
                    pun4.Text = Convert.ToString(sum);
                    tw21.Enabled = false;
                    if (ju5.Visible == true)
                    {
                        te19.Enabled = true;
                        te20.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Fin del juego");
                    }
                }
                else
                {
                    p = Convert.ToInt32(twp9.Text);
                    pp = Convert.ToInt32(tw21.Text);
                    sum = p + 10 + pp;
                    twp10.Text = Convert.ToString(sum);
                    pun4.Text = Convert.ToString(sum);
                    tw21.Enabled = false;
                    if (ju5.Visible == true)
                    {
                        te19.Enabled = true;
                        te20.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Fin del juego");
                    }
                }

            }
            if (tw19.Text == "X" && !(tw20.Text == "X"))
            {
                int c, p1, sump, sumpp, d;
                c = Convert.ToInt32(tw20.Text);
                p1 = Convert.ToInt32(tw21.Text);
                d = Convert.ToInt32(twp9.Text);
                sump = c + p1;
                if (sump > 10)
                {
                    MessageBox.Show("la suma no puede ser mayor a 10");
                    tw20.Enabled = true;
                    tw20.Text = "";
                    tw21.Enabled = true;
                    tw21.Text = "";
                }
                else
                {
                    sumpp = sump + 10 + d;
                    twp10.Text = Convert.ToString(sumpp);
                    pun4.Text = Convert.ToString(sumpp);
                    tw21.Enabled = false;
                    if (ju5.Visible == true)
                    {
                        te19.Enabled = true;
                        te20.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Fin del juego");
                    }
                }
            }
        }
        ///////
        private void te1_TextChanged(object sender, EventArgs e)
        {
            if (te1.Text == "X")
            {
                te2.Text = "X";
                te1.Enabled = false;
                te2.Enabled = false;
                if (ju6.Visible == true)
                {
                    tr1.Enabled = true;
                    tr2.Enabled = true;
                }
                else
                {
                    t3.Enabled = true;
                    t4.Enabled = true;
                }
            }
            else
            {
                te1.Enabled = false;
            }
        }

        private void te2_TextChanged(object sender, EventArgs e)
        {
            if (!(te1.Text == "X") && !(te2.Text == "X") && !(te2.Text == "/"))
            {
                int p1, p2, sum;
                p1 = Convert.ToInt32(te1.Text);
                p2 = Convert.ToInt32(te2.Text);
                sum = p1 + p2;
                if (sum == 10)
                {
                    te2.Text = "/";
                    te2.Enabled = false;
                    tep1.Text = "";
                    if (ju6.Visible == true)
                    {
                        tr1.Enabled = true;
                        tr2.Enabled = true;
                    }
                    else
                    {
                        t3.Enabled = true;
                        t4.Enabled = true;
                    }
                }
                if (sum > 10)
                {
                    MessageBox.Show("La suma no puede ser mayor a 10");
                    te1.Enabled = true;
                    te1.Text = "";
                    te2.Text = "";
                }
                else
                {
                    if (!(te2.Text == "/"))
                    {
                        tep1.Text = Convert.ToString(sum);
                        pun5.Text = Convert.ToString(sum);
                        te2.Enabled = false;
                        if (ju6.Visible == true)
                        {
                            tr1.Enabled = true;
                            tr2.Enabled = true;
                        }
                        else
                        {
                            t3.Enabled = true;
                            t4.Enabled = true;
                        }
                    }
                    else
                    {
                        tep1.Text = "";
                    }
                }
            }
        }

        private void te3_TextChanged(object sender, EventArgs e)
        {
            int p, sum;
            if (te3.Text == "X")
            {
                te4.Text = "X";
                te3.Enabled = false;
                te4.Enabled = false;
                if (ju6.Visible == true)
                {
                    tr3.Enabled = true;
                    tr4.Enabled = true;
                }
                else
                {
                    t5.Enabled = true;
                    t6.Enabled = true;
                }
            }
            else
            {
                te3.Enabled = false;
                if (ju6.Enabled == true)
                {
                    tr5.Enabled = false;
                }
                else
                {
                    t5.Enabled = true;
                    t6.Enabled = true;
                }
            }
            if (te2.Text == "/" && te3.Text == "X")
            {
                sum = 20;
                tep1.Text = Convert.ToString(sum);
                pun5.Text = Convert.ToString(sum);
            }
            else if (te2.Text == "/")
            {
                p = Convert.ToInt32(te3.Text);
                sum = 10 + p;
                tep1.Text = Convert.ToString(sum);
                pun5.Text = Convert.ToString(sum);
                te4.Enabled = true;
            }
        }

        private void te4_TextChanged(object sender, EventArgs e)
        {
            if (!(te3.Text == "X") && !(te4.Text == "X") && !(te4.Text == "/"))
            {
                int p1, p2, p3, sum, sumt;
                p1 = Convert.ToInt32(te3.Text);
                p2 = Convert.ToInt32(te4.Text);
                sum = p1 + p2;
                if (sum == 10)
                {
                    te4.Text = "/";
                    te4.Enabled = false;
                    te3.Enabled = false;
                    tep2.Text = "";
                    if (ju6.Visible == true)
                    {
                        tr3.Enabled = true;
                        tr4.Enabled = true;
                    }
                    else
                    {
                        t5.Enabled = true;
                        t6.Enabled = true;
                    }
                }
                if (sum > 10)
                {
                    MessageBox.Show("La suma no puede ser mayor a 10");
                    te3.Enabled = true;
                    te3.Text = "";
                    te4.Text = "";
                }
                if (te2.Text == "X" && !(te4.Text == "X"))
                {
                    int sumq;
                    sumt = 10 + sum;
                    tep1.Text = Convert.ToString(sumt);
                    sumq = Convert.ToInt32(tep1.Text) + sum;
                    if (sum == 10)
                    {
                        tep2.Text = "";
                        pun5.Text = tep1.Text;
                    }
                    else
                    {
                        tep2.Text = Convert.ToString(sumq);
                        pun5.Text = Convert.ToString(sumq);
                    }
                    te4.Enabled = false;
                    if (ju6.Visible == true)
                    {
                        tr3.Enabled = true;
                        tr4.Enabled = true;
                    }
                    else
                    {
                        t5.Enabled = true;
                        t6.Enabled = true;
                    }
                }
                else
                {
                    if (!(te4.Text == "/"))
                    {
                        p3 = Convert.ToInt32(tep1.Text);
                        sumt = p3 + sum;
                        tep2.Text = Convert.ToString(sumt);
                        pun5.Text = Convert.ToString(sumt);
                        te4.Enabled = false;
                        if (ju6.Visible == true)
                        {
                            tr3.Enabled = true;
                            tr4.Enabled = true;
                        }
                        else
                        {
                            t5.Enabled = true;
                            t6.Enabled = true;
                        }
                    }
                    else
                    {
                        tep2.Text = "";
                    }
                }
            }
        }

        private void te5_TextChanged(object sender, EventArgs e)
        {
            if (te5.Text == "X")
            {
                te6.Text = "X";
                te5.Enabled = false;
                te6.Enabled = false;
                if (ju6.Visible == true)
                {
                    tr5.Enabled = true;
                    tr6.Enabled = true;
                }
                else
                {
                    t7.Enabled = true;
                    t8.Enabled = true;
                }
            }
            else
            {
                te5.Enabled = false;
            }
            if (te4.Text == "/" && te5.Text == "X")
            {
                int sum, sum2, p;
                sum = 20;
                p = Convert.ToInt32(tep1.Text);
                sum2 = sum + p;
                tep2.Text = Convert.ToString(sum2);
                pun5.Text = Convert.ToString(sum2);
            }
            else if (te4.Text == "/")
            {
                int p, p2, sum;
                p = Convert.ToInt32(te5.Text);
                p2 = Convert.ToInt32(tep1.Text);
                sum = p2 + 10 + p;
                tep2.Text = Convert.ToString(sum);
                pun5.Text = Convert.ToString(sum);
            }
            if (te1.Text == "X" && te3.Text == "X" && !(te5.Text == "X"))
            {
                int p, sum;
                p = Convert.ToInt32(te5.Text);
                sum = 20 + p;
                tep1.Text = Convert.ToString(sum);
                pun5.Text = Convert.ToString(sum);
            }
            else if (te1.Text == "X" && te3.Text == "X" && te5.Text == "X")
            {
                int sum;
                sum = 30;
                tep1.Text = Convert.ToString(sum);
                pun5.Text = Convert.ToString(sum);
            }
        }

        private void te6_TextChanged(object sender, EventArgs e)
        {
            if (!(te5.Text == "X") && !(te6.Text == "X") && !(te6.Text == "/"))
            {
                int p1, p2, p3, sum, sumt;
                p1 = Convert.ToInt32(te5.Text);
                p2 = Convert.ToInt32(te6.Text);
                sum = p1 + p2;
                if (sum == 10)
                {
                    te6.Text = "/";
                    te6.Enabled = false;
                    te5.Enabled = false;
                    tep3.Text = "";
                    if (ju6.Visible == true)
                    {
                        tr5.Enabled = true;
                        tr6.Enabled = true;
                    }
                    else
                    {
                        t7.Enabled = true;
                        t8.Enabled = true;
                    }
                }
                if (sum > 10)
                {
                    MessageBox.Show("La suma no puede ser mayor a 10");
                    te5.Enabled = true;
                    te5.Text = "";
                    te6.Text = "";
                }
                if (te4.Text == "X")
                {
                    int sum1, p, t, sum2;
                    p = Convert.ToInt32(tep1.Text);
                    sum1 = 10 + sum + p;
                    tep2.Text = Convert.ToString(sum1);
                    pun5.Text = Convert.ToString(sum1);
                    te6.Enabled = false;


                    t = Convert.ToInt32(tep2.Text);
                    sum2 = t + sum;
                    if (sum == 10)
                    {
                        tep3.Text = "";
                        pun5.Text = tep2.Text;
                    }
                    else
                    {
                        tep3.Text = Convert.ToString(sum2);
                        pun5.Text = Convert.ToString(sum2);
                    }
                }
                else
                {
                    if (!(te6.Text == "/"))
                    {
                        p3 = Convert.ToInt32(tep2.Text);
                        sumt = p3 + sum;
                        tep3.Text = Convert.ToString(sumt);
                        pun5.Text = Convert.ToString(sumt);
                        te6.Enabled = false;
                        if (ju6.Visible == true)
                        {
                            tr5.Enabled = true;
                            tr6.Enabled = true;
                        }
                        else
                        {
                            t7.Enabled = true;
                            t8.Enabled = true;
                        }
                    }
                    else
                    {
                        tep3.Text = "";
                    }
                }
            }
        }

        private void te7_TextChanged(object sender, EventArgs e)
        {
            if (te7.Text == "X")
            {
                te8.Text = "X";
                te7.Enabled = false;
                te8.Enabled = false;
                if (ju6.Visible == true)
                {
                    tr7.Enabled = true;
                    tr8.Enabled = true;
                }
                else
                {
                    t9.Enabled = true;
                    t10.Enabled = true;
                }

            }
            else
            {
                te7.Enabled = false;
                if (ju6.Enabled == true)
                {
                    tr9.Enabled = false;
                }
                else
                {
                    t9.Enabled = true;
                }
            }
            if (te6.Text == "/" && te7.Text == "X")
            {
                int sum, sum2, p;
                sum = 20;
                p = Convert.ToInt32(tep2.Text);
                sum2 = sum + p;
                tep3.Text = Convert.ToString(sum2);
                pun5.Text = Convert.ToString(sum2);
            }
            else if (te6.Text == "/")
            {
                int p, p2, sum;
                p = Convert.ToInt32(te7.Text);
                p2 = Convert.ToInt32(tep2.Text);
                sum = p2 + 10 + p;
                tep3.Text = Convert.ToString(sum);
                pun5.Text = Convert.ToString(sum);
            }
            if (te3.Text == "X" && te5.Text == "X" && !(te7.Text == "X"))
            {
                int p, c, sum;
                p = Convert.ToInt32(te7.Text);
                c = Convert.ToInt32(tep1.Text);
                sum = 20 + p + c;
                tep2.Text = Convert.ToString(sum);
                pun5.Text = Convert.ToString(sum);
            }
            else if (te3.Text == "X" && te5.Text == "X" && te7.Text == "X")
            {
                int sum, p;
                p = Convert.ToInt32(tep1.Text);
                sum = 30 + p;
                tep2.Text = Convert.ToString(sum);
                pun5.Text = Convert.ToString(sum);
            }
        }

        private void te8_TextChanged(object sender, EventArgs e)
        {
            if (!(te7.Text == "X") && !(te8.Text == "X") && !(te8.Text == "/"))
            {
                int p1, p2, p3, sum, sumt;
                p1 = Convert.ToInt32(te7.Text);
                p2 = Convert.ToInt32(te8.Text);
                sum = p1 + p2;
                if (sum == 10)
                {
                    te8.Text = "/";
                    te8.Enabled = false;
                    te7.Enabled = false;
                    tep4.Text = "";
                    if (ju6.Visible == true)
                    {
                        tr7.Enabled = true;
                        tr8.Enabled = true;
                    }
                    else
                    {
                        t9.Enabled = true;
                        t10.Enabled = true;
                    }
                }
                if (sum > 10)
                {
                    MessageBox.Show("La suma no puede ser mayor a 10");
                    te7.Enabled = true;
                    te7.Text = "";
                    te8.Text = "";
                }
                if (te6.Text == "X")
                {
                    int sum1, p, t, sum2;
                    p = Convert.ToInt32(tep2.Text);
                    sum1 = 10 + sum + p;
                    tep3.Text = Convert.ToString(sum1);
                    pun5.Text = Convert.ToString(sum1);
                    te8.Enabled = false;
                    t = Convert.ToInt32(tep3.Text);
                    sum2 = t + sum;
                    if (sum == 10)
                    {
                        tep4.Text = "";
                        pun5.Text = tep3.Text;
                    }
                    else
                    {
                        tep4.Text = Convert.ToString(sum2);
                        pun5.Text = Convert.ToString(sum2);
                    }
                }
                else
                {
                    if (!(te8.Text == "/"))
                    {
                        p3 = Convert.ToInt32(tep3.Text);
                        sumt = p3 + sum;
                        tep4.Text = Convert.ToString(sumt);
                        pun5.Text = Convert.ToString(sumt);
                        te8.Enabled = false;
                        if (ju6.Visible == true)
                        {
                            tr7.Enabled = true;
                            tr8.Enabled = true;
                        }
                        else
                        {
                            t9.Enabled = true;
                            t10.Enabled = true;
                        }
                    }
                    else
                    {
                        tep4.Text = "";
                    }
                }
            }
        }

        private void te9_TextChanged(object sender, EventArgs e)
        {
            if (te9.Text == "X")
            {
                te10.Text = "X";
                te9.Enabled = false;
                te10.Enabled = false;
                if (ju6.Visible == true)
                {
                    tr9.Enabled = true;
                    tr10.Enabled = true;
                }
                else
                {
                    t11.Enabled = true;
                    t12.Enabled = true;
                }

            }
            else
            {
                te9.Enabled = false;
            }
            if (te8.Text == "/" && te9.Text == "X")
            {
                int sum, sum2, p;
                sum = 20;
                p = Convert.ToInt32(tep3.Text);
                sum2 = sum + p;
                tep4.Text = Convert.ToString(sum2);
                pun5.Text = Convert.ToString(sum2);
            }
            else if (te8.Text == "/")
            {
                int p, p2, sum;
                p = Convert.ToInt32(te9.Text);
                p2 = Convert.ToInt32(tep3.Text);
                sum = p2 + 10 + p;
                tep4.Text = Convert.ToString(sum);
                pun5.Text = Convert.ToString(sum);
            }
            if (te5.Text == "X" && te7.Text == "X" && !(te9.Text == "X"))
            {
                int p, c, sum;
                p = Convert.ToInt32(te9.Text);
                c = Convert.ToInt32(tep2.Text);
                sum = 20 + p + c;
                tep3.Text = Convert.ToString(sum);
                pun5.Text = Convert.ToString(sum);
            }
            else if (te5.Text == "X" && te7.Text == "X" && te9.Text == "X")
            {
                int sum, p;
                p = Convert.ToInt32(tep2.Text);
                sum = 30 + p;
                tep3.Text = Convert.ToString(sum);
                pun5.Text = Convert.ToString(sum);
            }
        }

        private void te10_TextChanged(object sender, EventArgs e)
        {
            if (!(te9.Text == "X") && !(te10.Text == "X") && !(te10.Text == "/"))
            {
                int p1, p2, p3, sum, sumt;
                p1 = Convert.ToInt32(te9.Text);
                p2 = Convert.ToInt32(te10.Text);
                sum = p1 + p2;
                if (sum == 10)
                {
                    te10.Text = "/";
                    te10.Enabled = false;
                    te9.Enabled = false;
                    tep5.Text = "";
                    if (ju6.Visible == true)
                    {
                        tr9.Enabled = true;
                        tr10.Enabled = true;
                    }
                    else
                    {
                        t11.Enabled = true;
                        t12.Enabled = true;
                    }
                }
                if (sum > 10)
                {
                    MessageBox.Show("La suma no puede ser mayor a 10");
                    te9.Enabled = true;
                    te9.Text = "";
                    te10.Text = "";
                }
                if (te8.Text == "X")
                {
                    int sum1, p, t, sum2;
                    p = Convert.ToInt32(tep3.Text);
                    sum1 = 10 + sum + p;
                    tep4.Text = Convert.ToString(sum1);
                    pun5.Text = Convert.ToString(sum1);
                    te10.Enabled = false;
                    t = Convert.ToInt32(tep4.Text);
                    sum2 = t + sum;
                    if (sum == 10)
                    {
                        tep5.Text = "";
                        pun5.Text = tep4.Text;
                    }
                    else
                    {
                        tep5.Text = Convert.ToString(sum2);
                        pun5.Text = Convert.ToString(sum2);
                    }
                }
                else
                {
                    if (!(te10.Text == "/"))
                    {
                        p3 = Convert.ToInt32(tep4.Text);
                        sumt = p3 + sum;
                        tep5.Text = Convert.ToString(sumt);
                        pun5.Text = Convert.ToString(sumt);
                        te10.Enabled = false;
                        if (ju6.Visible == true)
                        {
                            tr9.Enabled = true;
                            tr10.Enabled = true;
                        }
                        else
                        {
                            t11.Enabled = true;
                            t12.Enabled = true;
                        }
                    }
                    else
                    {
                        tep5.Text = "";
                    }
                }
            }
        }

        private void te11_TextChanged(object sender, EventArgs e)
        {
            if (te11.Text == "X")
            {
                te12.Text = "X";
                te11.Enabled = false;
                te12.Enabled = false;
                if (ju6.Visible == true)
                {
                    tr11.Enabled = true;
                    tr12.Enabled = true;
                }
                else
                {
                    t13.Enabled = true;
                    t14.Enabled = true;
                }
            }
            else
            {
                te11.Enabled = false;
            }
            if (te10.Text == "/" && te11.Text == "X")
            {
                int sum, sum2, p;
                sum = 20;
                p = Convert.ToInt32(tep4.Text);
                sum2 = sum + p;
                tep5.Text = Convert.ToString(sum2);
                pun5.Text = Convert.ToString(sum2);
            }
            else if (te10.Text == "/")
            {
                int p, p2, sum;
                p = Convert.ToInt32(te11.Text);
                p2 = Convert.ToInt32(tep4.Text);
                sum = p2 + 10 + p;
                tep5.Text = Convert.ToString(sum);
                pun5.Text = Convert.ToString(sum);
            }
            if (te7.Text == "X" && te9.Text == "X" && !(te11.Text == "X"))
            {
                int p, c, sum;
                p = Convert.ToInt32(te11.Text);
                c = Convert.ToInt32(tep3.Text);
                sum = 20 + p + c;
                tep4.Text = Convert.ToString(sum);
                pun5.Text = Convert.ToString(sum);
            }
            else if (te7.Text == "X" && te9.Text == "X" && te11.Text == "X")
            {
                int sum, p;
                p = Convert.ToInt32(tep3.Text);
                sum = 30 + p;
                tep4.Text = Convert.ToString(sum);
                pun5.Text = Convert.ToString(sum);
            }
        }

        private void te12_TextChanged(object sender, EventArgs e)
        {
            if (!(te11.Text == "X") && !(te12.Text == "X") && !(te12.Text == "/"))
            {
                int p1, p2, p3, sum, sumt;
                p1 = Convert.ToInt32(te11.Text);
                p2 = Convert.ToInt32(te12.Text);
                sum = p1 + p2;
                if (sum == 10)
                {
                    te12.Text = "/";
                    te12.Enabled = false;
                    te11.Enabled = false;
                    tep6.Text = "";
                    if (ju6.Visible == true)
                    {
                        tr11.Enabled = true;
                        tr12.Enabled = true;
                    }
                    else
                    {
                        t13.Enabled = true;
                        t14.Enabled = true;
                    }
                }
                if (sum > 10)
                {
                    MessageBox.Show("La suma no puede ser mayor a 10");
                    te11.Enabled = true;
                    te11.Text = "";
                    te12.Text = "";
                }
                if (te10.Text == "X")
                {
                    int sum1, p, t, sum2;
                    p = Convert.ToInt32(tep4.Text);
                    sum1 = 10 + sum + p;
                    tep5.Text = Convert.ToString(sum1);
                    pun5.Text = Convert.ToString(sum1);
                    te12.Enabled = false;
                    t = Convert.ToInt32(tep5.Text);
                    sum2 = t + sum;
                    if (sum == 10)
                    {
                        tep6.Text = "";
                        pun5.Text = tep5.Text;
                    }
                    else
                    {
                        tep6.Text = Convert.ToString(sum2);
                        pun5.Text = Convert.ToString(sum2);
                    }
                }
                else
                {
                    if (!(te12.Text == "/"))
                    {
                        p3 = Convert.ToInt32(tep5.Text);
                        sumt = p3 + sum;
                        tep6.Text = Convert.ToString(sumt);
                        pun5.Text = Convert.ToString(sumt);
                        te12.Enabled = false;
                        if (ju6.Visible == true)
                        {
                            tr11.Enabled = true;
                            tr12.Enabled = true;
                        }
                        else
                        {
                            t13.Enabled = true;
                            t14.Enabled = true;
                        }
                    }
                    else
                    {
                        tep6.Text = "";
                    }
                }
            }
        }

        private void te13_TextChanged(object sender, EventArgs e)
        {
            if (te13.Text == "X")
            {
                te14.Text = "X";
                te13.Enabled = false;
                te14.Enabled = false;
                if (ju6.Visible == true)
                {
                    tr13.Enabled = true;
                    tr14.Enabled = true;
                }
                else
                {
                    t15.Enabled = true;
                    t16.Enabled = true;
                }
            }
            else
            {
                te13.Enabled = false;
            }
            if (te12.Text == "/" && te13.Text == "X")
            {
                int sum, sum2, p;
                sum = 20;
                p = Convert.ToInt32(tep5.Text);
                sum2 = sum + p;
                tep6.Text = Convert.ToString(sum2);
                pun5.Text = Convert.ToString(sum2);
            }
            else if (te12.Text == "/")
            {
                int p, p2, sum;
                p = Convert.ToInt32(te13.Text);
                p2 = Convert.ToInt32(tep5.Text);
                sum = p2 + 10 + p;
                tep6.Text = Convert.ToString(sum);
                pun5.Text = Convert.ToString(sum);
            }
            if (te9.Text == "X" && te11.Text == "X" && !(te13.Text == "X"))
            {
                int p, c, sum;
                p = Convert.ToInt32(te13.Text);
                c = Convert.ToInt32(tep4.Text);
                sum = 20 + p + c;
                tep5.Text = Convert.ToString(sum);
                pun5.Text = Convert.ToString(sum);
            }
            else if (te9.Text == "X" && te11.Text == "X" && te13.Text == "X")
            {
                int sum, p;
                p = Convert.ToInt32(tep4.Text);
                sum = 30 + p;
                tep5.Text = Convert.ToString(sum);
                pun5.Text = Convert.ToString(sum);
            }
        }

        private void te14_TextChanged(object sender, EventArgs e)
        {
            if (!(te13.Text == "X") && !(te14.Text == "X") && !(te14.Text == "/"))
            {
                int p1, p2, p3, sum, sumt;
                p1 = Convert.ToInt32(te13.Text);
                p2 = Convert.ToInt32(te14.Text);
                sum = p1 + p2;
                if (sum == 10)
                {
                    te14.Text = "/";
                    te14.Enabled = false;
                    te13.Enabled = false;
                    tep7.Text = "";
                    if (ju6.Visible == true)
                    {
                        tr13.Enabled = true;
                        tr14.Enabled = true;
                    }
                    else
                    {
                        t15.Enabled = true;
                        t16.Enabled = true;
                    }
                }
                if (sum > 10)
                {
                    MessageBox.Show("La suma no puede ser mayor a 10");
                    te13.Enabled = true;
                    te13.Text = "";
                    te14.Text = "";
                }
                if (te12.Text == "X")
                {
                    int sum1, p, t, sum2;
                    p = Convert.ToInt32(tep5.Text);
                    sum1 = 10 + sum + p;
                    tep6.Text = Convert.ToString(sum1);
                    pun5.Text = Convert.ToString(sum1);
                    te14.Enabled = false;
                    if (ju6.Visible == true)
                    {
                        tr16.Enabled = false;
                    }
                    else
                    {
                        t16.Enabled = true;
                    }
                    t = Convert.ToInt32(tep6.Text);
                    sum2 = t + sum;
                    if (sum == 10)
                    {
                        tep7.Text = "";
                        pun5.Text = tep6.Text;
                    }
                    else
                    {
                        tep7.Text = Convert.ToString(sum2);
                        pun6.Text = Convert.ToString(sum2);
                    }
                }
                else
                {
                    if (!(te14.Text == "/"))
                    {
                        p3 = Convert.ToInt32(tep6.Text);
                        sumt = p3 + sum;
                        tep7.Text = Convert.ToString(sumt);
                        pun5.Text = Convert.ToString(sumt);
                        te14.Enabled = false;
                        if (ju6.Visible == true)
                        {
                            tr13.Enabled = true;
                            tr14.Enabled = true;
                        }
                        else
                        {
                            t15.Enabled = true;
                            t16.Enabled = true;
                        }
                    }
                    else
                    {
                        tep7.Text = "";
                    }
                }
            }
        }

        private void te15_TextChanged(object sender, EventArgs e)
        {
            if (te15.Text == "X")
            {
                te16.Text = "X";
                te15.Enabled = false;
                te16.Enabled = false;
                if (ju6.Visible == true)
                {
                    tr15.Enabled = true;
                    tr16.Enabled = true;
                }
                else
                {
                    t17.Enabled = true;
                    t18.Enabled = true;
                }
            }
            else
            {
                te15.Enabled = false;
            }
            if (te14.Text == "/" && te15.Text == "X")
            {
                int sum, sum2, p;
                sum = 20;
                p = Convert.ToInt32(tep6.Text);
                sum2 = sum + p;
                tep7.Text = Convert.ToString(sum2);
                pun5.Text = Convert.ToString(sum2);
            }
            else if (te14.Text == "/")
            {
                int p, p2, sum;
                p = Convert.ToInt32(te15.Text);
                p2 = Convert.ToInt32(tep6.Text);
                sum = p2 + 10 + p;
                tep7.Text = Convert.ToString(sum);
                pun5.Text = Convert.ToString(sum);
            }
            if (te11.Text == "X" && te13.Text == "X" && !(te15.Text == "X"))
            {
                int p, c, sum;
                p = Convert.ToInt32(te15.Text);
                c = Convert.ToInt32(tep5.Text);
                sum = 20 + p + c;
                tep6.Text = Convert.ToString(sum);
                pun5.Text = Convert.ToString(sum);
            }
            else if (te11.Text == "X" && te13.Text == "X" && te15.Text == "X")
            {
                int sum, p;
                p = Convert.ToInt32(tep5.Text);
                sum = 30 + p;
                tep6.Text = Convert.ToString(sum);
                pun5.Text = Convert.ToString(sum);
            }
        }

        private void te16_TextChanged(object sender, EventArgs e)
        {
            if (!(te15.Text == "X") && !(te16.Text == "X") && !(te16.Text == "/"))
            {
                int p1, p2, p3, sum, sumt;
                p1 = Convert.ToInt32(te15.Text);
                p2 = Convert.ToInt32(te16.Text);
                sum = p1 + p2;
                if (sum == 10)
                {
                    te16.Text = "/";
                    te16.Enabled = false;
                    te15.Enabled = false;
                    tep8.Text = "";
                    if (ju6.Visible == true)
                    {
                        tr15.Enabled = true;
                        tr16.Enabled = true;
                    }
                    else
                    {
                        t17.Enabled = true;
                        t18.Enabled = true;
                    }
                }
                if (sum > 10)
                {
                    MessageBox.Show("La suma no puede ser mayor a 10");
                    te15.Enabled = true;
                    te15.Text = "";
                    te16.Text = "";
                }
                if (te14.Text == "X")
                {
                    int sum1, p, t, sum2;
                    p = Convert.ToInt32(tep6.Text);
                    sum1 = 10 + sum + p;
                    tep7.Text = Convert.ToString(sum1);
                    pun5.Text = Convert.ToString(sum1);
                    te16.Enabled = false;
                    if (ju6.Visible == true)
                    {
                        tr18.Enabled = false;
                    }
                    else
                    {
                        t18.Enabled = true;
                    }
                    t = Convert.ToInt32(tep7.Text);
                    sum2 = t + sum;
                    if (sum == 10)
                    {
                        tep8.Text = "";
                        pun5.Text = tep7.Text;
                    }
                    else
                    {
                        tep8.Text = Convert.ToString(sum2);
                        pun5.Text = Convert.ToString(sum2);
                    }
                }
                else
                {
                    if (!(te16.Text == "/"))
                    {
                        p3 = Convert.ToInt32(tep7.Text);
                        sumt = p3 + sum;
                        tep8.Text = Convert.ToString(sumt);
                        pun5.Text = Convert.ToString(sumt);
                        te16.Enabled = false;
                        if (ju6.Visible == true)
                        {
                            tr15.Enabled = true;
                            tr16.Enabled = true;
                        }
                        else
                        {
                            t17.Enabled = true;
                            t18.Enabled = true;
                        }
                    }
                    else
                    {
                        tep8.Text = "";
                    }
                }
            }
        }

        private void te17_TextChanged(object sender, EventArgs e)
        {
            if (te17.Text == "X")
            {
                te18.Text = "X";
                te17.Enabled = false;
                te18.Enabled = false;
                if (ju6.Visible == true)
                {
                    tr17.Enabled = true;
                    tr18.Enabled = true;
                }
                else
                {
                    t19.Enabled = true;
                    t20.Enabled = true;
                }
            }
            else
            {
                te17.Enabled = false;
                if (ju6.Enabled == true)
                {
                    tr19.Enabled = false;
                }
                else
                {
                    t19.Enabled = true;
                }
            }
            if (te16.Text == "/" && te17.Text == "X")
            {
                int sum, sum2, p;
                sum = 20;
                p = Convert.ToInt32(tep7.Text);
                sum2 = sum + p;
                tep8.Text = Convert.ToString(sum2);
                pun5.Text = Convert.ToString(sum2);
            }
            else if (te16.Text == "/")
            {
                int p, p2, sum;
                p = Convert.ToInt32(te17.Text);
                p2 = Convert.ToInt32(tep7.Text);
                sum = p2 + 10 + p;
                tep8.Text = Convert.ToString(sum);
                pun5.Text = Convert.ToString(sum);
            }
            if (te13.Text == "X" && te15.Text == "X" && !(te17.Text == "X"))
            {
                int p, c, sum;
                p = Convert.ToInt32(te17.Text);
                c = Convert.ToInt32(tep6.Text);
                sum = 20 + p + c;
                tep7.Text = Convert.ToString(sum);
                pun5.Text = Convert.ToString(sum);
            }
            else if (te13.Text == "X" && te15.Text == "X" && te17.Text == "X")
            {
                int sum, p;
                p = Convert.ToInt32(tep6.Text);
                sum = 30 + p;
                tep7.Text = Convert.ToString(sum);
                pun5.Text = Convert.ToString(sum);
            }
        }

        private void te18_TextChanged(object sender, EventArgs e)
        {
            if (!(te17.Text == "X") && !(te18.Text == "X") && !(te18.Text == "/"))
            {
                int p1, p2, p3, sum, sumt;
                p1 = Convert.ToInt32(te17.Text);
                p2 = Convert.ToInt32(te18.Text);
                sum = p1 + p2;
                if (sum == 10)
                {
                    te18.Text = "/";
                    te18.Enabled = false;
                    te17.Enabled = false;
                    tep9.Text = "";
                    if (ju6.Visible == true)
                    {
                        tr17.Enabled = true;
                        tr18.Enabled = true;
                    }
                    else
                    {
                        t19.Enabled = true;
                        t20.Enabled = true;
                    }
                }
                if (sum > 10)
                {
                    MessageBox.Show("La suma no puede ser mayor a 10");
                    te17.Enabled = true;
                    te17.Text = "";
                    te18.Text = "";
                }
                if (te16.Text == "X")
                {
                    int sum1, p, t, sum2;
                    p = Convert.ToInt32(tep7.Text);
                    sum1 = 10 + sum + p;
                    tep8.Text = Convert.ToString(sum1);
                    pun5.Text = Convert.ToString(sum1);
                    te18.Enabled = false;
                    if (ju6.Visible == true)
                    {
                        te20.Enabled = false;
                    }
                    else
                    {
                        t20.Enabled = true;
                    }
                    t = Convert.ToInt32(tep8.Text);
                    sum2 = t + sum;
                    if (sum == 10)
                    {
                        tep9.Text = "";
                        pun5.Text = tep8.Text;
                    }
                    else
                    {
                        tep9.Text = Convert.ToString(sum2);
                        pun5.Text = Convert.ToString(sum2);
                    }
                }
                else
                {
                    if (!(te18.Text == "/"))
                    {
                        p3 = Convert.ToInt32(tep8.Text);
                        sumt = p3 + sum;
                        tep9.Text = Convert.ToString(sumt);
                        pun5.Text = Convert.ToString(sumt);
                        te18.Enabled = false;
                        if (ju6.Visible == true)
                        {
                            tr17.Enabled = true;
                            tr18.Enabled = true;
                        }
                        else
                        {
                            t19.Enabled = true;
                            t20.Enabled = true;
                        }
                    }
                    else
                    {
                        tep9.Text = "";
                    }
                }
            }
        }

        private void te19_TextChanged(object sender, EventArgs e)
        {
            if (te19.Text == "X")
            {
                te21.Enabled = true;
                te19.Enabled = false;
            }
            else
            {
                te19.Enabled = false;
                te21.Enabled = true;
            }
            if (te18.Text == "/" && te19.Text == "X")
            {
                int sum, sum2, p;
                sum = 20;
                p = Convert.ToInt32(tep8.Text);
                sum2 = sum + p;
                tep9.Text = Convert.ToString(sum2);
                pun5.Text = Convert.ToString(sum2);
                te20.Enabled = true;
            }
            else if (te18.Text == "/")
            {
                int p, p2, sum;
                p = Convert.ToInt32(te19.Text);
                p2 = Convert.ToInt32(tep8.Text);
                sum = p2 + 10 + p;
                tep9.Text = Convert.ToString(sum);
                pun5.Text = Convert.ToString(sum);
            }
            if (te15.Text == "X" && te17.Text == "X" && !(te19.Text == "X"))
            {
                int p, c, sum;
                p = Convert.ToInt32(te19.Text);
                c = Convert.ToInt32(tep7.Text);
                sum = 20 + p + c;
                tep8.Text = Convert.ToString(sum);
                pun5.Text = Convert.ToString(sum);
            }
            if (te15.Text == "X" && te17.Text == "X" && te19.Text == "X")
            {
                int sum, p;
                p = Convert.ToInt32(tep7.Text);
                sum = 30 + p;
                tep8.Text = Convert.ToString(sum);
                pun5.Text = Convert.ToString(sum);
            }
        }

        private void te20_TextChanged(object sender, EventArgs e)
        {
            if (te20.Text == "X")
            {
                te21.Enabled = true;
                te20.Enabled = false;
                tep10.Text = "";
            }
            else if (te20.Text == "/")
            {
                te20.Enabled = false;
                te21.Enabled = true;
            }
            else
            {
                if (!(te19.Text == "X"))
                {
                    int p1, p2, p3, sum, sumt;
                    p1 = Convert.ToInt32(te19.Text);
                    p2 = Convert.ToInt32(te20.Text);
                    sum = p1 + p2;
                    if (sum == 10)
                    {
                        te20.Text = "/";
                        te20.Enabled = false;
                        tep10.Text = "";
                        te21.Enabled = true;
                    }
                    if (sum > 10)
                    {
                        MessageBox.Show("La suma no puede ser mayor a 10");
                        te17.Enabled = true;
                        te17.Text = "";
                        te18.Text = "";
                    }
                    if (te18.Text == "X")
                    {
                        int sum1, p, t, sum2;
                        p = Convert.ToInt32(tep8.Text);
                        sum1 = 10 + sum + p;
                        tep9.Text = Convert.ToString(sum1);
                        pun5.Text = Convert.ToString(sum1);
                        te20.Enabled = false;
                        t = Convert.ToInt32(tep9.Text);
                        sum2 = t + sum;
                        if (sum == 10)
                        {
                            tep10.Text = "";
                            pun5.Text = tep9.Text;
                        }
                        else
                        {
                            tep10.Text = Convert.ToString(sum2);
                            pun5.Text = Convert.ToString(sum2);
                            te21.Enabled = false;
                            if (ju6.Visible == true)
                            {
                                tr19.Enabled = true;
                                tr20.Enabled = true;
                            }
                            else
                            {
                                MessageBox.Show("Fin del juego");
                            }

                        }
                    }
                    else
                    {
                        if (!(te20.Text == "/"))
                        {
                            te21.Enabled = false;
                            p3 = Convert.ToInt32(tep9.Text);
                            sumt = p3 + sum;
                            tep10.Text = Convert.ToString(sumt);
                            pun5.Text = Convert.ToString(sumt);
                            te19.Enabled = false;
                            te20.Enabled = false;

                            if (ju6.Visible == true)
                            {
                                tr19.Enabled = true;
                                tr20.Enabled = true;
                            }
                            else
                            {
                                MessageBox.Show("Fin del juego");
                            }
                        }
                        else
                        {
                            tep10.Text = "";
                            te21.Enabled = true;
                        }
                    }
                }
                else
                {
                    te20.Enabled = false;
                }
            }
            if (te17.Text == "X" && te19.Text == "X" && te20.Text == "X")
            {
                int sum, p;
                p = Convert.ToInt32(tep8.Text);
                sum = 30 + p;
                tep9.Text = Convert.ToString(sum);
                pun5.Text = Convert.ToString(sum);
            }
            else if (te17.Text == "X" && te19.Text == "X" && !(te20.Text == "X"))
            {
                int sum, p, y;
                y = Convert.ToInt32(te20.Text);
                p = Convert.ToInt32(tep8.Text);
                sum = 20 + p + y;
                tep9.Text = Convert.ToString(sum);
                pun5.Text = Convert.ToString(sum);
            }
        }

        private void te21_TextChanged(object sender, EventArgs e)
        {
            int p, sum, pp;
            if (te19.Text == "X" && te20.Text == "X" && te21.Text == "X")
            {
                p = Convert.ToInt32(tep9.Text);
                sum = p + 30;
                tep10.Text = Convert.ToString(sum);
                pun5.Text = Convert.ToString(sum);
                te21.Enabled = false;
                if (ju6.Visible == true)
                {
                    tr19.Enabled = true;
                    tr20.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Fin del juego");
                }
            }
            if (te20.Text == "/")
            {
                if (te21.Text == "X")
                {
                    p = Convert.ToInt32(tep9.Text);
                    sum = p + 20;
                    tep10.Text = Convert.ToString(sum);
                    pun5.Text = Convert.ToString(sum);
                    te21.Enabled = false;
                    if (ju6.Visible == true)
                    {
                        tr19.Enabled = true;
                        tr20.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Fin del juego");
                    }
                }
                else
                {
                    p = Convert.ToInt32(tep9.Text);
                    pp = Convert.ToInt32(te21.Text);
                    sum = p + 10 + pp;
                    tep10.Text = Convert.ToString(sum);
                    pun5.Text = Convert.ToString(sum);
                    te21.Enabled = false;
                    if (ju6.Visible == true)
                    {
                        tr19.Enabled = true;
                        tr20.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Fin del juego");
                    }
                }

            }
            if (te19.Text == "X" && !(te20.Text == "X"))
            {
                int c, p1, sump, sumpp, d;
                c = Convert.ToInt32(te20.Text);
                p1 = Convert.ToInt32(te21.Text);
                d = Convert.ToInt32(tep9.Text);
                sump = c + p1;
                if (sump > 10)
                {
                    MessageBox.Show("la suma no puede ser mayor a 10");
                    te20.Enabled = true;
                    te20.Text = "";
                    te21.Enabled = true;
                    te21.Text = "";
                }
                else
                {
                    sumpp = sump + 10 + d;
                    tep10.Text = Convert.ToString(sumpp);
                    pun5.Text = Convert.ToString(sumpp);
                    te21.Enabled = false;
                    if (ju6.Visible == true)
                    {
                        tr19.Enabled = true;
                        tr20.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Fin del juego");
                    }
                }
            }
        }
        /////////
        private void tr1_TextChanged(object sender, EventArgs e)
        {
            if (tr1.Text == "X")
            {
                tr2.Text = "X";
                tr1.Enabled = false;
                tr2.Enabled = false;
                if (ju7.Visible == true)
                {
                    ty1.Enabled = true;
                    ty2.Enabled = true;
                }
                else
                {
                    t3.Enabled = true;
                    t4.Enabled = true;
                }
            }
            else
            {
                tr1.Enabled = false;
            }
        }

        private void tr2_TextChanged(object sender, EventArgs e)
        {
            if (!(tr1.Text == "X") && !(tr2.Text == "X") && !(tr2.Text == "/"))
            {
                int p1, p2, sum;
                p1 = Convert.ToInt32(tr1.Text);
                p2 = Convert.ToInt32(tr2.Text);
                sum = p1 + p2;
                if (sum == 10)
                {
                    tr2.Text = "/";
                    tr2.Enabled = false;
                    trp1.Text = "";
                    if (ju7.Visible == true)
                    {
                        ty1.Enabled = true;
                        ty2.Enabled = true;
                    }
                    else
                    {
                        t3.Enabled = true;
                        t4.Enabled = true;
                    }
                }
                if (sum > 10)
                {
                    MessageBox.Show("La suma no puede ser mayor a 10");
                    tr1.Enabled = true;
                    tr1.Text = "";
                    tr2.Text = "";
                }
                else
                {
                    if (!(tr2.Text == "/"))
                    {
                        trp1.Text = Convert.ToString(sum);
                        pun6.Text = Convert.ToString(sum);
                        tr2.Enabled = false;
                        if (ju7.Visible == true)
                        {
                            ty1.Enabled = true;
                            ty2.Enabled = true;
                        }
                        else
                        {
                            t3.Enabled = true;
                            t4.Enabled = true;
                        }
                    }
                    else
                    {
                        trp1.Text = "";
                    }
                }
            }
        }

        private void tr3_TextChanged(object sender, EventArgs e)
        {
            int p, sum;
            if (tr3.Text == "X")
            {
                tr4.Text = "X";
                tr3.Enabled = false;
                tr4.Enabled = false;
                if (ju7.Visible == true)
                {
                    ty3.Enabled = true;
                    ty4.Enabled = true;
                }
                else
                {
                    t5.Enabled = true;
                    t6.Enabled = true;
                }
            }
            else
            {
                tr3.Enabled = false;
                if (ju7.Enabled == true)
                {
                    ty5.Enabled = false;
                }
                else
                {
                    t5.Enabled = true;
                    t6.Enabled = true;
                }
            }
            if (tr2.Text == "/" && tr3.Text == "X")
            {
                sum = 20;
                trp1.Text = Convert.ToString(sum);
                pun6.Text = Convert.ToString(sum);
            }
            else if (tr2.Text == "/")
            {
                p = Convert.ToInt32(tr3.Text);
                sum = 10 + p;
                trp1.Text = Convert.ToString(sum);
                pun6.Text = Convert.ToString(sum);
                tr4.Enabled = true;
            }
        }

        private void tr4_TextChanged(object sender, EventArgs e)
        {
            if (!(tr3.Text == "X") && !(tr4.Text == "X") && !(tr4.Text == "/"))
            {
                int p1, p2, p3, sum, sumt;
                p1 = Convert.ToInt32(tr3.Text);
                p2 = Convert.ToInt32(tr4.Text);
                sum = p1 + p2;
                if (sum == 10)
                {
                    tr4.Text = "/";
                    tr4.Enabled = false;
                    tr3.Enabled = false;
                    trp2.Text = "";
                    if (ju7.Visible == true)
                    {
                        ty3.Enabled = true;
                        ty4.Enabled = true;
                    }
                    else
                    {
                        t5.Enabled = true;
                        t6.Enabled = true;
                    }
                }
                if (sum > 10)
                {
                    MessageBox.Show("La suma no puede ser mayor a 10");
                    tr3.Enabled = true;
                    tr3.Text = "";
                    tr4.Text = "";
                }
                if (tr2.Text == "X" && !(tr4.Text == "X"))
                {
                    int sumq;
                    sumt = 10 + sum;
                    trp1.Text = Convert.ToString(sumt);
                    sumq = Convert.ToInt32(trp1.Text) + sum;
                    if (sum == 10)
                    {
                        trp2.Text = "";
                        pun6.Text = trp1.Text;
                    }
                    else
                    {
                        trp2.Text = Convert.ToString(sumq);
                        pun6.Text = Convert.ToString(sumq);
                    }
                    tr4.Enabled = false;
                    if (ju7.Visible == true)
                    {
                        ty3.Enabled = true;
                        ty4.Enabled = true;
                    }
                    else
                    {
                        t5.Enabled = true;
                        t6.Enabled = true;
                    }
                }
                else
                {
                    if (!(tr4.Text == "/"))
                    {
                        p3 = Convert.ToInt32(trp1.Text);
                        sumt = p3 + sum;
                        trp2.Text = Convert.ToString(sumt);
                        pun6.Text = Convert.ToString(sumt);
                        tr4.Enabled = false;
                        if (ju7.Visible == true)
                        {
                            ty3.Enabled = true;
                            ty4.Enabled = true;
                        }
                        else
                        {
                            t5.Enabled = true;
                            t6.Enabled = true;
                        }
                    }
                    else
                    {
                        trp2.Text = "";
                    }
                }
            }
        }

        private void tr5_TextChanged(object sender, EventArgs e)
        {
            if (tr5.Text == "X")
            {
                tr6.Text = "X";
                tr5.Enabled = false;
                tr6.Enabled = false;
                if (ju7.Visible == true)
                {
                    ty5.Enabled = true;
                    ty6.Enabled = true;
                }
                else
                {
                    t7.Enabled = true;
                    t8.Enabled = true;
                }
            }
            else
            {
                tr5.Enabled = false;
            }
            if (tr4.Text == "/" && tr5.Text == "X")
            {
                int sum, sum2, p;
                sum = 20;
                p = Convert.ToInt32(trp1.Text);
                sum2 = sum + p;
                trp2.Text = Convert.ToString(sum2);
                pun6.Text = Convert.ToString(sum2);
            }
            else if (tr4.Text == "/")
            {
                int p, p2, sum;
                p = Convert.ToInt32(tr5.Text);
                p2 = Convert.ToInt32(trp1.Text);
                sum = p2 + 10 + p;
                trp2.Text = Convert.ToString(sum);
                pun6.Text = Convert.ToString(sum);
            }
            if (tr1.Text == "X" && tr3.Text == "X" && !(tr5.Text == "X"))
            {
                int p, sum;
                p = Convert.ToInt32(tr5.Text);
                sum = 20 + p;
                trp1.Text = Convert.ToString(sum);
                pun6.Text = Convert.ToString(sum);
            }
            else if (tr1.Text == "X" && tr3.Text == "X" && tr5.Text == "X")
            {
                int sum;
                sum = 30;
                trp1.Text = Convert.ToString(sum);
                pun6.Text = Convert.ToString(sum);
            }
        }

        private void tr6_TextChanged(object sender, EventArgs e)
        {
            if (!(tr5.Text == "X") && !(tr6.Text == "X") && !(tr6.Text == "/"))
            {
                int p1, p2, p3, sum, sumt;
                p1 = Convert.ToInt32(tr5.Text);
                p2 = Convert.ToInt32(tr6.Text);
                sum = p1 + p2;
                if (sum == 10)
                {
                    tr6.Text = "/";
                    tr6.Enabled = false;
                    tr5.Enabled = false;
                    trp3.Text = "";
                    if (ju7.Visible == true)
                    {
                        ty5.Enabled = true;
                        ty6.Enabled = true;
                    }
                    else
                    {
                        t7.Enabled = true;
                        t8.Enabled = true;
                    }
                }
                if (sum > 10)
                {
                    MessageBox.Show("La suma no puede ser mayor a 10");
                    tr5.Enabled = true;
                    tr5.Text = "";
                    tr6.Text = "";
                }
                if (tr4.Text == "X")
                {
                    int sum1, p, t, sum2;
                    p = Convert.ToInt32(trp1.Text);
                    sum1 = 10 + sum + p;
                    trp2.Text = Convert.ToString(sum1);
                    pun6.Text = Convert.ToString(sum1);
                    tr6.Enabled = false;


                    t = Convert.ToInt32(trp2.Text);
                    sum2 = t + sum;
                    if (sum == 10)
                    {
                        trp3.Text = "";
                        pun6.Text = trp2.Text;
                    }
                    else
                    {
                        trp3.Text = Convert.ToString(sum2);
                        pun6.Text = Convert.ToString(sum2);
                    }
                }
                else
                {
                    if (!(tr6.Text == "/"))
                    {
                        p3 = Convert.ToInt32(trp2.Text);
                        sumt = p3 + sum;
                        trp3.Text = Convert.ToString(sumt);
                        pun6.Text = Convert.ToString(sumt);
                        tr6.Enabled = false;
                        if (ju7.Visible == true)
                        {
                            ty5.Enabled = true;
                            ty6.Enabled = true;
                        }
                        else
                        {
                            t7.Enabled = true;
                            t8.Enabled = true;
                        }
                    }
                    else
                    {
                        trp3.Text = "";
                    }
                }
            }
        }

        private void tr7_TextChanged(object sender, EventArgs e)
        {
            if (tr7.Text == "X")
            {
                tr8.Text = "X";
                tr7.Enabled = false;
                tr8.Enabled = false;
                if (ju7.Visible == true)
                {
                    ty7.Enabled = true;
                    ty8.Enabled = true;
                }
                else
                {
                    t9.Enabled = true;
                    t10.Enabled = true;
                }

            }
            else
            {
                tr7.Enabled = false;
                if (ju7.Enabled == true)
                {
                    ty9.Enabled = false;
                }
                else
                {
                    t9.Enabled = true;
                }
            }
            if (tr6.Text == "/" && tr7.Text == "X")
            {
                int sum, sum2, p;
                sum = 20;
                p = Convert.ToInt32(trp2.Text);
                sum2 = sum + p;
                trp3.Text = Convert.ToString(sum2);
                pun6.Text = Convert.ToString(sum2);
            }
            else if (tr6.Text == "/")
            {
                int p, p2, sum;
                p = Convert.ToInt32(tr7.Text);
                p2 = Convert.ToInt32(trp2.Text);
                sum = p2 + 10 + p;
                trp3.Text = Convert.ToString(sum);
                pun6.Text = Convert.ToString(sum);
            }
            if (tr3.Text == "X" && tr5.Text == "X" && !(tr7.Text == "X"))
            {
                int p, c, sum;
                p = Convert.ToInt32(tr7.Text);
                c = Convert.ToInt32(trp1.Text);
                sum = 20 + p + c;
                trp2.Text = Convert.ToString(sum);
                pun6.Text = Convert.ToString(sum);
            }
            else if (tr3.Text == "X" && tr5.Text == "X" && tr7.Text == "X")
            {
                int sum, p;
                p = Convert.ToInt32(trp1.Text);
                sum = 30 + p;
                trp2.Text = Convert.ToString(sum);
                pun6.Text = Convert.ToString(sum);
            }
        }

        private void tr8_TextChanged(object sender, EventArgs e)
        {
            if (!(tr7.Text == "X") && !(tr8.Text == "X") && !(tr8.Text == "/"))
            {
                int p1, p2, p3, sum, sumt;
                p1 = Convert.ToInt32(tr7.Text);
                p2 = Convert.ToInt32(tr8.Text);
                sum = p1 + p2;
                if (sum == 10)
                {
                    tr8.Text = "/";
                    tr8.Enabled = false;
                    tr7.Enabled = false;
                    trp4.Text = "";
                    if (ju7.Visible == true)
                    {
                        ty7.Enabled = true;
                        ty8.Enabled = true;
                    }
                    else
                    {
                        t9.Enabled = true;
                        t10.Enabled = true;
                    }
                }
                if (sum > 10)
                {
                    MessageBox.Show("La suma no puede ser mayor a 10");
                    tr7.Enabled = true;
                    tr7.Text = "";
                    tr8.Text = "";
                }
                if (tr6.Text == "X")
                {
                    int sum1, p, t, sum2;
                    p = Convert.ToInt32(trp2.Text);
                    sum1 = 10 + sum + p;
                    trp3.Text = Convert.ToString(sum1);
                    pun6.Text = Convert.ToString(sum1);
                    tr8.Enabled = false;
                    t = Convert.ToInt32(trp3.Text);
                    sum2 = t + sum;
                    if (sum == 10)
                    {
                        trp4.Text = "";
                        pun6.Text = trp3.Text;
                    }
                    else
                    {
                        trp4.Text = Convert.ToString(sum2);
                        pun6.Text = Convert.ToString(sum2);
                    }
                }
                else
                {
                    if (!(tr8.Text == "/"))
                    {
                        p3 = Convert.ToInt32(trp3.Text);
                        sumt = p3 + sum;
                        trp4.Text = Convert.ToString(sumt);
                        pun6.Text = Convert.ToString(sumt);
                        tr8.Enabled = false;
                        if (ju7.Visible == true)
                        {
                            ty7.Enabled = true;
                            ty8.Enabled = true;
                        }
                        else
                        {
                            t9.Enabled = true;
                            t10.Enabled = true;
                        }
                    }
                    else
                    {
                        trp4.Text = "";
                    }
                }
            }
        }

        private void tr9_TextChanged(object sender, EventArgs e)
        {
            if (tr9.Text == "X")
            {
                tr10.Text = "X";
                tr9.Enabled = false;
                tr10.Enabled = false;
                if (ju7.Visible == true)
                {
                    ty9.Enabled = true;
                    ty10.Enabled = true;
                }
                else
                {
                    t11.Enabled = true;
                    t12.Enabled = true;
                }

            }
            else
            {
                tr9.Enabled = false;
            }
            if (tr8.Text == "/" && tr9.Text == "X")
            {
                int sum, sum2, p;
                sum = 20;
                p = Convert.ToInt32(trp3.Text);
                sum2 = sum + p;
                trp4.Text = Convert.ToString(sum2);
                pun6.Text = Convert.ToString(sum2);
            }
            else if (tr8.Text == "/")
            {
                int p, p2, sum;
                p = Convert.ToInt32(tr9.Text);
                p2 = Convert.ToInt32(trp3.Text);
                sum = p2 + 10 + p;
                trp4.Text = Convert.ToString(sum);
                pun6.Text = Convert.ToString(sum);
            }
            if (tr5.Text == "X" && tr7.Text == "X" && !(tr9.Text == "X"))
            {
                int p, c, sum;
                p = Convert.ToInt32(tr9.Text);
                c = Convert.ToInt32(trp2.Text);
                sum = 20 + p + c;
                trp3.Text = Convert.ToString(sum);
                pun6.Text = Convert.ToString(sum);
            }
            else if (tr5.Text == "X" && tr7.Text == "X" && tr9.Text == "X")
            {
                int sum, p;
                p = Convert.ToInt32(trp2.Text);
                sum = 30 + p;
                trp3.Text = Convert.ToString(sum);
                pun6.Text = Convert.ToString(sum);
            }
        }

        private void tr10_TextChanged(object sender, EventArgs e)
        {
            if (!(tr9.Text == "X") && !(tr10.Text == "X") && !(tr10.Text == "/"))
            {
                int p1, p2, p3, sum, sumt;
                p1 = Convert.ToInt32(tr9.Text);
                p2 = Convert.ToInt32(tr10.Text);
                sum = p1 + p2;
                if (sum == 10)
                {
                    tr10.Text = "/";
                    tr10.Enabled = false;
                    tr9.Enabled = false;
                    trp5.Text = "";
                    if (ju7.Visible == true)
                    {
                        ty9.Enabled = true;
                        ty10.Enabled = true;
                    }
                    else
                    {
                        t11.Enabled = true;
                        t12.Enabled = true;
                    }
                }
                if (sum > 10)
                {
                    MessageBox.Show("La suma no puede ser mayor a 10");
                    tr9.Enabled = true;
                    tr9.Text = "";
                    tr10.Text = "";
                }
                if (tr8.Text == "X")
                {
                    int sum1, p, t, sum2;
                    p = Convert.ToInt32(trp3.Text);
                    sum1 = 10 + sum + p;
                    trp4.Text = Convert.ToString(sum1);
                    pun6.Text = Convert.ToString(sum1);
                    tr10.Enabled = false;
                    t = Convert.ToInt32(trp4.Text);
                    sum2 = t + sum;
                    if (sum == 10)
                    {
                        trp5.Text = "";
                        pun6.Text = trp4.Text;
                    }
                    else
                    {
                        trp5.Text = Convert.ToString(sum2);
                        pun6.Text = Convert.ToString(sum2);
                    }
                }
                else
                {
                    if (!(tr10.Text == "/"))
                    {
                        p3 = Convert.ToInt32(trp4.Text);
                        sumt = p3 + sum;
                        trp5.Text = Convert.ToString(sumt);
                        pun6.Text = Convert.ToString(sumt);
                        tr10.Enabled = false;
                        if (ju7.Visible == true)
                        {
                            ty9.Enabled = true;
                            ty10.Enabled = true;
                        }
                        else
                        {
                            t11.Enabled = true;
                            t12.Enabled = true;
                        }
                    }
                    else
                    {
                        trp5.Text = "";
                    }
                }
            }
        }

        private void tr11_TextChanged(object sender, EventArgs e)
        {
            if (tr11.Text == "X")
            {
                tr12.Text = "X";
                tr11.Enabled = false;
                tr12.Enabled = false;
                if (ju7.Visible == true)
                {
                    ty11.Enabled = true;
                    ty12.Enabled = true;
                }
                else
                {
                    t13.Enabled = true;
                    t14.Enabled = true;
                }
            }
            else
            {
                tr11.Enabled = false;
            }
            if (tr10.Text == "/" && tr11.Text == "X")
            {
                int sum, sum2, p;
                sum = 20;
                p = Convert.ToInt32(trp4.Text);
                sum2 = sum + p;
                trp5.Text = Convert.ToString(sum2);
                pun6.Text = Convert.ToString(sum2);
            }
            else if (tr10.Text == "/")
            {
                int p, p2, sum;
                p = Convert.ToInt32(tr11.Text);
                p2 = Convert.ToInt32(trp4.Text);
                sum = p2 + 10 + p;
                trp5.Text = Convert.ToString(sum);
                pun6.Text = Convert.ToString(sum);
            }
            if (tr7.Text == "X" && tr9.Text == "X" && !(tr11.Text == "X"))
            {
                int p, c, sum;
                p = Convert.ToInt32(tr11.Text);
                c = Convert.ToInt32(trp3.Text);
                sum = 20 + p + c;
                trp4.Text = Convert.ToString(sum);
                pun6.Text = Convert.ToString(sum);
            }
            else if (tr7.Text == "X" && tr9.Text == "X" && tr11.Text == "X")
            {
                int sum, p;
                p = Convert.ToInt32(trp3.Text);
                sum = 30 + p;
                trp4.Text = Convert.ToString(sum);
                pun6.Text = Convert.ToString(sum);
            }
        }

        private void tr12_TextChanged(object sender, EventArgs e)
        {
            if (!(tr11.Text == "X") && !(tr12.Text == "X") && !(tr12.Text == "/"))
            {
                int p1, p2, p3, sum, sumt;
                p1 = Convert.ToInt32(tr11.Text);
                p2 = Convert.ToInt32(tr12.Text);
                sum = p1 + p2;
                if (sum == 10)
                {
                    tr12.Text = "/";
                    tr12.Enabled = false;
                    tr11.Enabled = false;
                    trp6.Text = "";
                    if (ju7.Visible == true)
                    {
                        ty11.Enabled = true;
                        ty12.Enabled = true;
                    }
                    else
                    {
                        t13.Enabled = true;
                        t14.Enabled = true;
                    }
                }
                if (sum > 10)
                {
                    MessageBox.Show("La suma no puede ser mayor a 10");
                    tr11.Enabled = true;
                    tr11.Text = "";
                    tr12.Text = "";
                }
                if (tr10.Text == "X")
                {
                    int sum1, p, t, sum2;
                    p = Convert.ToInt32(trp4.Text);
                    sum1 = 10 + sum + p;
                    trp5.Text = Convert.ToString(sum1);
                    pun6.Text = Convert.ToString(sum1);
                    tr12.Enabled = false;
                    t = Convert.ToInt32(trp5.Text);
                    sum2 = t + sum;
                    if (sum == 10)
                    {
                        trp6.Text = "";
                        pun6.Text = trp5.Text;
                    }
                    else
                    {
                        trp6.Text = Convert.ToString(sum2);
                        pun6.Text = Convert.ToString(sum2);
                    }
                }
                else
                {
                    if (!(tr12.Text == "/"))
                    {
                        p3 = Convert.ToInt32(trp5.Text);
                        sumt = p3 + sum;
                        trp6.Text = Convert.ToString(sumt);
                        pun6.Text = Convert.ToString(sumt);
                        tr12.Enabled = false;
                        if (ju7.Visible == true)
                        {
                            ty11.Enabled = true;
                            ty12.Enabled = true;
                        }
                        else
                        {
                            t13.Enabled = true;
                            t14.Enabled = true;
                        }
                    }
                    else
                    {
                        trp6.Text = "";
                    }
                }
            }
        }

        private void tr13_TextChanged(object sender, EventArgs e)
        {
            if (tr13.Text == "X")
            {
                tr14.Text = "X";
                tr13.Enabled = false;
                tr14.Enabled = false;
                if (ju7.Visible == true)
                {
                    ty13.Enabled = true;
                    ty14.Enabled = true;
                }
                else
                {
                    t15.Enabled = true;
                    t16.Enabled = true;
                }
            }
            else
            {
                tr13.Enabled = false;
            }
            if (tr12.Text == "/" && tr13.Text == "X")
            {
                int sum, sum2, p;
                sum = 20;
                p = Convert.ToInt32(trp5.Text);
                sum2 = sum + p;
                trp6.Text = Convert.ToString(sum2);
                pun6.Text = Convert.ToString(sum2);
            }
            else if (tr12.Text == "/")
            {
                int p, p2, sum;
                p = Convert.ToInt32(tr13.Text);
                p2 = Convert.ToInt32(trp5.Text);
                sum = p2 + 10 + p;
                trp6.Text = Convert.ToString(sum);
                pun6.Text = Convert.ToString(sum);
            }
            if (tr9.Text == "X" && tr11.Text == "X" && !(tr13.Text == "X"))
            {
                int p, c, sum;
                p = Convert.ToInt32(tr13.Text);
                c = Convert.ToInt32(trp4.Text);
                sum = 20 + p + c;
                trp5.Text = Convert.ToString(sum);
                pun6.Text = Convert.ToString(sum);
            }
            else if (tr9.Text == "X" && tr11.Text == "X" && tr13.Text == "X")
            {
                int sum, p;
                p = Convert.ToInt32(trp4.Text);
                sum = 30 + p;
                trp5.Text = Convert.ToString(sum);
                pun6.Text = Convert.ToString(sum);
            }
        }

        private void tr14_TextChanged(object sender, EventArgs e)
        {
            if (!(tr13.Text == "X") && !(tr14.Text == "X") && !(tr14.Text == "/"))
            {
                int p1, p2, p3, sum, sumt;
                p1 = Convert.ToInt32(tr13.Text);
                p2 = Convert.ToInt32(tr14.Text);
                sum = p1 + p2;
                if (sum == 10)
                {
                    tr14.Text = "/";
                    tr14.Enabled = false;
                    tr13.Enabled = false;
                    trp7.Text = "";
                    if (ju7.Visible == true)
                    {
                        ty13.Enabled = true;
                        ty14.Enabled = true;
                    }
                    else
                    {
                        t15.Enabled = true;
                        t16.Enabled = true;
                    }
                }
                if (sum > 10)
                {
                    MessageBox.Show("La suma no puede ser mayor a 10");
                    tr13.Enabled = true;
                    tr13.Text = "";
                    tr14.Text = "";
                }
                if (tr12.Text == "X")
                {
                    int sum1, p, t, sum2;
                    p = Convert.ToInt32(trp5.Text);
                    sum1 = 10 + sum + p;
                    trp6.Text = Convert.ToString(sum1);
                    pun6.Text = Convert.ToString(sum1);
                    tr14.Enabled = false;
                    if (ju7.Visible == true)
                    {
                        ty16.Enabled = false;
                    }
                    else
                    {
                        t16.Enabled = true;
                    }
                    t = Convert.ToInt32(trp6.Text);
                    sum2 = t + sum;
                    if (sum == 10)
                    {
                        trp7.Text = "";
                        pun6.Text = trp6.Text;
                    }
                    else
                    {
                        trp7.Text = Convert.ToString(sum2);
                        pun7.Text = Convert.ToString(sum2);
                    }
                }
                else
                {
                    if (!(tr14.Text == "/"))
                    {
                        p3 = Convert.ToInt32(trp6.Text);
                        sumt = p3 + sum;
                        trp7.Text = Convert.ToString(sumt);
                        pun6.Text = Convert.ToString(sumt);
                        tr14.Enabled = false;
                        if (ju7.Visible == true)
                        {
                            ty13.Enabled = true;
                            ty14.Enabled = true;
                        }
                        else
                        {
                            t15.Enabled = true;
                            t16.Enabled = true;
                        }
                    }
                    else
                    {
                        trp7.Text = "";
                    }
                }
            }
        }

        private void tr15_TextChanged(object sender, EventArgs e)
        {
            if (tr15.Text == "X")
            {
                tr16.Text = "X";
                tr15.Enabled = false;
                tr16.Enabled = false;
                if (ju7.Visible == true)
                {
                    ty15.Enabled = true;
                    ty16.Enabled = true;
                }
                else
                {
                    t17.Enabled = true;
                    t18.Enabled = true;
                }
            }
            else
            {
                tr15.Enabled = false;
            }
            if (tr14.Text == "/" && tr15.Text == "X")
            {
                int sum, sum2, p;
                sum = 20;
                p = Convert.ToInt32(trp6.Text);
                sum2 = sum + p;
                trp7.Text = Convert.ToString(sum2);
                pun6.Text = Convert.ToString(sum2);
            }
            else if (tr14.Text == "/")
            {
                int p, p2, sum;
                p = Convert.ToInt32(tr15.Text);
                p2 = Convert.ToInt32(trp6.Text);
                sum = p2 + 10 + p;
                trp7.Text = Convert.ToString(sum);
                pun6.Text = Convert.ToString(sum);
            }
            if (tr11.Text == "X" && tr13.Text == "X" && !(tr15.Text == "X"))
            {
                int p, c, sum;
                p = Convert.ToInt32(tr15.Text);
                c = Convert.ToInt32(trp5.Text);
                sum = 20 + p + c;
                trp6.Text = Convert.ToString(sum);
                pun6.Text = Convert.ToString(sum);
            }
            else if (tr11.Text == "X" && tr13.Text == "X" && tr15.Text == "X")
            {
                int sum, p;
                p = Convert.ToInt32(trp5.Text);
                sum = 30 + p;
                trp6.Text = Convert.ToString(sum);
                pun6.Text = Convert.ToString(sum);
            }
        }

        private void tr16_TextChanged(object sender, EventArgs e)
        {
            if (!(tr15.Text == "X") && !(tr16.Text == "X") && !(tr16.Text == "/"))
            {
                int p1, p2, p3, sum, sumt;
                p1 = Convert.ToInt32(tr15.Text);
                p2 = Convert.ToInt32(tr16.Text);
                sum = p1 + p2;
                if (sum == 10)
                {
                    tr16.Text = "/";
                    tr16.Enabled = false;
                    tr15.Enabled = false;
                    trp8.Text = "";
                    if (ju7.Visible == true)
                    {
                        ty15.Enabled = true;
                        ty16.Enabled = true;
                    }
                    else
                    {
                        t17.Enabled = true;
                        t18.Enabled = true;
                    }
                }
                if (sum > 10)
                {
                    MessageBox.Show("La suma no puede ser mayor a 10");
                    tr15.Enabled = true;
                    tr15.Text = "";
                    tr16.Text = "";
                }
                if (tr14.Text == "X")
                {
                    int sum1, p, t, sum2;
                    p = Convert.ToInt32(trp6.Text);
                    sum1 = 10 + sum + p;
                    trp7.Text = Convert.ToString(sum1);
                    pun6.Text = Convert.ToString(sum1);
                    tr16.Enabled = false;
                    if (ju7.Visible == true)
                    {
                        ty18.Enabled = false;
                    }
                    else
                    {
                        t18.Enabled = true;
                    }
                    t = Convert.ToInt32(trp7.Text);
                    sum2 = t + sum;
                    if (sum == 10)
                    {
                        trp8.Text = "";
                        pun6.Text = trp7.Text;
                    }
                    else
                    {
                        trp8.Text = Convert.ToString(sum2);
                        pun6.Text = Convert.ToString(sum2);
                    }
                }
                else
                {
                    if (!(tr16.Text == "/"))
                    {
                        p3 = Convert.ToInt32(trp7.Text);
                        sumt = p3 + sum;
                        trp8.Text = Convert.ToString(sumt);
                        pun6.Text = Convert.ToString(sumt);
                        tr16.Enabled = false;
                        if (ju7.Visible == true)
                        {
                            ty15.Enabled = true;
                            ty16.Enabled = true;
                        }
                        else
                        {
                            t17.Enabled = true;
                            t18.Enabled = true;
                        }
                    }
                    else
                    {
                        trp8.Text = "";
                    }
                }
            }
        }

        private void tr17_TextChanged(object sender, EventArgs e)
        {
            if (tr17.Text == "X")
            {
                tr18.Text = "X";
                tr17.Enabled = false;
                tr18.Enabled = false;
                if (ju7.Visible == true)
                {
                    ty17.Enabled = true;
                    ty18.Enabled = true;
                }
                else
                {
                    t19.Enabled = true;
                    t20.Enabled = true;
                }
            }
            else
            {
                tr17.Enabled = false;
                if (ju7.Enabled == true)
                {
                    ty19.Enabled = false;
                }
                else
                {
                    t19.Enabled = true;
                }
            }
            if (tr16.Text == "/" && tr17.Text == "X")
            {
                int sum, sum2, p;
                sum = 20;
                p = Convert.ToInt32(trp7.Text);
                sum2 = sum + p;
                trp8.Text = Convert.ToString(sum2);
                pun6.Text = Convert.ToString(sum2);
            }
            else if (tr16.Text == "/")
            {
                int p, p2, sum;
                p = Convert.ToInt32(tr17.Text);
                p2 = Convert.ToInt32(trp7.Text);
                sum = p2 + 10 + p;
                trp8.Text = Convert.ToString(sum);
                pun6.Text = Convert.ToString(sum);
            }
            if (tr13.Text == "X" && tr15.Text == "X" && !(tr17.Text == "X"))
            {
                int p, c, sum;
                p = Convert.ToInt32(tr17.Text);
                c = Convert.ToInt32(trp6.Text);
                sum = 20 + p + c;
                trp7.Text = Convert.ToString(sum);
                pun6.Text = Convert.ToString(sum);
            }
            else if (tr13.Text == "X" && tr15.Text == "X" && tr17.Text == "X")
            {
                int sum, p;
                p = Convert.ToInt32(trp6.Text);
                sum = 30 + p;
                trp7.Text = Convert.ToString(sum);
                pun6.Text = Convert.ToString(sum);
            }
        }

        private void tr18_TextChanged(object sender, EventArgs e)
        {
            if (!(tr17.Text == "X") && !(tr18.Text == "X") && !(tr18.Text == "/"))
            {
                int p1, p2, p3, sum, sumt;
                p1 = Convert.ToInt32(tr17.Text);
                p2 = Convert.ToInt32(tr18.Text);
                sum = p1 + p2;
                if (sum == 10)
                {
                    tr18.Text = "/";
                    tr18.Enabled = false;
                    tr17.Enabled = false;
                    trp9.Text = "";
                    if (ju7.Visible == true)
                    {
                        ty17.Enabled = true;
                        ty18.Enabled = true;
                    }
                    else
                    {
                        t19.Enabled = true;
                        t20.Enabled = true;
                    }
                }
                if (sum > 10)
                {
                    MessageBox.Show("La suma no puede ser mayor a 10");
                    tr17.Enabled = true;
                    tr17.Text = "";
                    tr18.Text = "";
                }
                if (tr16.Text == "X")
                {
                    int sum1, p, t, sum2;
                    p = Convert.ToInt32(trp7.Text);
                    sum1 = 10 + sum + p;
                    trp8.Text = Convert.ToString(sum1);
                    pun6.Text = Convert.ToString(sum1);
                    tr18.Enabled = false;
                    if (ju7.Visible == true)
                    {
                        tr20.Enabled = false;
                    }
                    else
                    {
                        t20.Enabled = true;
                    }
                    t = Convert.ToInt32(trp8.Text);
                    sum2 = t + sum;
                    if (sum == 10)
                    {
                        trp9.Text = "";
                        pun6.Text = trp8.Text;
                    }
                    else
                    {
                        trp9.Text = Convert.ToString(sum2);
                        pun6.Text = Convert.ToString(sum2);
                    }
                }
                else
                {
                    if (!(tr18.Text == "/"))
                    {
                        p3 = Convert.ToInt32(trp8.Text);
                        sumt = p3 + sum;
                        trp9.Text = Convert.ToString(sumt);
                        pun6.Text = Convert.ToString(sumt);
                        tr18.Enabled = false;
                        if (ju7.Visible == true)
                        {
                            ty17.Enabled = true;
                            ty18.Enabled = true;
                        }
                        else
                        {
                            t19.Enabled = true;
                            t20.Enabled = true;
                        }
                    }
                    else
                    {
                        trp9.Text = "";
                    }
                }
            }
        }

        private void tr19_TextChanged(object sender, EventArgs e)
        {
            if (tr19.Text == "X")
            {
                tr21.Enabled = true;
                tr19.Enabled = false;
            }
            else
            {
                tr19.Enabled = false;
                tr21.Enabled = true;
            }
            if (tr18.Text == "/" && tr19.Text == "X")
            {
                int sum, sum2, p;
                sum = 20;
                p = Convert.ToInt32(trp8.Text);
                sum2 = sum + p;
                trp9.Text = Convert.ToString(sum2);
                pun6.Text = Convert.ToString(sum2);
                tr20.Enabled = true;
            }
            else if (tr18.Text == "/")
            {
                int p, p2, sum;
                p = Convert.ToInt32(tr19.Text);
                p2 = Convert.ToInt32(trp8.Text);
                sum = p2 + 10 + p;
                trp9.Text = Convert.ToString(sum);
                pun6.Text = Convert.ToString(sum);
            }
            if (tr15.Text == "X" && tr17.Text == "X" && !(tr19.Text == "X"))
            {
                int p, c, sum;
                p = Convert.ToInt32(tr19.Text);
                c = Convert.ToInt32(trp7.Text);
                sum = 20 + p + c;
                trp8.Text = Convert.ToString(sum);
                pun6.Text = Convert.ToString(sum);
            }
            if (tr15.Text == "X" && tr17.Text == "X" && tr19.Text == "X")
            {
                int sum, p;
                p = Convert.ToInt32(trp7.Text);
                sum = 30 + p;
                trp8.Text = Convert.ToString(sum);
                pun6.Text = Convert.ToString(sum);
            }
        }

        private void tr20_TextChanged(object sender, EventArgs e)
        {
            if (tr20.Text == "X")
            {
                tr21.Enabled = true;
                tr20.Enabled = false;
                trp10.Text = "";
            }
            else if (tr20.Text == "/")
            {
                tr20.Enabled = false;
                tr21.Enabled = true;
            }
            else
            {
                if (!(tr19.Text == "X"))
                {
                    int p1, p2, p3, sum, sumt;
                    p1 = Convert.ToInt32(tr19.Text);
                    p2 = Convert.ToInt32(tr20.Text);
                    sum = p1 + p2;
                    if (sum == 10)
                    {
                        tr20.Text = "/";
                        tr20.Enabled = false;
                        trp10.Text = "";
                        tr21.Enabled = true;
                    }
                    if (sum > 10)
                    {
                        MessageBox.Show("La suma no puede ser mayor a 10");
                        tr17.Enabled = true;
                        tr17.Text = "";
                        tr18.Text = "";
                    }
                    if (tr18.Text == "X")
                    {
                        int sum1, p, t, sum2;
                        p = Convert.ToInt32(trp8.Text);
                        sum1 = 10 + sum + p;
                        trp9.Text = Convert.ToString(sum1);
                        pun6.Text = Convert.ToString(sum1);
                        tr20.Enabled = false;
                        t = Convert.ToInt32(trp9.Text);
                        sum2 = t + sum;
                        if (sum == 10)
                        {
                            trp10.Text = "";
                            pun6.Text = trp9.Text;
                        }
                        else
                        {
                            trp10.Text = Convert.ToString(sum2);
                            pun6.Text = Convert.ToString(sum2);
                            tr21.Enabled = false;
                            if (ju7.Visible == true)
                            {
                                ty19.Enabled = true;
                                ty20.Enabled = true;
                            }
                            else
                            {
                                MessageBox.Show("Fin del juego");
                            }

                        }
                    }
                    else
                    {
                        if (!(tr20.Text == "/"))
                        {
                            tr21.Enabled = false;
                            p3 = Convert.ToInt32(trp9.Text);
                            sumt = p3 + sum;
                            trp10.Text = Convert.ToString(sumt);
                            pun6.Text = Convert.ToString(sumt);
                            tr19.Enabled = false;
                            tr20.Enabled = false;

                            if (ju7.Visible == true)
                            {
                                ty19.Enabled = true;
                                ty20.Enabled = true;
                            }
                            else
                            {
                                MessageBox.Show("Fin del juego");
                            }
                        }
                        else
                        {
                            trp10.Text = "";
                            tr21.Enabled = true;
                        }
                    }
                }
                else
                {
                    tr20.Enabled = false;
                }
            }
            if (tr17.Text == "X" && tr19.Text == "X" && tr20.Text == "X")
            {
                int sum, p;
                p = Convert.ToInt32(trp8.Text);
                sum = 30 + p;
                trp9.Text = Convert.ToString(sum);
                pun6.Text = Convert.ToString(sum);
            }
            else if (tr17.Text == "X" && tr19.Text == "X" && !(tr20.Text == "X"))
            {
                int sum, p, y;
                y = Convert.ToInt32(tr20.Text);
                p = Convert.ToInt32(trp8.Text);
                sum = 20 + p + y;
                trp9.Text = Convert.ToString(sum);
                pun6.Text = Convert.ToString(sum);
            }
        }

        private void tr21_TextChanged(object sender, EventArgs e)
        {
            int p, sum, pp;
            if (tr19.Text == "X" && tr20.Text == "X" && tr21.Text == "X")
            {
                p = Convert.ToInt32(trp9.Text);
                sum = p + 30;
                trp10.Text = Convert.ToString(sum);
                pun6.Text = Convert.ToString(sum);
                tr21.Enabled = false;
                if (ju7.Visible == true)
                {
                    ty19.Enabled = true;
                    ty20.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Fin del juego");
                }
            }
            if (tr20.Text == "/")
            {
                if (tr21.Text == "X")
                {
                    p = Convert.ToInt32(trp9.Text);
                    sum = p + 20;
                    trp10.Text = Convert.ToString(sum);
                    pun6.Text = Convert.ToString(sum);
                    tr21.Enabled = false;
                    if (ju7.Visible == true)
                    {
                        ty19.Enabled = true;
                        ty20.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Fin del juego");
                    }
                }
                else
                {
                    p = Convert.ToInt32(trp9.Text);
                    pp = Convert.ToInt32(tr21.Text);
                    sum = p + 10 + pp;
                    trp10.Text = Convert.ToString(sum);
                    pun6.Text = Convert.ToString(sum);
                    tr21.Enabled = false;
                    if (ju7.Visible == true)
                    {
                        ty19.Enabled = true;
                        ty20.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Fin del juego");
                    }
                }

            }
            if (tr19.Text == "X" && !(tr20.Text == "X"))
            {
                int c, p1, sump, sumpp, d;
                c = Convert.ToInt32(tr20.Text);
                p1 = Convert.ToInt32(tr21.Text);
                d = Convert.ToInt32(trp9.Text);
                sump = c + p1;
                if (sump > 10)
                {
                    MessageBox.Show("la suma no puede ser mayor a 10");
                    tr20.Enabled = true;
                    tr20.Text = "";
                    tr21.Enabled = true;
                    tr21.Text = "";
                }
                else
                {
                    sumpp = sump + 10 + d;
                    trp10.Text = Convert.ToString(sumpp);
                    pun6.Text = Convert.ToString(sumpp);
                    tr21.Enabled = false;
                    if (ju7.Visible == true)
                    {
                        ty19.Enabled = true;
                        ty20.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Fin del juego");
                    }
                }
            }
        }
        ////////
        private void ty1_TextChanged(object sender, EventArgs e)
        {
            if (ty1.Text == "X")
            {
                ty2.Text = "X";
                ty1.Enabled = false;
                ty2.Enabled = false;
                if (ju8.Visible == true)
                {
                    tu1.Enabled = true;
                    tu2.Enabled = true;
                }
                else
                {
                    t3.Enabled = true;
                    t4.Enabled = true;
                }
            }
            else
            {
                ty1.Enabled = false;
            }
        }

        private void ty2_TextChanged(object sender, EventArgs e)
        {
            if (!(ty1.Text == "X") && !(ty2.Text == "X") && !(ty2.Text == "/"))
            {
                int p1, p2, sum;
                p1 = Convert.ToInt32(ty1.Text);
                p2 = Convert.ToInt32(ty2.Text);
                sum = p1 + p2;
                if (sum == 10)
                {
                    ty2.Text = "/";
                    ty2.Enabled = false;
                    typ1.Text = "";
                    if (ju8.Visible == true)
                    {
                        tu1.Enabled = true;
                        tu2.Enabled = true;
                    }
                    else
                    {
                        t3.Enabled = true;
                        t4.Enabled = true;
                    }
                }
                if (sum > 10)
                {
                    MessageBox.Show("La suma no puede ser mayor a 10");
                    ty1.Enabled = true;
                    ty1.Text = "";
                    ty2.Text = "";
                }
                else
                {
                    if (!(ty2.Text == "/"))
                    {
                        typ1.Text = Convert.ToString(sum);
                        pun7.Text = Convert.ToString(sum);
                        ty2.Enabled = false;
                        if (ju8.Visible == true)
                        {
                            tu1.Enabled = true;
                            tu2.Enabled = true;
                        }
                        else
                        {
                            t3.Enabled = true;
                            t4.Enabled = true;
                        }
                    }
                    else
                    {
                        typ1.Text = "";
                    }
                }
            }
        }

        private void ty3_TextChanged(object sender, EventArgs e)
        {
            int p, sum;
            if (ty3.Text == "X")
            {
                ty4.Text = "X";
                ty3.Enabled = false;
                ty4.Enabled = false;
                if (ju8.Visible == true)
                {
                    tu3.Enabled = true;
                    tu4.Enabled = true;
                }
                else
                {
                    t5.Enabled = true;
                    t6.Enabled = true;
                }
            }
            else
            {
                ty3.Enabled = false;
                if (ju8.Enabled == true)
                {
                    tu5.Enabled = false;
                }
                else
                {
                    t5.Enabled = true;
                    t6.Enabled = true;
                }
            }
            if (ty2.Text == "/" && ty3.Text == "X")
            {
                sum = 20;
                typ1.Text = Convert.ToString(sum);
                pun7.Text = Convert.ToString(sum);
            }
            else if (ty2.Text == "/")
            {
                p = Convert.ToInt32(ty3.Text);
                sum = 10 + p;
                typ1.Text = Convert.ToString(sum);
                pun7.Text = Convert.ToString(sum);
                ty4.Enabled = true;
            }
        }

        private void ty4_TextChanged(object sender, EventArgs e)
        {
            if (!(ty3.Text == "X") && !(ty4.Text == "X") && !(ty4.Text == "/"))
            {
                int p1, p2, p3, sum, sumt;
                p1 = Convert.ToInt32(ty3.Text);
                p2 = Convert.ToInt32(ty4.Text);
                sum = p1 + p2;
                if (sum == 10)
                {
                    ty4.Text = "/";
                    ty4.Enabled = false;
                    ty3.Enabled = false;
                    typ2.Text = "";
                    if (ju8.Visible == true)
                    {
                        tu3.Enabled = true;
                        tu4.Enabled = true;
                    }
                    else
                    {
                        t5.Enabled = true;
                        t6.Enabled = true;
                    }
                }
                if (sum > 10)
                {
                    MessageBox.Show("La suma no puede ser mayor a 10");
                    ty3.Enabled = true;
                    ty3.Text = "";
                    ty4.Text = "";
                }
                if (ty2.Text == "X" && !(ty4.Text == "X"))
                {
                    int sumq;
                    sumt = 10 + sum;
                    typ1.Text = Convert.ToString(sumt);
                    sumq = Convert.ToInt32(typ1.Text) + sum;
                    if (sum == 10)
                    {
                        typ2.Text = "";
                        pun7.Text = typ1.Text;
                    }
                    else
                    {
                        typ2.Text = Convert.ToString(sumq);
                        pun7.Text = Convert.ToString(sumq);
                    }
                    ty4.Enabled = false;
                    if (ju8.Visible == true)
                    {
                        tu3.Enabled = true;
                        tu4.Enabled = true;
                    }
                    else
                    {
                        t5.Enabled = true;
                        t6.Enabled = true;
                    }
                }
                else
                {
                    if (!(ty4.Text == "/"))
                    {
                        p3 = Convert.ToInt32(typ1.Text);
                        sumt = p3 + sum;
                        typ2.Text = Convert.ToString(sumt);
                        pun7.Text = Convert.ToString(sumt);
                        ty4.Enabled = false;
                        if (ju8.Visible == true)
                        {
                            tu3.Enabled = true;
                            tu4.Enabled = true;
                        }
                        else
                        {
                            t5.Enabled = true;
                            t6.Enabled = true;
                        }
                    }
                    else
                    {
                        typ2.Text = "";
                    }
                }
            }
        }

        private void ty5_TextChanged(object sender, EventArgs e)
        {
            if (ty5.Text == "X")
            {
                ty6.Text = "X";
                ty5.Enabled = false;
                ty6.Enabled = false;
                if (ju8.Visible == true)
                {
                    tu5.Enabled = true;
                    tu6.Enabled = true;
                }
                else
                {
                    t7.Enabled = true;
                    t8.Enabled = true;
                }
            }
            else
            {
                ty5.Enabled = false;
            }
            if (ty4.Text == "/" && ty5.Text == "X")
            {
                int sum, sum2, p;
                sum = 20;
                p = Convert.ToInt32(typ1.Text);
                sum2 = sum + p;
                typ2.Text = Convert.ToString(sum2);
                pun7.Text = Convert.ToString(sum2);
            }
            else if (ty4.Text == "/")
            {
                int p, p2, sum;
                p = Convert.ToInt32(ty5.Text);
                p2 = Convert.ToInt32(typ1.Text);
                sum = p2 + 10 + p;
                typ2.Text = Convert.ToString(sum);
                pun7.Text = Convert.ToString(sum);
            }
            if (ty1.Text == "X" && ty3.Text == "X" && !(ty5.Text == "X"))
            {
                int p, sum;
                p = Convert.ToInt32(ty5.Text);
                sum = 20 + p;
                typ1.Text = Convert.ToString(sum);
                pun7.Text = Convert.ToString(sum);
            }
            else if (ty1.Text == "X" && ty3.Text == "X" && ty5.Text == "X")
            {
                int sum;
                sum = 30;
                typ1.Text = Convert.ToString(sum);
                pun7.Text = Convert.ToString(sum);
            }
        }

        private void ty6_TextChanged(object sender, EventArgs e)
        {
            if (!(ty5.Text == "X") && !(ty6.Text == "X") && !(ty6.Text == "/"))
            {
                int p1, p2, p3, sum, sumt;
                p1 = Convert.ToInt32(ty5.Text);
                p2 = Convert.ToInt32(ty6.Text);
                sum = p1 + p2;
                if (sum == 10)
                {
                    ty6.Text = "/";
                    ty6.Enabled = false;
                    ty5.Enabled = false;
                    typ3.Text = "";
                    if (ju8.Visible == true)
                    {
                        tu5.Enabled = true;
                        tu6.Enabled = true;
                    }
                    else
                    {
                        t7.Enabled = true;
                        t8.Enabled = true;
                    }
                }
                if (sum > 10)
                {
                    MessageBox.Show("La suma no puede ser mayor a 10");
                    ty5.Enabled = true;
                    ty5.Text = "";
                    ty6.Text = "";
                }
                if (ty4.Text == "X")
                {
                    int sum1, p, t, sum2;
                    p = Convert.ToInt32(typ1.Text);
                    sum1 = 10 + sum + p;
                    typ2.Text = Convert.ToString(sum1);
                    pun7.Text = Convert.ToString(sum1);
                    ty6.Enabled = false;


                    t = Convert.ToInt32(typ2.Text);
                    sum2 = t + sum;
                    if (sum == 10)
                    {
                        typ3.Text = "";
                        pun7.Text = typ2.Text;
                    }
                    else
                    {
                        typ3.Text = Convert.ToString(sum2);
                        pun7.Text = Convert.ToString(sum2);
                    }
                }
                else
                {
                    if (!(ty6.Text == "/"))
                    {
                        p3 = Convert.ToInt32(typ2.Text);
                        sumt = p3 + sum;
                        typ3.Text = Convert.ToString(sumt);
                        pun7.Text = Convert.ToString(sumt);
                        ty6.Enabled = false;
                        if (ju8.Visible == true)
                        {
                            tu5.Enabled = true;
                            tu6.Enabled = true;
                        }
                        else
                        {
                            t7.Enabled = true;
                            t8.Enabled = true;
                        }
                    }
                    else
                    {
                        typ3.Text = "";
                    }
                }
            }
        }

        private void ty7_TextChanged(object sender, EventArgs e)
        {
            if (ty7.Text == "X")
            {
                ty8.Text = "X";
                ty7.Enabled = false;
                ty8.Enabled = false;
                if (ju8.Visible == true)
                {
                    tu7.Enabled = true;
                    tu8.Enabled = true;
                }
                else
                {
                    t9.Enabled = true;
                    t10.Enabled = true;
                }

            }
            else
            {
                ty7.Enabled = false;
                if (ju8.Enabled == true)
                {
                    tu9.Enabled = false;
                }
                else
                {
                    t9.Enabled = true;
                }
            }
            if (ty6.Text == "/" && ty7.Text == "X")
            {
                int sum, sum2, p;
                sum = 20;
                p = Convert.ToInt32(typ2.Text);
                sum2 = sum + p;
                typ3.Text = Convert.ToString(sum2);
                pun7.Text = Convert.ToString(sum2);
            }
            else if (ty6.Text == "/")
            {
                int p, p2, sum;
                p = Convert.ToInt32(ty7.Text);
                p2 = Convert.ToInt32(typ2.Text);
                sum = p2 + 10 + p;
                typ3.Text = Convert.ToString(sum);
                pun7.Text = Convert.ToString(sum);
            }
            if (ty3.Text == "X" && ty5.Text == "X" && !(ty7.Text == "X"))
            {
                int p, c, sum;
                p = Convert.ToInt32(ty7.Text);
                c = Convert.ToInt32(typ1.Text);
                sum = 20 + p + c;
                typ2.Text = Convert.ToString(sum);
                pun7.Text = Convert.ToString(sum);
            }
            else if (ty3.Text == "X" && ty5.Text == "X" && ty7.Text == "X")
            {
                int sum, p;
                p = Convert.ToInt32(typ1.Text);
                sum = 30 + p;
                typ2.Text = Convert.ToString(sum);
                pun7.Text = Convert.ToString(sum);
            }
        }

        private void ty8_TextChanged(object sender, EventArgs e)
        {
            if (!(ty7.Text == "X") && !(ty8.Text == "X") && !(ty8.Text == "/"))
            {
                int p1, p2, p3, sum, sumt;
                p1 = Convert.ToInt32(ty7.Text);
                p2 = Convert.ToInt32(ty8.Text);
                sum = p1 + p2;
                if (sum == 10)
                {
                    ty8.Text = "/";
                    ty8.Enabled = false;
                    ty7.Enabled = false;
                    typ4.Text = "";
                    if (ju8.Visible == true)
                    {
                        tu7.Enabled = true;
                        tu8.Enabled = true;
                    }
                    else
                    {
                        t9.Enabled = true;
                        t10.Enabled = true;
                    }
                }
                if (sum > 10)
                {
                    MessageBox.Show("La suma no puede ser mayor a 10");
                    ty7.Enabled = true;
                    ty7.Text = "";
                    ty8.Text = "";
                }
                if (ty6.Text == "X")
                {
                    int sum1, p, t, sum2;
                    p = Convert.ToInt32(typ2.Text);
                    sum1 = 10 + sum + p;
                    typ3.Text = Convert.ToString(sum1);
                    pun7.Text = Convert.ToString(sum1);
                    ty8.Enabled = false;
                    t = Convert.ToInt32(typ3.Text);
                    sum2 = t + sum;
                    if (sum == 10)
                    {
                        typ4.Text = "";
                        pun7.Text = typ3.Text;
                    }
                    else
                    {
                        typ4.Text = Convert.ToString(sum2);
                        pun7.Text = Convert.ToString(sum2);
                    }
                }
                else
                {
                    if (!(ty8.Text == "/"))
                    {
                        p3 = Convert.ToInt32(typ3.Text);
                        sumt = p3 + sum;
                        typ4.Text = Convert.ToString(sumt);
                        pun7.Text = Convert.ToString(sumt);
                        ty8.Enabled = false;
                        if (ju8.Visible == true)
                        {
                            tu7.Enabled = true;
                            tu8.Enabled = true;
                        }
                        else
                        {
                            t9.Enabled = true;
                            t10.Enabled = true;
                        }
                    }
                    else
                    {
                        typ4.Text = "";
                    }
                }
            }
        }

        private void ty9_TextChanged(object sender, EventArgs e)
        {
            if (ty9.Text == "X")
            {
                ty10.Text = "X";
                ty9.Enabled = false;
                ty10.Enabled = false;
                if (ju8.Visible == true)
                {
                    tu9.Enabled = true;
                    tu10.Enabled = true;
                }
                else
                {
                    t11.Enabled = true;
                    t12.Enabled = true;
                }

            }
            else
            {
                ty9.Enabled = false;
            }
            if (ty8.Text == "/" && ty9.Text == "X")
            {
                int sum, sum2, p;
                sum = 20;
                p = Convert.ToInt32(typ3.Text);
                sum2 = sum + p;
                typ4.Text = Convert.ToString(sum2);
                pun7.Text = Convert.ToString(sum2);
            }
            else if (ty8.Text == "/")
            {
                int p, p2, sum;
                p = Convert.ToInt32(ty9.Text);
                p2 = Convert.ToInt32(typ3.Text);
                sum = p2 + 10 + p;
                typ4.Text = Convert.ToString(sum);
                pun7.Text = Convert.ToString(sum);
            }
            if (ty5.Text == "X" && ty7.Text == "X" && !(ty9.Text == "X"))
            {
                int p, c, sum;
                p = Convert.ToInt32(ty9.Text);
                c = Convert.ToInt32(typ2.Text);
                sum = 20 + p + c;
                typ3.Text = Convert.ToString(sum);
                pun7.Text = Convert.ToString(sum);
            }
            else if (ty5.Text == "X" && ty7.Text == "X" && ty9.Text == "X")
            {
                int sum, p;
                p = Convert.ToInt32(typ2.Text);
                sum = 30 + p;
                typ3.Text = Convert.ToString(sum);
                pun7.Text = Convert.ToString(sum);
            }
        }

        private void ty10_TextChanged(object sender, EventArgs e)
        {
            if (!(ty9.Text == "X") && !(ty10.Text == "X") && !(ty10.Text == "/"))
            {
                int p1, p2, p3, sum, sumt;
                p1 = Convert.ToInt32(ty9.Text);
                p2 = Convert.ToInt32(ty10.Text);
                sum = p1 + p2;
                if (sum == 10)
                {
                    ty10.Text = "/";
                    ty10.Enabled = false;
                    ty9.Enabled = false;
                    typ5.Text = "";
                    if (ju8.Visible == true)
                    {
                        tu9.Enabled = true;
                        tu10.Enabled = true;
                    }
                    else
                    {
                        t11.Enabled = true;
                        t12.Enabled = true;
                    }
                }
                if (sum > 10)
                {
                    MessageBox.Show("La suma no puede ser mayor a 10");
                    ty9.Enabled = true;
                    ty9.Text = "";
                    ty10.Text = "";
                }
                if (ty8.Text == "X")
                {
                    int sum1, p, t, sum2;
                    p = Convert.ToInt32(typ3.Text);
                    sum1 = 10 + sum + p;
                    typ4.Text = Convert.ToString(sum1);
                    pun7.Text = Convert.ToString(sum1);
                    ty10.Enabled = false;
                    t = Convert.ToInt32(typ4.Text);
                    sum2 = t + sum;
                    if (sum == 10)
                    {
                        typ5.Text = "";
                        pun7.Text = typ4.Text;
                    }
                    else
                    {
                        typ5.Text = Convert.ToString(sum2);
                        pun7.Text = Convert.ToString(sum2);
                    }
                }
                else
                {
                    if (!(ty10.Text == "/"))
                    {
                        p3 = Convert.ToInt32(typ4.Text);
                        sumt = p3 + sum;
                        typ5.Text = Convert.ToString(sumt);
                        pun7.Text = Convert.ToString(sumt);
                        ty10.Enabled = false;
                        if (ju8.Visible == true)
                        {
                            tu9.Enabled = true;
                            tu10.Enabled = true;
                        }
                        else
                        {
                            t11.Enabled = true;
                            t12.Enabled = true;
                        }
                    }
                    else
                    {
                        typ5.Text = "";
                    }
                }
            }
        }

        private void ty11_TextChanged(object sender, EventArgs e)
        {
            if (ty11.Text == "X")
            {
                ty12.Text = "X";
                ty11.Enabled = false;
                ty12.Enabled = false;
                if (ju8.Visible == true)
                {
                    tu11.Enabled = true;
                    tu12.Enabled = true;
                }
                else
                {
                    t13.Enabled = true;
                    t14.Enabled = true;
                }
            }
            else
            {
                ty11.Enabled = false;
            }
            if (ty10.Text == "/" && ty11.Text == "X")
            {
                int sum, sum2, p;
                sum = 20;
                p = Convert.ToInt32(typ4.Text);
                sum2 = sum + p;
                typ5.Text = Convert.ToString(sum2);
                pun7.Text = Convert.ToString(sum2);
            }
            else if (ty10.Text == "/")
            {
                int p, p2, sum;
                p = Convert.ToInt32(ty11.Text);
                p2 = Convert.ToInt32(typ4.Text);
                sum = p2 + 10 + p;
                typ5.Text = Convert.ToString(sum);
                pun7.Text = Convert.ToString(sum);
            }
            if (ty7.Text == "X" && ty9.Text == "X" && !(ty11.Text == "X"))
            {
                int p, c, sum;
                p = Convert.ToInt32(ty11.Text);
                c = Convert.ToInt32(typ3.Text);
                sum = 20 + p + c;
                typ4.Text = Convert.ToString(sum);
                pun7.Text = Convert.ToString(sum);
            }
            else if (ty7.Text == "X" && ty9.Text == "X" && ty11.Text == "X")
            {
                int sum, p;
                p = Convert.ToInt32(typ3.Text);
                sum = 30 + p;
                typ4.Text = Convert.ToString(sum);
                pun7.Text = Convert.ToString(sum);
            }
        }
        
        private void ty12_TextChanged(object sender, EventArgs e)
        {
            if (!(ty11.Text == "X") && !(ty12.Text == "X") && !(ty12.Text == "/"))
            {
                int p1, p2, p3, sum, sumt;
                p1 = Convert.ToInt32(ty11.Text);
                p2 = Convert.ToInt32(ty12.Text);
                sum = p1 + p2;
                if (sum == 10)
                {
                    ty12.Text = "/";
                    ty12.Enabled = false;
                    ty11.Enabled = false;
                    typ6.Text = "";
                    if (ju8.Visible == true)
                    {
                        tu11.Enabled = true;
                        tu12.Enabled = true;
                    }
                    else
                    {
                        t13.Enabled = true;
                        t14.Enabled = true;
                    }
                }
                if (sum > 10)
                {
                    MessageBox.Show("La suma no puede ser mayor a 10");
                    ty11.Enabled = true;
                    ty11.Text = "";
                    ty12.Text = "";
                }
                if (ty10.Text == "X")
                {
                    int sum1, p, t, sum2;
                    p = Convert.ToInt32(typ4.Text);
                    sum1 = 10 + sum + p;
                    typ5.Text = Convert.ToString(sum1);
                    pun7.Text = Convert.ToString(sum1);
                    ty12.Enabled = false;
                    t = Convert.ToInt32(typ5.Text);
                    sum2 = t + sum;
                    if (sum == 10)
                    {
                        typ6.Text = "";
                        pun7.Text = typ5.Text;
                    }
                    else
                    {
                        typ6.Text = Convert.ToString(sum2);
                        pun7.Text = Convert.ToString(sum2);
                    }
                }
                else
                {
                    if (!(ty12.Text == "/"))
                    {
                        p3 = Convert.ToInt32(typ5.Text);
                        sumt = p3 + sum;
                        typ6.Text = Convert.ToString(sumt);
                        pun7.Text = Convert.ToString(sumt);
                        ty12.Enabled = false;
                        if (ju8.Visible == true)
                        {
                            tu11.Enabled = true;
                            tu12.Enabled = true;
                        }
                        else
                        {
                            t13.Enabled = true;
                            t14.Enabled = true;
                        }
                    }
                    else
                    {
                        typ6.Text = "";
                    }
                }
            }
        }

        private void ty13_TextChanged(object sender, EventArgs e)
        {
            if (ty13.Text == "X")
            {
                ty14.Text = "X";
                ty13.Enabled = false;
                ty14.Enabled = false;
                if (ju8.Visible == true)
                {
                    tu13.Enabled = true;
                    tu14.Enabled = true;
                }
                else
                {
                    t15.Enabled = true;
                    t16.Enabled = true;
                }
            }
            else
            {
                ty13.Enabled = false;
            }
            if (ty12.Text == "/" && ty13.Text == "X")
            {
                int sum, sum2, p;
                sum = 20;
                p = Convert.ToInt32(typ5.Text);
                sum2 = sum + p;
                typ6.Text = Convert.ToString(sum2);
                pun7.Text = Convert.ToString(sum2);
            }
            else if (ty12.Text == "/")
            {
                int p, p2, sum;
                p = Convert.ToInt32(ty13.Text);
                p2 = Convert.ToInt32(typ5.Text);
                sum = p2 + 10 + p;
                typ6.Text = Convert.ToString(sum);
                pun7.Text = Convert.ToString(sum);
            }
            if (ty9.Text == "X" && ty11.Text == "X" && !(ty13.Text == "X"))
            {
                int p, c, sum;
                p = Convert.ToInt32(ty13.Text);
                c = Convert.ToInt32(typ4.Text);
                sum = 20 + p + c;
                typ5.Text = Convert.ToString(sum);
                pun7.Text = Convert.ToString(sum);
            }
            else if (ty9.Text == "X" && ty11.Text == "X" && ty13.Text == "X")
            {
                int sum, p;
                p = Convert.ToInt32(typ4.Text);
                sum = 30 + p;
                typ5.Text = Convert.ToString(sum);
                pun7.Text = Convert.ToString(sum);
            }
        }

        private void ty14_TextChanged(object sender, EventArgs e)
        {
            if (!(ty13.Text == "X") && !(ty14.Text == "X") && !(ty14.Text == "/"))
            {
                int p1, p2, p3, sum, sumt;
                p1 = Convert.ToInt32(ty13.Text);
                p2 = Convert.ToInt32(ty14.Text);
                sum = p1 + p2;
                if (sum == 10)
                {
                    ty14.Text = "/";
                    ty14.Enabled = false;
                    ty13.Enabled = false;
                    typ7.Text = "";
                    if (ju8.Visible == true)
                    {
                        tu13.Enabled = true;
                        tu14.Enabled = true;
                    }
                    else
                    {
                        t15.Enabled = true;
                        t16.Enabled = true;
                    }
                }
                if (sum > 10)
                {
                    MessageBox.Show("La suma no puede ser mayor a 10");
                    ty13.Enabled = true;
                    ty13.Text = "";
                    ty14.Text = "";
                }
                if (ty12.Text == "X")
                {
                    int sum1, p, t, sum2;
                    p = Convert.ToInt32(typ5.Text);
                    sum1 = 10 + sum + p;
                    typ6.Text = Convert.ToString(sum1);
                    pun7.Text = Convert.ToString(sum1);
                    ty14.Enabled = false;
                    if (ju8.Visible == true)
                    {
                        tu16.Enabled = false;
                    }
                    else
                    {
                        t16.Enabled = true;
                    }
                    t = Convert.ToInt32(typ6.Text);
                    sum2 = t + sum;
                    if (sum == 10)
                    {
                        typ7.Text = "";
                        pun7.Text = typ6.Text;
                    }
                    else
                    {
                        typ7.Text = Convert.ToString(sum2);
                        pun7.Text = Convert.ToString(sum2);
                    }
                }
                else
                {
                    if (!(ty14.Text == "/"))
                    {
                        p3 = Convert.ToInt32(typ6.Text);
                        sumt = p3 + sum;
                        typ7.Text = Convert.ToString(sumt);
                        pun7.Text = Convert.ToString(sumt);
                        ty14.Enabled = false;
                        if (ju8.Visible == true)
                        {
                            tu13.Enabled = true;
                            tu14.Enabled = true;
                        }
                        else
                        {
                            t15.Enabled = true;
                            t16.Enabled = true;
                        }
                    }
                    else
                    {
                        typ7.Text = "";
                    }
                }
            }
        }

        private void ty15_TextChanged(object sender, EventArgs e)
        {
            if (ty15.Text == "X")
            {
                ty16.Text = "X";
                ty15.Enabled = false;
                ty16.Enabled = false;
                if (ju8.Visible == true)
                {
                    tu15.Enabled = true;
                    tu16.Enabled = true;
                }
                else
                {
                    t17.Enabled = true;
                    t18.Enabled = true;
                }
            }
            else
            {
                ty15.Enabled = false;
            }
            if (ty14.Text == "/" && ty15.Text == "X")
            {
                int sum, sum2, p;
                sum = 20;
                p = Convert.ToInt32(typ6.Text);
                sum2 = sum + p;
                typ7.Text = Convert.ToString(sum2);
                pun7.Text = Convert.ToString(sum2);
            }
            else if (ty14.Text == "/")
            {
                int p, p2, sum;
                p = Convert.ToInt32(ty15.Text);
                p2 = Convert.ToInt32(typ6.Text);
                sum = p2 + 10 + p;
                typ7.Text = Convert.ToString(sum);
                pun7.Text = Convert.ToString(sum);
            }
            if (ty11.Text == "X" && ty13.Text == "X" && !(ty15.Text == "X"))
            {
                int p, c, sum;
                p = Convert.ToInt32(ty15.Text);
                c = Convert.ToInt32(typ5.Text);
                sum = 20 + p + c;
                typ6.Text = Convert.ToString(sum);
                pun7.Text = Convert.ToString(sum);
            }
            else if (ty11.Text == "X" && ty13.Text == "X" && ty15.Text == "X")
            {
                int sum, p;
                p = Convert.ToInt32(typ5.Text);
                sum = 30 + p;
                typ6.Text = Convert.ToString(sum);
                pun7.Text = Convert.ToString(sum);
            }
        }

        private void ty16_TextChanged(object sender, EventArgs e)
        {
            if (!(ty15.Text == "X") && !(ty16.Text == "X") && !(ty16.Text == "/"))
            {
                int p1, p2, p3, sum, sumt;
                p1 = Convert.ToInt32(ty15.Text);
                p2 = Convert.ToInt32(ty16.Text);
                sum = p1 + p2;
                if (sum == 10)
                {
                    ty16.Text = "/";
                    ty16.Enabled = false;
                    ty15.Enabled = false;
                    typ8.Text = "";
                    if (ju8.Visible == true)
                    {
                        tu15.Enabled = true;
                        tu16.Enabled = true;
                    }
                    else
                    {
                        t17.Enabled = true;
                        t18.Enabled = true;
                    }
                }
                if (sum > 10)
                {
                    MessageBox.Show("La suma no puede ser mayor a 10");
                    ty15.Enabled = true;
                    ty15.Text = "";
                    ty16.Text = "";
                }
                if (ty14.Text == "X")
                {
                    int sum1, p, t, sum2;
                    p = Convert.ToInt32(typ6.Text);
                    sum1 = 10 + sum + p;
                    typ7.Text = Convert.ToString(sum1);
                    pun7.Text = Convert.ToString(sum1);
                    ty16.Enabled = false;
                    if (ju8.Visible == true)
                    {
                        tu18.Enabled = false;
                    }
                    else
                    {
                        t18.Enabled = true;
                    }
                    t = Convert.ToInt32(typ7.Text);
                    sum2 = t + sum;
                    if (sum == 10)
                    {
                        typ8.Text = "";
                        pun7.Text = typ7.Text;
                    }
                    else
                    {
                        typ8.Text = Convert.ToString(sum2);
                        pun7.Text = Convert.ToString(sum2);
                    }
                }
                else
                {
                    if (!(ty16.Text == "/"))
                    {
                        p3 = Convert.ToInt32(typ7.Text);
                        sumt = p3 + sum;
                        typ8.Text = Convert.ToString(sumt);
                        pun7.Text = Convert.ToString(sumt);
                        ty16.Enabled = false;
                        if (ju8.Visible == true)
                        {
                            tu15.Enabled = true;
                            tu16.Enabled = true;
                        }
                        else
                        {
                            t17.Enabled = true;
                            t18.Enabled = true;
                        }
                    }
                    else
                    {
                        typ8.Text = "";
                    }
                }
            }
        }

        private void ty17_TextChanged(object sender, EventArgs e)
        {
            if (ty17.Text == "X")
            {
                ty18.Text = "X";
                ty17.Enabled = false;
                ty18.Enabled = false;
                if (ju8.Visible == true)
                {
                    tu17.Enabled = true;
                    tu18.Enabled = true;
                }
                else
                {
                    t19.Enabled = true;
                    t20.Enabled = true;
                }
            }
            else
            {
                ty17.Enabled = false;
                if (ju8.Enabled == true)
                {
                    tu19.Enabled = false;
                }
                else
                {
                    t19.Enabled = true;
                }
            }
            if (ty16.Text == "/" && ty17.Text == "X")
            {

                int sum, sum2, p;
                sum = 20;
                p = Convert.ToInt32(typ7.Text);
                sum2 = sum + p;
                typ8.Text = Convert.ToString(sum2);
                pun7.Text = Convert.ToString(sum2);
            }
            else if (ty16.Text == "/")
            {
                int p, p2, sum;
                p = Convert.ToInt32(ty17.Text);
                p2 = Convert.ToInt32(typ7.Text);
                sum = p2 + 10 + p;
                typ8.Text = Convert.ToString(sum);
                pun7.Text = Convert.ToString(sum);
            }
            if (ty13.Text == "X" && ty15.Text == "X" && !(ty17.Text == "X"))
            {
                int p, c, sum;
                p = Convert.ToInt32(ty17.Text);
                c = Convert.ToInt32(typ6.Text);
                sum = 20 + p + c;
                typ7.Text = Convert.ToString(sum);
                pun7.Text = Convert.ToString(sum);
            }
            else if (ty13.Text == "X" && ty15.Text == "X" && ty17.Text == "X")
            {
                int sum, p;
                p = Convert.ToInt32(typ6.Text);
                sum = 30 + p;
                typ7.Text = Convert.ToString(sum);
                pun7.Text = Convert.ToString(sum);
            }
        }

        private void ty18_TextChanged(object sender, EventArgs e)
        {
            if (!(ty17.Text == "X") && !(ty18.Text == "X") && !(ty18.Text == "/"))
            {
                int p1, p2, p3, sum, sumt;
                p1 = Convert.ToInt32(ty17.Text);
                p2 = Convert.ToInt32(ty18.Text);
                sum = p1 + p2;
                if (sum == 10)
                {
                    ty18.Text = "/";
                    ty18.Enabled = false;
                    ty17.Enabled = false;
                    typ9.Text = "";
                    if (ju8.Visible == true)
                    {
                        tu17.Enabled = true;
                        tu18.Enabled = true;
                    }
                    else
                    {
                        t19.Enabled = true;
                        t20.Enabled = true;
                    }
                }
                if (sum > 10)
                {
                    MessageBox.Show("La suma no puede ser mayor a 10");
                    ty17.Enabled = true;
                    ty17.Text = "";
                    ty18.Text = "";
                }
                if (ty16.Text == "X")
                {
                    int sum1, p, t, sum2;
                    p = Convert.ToInt32(typ7.Text);
                    sum1 = 10 + sum + p;
                    typ8.Text = Convert.ToString(sum1);
                    pun7.Text = Convert.ToString(sum1);
                    ty18.Enabled = false;
                    if (ju8.Visible == true)
                    {
                        ty20.Enabled = false;
                    }
                    else
                    {
                        t20.Enabled = true;
                    }
                    t = Convert.ToInt32(typ8.Text);
                    sum2 = t + sum;
                    if (sum == 10)
                    {
                        typ9.Text = "";
                        pun7.Text = typ8.Text;
                    }
                    else
                    {
                        typ9.Text = Convert.ToString(sum2);
                        pun7.Text = Convert.ToString(sum2);
                    }
                }
                else
                {
                    if (!(ty18.Text == "/"))
                    {
                        p3 = Convert.ToInt32(typ8.Text);
                        sumt = p3 + sum;
                        typ9.Text = Convert.ToString(sumt);
                        pun7.Text = Convert.ToString(sumt);
                        ty18.Enabled = false;
                        if (ju8.Visible == true)
                        {
                            tu17.Enabled = true;
                            tu18.Enabled = true;
                        }
                        else
                        {
                            t19.Enabled = true;
                            t20.Enabled = true;
                        }
                    }
                    else
                    {
                        typ9.Text = "";
                    }
                }
            }
        }

        private void ty19_TextChanged(object sender, EventArgs e)
        {
            if (ty19.Text == "X")
            {
                ty21.Enabled = true;
                ty19.Enabled = false;
            }
            else
            {
                ty19.Enabled = false;
                ty21.Enabled = true;
            }
            if (ty18.Text == "/" && ty19.Text == "X")
            {
                int sum, sum2, p;
                sum = 20;
                p = Convert.ToInt32(typ8.Text);
                sum2 = sum + p;
                typ9.Text = Convert.ToString(sum2);
                pun7.Text = Convert.ToString(sum2);
                ty20.Enabled = true;
            }
            else if (ty18.Text == "/")
            {
                int p, p2, sum;
                p = Convert.ToInt32(ty19.Text);
                p2 = Convert.ToInt32(typ8.Text);
                sum = p2 + 10 + p;
                typ9.Text = Convert.ToString(sum);
                pun7.Text = Convert.ToString(sum);
            }
            if (ty15.Text == "X" && ty17.Text == "X" && !(ty19.Text == "X"))
            {
                int p, c, sum;
                p = Convert.ToInt32(ty19.Text);
                c = Convert.ToInt32(typ7.Text);
                sum = 20 + p + c;
                typ8.Text = Convert.ToString(sum);
                pun7.Text = Convert.ToString(sum);
            }
            if (ty15.Text == "X" && ty17.Text == "X" && ty19.Text == "X")
            {
                int sum, p;
                p = Convert.ToInt32(typ7.Text);
                sum = 30 + p;
                typ8.Text = Convert.ToString(sum);
                pun7.Text = Convert.ToString(sum);
            }
        }

        private void ty20_TextChanged(object sender, EventArgs e)
        {
            if (ty20.Text == "X")
            {
                ty21.Enabled = true;
                ty20.Enabled = false;
                typ10.Text = "";
            }
            else if (ty20.Text == "/")
            {
                ty20.Enabled = false;
                ty21.Enabled = true;
            }
            else
            {
                if (!(ty19.Text == "X"))
                {
                    int p1, p2, p3, sum, sumt;
                    p1 = Convert.ToInt32(ty19.Text);
                    p2 = Convert.ToInt32(ty20.Text);
                    sum = p1 + p2;
                    if (sum == 10)
                    {
                        ty20.Text = "/";
                        ty20.Enabled = false;
                        typ10.Text = "";
                        ty21.Enabled = true;
                    }
                    if (sum > 10)
                    {
                        MessageBox.Show("La suma no puede ser mayor a 10");
                        ty17.Enabled = true;
                        ty17.Text = "";
                        ty18.Text = "";
                    }
                    if (ty18.Text == "X")
                    {
                        int sum1, p, t, sum2;
                        p = Convert.ToInt32(typ8.Text);
                        sum1 = 10 + sum + p;
                        typ9.Text = Convert.ToString(sum1);
                        pun7.Text = Convert.ToString(sum1);
                        ty20.Enabled = false;
                        t = Convert.ToInt32(typ9.Text);
                        sum2 = t + sum;
                        if (sum == 10)
                        {
                            typ10.Text = "";
                            pun7.Text = typ9.Text;
                        }
                        else
                        {
                            typ10.Text = Convert.ToString(sum2);
                            pun7.Text = Convert.ToString(sum2);
                            ty21.Enabled = false;
                            if (ju8.Visible == true)
                            {
                                tu19.Enabled = true;
                                tu20.Enabled = true;
                            }
                            else
                            {
                                MessageBox.Show("Fin del juego");
                            }

                        }
                    }
                    else
                    {
                        if (!(ty20.Text == "/"))
                        {
                            ty21.Enabled = false;
                            p3 = Convert.ToInt32(typ9.Text);
                            sumt = p3 + sum;
                            typ10.Text = Convert.ToString(sumt);
                            pun7.Text = Convert.ToString(sumt);
                            ty19.Enabled = false;
                            ty20.Enabled = false;

                            if (ju8.Visible == true)
                            {
                                tu19.Enabled = true;
                                tu20.Enabled = true;
                            }
                            else
                            {
                                MessageBox.Show("Fin del juego");
                            }
                        }
                        else
                        {
                            typ10.Text = "";
                            ty21.Enabled = true;
                        }
                    }
                }
                else
                {
                    ty20.Enabled = false;
                }
            }
            if (ty17.Text == "X" && ty19.Text == "X" && ty20.Text == "X")
            {
                int sum, p;
                p = Convert.ToInt32(typ8.Text);
                sum = 30 + p;
                typ9.Text = Convert.ToString(sum);
                pun7.Text = Convert.ToString(sum);
            }
            else if (ty17.Text == "X" && ty19.Text == "X" && !(ty20.Text == "X"))
            {
                int sum, p, y;
                y = Convert.ToInt32(ty20.Text);
                p = Convert.ToInt32(typ8.Text);
                sum = 20 + p + y;
                typ9.Text = Convert.ToString(sum);
                pun7.Text = Convert.ToString(sum);
            }
        }

        private void ty21_TextChanged(object sender, EventArgs e)
        {
            int p, sum, pp;
            if (ty19.Text == "X" && ty20.Text == "X" && ty21.Text == "X")
            {
                p = Convert.ToInt32(typ9.Text);
                sum = p + 30;
                typ10.Text = Convert.ToString(sum);
                pun7.Text = Convert.ToString(sum);
                ty21.Enabled = false;
                if (ju8.Visible == true)
                {
                    tu19.Enabled = true;
                    tu20.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Fin del juego");
                }
            }
            if (ty20.Text == "/")
            {
                if (ty21.Text == "X")
                {
                    p = Convert.ToInt32(typ9.Text);
                    sum = p + 20;
                    typ10.Text = Convert.ToString(sum);
                    pun7.Text = Convert.ToString(sum);
                    ty21.Enabled = false;
                    if (ju8.Visible == true)
                    {
                        tu19.Enabled = true;
                        tu20.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Fin del juego");
                    }
                }
                else
                {
                    p = Convert.ToInt32(typ9.Text);
                    pp = Convert.ToInt32(ty21.Text);
                    sum = p + 10 + pp;
                    typ10.Text = Convert.ToString(sum);
                    pun7.Text = Convert.ToString(sum);
                    ty21.Enabled = false;
                    if (ju8.Visible == true)
                    {
                        tu19.Enabled = true;
                        tu20.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Fin del juego");
                    }
                }

            }
            if (ty19.Text == "X" && !(ty20.Text == "X"))
            {
                int c, p1, sump, sumpp, d;
                c = Convert.ToInt32(ty20.Text);
                p1 = Convert.ToInt32(ty21.Text);
                d = Convert.ToInt32(typ9.Text);
                sump = c + p1;
                if (sump > 10)
                {
                    MessageBox.Show("la suma no puede ser mayor a 10");
                    ty20.Enabled = true;
                    ty20.Text = "";
                    ty21.Enabled = true;
                    ty21.Text = "";
                }
                else
                {
                    sumpp = sump + 10 + d;
                    typ10.Text = Convert.ToString(sumpp);
                    pun7.Text = Convert.ToString(sumpp);
                    ty21.Enabled = false;
                    if (ju8.Visible == true)
                    {
                        tu19.Enabled = true;
                        tu20.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Fin del juego");
                    }
                }
            }
        }
        ////////
        private void tu1_TextChanged(object sender, EventArgs e)
        {
            if (tu1.Text == "X")
            {
                tu2.Text = "X";
                tu1.Enabled = false;
                tu2.Enabled = false;
                t3.Enabled = true;
                t4.Enabled = true;
            }
            else
            {
                tu1.Enabled = false;
            }
        }

        private void tu2_TextChanged(object sender, EventArgs e)
        {
            if (!(tu1.Text == "X") && !(tu2.Text == "X") && !(tu2.Text == "/"))
            {
                int p1, p2, sum;
                p1 = Convert.ToInt32(tu1.Text);
                p2 = Convert.ToInt32(tu2.Text);
                sum = p1 + p2;
                if (sum == 10)
                {
                    tu2.Text = "/";
                    tu2.Enabled = false;
                    tup1.Text = "";
                    t3.Enabled = true;
                    t4.Enabled = true;
                    
                }
                if (sum > 10)
                {
                    MessageBox.Show("La suma no puede ser mayor a 10");
                    tu1.Enabled = true;
                    tu1.Text = "";
                    tu2.Text = "";
                }
                else
                {
                    if (!(tu2.Text == "/"))
                    {
                        tup1.Text = Convert.ToString(sum);
                        pun8.Text = Convert.ToString(sum);
                        tu2.Enabled = false;
                        t3.Enabled = true;
                        t4.Enabled = true;
                    }
                    else
                    {
                        tup1.Text = "";
                    }
                }
            }
        }

        private void tu3_TextChanged(object sender, EventArgs e)
        {
            int p, sum;
            if (tu3.Text == "X")
            {
                tu4.Text = "X";
                tu3.Enabled = false;
                tu4.Enabled = false;
                t5.Enabled = true;
                t6.Enabled = true;
                
            }
            else
            {
                tu3.Enabled = false;
                t5.Enabled = true;
                t6.Enabled = true;

            }
            if (tu2.Text == "/" && tu3.Text == "X")
            {
                sum = 20;
                tup1.Text = Convert.ToString(sum);
                pun8.Text = Convert.ToString(sum);
            }
            else if (tu2.Text == "/")
            {
                p = Convert.ToInt32(tu3.Text);
                sum = 10 + p;
                tup1.Text = Convert.ToString(sum);
                pun8.Text = Convert.ToString(sum);
                tu4.Enabled = true;
            }
        }

        private void tu4_TextChanged(object sender, EventArgs e)
        {
            if (!(tu3.Text == "X") && !(tu4.Text == "X") && !(tu4.Text == "/"))
            {
                int p1, p2, p3, sum, sumt;
                p1 = Convert.ToInt32(tu3.Text);
                p2 = Convert.ToInt32(tu4.Text);
                sum = p1 + p2;
                if (sum == 10)
                {
                    tu4.Text = "/";
                    tu4.Enabled = false;
                    tu3.Enabled = false;
                    tup2.Text = "";
                    t5.Enabled = true;
                    t6.Enabled = true;
                }
                if (sum > 10)
                {
                    MessageBox.Show("La suma no puede ser mayor a 10");
                    tu3.Enabled = true;
                    tu3.Text = "";
                    tu4.Text = "";
                }
                if (tu2.Text == "X" && !(tu4.Text == "X"))
                {
                    int sumq;
                    sumt = 10 + sum;
                    tup1.Text = Convert.ToString(sumt);
                    sumq = Convert.ToInt32(tup1.Text) + sum;
                    if (sum == 10)
                    {
                        tup2.Text = "";
                        pun8.Text = tup1.Text;
                    }
                    else
                    {
                        tup2.Text = Convert.ToString(sumq);
                        pun8.Text = Convert.ToString(sumq);
                    }
                    tu4.Enabled = false;
                    t5.Enabled = true;
                    t6.Enabled = true;
                }
                else
                {
                    if (!(tu4.Text == "/"))
                    {
                        p3 = Convert.ToInt32(tup1.Text);
                        sumt = p3 + sum;
                        tup2.Text = Convert.ToString(sumt);
                        pun8.Text = Convert.ToString(sumt);
                        tu4.Enabled = false;
                        t5.Enabled = true;
                        t6.Enabled = true;

                    }
                    else
                    {
                        tup2.Text = "";
                    }
                }
            }
        }

        private void tu5_TextChanged(object sender, EventArgs e)
        {
            if (tu5.Text == "X")
            {
                tu6.Text = "X";
                tu5.Enabled = false;
                tu6.Enabled = false;
                t7.Enabled = true;
                t8.Enabled = true;
            }
            else
            {
                tu5.Enabled = false;
            }
            if (tu4.Text == "/" && tu5.Text == "X")
            {
                int sum, sum2, p;
                sum = 20;
                p = Convert.ToInt32(tup1.Text);
                sum2 = sum + p;
                tup2.Text = Convert.ToString(sum2);
                pun8.Text = Convert.ToString(sum2);
            }
            else if (tu4.Text == "/")
            {
                int p, p2, sum;
                p = Convert.ToInt32(tu5.Text);
                p2 = Convert.ToInt32(tup1.Text);
                sum = p2 + 10 + p;
                tup2.Text = Convert.ToString(sum);
                pun8.Text = Convert.ToString(sum);
            }
            if (tu1.Text == "X" && tu3.Text == "X" && !(tu5.Text == "X"))
            {
                int p, sum;
                p = Convert.ToInt32(tu5.Text);
                sum = 20 + p;
                tup1.Text = Convert.ToString(sum);
                pun8.Text = Convert.ToString(sum);
            }
            else if (tu1.Text == "X" && tu3.Text == "X" && tu5.Text == "X")
            {
                int sum;
                sum = 30;
                tup1.Text = Convert.ToString(sum);
                pun8.Text = Convert.ToString(sum);
            }
        }

        private void tu6_TextChanged(object sender, EventArgs e)
        {
            if (!(tu5.Text == "X") && !(tu6.Text == "X") && !(tu6.Text == "/"))
            {
                int p1, p2, p3, sum, sumt;
                p1 = Convert.ToInt32(tu5.Text);
                p2 = Convert.ToInt32(tu6.Text);
                sum = p1 + p2;
                if (sum == 10)
                {
                    tu6.Text = "/";
                    tu6.Enabled = false;
                    tu5.Enabled = false;
                    tup3.Text = "";
                    t7.Enabled = true;
                    t8.Enabled = true;
                }
                if (sum > 10)
                {
                    MessageBox.Show("La suma no puede ser mayor a 10");
                    tu5.Enabled = true;
                    tu5.Text = "";
                    tu6.Text = "";
                }
                if (tu4.Text == "X")
                {
                    int sum1, p, t, sum2;
                    p = Convert.ToInt32(tup1.Text);
                    sum1 = 10 + sum + p;
                    tup2.Text = Convert.ToString(sum1);
                    pun8.Text = Convert.ToString(sum1);
                    tu6.Enabled = false;


                    t = Convert.ToInt32(tup2.Text);
                    sum2 = t + sum;
                    if (sum == 10)
                    {
                        tup3.Text = "";
                        pun8.Text = tup2.Text;
                    }
                    else
                    {
                        tup3.Text = Convert.ToString(sum2);
                        pun8.Text = Convert.ToString(sum2);
                    }
                }
                else
                {
                    if (!(tu6.Text == "/"))
                    {
                        p3 = Convert.ToInt32(tup2.Text);
                        sumt = p3 + sum;
                        tup3.Text = Convert.ToString(sumt);
                        pun8.Text = Convert.ToString(sumt);
                        tu6.Enabled = false;
                        t7.Enabled = true;
                        t8.Enabled = true;
                    }
                    else
                    {
                        tup3.Text = "";
                    }
                }
            }
        }

        private void tu7_TextChanged(object sender, EventArgs e)
        {
            if (tu7.Text == "X")
            {
                tu8.Text = "X";
                tu7.Enabled = false;
                tu8.Enabled = false;
                t9.Enabled = true;
                t10.Enabled = true;
            }
            else
            {
                tu7.Enabled = false;
            }
            if (tu6.Text == "/" && tu7.Text == "X")
            {
                int sum, sum2, p;
                sum = 20;
                p = Convert.ToInt32(tup2.Text);
                sum2 = sum + p;
                tup3.Text = Convert.ToString(sum2);
                pun8.Text = Convert.ToString(sum2);
            }
            else if (tu6.Text == "/")
            {
                int p, p2, sum;
                p = Convert.ToInt32(tu7.Text);
                p2 = Convert.ToInt32(tup2.Text);
                sum = p2 + 10 + p;
                tup3.Text = Convert.ToString(sum);
                pun8.Text = Convert.ToString(sum);
            }
            if (tu3.Text == "X" && tu5.Text == "X" && !(tu7.Text == "X"))
            {
                int p, c, sum;
                p = Convert.ToInt32(tu7.Text);
                c = Convert.ToInt32(tup1.Text);
                sum = 20 + p + c;
                tup2.Text = Convert.ToString(sum);
                pun8.Text = Convert.ToString(sum);
            }
            else if (tu3.Text == "X" && tu5.Text == "X" && tu7.Text == "X")
            {
                int sum, p;
                p = Convert.ToInt32(tup1.Text);
                sum = 30 + p;
                tup2.Text = Convert.ToString(sum);
                pun8.Text = Convert.ToString(sum);
            }
        }

        private void tu8_TextChanged(object sender, EventArgs e)
        {
            if (!(tu7.Text == "X") && !(tu8.Text == "X") && !(tu8.Text == "/"))
            {
                int p1, p2, p3, sum, sumt;
                p1 = Convert.ToInt32(tu7.Text);
                p2 = Convert.ToInt32(tu8.Text);
                sum = p1 + p2;
                if (sum == 10)
                {
                    tu8.Text = "/";
                    tu8.Enabled = false;
                    tu7.Enabled = false;
                    tup4.Text = "";
                    t9.Enabled = true;
                    t10.Enabled = true;
                    
                }
                if (sum > 10)
                {
                    MessageBox.Show("La suma no puede ser mayor a 10");
                    tu7.Enabled = true;
                    tu7.Text = "";
                    tu8.Text = "";
                }
                if (tu6.Text == "X")
                {
                    int sum1, p, t, sum2;
                    p = Convert.ToInt32(tup2.Text);
                    sum1 = 10 + sum + p;
                    tup3.Text = Convert.ToString(sum1);
                    pun8.Text = Convert.ToString(sum1);
                    tu8.Enabled = false;
                    t = Convert.ToInt32(tup3.Text);
                    sum2 = t + sum;
                    if (sum == 10)
                    {
                        tup4.Text = "";
                        pun8.Text = tup3.Text;
                    }
                    else
                    {
                        tup4.Text = Convert.ToString(sum2);
                        pun8.Text = Convert.ToString(sum2);
                    }
                }
                else
                {
                    if (!(tu8.Text == "/"))
                    {
                        p3 = Convert.ToInt32(tup3.Text);
                        sumt = p3 + sum;
                        tup4.Text = Convert.ToString(sumt);
                        pun8.Text = Convert.ToString(sumt);
                        tu8.Enabled = false;
                        t9.Enabled = true;
                        t10.Enabled = true;
                        
                    }
                    else
                    {
                        tup4.Text = "";
                    }
                }
            }
        }

        private void tu9_TextChanged(object sender, EventArgs e)
        {
            if (tu9.Text == "X")
            {
                tu10.Text = "X";
                tu9.Enabled = false;
                tu10.Enabled = false;
                t11.Enabled = true;
                t12.Enabled = true;
            }
            else
            {
                tu9.Enabled = false;
            }
            if (tu8.Text == "/" && tu9.Text == "X")
            {
                int sum, sum2, p;
                sum = 20;
                p = Convert.ToInt32(tup3.Text);
                sum2 = sum + p;
                tup4.Text = Convert.ToString(sum2);
                pun8.Text = Convert.ToString(sum2);
            }
            else if (tu8.Text == "/")
            {
                int p, p2, sum;
                p = Convert.ToInt32(tu9.Text);
                p2 = Convert.ToInt32(tup3.Text);
                sum = p2 + 10 + p;
                tup4.Text = Convert.ToString(sum);
                pun8.Text = Convert.ToString(sum);
            }
            if (tu5.Text == "X" && tu7.Text == "X" && !(tu9.Text == "X"))
            {
                int p, c, sum;
                p = Convert.ToInt32(tu9.Text);
                c = Convert.ToInt32(tup2.Text);
                sum = 20 + p + c;
                tup3.Text = Convert.ToString(sum);
                pun8.Text = Convert.ToString(sum);
            }
            else if (tu5.Text == "X" && tu7.Text == "X" && tu9.Text == "X")
            {
                int sum, p;
                p = Convert.ToInt32(tup2.Text);
                sum = 30 + p;
                tup3.Text = Convert.ToString(sum);
                pun8.Text = Convert.ToString(sum);
            }
        }

        private void tu10_TextChanged(object sender, EventArgs e)
        {
            if (!(tu9.Text == "X") && !(tu10.Text == "X") && !(tu10.Text == "/"))
            {
                int p1, p2, p3, sum, sumt;
                p1 = Convert.ToInt32(tu9.Text);
                p2 = Convert.ToInt32(tu10.Text);
                sum = p1 + p2;
                if (sum == 10)
                {
                    tu10.Text = "/";
                    tu10.Enabled = false;
                    tu9.Enabled = false;
                    tup5.Text = "";
                    t11.Enabled = true;
                    t12.Enabled = true;
                }
                if (sum > 10)
                {
                    MessageBox.Show("La suma no puede ser mayor a 10");
                    tu9.Enabled = true;
                    tu9.Text = "";
                    tu10.Text = "";
                }
                if (tu8.Text == "X")
                {
                    int sum1, p, t, sum2;
                    p = Convert.ToInt32(tup3.Text);
                    sum1 = 10 + sum + p;
                    tup4.Text = Convert.ToString(sum1);
                    pun8.Text = Convert.ToString(sum1);
                    tu10.Enabled = false;
                    t = Convert.ToInt32(tup4.Text);
                    sum2 = t + sum;
                    if (sum == 10)
                    {
                        tup5.Text = "";
                        pun8.Text = tup4.Text;
                    }
                    else
                    {
                        tup5.Text = Convert.ToString(sum2);
                        pun8.Text = Convert.ToString(sum2);
                    }
                }
                else
                {
                    if (!(tu10.Text == "/"))
                    {
                        p3 = Convert.ToInt32(tup4.Text);
                        sumt = p3 + sum;
                        tup5.Text = Convert.ToString(sumt);
                        pun8.Text = Convert.ToString(sumt);
                        tu10.Enabled = false;
                        t11.Enabled = true;
                        t12.Enabled = true;
                    }
                    else
                    {
                        tup5.Text = "";
                    }
                }
            }
        }

        private void tu11_TextChanged(object sender, EventArgs e)
        {
            if (tu11.Text == "X")
            {
                tu12.Text = "X";
                tu11.Enabled = false;
                tu12.Enabled = false;
                t13.Enabled = true;
                t14.Enabled = true;
            }
            else
            {
                tu11.Enabled = false;
            }
            if (tu10.Text == "/" && tu11.Text == "X")
            {
                int sum, sum2, p;
                sum = 20;
                p = Convert.ToInt32(tup4.Text);
                sum2 = sum + p;
                tup5.Text = Convert.ToString(sum2);
                pun8.Text = Convert.ToString(sum2);
            }
            else if (tu10.Text == "/")
            {
                int p, p2, sum;
                p = Convert.ToInt32(tu11.Text);
                p2 = Convert.ToInt32(tup4.Text);
                sum = p2 + 10 + p;
                tup5.Text = Convert.ToString(sum);
                pun8.Text = Convert.ToString(sum);
            }
            if (tu7.Text == "X" && tu9.Text == "X" && !(tu11.Text == "X"))
            {
                int p, c, sum;
                p = Convert.ToInt32(tu11.Text);
                c = Convert.ToInt32(tup3.Text);
                sum = 20 + p + c;
                tup4.Text = Convert.ToString(sum);
                pun8.Text = Convert.ToString(sum);
            }
            else if (tu7.Text == "X" && tu9.Text == "X" && tu11.Text == "X")
            {
                int sum, p;
                p = Convert.ToInt32(tup3.Text);
                sum = 30 + p;
                tup4.Text = Convert.ToString(sum);
                pun8.Text = Convert.ToString(sum);
            }
        }

        private void tu12_TextChanged(object sender, EventArgs e)
        {
            if (!(tu11.Text == "X") && !(tu12.Text == "X") && !(tu12.Text == "/"))
            {
                int p1, p2, p3, sum, sumt;
                p1 = Convert.ToInt32(tu11.Text);
                p2 = Convert.ToInt32(tu12.Text);
                sum = p1 + p2;
                if (sum == 10)
                {
                    tu12.Text = "/";
                    tu12.Enabled = false;
                    tu11.Enabled = false;
                    tup6.Text = "";
                    t13.Enabled = true;
                    t14.Enabled = true;
                }
                if (sum > 10)
                {
                    MessageBox.Show("La suma no puede ser mayor a 10");
                    tu11.Enabled = true;
                    tu11.Text = "";
                    tu12.Text = "";
                }
                if (tu10.Text == "X")
                {
                    int sum1, p, t, sum2;
                    p = Convert.ToInt32(tup4.Text);
                    sum1 = 10 + sum + p;
                    tup5.Text = Convert.ToString(sum1);
                    pun8.Text = Convert.ToString(sum1);
                    tu12.Enabled = false;
                    t = Convert.ToInt32(tup5.Text);
                    sum2 = t + sum;
                    if (sum == 10)
                    {
                        tup6.Text = "";
                        pun8.Text = tup5.Text;
                    }
                    else
                    {
                        tup6.Text = Convert.ToString(sum2);
                        pun8.Text = Convert.ToString(sum2);
                    }
                }
                else
                {
                    if (!(tu12.Text == "/"))
                    {
                        p3 = Convert.ToInt32(tup5.Text);
                        sumt = p3 + sum;
                        tup6.Text = Convert.ToString(sumt);
                        pun8.Text = Convert.ToString(sumt);
                        tu12.Enabled = false;
                        t13.Enabled = true;
                        t14.Enabled = true;
                    }
                    else
                    {
                        tup6.Text = "";
                    }
                }
            }
        }

        private void tu13_TextChanged(object sender, EventArgs e)
        {
            if (tu13.Text == "X")
            {
                tu14.Text = "X";
                tu13.Enabled = false;
                tu14.Enabled = false;
                t15.Enabled = true;
                t16.Enabled = true;
                
            }
            else
            {
                tu13.Enabled = false;
            }
            if (tu12.Text == "/" && tu13.Text == "X")
            {
                int sum, sum2, p;
                sum = 20;
                p = Convert.ToInt32(tup5.Text);
                sum2 = sum + p;
                tup6.Text = Convert.ToString(sum2);
                pun8.Text = Convert.ToString(sum2);
            }
            else if (tu12.Text == "/")
            {
                int p, p2, sum;
                p = Convert.ToInt32(tu13.Text);
                p2 = Convert.ToInt32(tup5.Text);
                sum = p2 + 10 + p;
                tup6.Text = Convert.ToString(sum);
                pun8.Text = Convert.ToString(sum);
            }
            if (tu9.Text == "X" && tu11.Text == "X" && !(tu13.Text == "X"))
            {
                int p, c, sum;
                p = Convert.ToInt32(tu13.Text);
                c = Convert.ToInt32(tup4.Text);
                sum = 20 + p + c;
                tup5.Text = Convert.ToString(sum);
                pun8.Text = Convert.ToString(sum);
            }
            else if (tu9.Text == "X" && tu11.Text == "X" && tu13.Text == "X")
            {
                int sum, p;
                p = Convert.ToInt32(tup4.Text);
                sum = 30 + p;
                tup5.Text = Convert.ToString(sum);
                pun8.Text = Convert.ToString(sum);
            }
        }

        private void tu14_TextChanged(object sender, EventArgs e)
        {
            if (!(tu13.Text == "X") && !(tu14.Text == "X") && !(tu14.Text == "/"))
            {
                int p1, p2, p3, sum, sumt;
                p1 = Convert.ToInt32(tu13.Text);
                p2 = Convert.ToInt32(tu14.Text);
                sum = p1 + p2;
                if (sum == 10)
                {
                    tu14.Text = "/";
                    tu14.Enabled = false;
                    tu13.Enabled = false;
                    tup7.Text = "";
                    t15.Enabled = true;
                    t16.Enabled = true;
                    
                }
                if (sum > 10)
                {
                    MessageBox.Show("La suma no puede ser mayor a 10");
                    tu13.Enabled = true;
                    tu13.Text = "";
                    tu14.Text = "";
                }
                if (tu12.Text == "X")
                {
                    int sum1, p, t, sum2;
                    p = Convert.ToInt32(tup5.Text);
                    sum1 = 10 + sum + p;
                    tup6.Text = Convert.ToString(sum1);
                    pun8.Text = Convert.ToString(sum1);
                    tu14.Enabled = false;
                    t = Convert.ToInt32(tup6.Text);
                    sum2 = t + sum;
                    if (sum == 10)
                    {
                        tup7.Text = "";
                        pun8.Text = tup6.Text;
                    }
                    else
                    {
                        tup7.Text = Convert.ToString(sum2);
                        pun8.Text = Convert.ToString(sum2);
                    }
                }
                else
                {
                    if (!(tu14.Text == "/"))
                    {
                        p3 = Convert.ToInt32(tup6.Text);
                        sumt = p3 + sum;
                        tup7.Text = Convert.ToString(sumt);
                        pun8.Text = Convert.ToString(sumt);
                        tu14.Enabled = false;
                        t15.Enabled = true;
                        t16.Enabled = true;
                        
                    }
                    else
                    {
                        tup7.Text = "";
                    }
                }
            }
        }

        private void tu15_TextChanged(object sender, EventArgs e)
        {
            if (tu15.Text == "X")
            {
                tu16.Text = "X";
                tu15.Enabled = false;
                tu16.Enabled = false;
                t17.Enabled = true;
                t18.Enabled = true;
                
            }
            else
            {
                tu15.Enabled = false;
            }
            if (tu14.Text == "/" && tu15.Text == "X")
            {
                int sum, sum2, p;
                sum = 20;
                p = Convert.ToInt32(tup6.Text);
                sum2 = sum + p;
                tup7.Text = Convert.ToString(sum2);
                pun8.Text = Convert.ToString(sum2);
            }
            else if (tu14.Text == "/")
            {
                int p, p2, sum;
                p = Convert.ToInt32(tu15.Text);
                p2 = Convert.ToInt32(tup6.Text);
                sum = p2 + 10 + p;
                tup7.Text = Convert.ToString(sum);
                pun8.Text = Convert.ToString(sum);
            }
            if (tu11.Text == "X" && tu13.Text == "X" && !(tu15.Text == "X"))
            {
                int p, c, sum;
                p = Convert.ToInt32(tu15.Text);
                c = Convert.ToInt32(tup5.Text);
                sum = 20 + p + c;
                tup6.Text = Convert.ToString(sum);
                pun8.Text = Convert.ToString(sum);
            }
            else if (tu11.Text == "X" && tu13.Text == "X" && tu15.Text == "X")
            {
                int sum, p;
                p = Convert.ToInt32(tup5.Text);
                sum = 30 + p;
                tup6.Text = Convert.ToString(sum);
                pun8.Text = Convert.ToString(sum);
            }
        }

        private void tu16_TextChanged(object sender, EventArgs e)
        {
            if (!(tu15.Text == "X") && !(tu16.Text == "X") && !(tu16.Text == "/"))
            {
                int p1, p2, p3, sum, sumt;
                p1 = Convert.ToInt32(tu15.Text);
                p2 = Convert.ToInt32(tu16.Text);
                sum = p1 + p2;
                if (sum == 10)
                {
                    tu16.Text = "/";
                    tu16.Enabled = false;
                    tu15.Enabled = false;
                    tup8.Text = "";
                    t17.Enabled = true;
                    t18.Enabled = true;
                    
                }
                if (sum > 10)
                {
                    MessageBox.Show("La suma no puede ser mayor a 10");
                    tu15.Enabled = true;
                    tu15.Text = "";
                    tu16.Text = "";
                }
                if (tu14.Text == "X")
                {
                    int sum1, p, t, sum2;
                    p = Convert.ToInt32(tup6.Text);
                    sum1 = 10 + sum + p;
                    tup7.Text = Convert.ToString(sum1);
                    pun8.Text = Convert.ToString(sum1);
                    tu16.Enabled = false;
                    
                    t = Convert.ToInt32(tup7.Text);
                    sum2 = t + sum;
                    if (sum == 10)
                    {
                        tup8.Text = "";
                        pun8.Text = tup7.Text;
                    }
                    else
                    {
                        tup8.Text = Convert.ToString(sum2);
                        pun8.Text = Convert.ToString(sum2);
                    }
                }
                else
                {
                    if (!(tu16.Text == "/"))
                    {
                        p3 = Convert.ToInt32(tup7.Text);
                        sumt = p3 + sum;
                        tup8.Text = Convert.ToString(sumt);
                        pun8.Text = Convert.ToString(sumt);
                        tu16.Enabled = false;
                        t17.Enabled = true;
                        t18.Enabled = true;
                        
                    }
                    else
                    {
                        tup8.Text = "";
                    }
                }
            }
        }

        private void tu17_TextChanged(object sender, EventArgs e)
        {
            if (tu17.Text == "X")
            {
                tu18.Text = "X";
                tu17.Enabled = false;
                tu18.Enabled = false;
                t19.Enabled = true;
                t20.Enabled = true;
            }
            else
            {
                tu17.Enabled = false;
                
            }
            if (tu16.Text == "/" && tu17.Text == "X")
            {

                int sum, sum2, p;
                sum = 20;
                p = Convert.ToInt32(tup7.Text);
                sum2 = sum + p;
                tup8.Text = Convert.ToString(sum2);
                pun8.Text = Convert.ToString(sum2);
            }
            else if (tu16.Text == "/")
            {
                int p, p2, sum;
                p = Convert.ToInt32(tu17.Text);
                p2 = Convert.ToInt32(tup7.Text);
                sum = p2 + 10 + p;
                tup8.Text = Convert.ToString(sum);
                pun8.Text = Convert.ToString(sum);
            }
            if (tu13.Text == "X" && tu15.Text == "X" && !(tu17.Text == "X"))
            {
                int p, c, sum;
                p = Convert.ToInt32(tu17.Text);
                c = Convert.ToInt32(tup6.Text);
                sum = 20 + p + c;
                tup7.Text = Convert.ToString(sum);
                pun8.Text = Convert.ToString(sum);
            }
            else if (tu13.Text == "X" && tu15.Text == "X" && tu17.Text == "X")
            {
                int sum, p;
                p = Convert.ToInt32(tup6.Text);
                sum = 30 + p;
                tup7.Text = Convert.ToString(sum);
                pun8.Text = Convert.ToString(sum);
            }
        }

        private void tu18_TextChanged(object sender, EventArgs e)
        {
            if (!(tu17.Text == "X") && !(tu18.Text == "X") && !(tu18.Text == "/"))
            {
                int p1, p2, p3, sum, sumt;
                p1 = Convert.ToInt32(tu17.Text);
                p2 = Convert.ToInt32(tu18.Text);
                sum = p1 + p2;
                if (sum == 10)
                {
                    tu18.Text = "/";
                    tu18.Enabled = false;
                    tu17.Enabled = false;
                    tup9.Text = "";
                    t19.Enabled = true;
                    t20.Enabled = true;
                    
                }
                if (sum > 10)
                {
                    MessageBox.Show("La suma no puede ser mayor a 10");
                    tu17.Enabled = true;
                    tu17.Text = "";
                    tu18.Text = "";
                }
                if (tu16.Text == "X")
                {
                    int sum1, p, t, sum2;
                    p = Convert.ToInt32(tup7.Text);
                    sum1 = 10 + sum + p;
                    tup8.Text = Convert.ToString(sum1);
                    pun8.Text = Convert.ToString(sum1);
                    tu18.Enabled = false;
                    t = Convert.ToInt32(tup8.Text);
                    sum2 = t + sum;
                    if (sum == 10)
                    {
                        tup9.Text = "";
                        pun8.Text = tup8.Text;
                    }
                    else
                    {
                        tup9.Text = Convert.ToString(sum2);
                        pun8.Text = Convert.ToString(sum2);
                    }
                }
                else
                {
                    if (!(tu18.Text == "/"))
                    {
                        p3 = Convert.ToInt32(tup8.Text);
                        sumt = p3 + sum;
                        tup9.Text = Convert.ToString(sumt);
                        pun8.Text = Convert.ToString(sumt);
                        tu18.Enabled = false;
                        t19.Enabled = true;
                        t20.Enabled = true;
                        
                    }
                    else
                    {
                        tup9.Text = "";
                    }
                }
            }
        }

        private void tu19_TextChanged(object sender, EventArgs e)
        {
            if (tu19.Text == "X")
            {
                tu21.Enabled = true;
                tu19.Enabled = false;
            }
            else
            {
                tu19.Enabled = false;
                tu21.Enabled = true;
            }
            if (tu18.Text == "/" && tu19.Text == "X")
            {
                int sum, sum2, p;
                sum = 20;
                p = Convert.ToInt32(tup8.Text);
                sum2 = sum + p;
                tup9.Text = Convert.ToString(sum2);
                pun8.Text = Convert.ToString(sum2);
                tu20.Enabled = true;
            }
            else if (tu18.Text == "/")
            {
                int p, p2, sum;
                p = Convert.ToInt32(tu19.Text);
                p2 = Convert.ToInt32(tup8.Text);
                sum = p2 + 10 + p;
                tup9.Text = Convert.ToString(sum);
                pun8.Text = Convert.ToString(sum);
            }
            if (tu15.Text == "X" && tu17.Text == "X" && !(tu19.Text == "X"))
            {
                int p, c, sum;
                p = Convert.ToInt32(tu19.Text);
                c = Convert.ToInt32(tup7.Text);
                sum = 20 + p + c;
                tup8.Text = Convert.ToString(sum);
                pun8.Text = Convert.ToString(sum);
            }
            if (tu15.Text == "X" && tu17.Text == "X" && tu19.Text == "X")
            {
                int sum, p;
                p = Convert.ToInt32(tup7.Text);
                sum = 30 + p;
                tup8.Text = Convert.ToString(sum);
                pun8.Text = Convert.ToString(sum);
            }
        }

        private void tu20_TextChanged(object sender, EventArgs e)
        {
            if (tu20.Text == "X")
            {
                tu21.Enabled = true;
                tu20.Enabled = false;
                tup10.Text = "";
            }
            else if (tu20.Text == "/")
            {
                tu20.Enabled = false;
                tu21.Enabled = true;
            }
            else
            {
                if (!(tu19.Text == "X"))
                {
                    int p1, p2, p3, sum, sumt;
                    p1 = Convert.ToInt32(tu19.Text);
                    p2 = Convert.ToInt32(tu20.Text);
                    sum = p1 + p2;
                    if (sum == 10)
                    {
                        tu20.Text = "/";
                        tu20.Enabled = false;
                        tup10.Text = "";
                        tu21.Enabled = true;
                    }
                    if (sum > 10)
                    {
                        MessageBox.Show("La suma no puede ser mayor a 10");
                        tu17.Enabled = true;
                        tu17.Text = "";
                        tu18.Text = "";
                    }
                    if (tu18.Text == "X")
                    {
                        int sum1, p, t, sum2;
                        p = Convert.ToInt32(tup8.Text);
                        sum1 = 10 + sum + p;
                        tup9.Text = Convert.ToString(sum1);
                        pun8.Text = Convert.ToString(sum1);
                        tu20.Enabled = false;
                        t = Convert.ToInt32(tup9.Text);
                        sum2 = t + sum;
                        if (sum == 10)
                        {
                            tup10.Text = "";
                            pun8.Text = tup9.Text;
                        }
                        else
                        {
                            tup10.Text = Convert.ToString(sum2);
                            pun8.Text = Convert.ToString(sum2);
                            tu21.Enabled = false;
                            MessageBox.Show("Fin del juego");
                        }
                    }
                    else
                    {
                        if (!(tu20.Text == "/"))
                        {
                            tu21.Enabled = false;
                            p3 = Convert.ToInt32(tup9.Text);
                            sumt = p3 + sum;
                            tup10.Text = Convert.ToString(sumt);
                            pun8.Text = Convert.ToString(sumt);
                            tu19.Enabled = false;
                            tu20.Enabled = false;
                            MessageBox.Show("Fin del juego");
                        }
                        else
                        {
                            tup10.Text = "";
                            tu21.Enabled = true;
                        }
                    }
                }
                else
                {
                    tu20.Enabled = false;
                }
            }
            if (tu17.Text == "X" && tu19.Text == "X" && tu20.Text == "X")
            {
                int sum, p;
                p = Convert.ToInt32(tup8.Text);
                sum = 30 + p;
                tup9.Text = Convert.ToString(sum);
                pun8.Text = Convert.ToString(sum);
            }
            else if (tu17.Text == "X" && tu19.Text == "X" && !(tu20.Text == "X"))
            {
                int sum, p, y;
                y = Convert.ToInt32(tu20.Text);
                p = Convert.ToInt32(tup8.Text);
                sum = 20 + p + y;
                tup9.Text = Convert.ToString(sum);
                pun8.Text = Convert.ToString(sum);
            }
        }

        private void tu21_TextChanged(object sender, EventArgs e)
        {
            int p, sum, pp;
            if (tu19.Text == "X" && tu20.Text == "X" && tu21.Text == "X")
            {
                p = Convert.ToInt32(tup9.Text);
                sum = p + 30;
                tup10.Text = Convert.ToString(sum);
                pun8.Text = Convert.ToString(sum);
                tu21.Enabled = false;
                MessageBox.Show("Fin del juego");
                
            }
            if (tu20.Text == "/")
            {
                if (tu21.Text == "X")
                {
                    p = Convert.ToInt32(tup9.Text);
                    sum = p + 20;
                    tup10.Text = Convert.ToString(sum);
                    pun8.Text = Convert.ToString(sum);
                    tu21.Enabled = false;
                    MessageBox.Show("Fin del juego");
                    
                }
                else
                {
                    p = Convert.ToInt32(tup9.Text);
                    pp = Convert.ToInt32(tu21.Text);
                    sum = p + 10 + pp;
                    tup10.Text = Convert.ToString(sum);
                    pun8.Text = Convert.ToString(sum);
                    tu21.Enabled = false;
                    MessageBox.Show("Fin del juego");
                    
                }

            }
            if (tu19.Text == "X" && !(tu20.Text == "X"))
            {
                int c, p1, sump, sumpp, d;
                c = Convert.ToInt32(tu20.Text);
                p1 = Convert.ToInt32(tu21.Text);
                d = Convert.ToInt32(tup9.Text);
                sump = c + p1;
                if (sump > 10)
                {
                    MessageBox.Show("la suma no puede ser mayor a 10");
                    tu20.Enabled = true;
                    tu20.Text = "";
                    tu21.Enabled = true;
                    tu21.Text = "";
                }
                else
                {
                    
                    sumpp = sump + 10 + d;
                    tup10.Text = Convert.ToString(sumpp);
                    pun8.Text = Convert.ToString(sumpp);
                    tu21.Enabled = false;
                    MessageBox.Show("Fin del juego");
                }
            }
        }
        //inicio
        private void Planilla_Load(object sender, EventArgs e)
        {
            //Thread Hilo = new Thread(escuchar);
            //Hilo.Start();
        }
        //cierre
        private void Planilla_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Isclosed = true;
            //if (Port.IsOpen)
                //Port.Close();
        }
    }
}
