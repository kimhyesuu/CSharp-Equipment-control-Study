using System;
using System.Windows.Forms;

namespace Sample_01
{
   public partial class Form1 : Form
   {
      public int Cnt { get; set; } 

      public Form1()
      {
         InitializeComponent();

         Cnt = 0;

         // SelectTab은 load되고 app run 됐을 시 form1에서 tabPage3 시작 지점으로 변경 
         // 1. tabControl1.SelectTab("tabPage3");
         // 2. tabControl1.SelectedIndex = 2; 0 부터 index 시작 
      }

      private void Btn_Remove_Click(object sender, EventArgs e)
      {
         tabControl1.TabPages.Remove(tabControl1.SelectedTab);
      }
      
      private void Btn_Add_Click(object sender, EventArgs e)
      {
         var tabPage = new TabPage("page"+ Cnt);         
         var li = new Label();
         li.Text = "page"+ Cnt++;
         tabPage.Controls.Add(li);
         tabControl1.TabPages.Add(tabPage);
      }

      private void button1_Click(object sender, EventArgs e)
      {
         tabControl1.TabPages.Clear();
      }
   }
}
