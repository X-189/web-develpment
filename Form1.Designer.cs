using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    partial class Form1
    {
            private System.ComponentModel.IContainer components = null;
            private Label lblTitle;
            private Label lblName;
            private Label lblEmail;
            private Label lblEvent;
            private Label lblID;
            private TextBox txtName;
            private TextBox txtEmail;
            private ComboBox cmbEvent;
            private PictureBox picID;
            private Button btnBrowse;
            private Button btnSubmit;

            protected override void Dispose(bool disposing)
            {
                if (disposing && (components != null)) components.Dispose();
                base.Dispose(disposing);
            }

            private void InitializeComponent()
            {
                this.lblTitle = new Label();
                this.lblName = new Label();
                this.lblEmail = new Label();
                this.lblEvent = new Label();
                this.lblID = new Label();
                this.txtName = new TextBox();
                this.txtEmail = new TextBox();
                this.cmbEvent = new ComboBox();
                this.picID = new PictureBox();
                this.btnBrowse = new Button();
                this.btnSubmit = new Button();
                ((System.ComponentModel.ISupportInitialize)(this.picID)).BeginInit();
                this.SuspendLayout();

                // lblTitle
                this.lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
                this.lblTitle.Text = "Event Registration System";
                this.lblTitle.AutoSize = true;
                this.lblTitle.Location = new Point(60, 20);

                // lblName
                this.lblName.Text = "Full Name:";
                this.lblName.Location = new Point(40, 80);

                // txtName
                this.txtName.Location = new Point(160, 80);
                this.txtName.Width = 200;

                // lblEmail
                this.lblEmail.Text = "Email:";
                this.lblEmail.Location = new Point(40, 120);

                // txtEmail
                this.txtEmail.Location = new Point(160, 120);
                this.txtEmail.Width = 200;

                // lblEvent
                this.lblEvent.Text = "Select Event:";
                this.lblEvent.Location = new Point(40, 160);

                // cmbEvent
                this.cmbEvent.Location = new Point(160, 160);
                this.cmbEvent.Width = 200;

                // lblID
                this.lblID.Text = "Upload ID:";
                this.lblID.Location = new Point(40, 200);

                // picID
                this.picID.Location = new Point(160, 200);
                this.picID.Size = new Size(100, 100);
                this.picID.BorderStyle = BorderStyle.FixedSingle;

                // btnBrowse
                this.btnBrowse.Text = "Browse...";
                this.btnBrowse.Location = new Point(270, 200);
                this.btnBrowse.Click += new EventHandler(this.btnBrowse_Click);

                // btnSubmit
                this.btnSubmit.Text = "Register";
                this.btnSubmit.Location = new Point(160, 320);
                this.btnSubmit.Click += new EventHandler(this.btnSubmit_Click);

                // Form1
                this.ClientSize = new Size(450, 400);
                this.Controls.AddRange(new Control[] {
                lblTitle, lblName, txtName, lblEmail, txtEmail,
                lblEvent, cmbEvent, lblID, picID, btnBrowse, btnSubmit
            });
                this.Text = "Event Registration System";
                this.Load += new EventHandler(this.Form1_Load);

                ((System.ComponentModel.ISupportInitialize)(this.picID)).EndInit();
                this.ResumeLayout(false);
                this.PerformLayout();
            }
        }
    }