namespace DesktopApp1
{
    partial class FormTimer
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
            this.components = new System.ComponentModel.Container();
            this.pbxMario = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbxMario1 = new System.Windows.Forms.PictureBox();
            this.pbxMario2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMario1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMario2)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxMario
            // 
            this.pbxMario.Image = global::DesktopApp1.Properties.Resources.giphy1;
            this.pbxMario.Location = new System.Drawing.Point(12, 118);
            this.pbxMario.Name = "pbxMario";
            this.pbxMario.Size = new System.Drawing.Size(58, 54);
            this.pbxMario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxMario.TabIndex = 0;
            this.pbxMario.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbxMario1
            // 
            this.pbxMario1.Image = global::DesktopApp1.Properties.Resources.giphy1;
            this.pbxMario1.Location = new System.Drawing.Point(720, 118);
            this.pbxMario1.Name = "pbxMario1";
            this.pbxMario1.Size = new System.Drawing.Size(58, 54);
            this.pbxMario1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxMario1.TabIndex = 1;
            this.pbxMario1.TabStop = false;
            // 
            // pbxMario2
            // 
            this.pbxMario2.Image = global::DesktopApp1.Properties.Resources.giphy1;
            this.pbxMario2.Location = new System.Drawing.Point(720, 210);
            this.pbxMario2.Name = "pbxMario2";
            this.pbxMario2.Size = new System.Drawing.Size(58, 54);
            this.pbxMario2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxMario2.TabIndex = 2;
            this.pbxMario2.TabStop = false;
            // 
            // FormTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbxMario2);
            this.Controls.Add(this.pbxMario1);
            this.Controls.Add(this.pbxMario);
            this.Name = "FormTimer";
            this.Text = "FormTimer";
            this.Load += new System.EventHandler(this.FormTimer_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormTimer_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormTimer_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pbxMario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMario1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMario2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxMario;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pbxMario1;
        private System.Windows.Forms.PictureBox pbxMario2;
    }
}