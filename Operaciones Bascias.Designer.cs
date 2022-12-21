namespace Clase_19_09_222
{
    partial class BasicOperations
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.lbnum1 = new System.Windows.Forms.Label();
            this.lbnum2 = new System.Windows.Forms.Label();
            this.btnplus = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnmulti = new System.Windows.Forms.Button();
            this.btndivide = new System.Windows.Forms.Button();
            this.btnmin = new System.Windows.Forms.Button();
            this.ValidateError = new System.Windows.Forms.ErrorProvider(this.components);
            this.LstHistoryResult = new System.Windows.Forms.ListBox();
            this.btnCleanlts = new System.Windows.Forms.Button();
            this.LbDatetime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ValidateError)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnum1
            // 
            this.txtnum1.BackColor = System.Drawing.Color.White;
            this.txtnum1.Location = new System.Drawing.Point(32, 41);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(86, 22);
            this.txtnum1.TabIndex = 2;
            // 
            // txtnum2
            // 
            this.txtnum2.Location = new System.Drawing.Point(167, 41);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(100, 22);
            this.txtnum2.TabIndex = 3;
            // 
            // lbnum1
            // 
            this.lbnum1.Location = new System.Drawing.Point(32, 9);
            this.lbnum1.Name = "lbnum1";
            this.lbnum1.Size = new System.Drawing.Size(86, 16);
            this.lbnum1.TabIndex = 0;
            this.lbnum1.Text = "Number 1";
            this.lbnum1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbnum2
            // 
            this.lbnum2.Location = new System.Drawing.Point(167, 9);
            this.lbnum2.Name = "lbnum2";
            this.lbnum2.Size = new System.Drawing.Size(100, 16);
            this.lbnum2.TabIndex = 1;
            this.lbnum2.Text = "Number 2";
            this.lbnum2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnplus
            // 
            this.btnplus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnplus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnplus.Location = new System.Drawing.Point(16, 83);
            this.btnplus.Name = "btnplus";
            this.btnplus.Size = new System.Drawing.Size(255, 31);
            this.btnplus.TabIndex = 4;
            this.btnplus.Text = "+";
            this.btnplus.UseVisualStyleBackColor = true;
            this.btnplus.Click += new System.EventHandler(this.btnplus_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.Red;
            this.btnsalir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnsalir.ForeColor = System.Drawing.Color.Black;
            this.btnsalir.Location = new System.Drawing.Point(1233, 380);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(80, 23);
            this.btnsalir.TabIndex = 15;
            this.btnsalir.Text = "CLOSE";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnmulti
            // 
            this.btnmulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmulti.Location = new System.Drawing.Point(17, 183);
            this.btnmulti.Name = "btnmulti";
            this.btnmulti.Size = new System.Drawing.Size(255, 31);
            this.btnmulti.TabIndex = 6;
            this.btnmulti.Text = "*";
            this.btnmulti.UseVisualStyleBackColor = true;
            this.btnmulti.Click += new System.EventHandler(this.btnmulti_Click);
            // 
            // btndivide
            // 
            this.btndivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndivide.Location = new System.Drawing.Point(17, 235);
            this.btndivide.Name = "btndivide";
            this.btndivide.Size = new System.Drawing.Size(256, 31);
            this.btndivide.TabIndex = 7;
            this.btndivide.Text = "%";
            this.btndivide.UseVisualStyleBackColor = true;
            this.btndivide.Click += new System.EventHandler(this.btndivide_Click);
            // 
            // btnmin
            // 
            this.btnmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmin.Location = new System.Drawing.Point(17, 132);
            this.btnmin.Name = "btnmin";
            this.btnmin.Size = new System.Drawing.Size(255, 31);
            this.btnmin.TabIndex = 5;
            this.btnmin.Text = "-";
            this.btnmin.UseVisualStyleBackColor = true;
            this.btnmin.Click += new System.EventHandler(this.btnmin_Click);
            // 
            // ValidateError
            // 
            this.ValidateError.ContainerControl = this;
            // 
            // LstHistoryResult
            // 
            this.LstHistoryResult.FormattingEnabled = true;
            this.LstHistoryResult.ItemHeight = 16;
            this.LstHistoryResult.Location = new System.Drawing.Point(315, 86);
            this.LstHistoryResult.Name = "LstHistoryResult";
            this.LstHistoryResult.ScrollAlwaysVisible = true;
            this.LstHistoryResult.Size = new System.Drawing.Size(356, 180);
            this.LstHistoryResult.TabIndex = 11;
            // 
            // btnCleanlts
            // 
            this.btnCleanlts.AutoSize = true;
            this.btnCleanlts.Location = new System.Drawing.Point(558, 54);
            this.btnCleanlts.Name = "btnCleanlts";
            this.btnCleanlts.Size = new System.Drawing.Size(113, 26);
            this.btnCleanlts.TabIndex = 12;
            this.btnCleanlts.Text = "Delete History";
            this.btnCleanlts.UseVisualStyleBackColor = true;
            this.btnCleanlts.Click += new System.EventHandler(this.btnCleanlts_Click);
            // 
            // LbDatetime
            // 
            this.LbDatetime.AutoSize = true;
            this.LbDatetime.BackColor = System.Drawing.Color.OldLace;
            this.LbDatetime.Location = new System.Drawing.Point(1047, 9);
            this.LbDatetime.Name = "LbDatetime";
            this.LbDatetime.Size = new System.Drawing.Size(0, 16);
            this.LbDatetime.TabIndex = 14;
            // 
            // BasicOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1325, 415);
            this.Controls.Add(this.LbDatetime);
            this.Controls.Add(this.btnCleanlts);
            this.Controls.Add(this.LstHistoryResult);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnmin);
            this.Controls.Add(this.btndivide);
            this.Controls.Add(this.btnmulti);
            this.Controls.Add(this.btnplus);
            this.Controls.Add(this.lbnum2);
            this.Controls.Add(this.lbnum1);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.txtnum1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "BasicOperations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operaciones Basicas";
            this.Load += new System.EventHandler(this.BasicOperations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ValidateError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.Label lbnum1;
        private System.Windows.Forms.Label lbnum2;
        private System.Windows.Forms.Button btnplus;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnmulti;
        private System.Windows.Forms.Button btndivide;
        private System.Windows.Forms.Button btnmin;
        private System.Windows.Forms.ErrorProvider ValidateError;
        private System.Windows.Forms.ListBox LstHistoryResult;
        private System.Windows.Forms.Button btnCleanlts;
        private System.Windows.Forms.Label LbDatetime;
    }
}

