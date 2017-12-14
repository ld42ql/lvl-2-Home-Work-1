using System.Drawing;

namespace Game_Asteroids
{
    partial class MainScreen
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnRecords = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.BoxRecords = new System.Windows.Forms.GroupBox();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.Lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.AutoSize = true;
            this.btnStart.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnStart.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.ForeColor = System.Drawing.Color.DarkRed;
            this.btnStart.Location = new System.Drawing.Point(775, 437);
            this.btnStart.Margin = new System.Windows.Forms.Padding(0);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(127, 44);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnRecords
            // 
            this.btnRecords.AutoSize = true;
            this.btnRecords.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnRecords.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecords.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRecords.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRecords.ForeColor = System.Drawing.Color.DarkRed;
            this.btnRecords.Location = new System.Drawing.Point(775, 487);
            this.btnRecords.Name = "btnRecords";
            this.btnRecords.Size = new System.Drawing.Size(127, 44);
            this.btnRecords.TabIndex = 1;
            this.btnRecords.Text = "Records";
            this.btnRecords.UseVisualStyleBackColor = false;
            this.btnRecords.Click += new System.EventHandler(this.BtnRecords_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.ForeColor = System.Drawing.Color.DarkRed;
            this.btnExit.Location = new System.Drawing.Point(775, 537);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(127, 44);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BoxRecords
            // 
            this.BoxRecords.BackColor = System.Drawing.Color.Transparent;
            this.BoxRecords.Font = new System.Drawing.Font("Roboto Black", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BoxRecords.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BoxRecords.Location = new System.Drawing.Point(154, 12);
            this.BoxRecords.Name = "BoxRecords";
            this.BoxRecords.Size = new System.Drawing.Size(583, 687);
            this.BoxRecords.TabIndex = 4;
            this.BoxRecords.TabStop = false;
            this.BoxRecords.Text = "Records ";
            this.BoxRecords.Visible = false;
            // 
            // BtnReturn
            // 
            this.BtnReturn.BackColor = System.Drawing.Color.White;
            this.BtnReturn.Font = new System.Drawing.Font("Roboto Medium", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnReturn.ForeColor = System.Drawing.Color.Black;
            this.BtnReturn.Location = new System.Drawing.Point(743, 669);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(66, 30);
            this.BtnReturn.TabIndex = 0;
            this.BtnReturn.Text = "Return";
            this.BtnReturn.UseVisualStyleBackColor = false;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // Lbl
            // 
            this.Lbl.AutoSize = true;
            this.Lbl.BackColor = System.Drawing.Color.Transparent;
            this.Lbl.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl.Location = new System.Drawing.Point(681, 688);
            this.Lbl.Name = "Lbl";
            this.Lbl.Size = new System.Drawing.Size(234, 23);
            this.Lbl.TabIndex = 0;
            this.Lbl.Text = "\"Автор: Владимир Балеев\"";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Game_Asteroids.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(914, 711);
            this.Controls.Add(this.Lbl);
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.BoxRecords);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRecords);
            this.Controls.Add(this.btnStart);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(930, 750);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(930, 736);
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Asteroids";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnRecords;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox BoxRecords;
        private System.Windows.Forms.Button BtnReturn;
        private System.Windows.Forms.Label Lbl;
    }
}

