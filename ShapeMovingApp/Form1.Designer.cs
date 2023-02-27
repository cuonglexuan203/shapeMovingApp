namespace ShapeMovingApp
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
            this.components = new System.ComponentModel.Container();
            this.TimerShape = new System.Windows.Forms.Timer(this.components);
            this.PnlMainDrawing = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // TimerShape
            // 
            this.TimerShape.Tick += new System.EventHandler(this.TimerShape_Tick);
            // 
            // PnlMainDrawing
            // 
            this.PnlMainDrawing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMainDrawing.Location = new System.Drawing.Point(0, 0);
            this.PnlMainDrawing.Name = "PnlMainDrawing";
            this.PnlMainDrawing.Size = new System.Drawing.Size(800, 450);
            this.PnlMainDrawing.TabIndex = 0;
            this.PnlMainDrawing.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlMainDrawing_Paint);
            this.PnlMainDrawing.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.PnlMainDrawing_PreviewKeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PnlMainDrawing);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer TimerShape;
        private System.Windows.Forms.Panel PnlMainDrawing;
    }
}

