namespace SegundaEntrega
{
    partial class GoalOverpast
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
            this.lblOverpastUsers = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(556, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad de usuarios que excedieron la meta";
            // 
            // lblOverpastUsers
            // 
            this.lblOverpastUsers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOverpastUsers.AutoSize = true;
            this.lblOverpastUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverpastUsers.Location = new System.Drawing.Point(273, 82);
            this.lblOverpastUsers.Name = "lblOverpastUsers";
            this.lblOverpastUsers.Size = new System.Drawing.Size(0, 31);
            this.lblOverpastUsers.TabIndex = 1;
            // 
            // GoalOverpast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 148);
            this.Controls.Add(this.lblOverpastUsers);
            this.Controls.Add(this.label1);
            this.Name = "GoalOverpast";
            this.Text = "Superaron la Meta";
            this.Load += new System.EventHandler(this.GoalOverpast_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOverpastUsers;
    }
}