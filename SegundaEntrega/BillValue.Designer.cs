namespace SegundaEntrega
{
    partial class BillValue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillValue));
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdCard = new System.Windows.Forms.TextBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBillValue = new System.Windows.Forms.Label();
            this.gpBox = new System.Windows.Forms.GroupBox();
            this.gpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtIdCard
            // 
            resources.ApplyResources(this.txtIdCard, "txtIdCard");
            this.txtIdCard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdCard.Name = "txtIdCard";
            this.txtIdCard.Tag = "";
            // 
            // btnQuery
            // 
            resources.ApplyResources(this.btnQuery, "btnQuery");
            this.btnQuery.BackColor = System.Drawing.Color.Tan;
            this.btnQuery.ForeColor = System.Drawing.Color.Wheat;
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.UseVisualStyleBackColor = false;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // lblBillValue
            // 
            resources.ApplyResources(this.lblBillValue, "lblBillValue");
            this.lblBillValue.Name = "lblBillValue";
            // 
            // gpBox
            // 
            resources.ApplyResources(this.gpBox, "gpBox");
            this.gpBox.Controls.Add(this.lblBillValue);
            this.gpBox.Controls.Add(this.label2);
            this.gpBox.Controls.Add(this.btnQuery);
            this.gpBox.Controls.Add(this.txtIdCard);
            this.gpBox.Controls.Add(this.label1);
            this.gpBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpBox.Name = "gpBox";
            this.gpBox.TabStop = false;
            // 
            // BillValue
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.Controls.Add(this.gpBox);
            this.Name = "BillValue";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gpBox.ResumeLayout(false);
            this.gpBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdCard;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBillValue;
        private System.Windows.Forms.GroupBox gpBox;
    }
}