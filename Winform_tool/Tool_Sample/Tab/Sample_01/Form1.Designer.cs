namespace Sample_01
{
   partial class Form1
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.tabControl1 = new System.Windows.Forms.TabControl();
         this.tabPage1 = new System.Windows.Forms.TabPage();
         this.label1 = new System.Windows.Forms.Label();
         this.tabPage2 = new System.Windows.Forms.TabPage();
         this.label2 = new System.Windows.Forms.Label();
         this.tabPage3 = new System.Windows.Forms.TabPage();
         this.label3 = new System.Windows.Forms.Label();
         this.tabPage4 = new System.Windows.Forms.TabPage();
         this.label4 = new System.Windows.Forms.Label();
         this.Btn_Add = new System.Windows.Forms.Button();
         this.Btn_Remove = new System.Windows.Forms.Button();
         this.button1 = new System.Windows.Forms.Button();
         this.tabControl1.SuspendLayout();
         this.tabPage1.SuspendLayout();
         this.tabPage2.SuspendLayout();
         this.tabPage3.SuspendLayout();
         this.tabPage4.SuspendLayout();
         this.SuspendLayout();
         // 
         // tabControl1
         // 
         this.tabControl1.Controls.Add(this.tabPage1);
         this.tabControl1.Controls.Add(this.tabPage2);
         this.tabControl1.Controls.Add(this.tabPage3);
         this.tabControl1.Controls.Add(this.tabPage4);
         this.tabControl1.Location = new System.Drawing.Point(0, 0);
         this.tabControl1.Name = "tabControl1";
         this.tabControl1.SelectedIndex = 0;
         this.tabControl1.Size = new System.Drawing.Size(676, 204);
         this.tabControl1.TabIndex = 0;
         // 
         // tabPage1
         // 
         this.tabPage1.Controls.Add(this.label1);
         this.tabPage1.Location = new System.Drawing.Point(4, 22);
         this.tabPage1.Name = "tabPage1";
         this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
         this.tabPage1.Size = new System.Drawing.Size(668, 399);
         this.tabPage1.TabIndex = 0;
         this.tabPage1.Text = "tabPage1";
         this.tabPage1.UseVisualStyleBackColor = true;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(8, 20);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(70, 12);
         this.label1.TabIndex = 0;
         this.label1.Text = "Tab Page 1";
         // 
         // tabPage2
         // 
         this.tabPage2.Controls.Add(this.label2);
         this.tabPage2.Location = new System.Drawing.Point(4, 22);
         this.tabPage2.Name = "tabPage2";
         this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
         this.tabPage2.Size = new System.Drawing.Size(668, 399);
         this.tabPage2.TabIndex = 1;
         this.tabPage2.Text = "tabPage2";
         this.tabPage2.UseVisualStyleBackColor = true;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(8, 8);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(74, 12);
         this.label2.TabIndex = 0;
         this.label2.Text = "label page 2";
         // 
         // tabPage3
         // 
         this.tabPage3.Controls.Add(this.label3);
         this.tabPage3.Location = new System.Drawing.Point(4, 22);
         this.tabPage3.Name = "tabPage3";
         this.tabPage3.Size = new System.Drawing.Size(668, 178);
         this.tabPage3.TabIndex = 2;
         this.tabPage3.Text = "tabPage3";
         this.tabPage3.UseVisualStyleBackColor = true;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(8, 8);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(74, 12);
         this.label3.TabIndex = 0;
         this.label3.Text = "label page 3";
         // 
         // tabPage4
         // 
         this.tabPage4.Controls.Add(this.label4);
         this.tabPage4.Location = new System.Drawing.Point(4, 22);
         this.tabPage4.Name = "tabPage4";
         this.tabPage4.Size = new System.Drawing.Size(668, 399);
         this.tabPage4.TabIndex = 3;
         this.tabPage4.Text = "tabPage4";
         this.tabPage4.UseVisualStyleBackColor = true;
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(8, 52);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(74, 12);
         this.label4.TabIndex = 0;
         this.label4.Text = "label page 4";
         // 
         // Btn_Add
         // 
         this.Btn_Add.Font = new System.Drawing.Font("Gulim", 20F);
         this.Btn_Add.Location = new System.Drawing.Point(315, 231);
         this.Btn_Add.Name = "Btn_Add";
         this.Btn_Add.Size = new System.Drawing.Size(169, 81);
         this.Btn_Add.TabIndex = 1;
         this.Btn_Add.Text = "Page Add";
         this.Btn_Add.UseVisualStyleBackColor = true;
         this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
         // 
         // Btn_Remove
         // 
         this.Btn_Remove.Font = new System.Drawing.Font("Gulim", 20F);
         this.Btn_Remove.Location = new System.Drawing.Point(503, 231);
         this.Btn_Remove.Name = "Btn_Remove";
         this.Btn_Remove.Size = new System.Drawing.Size(169, 81);
         this.Btn_Remove.TabIndex = 2;
         this.Btn_Remove.Text = "Remove";
         this.Btn_Remove.UseVisualStyleBackColor = true;
         this.Btn_Remove.Click += new System.EventHandler(this.Btn_Remove_Click);
         // 
         // button1
         // 
         this.button1.Font = new System.Drawing.Font("Gulim", 20F);
         this.button1.Location = new System.Drawing.Point(315, 341);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(169, 81);
         this.button1.TabIndex = 3;
         this.button1.Text = "All Remove ";
         this.button1.UseVisualStyleBackColor = true;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.button1);
         this.Controls.Add(this.Btn_Remove);
         this.Controls.Add(this.Btn_Add);
         this.Controls.Add(this.tabControl1);
         this.Name = "Form1";
         this.Text = "Form1";
         this.tabControl1.ResumeLayout(false);
         this.tabPage1.ResumeLayout(false);
         this.tabPage1.PerformLayout();
         this.tabPage2.ResumeLayout(false);
         this.tabPage2.PerformLayout();
         this.tabPage3.ResumeLayout(false);
         this.tabPage3.PerformLayout();
         this.tabPage4.ResumeLayout(false);
         this.tabPage4.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.TabControl tabControl1;
      private System.Windows.Forms.TabPage tabPage1;
      private System.Windows.Forms.TabPage tabPage2;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TabPage tabPage3;
      private System.Windows.Forms.TabPage tabPage4;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Button Btn_Add;
      private System.Windows.Forms.Button Btn_Remove;
      private System.Windows.Forms.Button button1;
   }
}

