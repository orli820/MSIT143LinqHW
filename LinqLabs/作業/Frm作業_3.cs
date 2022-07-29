using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LinqLabs.作業;

namespace LinqLabs.作業
{
    public partial class Frm作業_3 : Form
    {
        public Frm作業_3()
        {
            InitializeComponent();

            Random rd = new Random();
            int x=rd.Next(0, 100);
            
            students_scores = new List<Students>()
                                         {
                                            new Students { Name = "廖家毅", Class = "CS_101", Chi = x, Eng = x, Math = x, Gender = "Male" },
                                            new Students { Name = "鄭凱", Class = "CS_102", Chi = x, Eng = x, Math = x, Gender = "Male" },
                                            new Students { Name = "李沛軒", Class = "CS_102", Chi = x, Eng = x, Math = x, Gender = "Male" },
                                            new Students { Name = "陳苡錚", Class = "CS_101", Chi = x, Eng = x, Math = x, Gender = "Female" },
                                            new Students { Name = "王婷薇", Class = "CS_102", Chi = x, Eng = x, Math = x, Gender = "Female" },
                                            new Students { Name = "洪暐婷", Class = "CS_101", Chi = x, Eng = x, Math = x, Gender = "Female" },
                                            new Students { Name = "游曉雯", Class = "CS_102", Chi = x, Eng = x, Math = x, Gender = "Female" },

                                          };
        }
    
    List<Students> students_scores;

    private void button33_Click(object sender, EventArgs e)
        {
            // split=> 數學成績 分成 三群 '待加強'(60~69) '佳'(70~89) '優良'(90~100) 
        }

        private void button36_Click(object sender, EventArgs e)
        {

        }
    }
}
