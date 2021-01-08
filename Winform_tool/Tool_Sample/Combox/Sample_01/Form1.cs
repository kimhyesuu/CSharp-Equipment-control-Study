using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample_01
{
   public partial class Form1 : Form
   {
      public List<Person> PersonList { get; set; }
      public Person SelectedPerson { get; set; }

      public Form1()
      {
         InitializeComponent();
         PersonList = new List<Person>()
         {
            new Person { FirstName = "Kim", LastName = "Hyesu"},
            new Person { FirstName = "Gu", LastName = "Maru"}
         };

         Cb_01.DisplayMember = "FirstName";
         Cb_01.DataSource = PersonList;

         Lb_01.DataBindings.Add("Text", PersonList, "FirstName");
         Lb_02.DataBindings.Add("Text", PersonList, "LastName");
      }
   }

   public class Person
   {
      public string FirstName { get; set; }
      public string LastName { get; set; }

      public Person() { }    
   }
}
