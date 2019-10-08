namespace SegundaEntrega
{
    partial class ConsumeAverage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsumeAverage));
            this.label1 = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.gpBox = new System.Windows.Forms.GroupBox();
            this.gpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // lblAverage
            // 
            resources.ApplyResources(this.lblAverage, "lblAverage");
            this.lblAverage.Name = "lblAverage";
            // 
            // gpBox
            // 
            resources.ApplyResources(this.gpBox, "gpBox");
            this.gpBox.Controls.Add(this.label1);
            this.gpBox.Controls.Add(this.lblAverage);
            this.gpBox.Name = "gpBox";
            this.gpBox.TabStop = false;
            // 
            // ConsumeAverage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.Controls.Add(this.gpBox);
            this.Name = "ConsumeAverage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ConsumeAverage_Load);
            this.gpBox.ResumeLayout(false);
            this.gpBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.GroupBox gpBox;
    }
}