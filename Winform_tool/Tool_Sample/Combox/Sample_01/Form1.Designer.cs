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
         this.Cb_01 = new System.Windows.Forms.ComboBox();
         this.Lb_01 = new System.Windows.Forms.Label();
         this.Lb_02 = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // Cb_01
         // 
         this.Cb_01.FormattingEnabled = true;
         this.Cb_01.Location = new System.Drawing.Point(193, 89);
         this.Cb_01.Name = "Cb_01";
         this.Cb_01.Size = new System.Drawing.Size(289, 20);
         this.Cb_01.TabIndex = 0;
         // 
         // Lb_01
         // 
         this.Lb_01.AutoSize = true;
         this.Lb_01.Font = new System.Drawing.Font("Gulim", 40F);
         this.Lb_01.ForeColor = System.Drawing.Color.Red;
         this.Lb_01.Location = new System.Drawing.Point(184, 208);
         this.Lb_01.Name = "Lb_01";
         this.Lb_01.Size = new System.Drawing.Size(54, 54);
         this.Lb_01.TabIndex = 1;
         this.Lb_01.Text = "0";
         // 
         // Lb_02
         // 
         this.Lb_02.AutoSize = true;
         this.Lb_02.Font = new System.Drawing.Font("Gulim", 40F);
         this.Lb_02.ForeColor = System.Drawing.Color.Red;
         this.Lb_02.Location = new System.Drawing.Point(184, 316);
         this.Lb_02.Name = "Lb_02";
         this.Lb_02.Size = new System.Drawing.Size(54, 54);
         this.Lb_02.TabIndex = 2;
         this.Lb_02.Text = "0";
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.Lb_02);
         this.Controls.Add(this.Lb_01);
         this.Controls.Add(this.Cb_01);
         this.Name = "Form1";
         this.Text = "Form1";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.ComboBox Cb_01;
      private System.Windows.Forms.Label Lb_01;
      private System.Windows.Forms.Label Lb_02;
   }
}

