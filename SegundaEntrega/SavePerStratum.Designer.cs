namespace SegundaEntrega
{
    partial class SavePerStratum
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtStratum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSavedPercentage = new System.Windows.Forms.Label();
            this.btnQuery = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el estrato";
            // 
            // txtStratum
            // 
            this.txtStratum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStratum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStratum.Location = new System.Drawing.Point(18, 54);
            this.txtStratum.Name = "txtStratum";
            this.txtStratum.Size = new System.Drawing.Size(76, 38);
            this.txtStratum.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Porcentaje ahorrado";
            // 
            // lblSavedPercentage
            // 
            this.lblSavedPercentage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSavedPercentage.AutoSize = true;
            this.lblSavedPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSavedPercentage.Location = new System.Drawing.Point(112, 160);
            this.lblSavedPercentage.Name = "lblSavedPercentage";
            this.lblSavedPercentage.Size = new System.Drawing.Size(0, 31);
            this.lblSavedPercentage.TabIndex = 3;
            // 
            // btnQuery
            // 
            this.btnQuery.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuery.Location = new System.Drawing.Point(118, 54);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(153, 38);
            this.btnQuery.TabIndex = 4;
            this.btnQuery.Text = "Consultar";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // SavePerStratum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 200);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.lblSavedPercentage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStratum);
            this.Controls.Add(this.label1);
            this.Name = "SavePerStratum";
            this.Text = "Ahorro por Estrato";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStratum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSavedPercentage;
        private System.Windows.Forms.Button btnQuery;
    }
}