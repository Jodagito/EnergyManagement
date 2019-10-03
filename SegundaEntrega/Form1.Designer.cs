namespace SegundaEntrega
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
            this.label1 = new System.Windows.Forms.Label();
            this.registerBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.idCardTxt = new System.Windows.Forms.TextBox();
            this.idCardLbl = new System.Windows.Forms.Label();
            this.stratumLabel = new System.Windows.Forms.Label();
            this.goalLbl = new System.Windows.Forms.Label();
            this.consumeLbl = new System.Windows.Forms.Label();
            this.stratumTxt = new System.Windows.Forms.TextBox();
            this.goalTxt = new System.Windows.Forms.TextBox();
            this.consumeTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 91);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido";
            // 
            // registerBtn
            // 
            this.registerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerBtn.Location = new System.Drawing.Point(17, 334);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(142, 47);
            this.registerBtn.TabIndex = 1;
            this.registerBtn.Text = "Registrar";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(289, 334);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(142, 47);
            this.clearBtn.TabIndex = 2;
            this.clearBtn.Text = "Limpiar";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // idCardTxt
            // 
            this.idCardTxt.AccessibleDescription = "Cédula del usuario";
            this.idCardTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idCardTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idCardTxt.Location = new System.Drawing.Point(289, 101);
            this.idCardTxt.Name = "idCardTxt";
            this.idCardTxt.Size = new System.Drawing.Size(142, 23);
            this.idCardTxt.TabIndex = 3;
            this.idCardTxt.Tag = "";
            // 
            // idCardLbl
            // 
            this.idCardLbl.AutoSize = true;
            this.idCardLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idCardLbl.Location = new System.Drawing.Point(14, 90);
            this.idCardLbl.Name = "idCardLbl";
            this.idCardLbl.Size = new System.Drawing.Size(100, 31);
            this.idCardLbl.TabIndex = 4;
            this.idCardLbl.Text = "Cédula";
            // 
            // stratumLabel
            // 
            this.stratumLabel.AutoSize = true;
            this.stratumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stratumLabel.Location = new System.Drawing.Point(14, 140);
            this.stratumLabel.Name = "stratumLabel";
            this.stratumLabel.Size = new System.Drawing.Size(101, 31);
            this.stratumLabel.TabIndex = 5;
            this.stratumLabel.Text = "Estrato";
            // 
            // goalLbl
            // 
            this.goalLbl.AutoSize = true;
            this.goalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goalLbl.Location = new System.Drawing.Point(14, 194);
            this.goalLbl.Name = "goalLbl";
            this.goalLbl.Size = new System.Drawing.Size(228, 31);
            this.goalLbl.TabIndex = 6;
            this.goalLbl.Text = "Meta de consumo";
            // 
            // consumeLbl
            // 
            this.consumeLbl.AutoSize = true;
            this.consumeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consumeLbl.Location = new System.Drawing.Point(14, 247);
            this.consumeLbl.Name = "consumeLbl";
            this.consumeLbl.Size = new System.Drawing.Size(210, 31);
            this.consumeLbl.TabIndex = 7;
            this.consumeLbl.Text = "Consumo actual";
            // 
            // stratumTxt
            // 
            this.stratumTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stratumTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stratumTxt.Location = new System.Drawing.Point(289, 151);
            this.stratumTxt.Name = "stratumTxt";
            this.stratumTxt.Size = new System.Drawing.Size(142, 23);
            this.stratumTxt.TabIndex = 9;
            // 
            // goalTxt
            // 
            this.goalTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.goalTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goalTxt.Location = new System.Drawing.Point(289, 205);
            this.goalTxt.Name = "goalTxt";
            this.goalTxt.Size = new System.Drawing.Size(142, 23);
            this.goalTxt.TabIndex = 10;
            // 
            // consumeTxt
            // 
            this.consumeTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.consumeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consumeTxt.Location = new System.Drawing.Point(289, 258);
            this.consumeTxt.Name = "consumeTxt";
            this.consumeTxt.Size = new System.Drawing.Size(142, 23);
            this.consumeTxt.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 425);
            this.Controls.Add(this.consumeTxt);
            this.Controls.Add(this.goalTxt);
            this.Controls.Add(this.stratumTxt);
            this.Controls.Add(this.consumeLbl);
            this.Controls.Add(this.goalLbl);
            this.Controls.Add(this.stratumLabel);
            this.Controls.Add(this.idCardLbl);
            this.Controls.Add(this.idCardTxt);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calculadora Consumo de Energía";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.TextBox idCardTxt;
        private System.Windows.Forms.Label idCardLbl;
        private System.Windows.Forms.Label stratumLabel;
        private System.Windows.Forms.Label goalLbl;
        private System.Windows.Forms.Label consumeLbl;
        private System.Windows.Forms.TextBox stratumTxt;
        private System.Windows.Forms.TextBox goalTxt;
        private System.Windows.Forms.TextBox consumeTxt;
    }
}

