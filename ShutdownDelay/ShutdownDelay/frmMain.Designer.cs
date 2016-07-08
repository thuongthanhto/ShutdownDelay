namespace ShutdownDelay
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnMininize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHuyHenGio = new System.Windows.Forms.Button();
            this.btnHenGio = new System.Windows.Forms.Button();
            this.txtSoPhut = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMininize
            // 
            this.btnMininize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMininize.BackgroundImage")));
            this.btnMininize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMininize.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMininize.FlatAppearance.BorderSize = 0;
            this.btnMininize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMininize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMininize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMininize.Location = new System.Drawing.Point(392, 2);
            this.btnMininize.Name = "btnMininize";
            this.btnMininize.Size = new System.Drawing.Size(31, 31);
            this.btnMininize.TabIndex = 5;
            this.btnMininize.UseVisualStyleBackColor = true;
            this.btnMininize.Click += new System.EventHandler(this.btnMininize_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(429, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(31, 31);
            this.btnExit.TabIndex = 4;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Hẹn giờ tắt máy";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnHuyHenGio);
            this.panel1.Controls.Add(this.btnHenGio);
            this.panel1.Controls.Add(this.txtSoPhut);
            this.panel1.Location = new System.Drawing.Point(-1, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 201);
            this.panel1.TabIndex = 12;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseUp);
            // 
            // btnHuyHenGio
            // 
            this.btnHuyHenGio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(128)))));
            this.btnHuyHenGio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHuyHenGio.FlatAppearance.BorderSize = 0;
            this.btnHuyHenGio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(89)))), ((int)(((byte)(149)))));
            this.btnHuyHenGio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(89)))), ((int)(((byte)(149)))));
            this.btnHuyHenGio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyHenGio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyHenGio.ForeColor = System.Drawing.Color.White;
            this.btnHuyHenGio.Image = ((System.Drawing.Image)(resources.GetObject("btnHuyHenGio.Image")));
            this.btnHuyHenGio.Location = new System.Drawing.Point(256, 103);
            this.btnHuyHenGio.Name = "btnHuyHenGio";
            this.btnHuyHenGio.Size = new System.Drawing.Size(136, 45);
            this.btnHuyHenGio.TabIndex = 13;
            this.btnHuyHenGio.Text = "  Hủy hẹn giờ";
            this.btnHuyHenGio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuyHenGio.UseVisualStyleBackColor = false;
            this.btnHuyHenGio.Click += new System.EventHandler(this.btnHuyHenGio_Click);
            // 
            // btnHenGio
            // 
            this.btnHenGio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(128)))));
            this.btnHenGio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHenGio.FlatAppearance.BorderSize = 0;
            this.btnHenGio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(89)))), ((int)(((byte)(149)))));
            this.btnHenGio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(89)))), ((int)(((byte)(149)))));
            this.btnHenGio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHenGio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHenGio.ForeColor = System.Drawing.Color.White;
            this.btnHenGio.Image = ((System.Drawing.Image)(resources.GetObject("btnHenGio.Image")));
            this.btnHenGio.Location = new System.Drawing.Point(76, 103);
            this.btnHenGio.Name = "btnHenGio";
            this.btnHenGio.Size = new System.Drawing.Size(136, 45);
            this.btnHenGio.TabIndex = 12;
            this.btnHenGio.Text = "    Hẹn giờ";
            this.btnHenGio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHenGio.UseVisualStyleBackColor = false;
            this.btnHenGio.Click += new System.EventHandler(this.btnHenGio_Click);
            // 
            // txtSoPhut
            // 
            this.txtSoPhut.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoPhut.ForeColor = System.Drawing.Color.Gray;
            this.txtSoPhut.Location = new System.Drawing.Point(104, 48);
            this.txtSoPhut.Name = "txtSoPhut";
            this.txtSoPhut.Size = new System.Drawing.Size(255, 35);
            this.txtSoPhut.TabIndex = 11;
            this.txtSoPhut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSoPhut.Enter += new System.EventHandler(this.txtSoPhut_Enter);
            this.txtSoPhut.Leave += new System.EventHandler(this.txtSoPhut_Leave);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(89)))), ((int)(((byte)(149)))));
            this.ClientSize = new System.Drawing.Size(460, 231);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMininize);
            this.Controls.Add(this.btnExit);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMininize;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHuyHenGio;
        private System.Windows.Forms.Button btnHenGio;
        private System.Windows.Forms.TextBox txtSoPhut;
    }
}

