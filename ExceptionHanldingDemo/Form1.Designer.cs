
namespace ExceptionHanldingDemo
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
            this.BTNCLICK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTNCLICK
            // 
            this.BTNCLICK.Location = new System.Drawing.Point(246, 136);
            this.BTNCLICK.Name = "BTNCLICK";
            this.BTNCLICK.Size = new System.Drawing.Size(75, 23);
            this.BTNCLICK.TabIndex = 0;
            this.BTNCLICK.Text = "CLICK";
            this.BTNCLICK.UseVisualStyleBackColor = true;
            this.BTNCLICK.Click += new System.EventHandler(this.BtnClick_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTNCLICK);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTNCLICK;
    }
}

