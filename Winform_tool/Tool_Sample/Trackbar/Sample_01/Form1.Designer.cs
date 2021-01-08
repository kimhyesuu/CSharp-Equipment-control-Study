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
         this.Tk_01 = new System.Windows.Forms.TrackBar();
         this.Tb_01 = new System.Windows.Forms.TextBox();
         ((System.ComponentModel.ISupportInitialize)(this.Tk_01)).BeginInit();
         this.SuspendLayout();
         // 
         // Tk_01
         // 
         this.Tk_01.LargeChange = 10;
         this.Tk_01.Location = new System.Drawing.Point(12, 77);
         this.Tk_01.Maximum = 100;
         this.Tk_01.Name = "Tk_01";
         this.Tk_01.Size = new System.Drawing.Size(764, 45);
         this.Tk_01.TabIndex = 0;
         this.Tk_01.Scroll += new System.EventHandler(this.Tk_01_Scroll);
         // 
         // Tb_01
         // 
         this.Tb_01.BackColor = System.Drawing.SystemColors.ScrollBar;
         this.Tb_01.Font = new System.Drawing.Font("Gulim", 30F);
         this.Tb_01.ForeColor = System.Drawing.Color.Red;
         this.Tb_01.Location = new System.Drawing.Point(325, 160);
         this.Tb_01.Name = "Tb_01";
         this.Tb_01.Size = new System.Drawing.Size(100, 53);
         this.Tb_01.TabIndex = 1;
         this.Tb_01.Text = "0";
         this.Tb_01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.Tb_01);
         this.Controls.Add(this.Tk_01);
         this.Name = "Form1";
         this.Text = "Form1";
         ((System.ComponentModel.ISupportInitialize)(this.Tk_01)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TrackBar Tk_01;
      private System.Windows.Forms.TextBox Tb_01;
   }
}

