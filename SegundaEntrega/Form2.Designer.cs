namespace SegundaEntrega
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.consumeTxt = new System.Windows.Forms.TextBox();
            this.goalTxt = new System.Windows.Forms.TextBox();
            this.stratumTxt = new System.Windows.Forms.TextBox();
            this.consumeLbl = new System.Windows.Forms.Label();
            this.goalLbl = new System.Windows.Forms.Label();
            this.stratumLabel = new System.Windows.Forms.Label();
            this.idCardLbl = new System.Windows.Forms.Label();
            this.idCardTxt = new System.Windows.Forms.TextBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.registerBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gpBox = new System.Windows.Forms.GroupBox();
            this.gpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // consumeTxt
            // 
            resources.ApplyResources(this.consumeTxt, "consumeTxt");
            this.consumeTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.consumeTxt.Name = "consumeTxt";
            // 
            // goalTxt
            // 
            resources.ApplyResources(this.goalTxt, "goalTxt");
            this.goalTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.goalTxt.Name = "goalTxt";
            // 
            // stratumTxt
            // 
            resources.ApplyResources(this.stratumTxt, "stratumTxt");
            this.stratumTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stratumTxt.Name = "stratumTxt";
            // 
            // consumeLbl
            // 
            resources.ApplyResources(this.consumeLbl, "consumeLbl");
            this.consumeLbl.Name = "consumeLbl";
            // 
            // goalLbl
            // 
            resources.ApplyResources(this.goalLbl, "goalLbl");
            this.goalLbl.Name = "goalLbl";
            // 
            // stratumLabel
            // 
            resources.ApplyResources(this.stratumLabel, "stratumLabel");
            this.stratumLabel.Name = "stratumLabel";
            // 
            // idCardLbl
            // 
            resources.ApplyResources(this.idCardLbl, "idCardLbl");
            this.idCardLbl.Name = "idCardLbl";
            // 
            // idCardTxt
            // 
            resources.ApplyResources(this.idCardTxt, "idCardTxt");
            this.idCardTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idCardTxt.Name = "idCardTxt";
            this.idCardTxt.Tag = "";
            // 
            // clearBtn
            // 
            resources.ApplyResources(this.clearBtn, "clearBtn");
            this.clearBtn.BackColor = System.Drawing.Color.Tan;
            this.clearBtn.ForeColor = System.Drawing.Color.Wheat;
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // registerBtn
            // 
            resources.ApplyResources(this.registerBtn, "registerBtn");
            this.registerBtn.BackColor = System.Drawing.Color.Tan;
            this.registerBtn.ForeColor = System.Drawing.Color.Wheat;
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.UseVisualStyleBackColor = false;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // gpBox
            // 
            resources.ApplyResources(this.gpBox, "gpBox");
            this.gpBox.Controls.Add(this.consumeTxt);
            this.gpBox.Controls.Add(this.goalTxt);
            this.gpBox.Controls.Add(this.stratumTxt);
            this.gpBox.Controls.Add(this.consumeLbl);
            this.gpBox.Controls.Add(this.goalLbl);
            this.gpBox.Controls.Add(this.stratumLabel);
            this.gpBox.Controls.Add(this.idCardLbl);
            this.gpBox.Controls.Add(this.idCardTxt);
            this.gpBox.Controls.Add(this.clearBtn);
            this.gpBox.Controls.Add(this.registerBtn);
            this.gpBox.Controls.Add(this.label1);
            this.gpBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpBox.Name = "gpBox";
            this.gpBox.TabStop = false;
            // 
            // Form2
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.Controls.Add(this.gpBox);
            this.Name = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gpBox.ResumeLayout(false);
            this.gpBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox consumeTxt;
        private System.Windows.Forms.TextBox goalTxt;
        private System.Windows.Forms.TextBox stratumTxt;
        private System.Windows.Forms.Label consumeLbl;
        private System.Windows.Forms.Label goalLbl;
        private System.Windows.Forms.Label stratumLabel;
        private System.Windows.Forms.Label idCardLbl;
        private System.Windows.Forms.TextBox idCardTxt;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpBox;
    }
}