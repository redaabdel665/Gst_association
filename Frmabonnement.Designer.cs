namespace Gst_association
{
    partial class Frmabonnement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmabonnement));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Txtdateabonnement = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.Cmbidclient = new System.Windows.Forms.ComboBox();
            this.Txtidabonnement = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txtmontantpaye = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Adresse = new System.Windows.Forms.Label();
            this.Txtnrcontrat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txtnomclient = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txtprenomclient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Dgvabonnement = new System.Windows.Forms.DataGridView();
            this.Btnmodifier = new System.Windows.Forms.Button();
            this.Btnsupprimer = new System.Windows.Forms.Button();
            this.Btnajouter = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgvabonnement)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Txtdateabonnement);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Cmbidclient);
            this.panel1.Controls.Add(this.Txtidabonnement);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.Txtmontantpaye);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Adresse);
            this.panel1.Controls.Add(this.Txtnrcontrat);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Txtnomclient);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Txtprenomclient);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Location = new System.Drawing.Point(11, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 383);
            this.panel1.TabIndex = 16;
            // 
            // Txtdateabonnement
            // 
            this.Txtdateabonnement.CalendarFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtdateabonnement.CustomFormat = "";
            this.Txtdateabonnement.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtdateabonnement.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Txtdateabonnement.Location = new System.Drawing.Point(204, 266);
            this.Txtdateabonnement.Name = "Txtdateabonnement";
            this.Txtdateabonnement.RightToLeftLayout = true;
            this.Txtdateabonnement.Size = new System.Drawing.Size(201, 27);
            this.Txtdateabonnement.TabIndex = 6;
            this.Txtdateabonnement.ValueChanged += new System.EventHandler(this.Txtdateabonnement_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(114, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 21);
            this.label4.TabIndex = 16;
            this.label4.Text = "Id Client :";
            // 
            // Cmbidclient
            // 
            this.Cmbidclient.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmbidclient.FormattingEnabled = true;
            this.Cmbidclient.Location = new System.Drawing.Point(204, 83);
            this.Cmbidclient.Name = "Cmbidclient";
            this.Cmbidclient.Size = new System.Drawing.Size(201, 29);
            this.Cmbidclient.TabIndex = 1;
            this.Cmbidclient.SelectedIndexChanged += new System.EventHandler(this.Cmbidclient_SelectedIndexChanged);
            this.Cmbidclient.SelectionChangeCommitted += new System.EventHandler(this.Cmbidclient_SelectionChangeCommitted);
            // 
            // Txtidabonnement
            // 
            this.Txtidabonnement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txtidabonnement.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtidabonnement.Location = new System.Drawing.Point(204, 38);
            this.Txtidabonnement.Name = "Txtidabonnement";
            this.Txtidabonnement.Size = new System.Drawing.Size(201, 27);
            this.Txtidabonnement.TabIndex = 0;
            this.Txtidabonnement.WordWrap = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label6.Location = new System.Drawing.Point(32, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Frais Abonnement :";
            // 
            // Txtmontantpaye
            // 
            this.Txtmontantpaye.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txtmontantpaye.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtmontantpaye.Location = new System.Drawing.Point(204, 312);
            this.Txtmontantpaye.Name = "Txtmontantpaye";
            this.Txtmontantpaye.Size = new System.Drawing.Size(201, 27);
            this.Txtmontantpaye.TabIndex = 7;
            this.Txtmontantpaye.WordWrap = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label5.Location = new System.Drawing.Point(30, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Date Abonnement :";
            // 
            // Adresse
            // 
            this.Adresse.AutoSize = true;
            this.Adresse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Adresse.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adresse.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Adresse.Location = new System.Drawing.Point(94, 220);
            this.Adresse.Name = "Adresse";
            this.Adresse.Size = new System.Drawing.Size(99, 21);
            this.Adresse.TabIndex = 7;
            this.Adresse.Text = "Nr contrat :";
            // 
            // Txtnrcontrat
            // 
            this.Txtnrcontrat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txtnrcontrat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtnrcontrat.Location = new System.Drawing.Point(204, 220);
            this.Txtnrcontrat.Name = "Txtnrcontrat";
            this.Txtnrcontrat.Size = new System.Drawing.Size(201, 27);
            this.Txtnrcontrat.TabIndex = 5;
            this.Txtnrcontrat.WordWrap = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(138, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nom :";
            // 
            // Txtnomclient
            // 
            this.Txtnomclient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txtnomclient.Enabled = false;
            this.Txtnomclient.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtnomclient.Location = new System.Drawing.Point(204, 128);
            this.Txtnomclient.Name = "Txtnomclient";
            this.Txtnomclient.Size = new System.Drawing.Size(201, 27);
            this.Txtnomclient.TabIndex = 3;
            this.Txtnomclient.WordWrap = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(114, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prénom :";
            // 
            // Txtprenomclient
            // 
            this.Txtprenomclient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txtprenomclient.Enabled = false;
            this.Txtprenomclient.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtprenomclient.Location = new System.Drawing.Point(204, 174);
            this.Txtprenomclient.Name = "Txtprenomclient";
            this.Txtprenomclient.Size = new System.Drawing.Size(201, 27);
            this.Txtprenomclient.TabIndex = 4;
            this.Txtprenomclient.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(54, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id Abonnement :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.Dgvabonnement);
            this.panel2.Location = new System.Drawing.Point(475, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(532, 475);
            this.panel2.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Image = global::Gst_association.Properties.Resources.icons8_rechercher_des_contacts_16;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(208, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 29);
            this.button1.TabIndex = 12;
            this.button1.Text = "Sélectionner";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dgvabonnement
            // 
            this.Dgvabonnement.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dgvabonnement.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgvabonnement.CausesValidation = false;
            this.Dgvabonnement.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgvabonnement.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgvabonnement.ColumnHeadersHeight = 35;
            this.Dgvabonnement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Dgvabonnement.EnableHeadersVisualStyles = false;
            this.Dgvabonnement.Location = new System.Drawing.Point(13, 22);
            this.Dgvabonnement.MultiSelect = false;
            this.Dgvabonnement.Name = "Dgvabonnement";
            this.Dgvabonnement.ReadOnly = true;
            this.Dgvabonnement.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgvabonnement.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Dgvabonnement.RowHeadersVisible = false;
            this.Dgvabonnement.RowHeadersWidth = 55;
            this.Dgvabonnement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgvabonnement.Size = new System.Drawing.Size(505, 406);
            this.Dgvabonnement.TabIndex = 11;
            this.Dgvabonnement.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgvabonnement_CellContentClick);
            // 
            // Btnmodifier
            // 
            this.Btnmodifier.BackColor = System.Drawing.Color.Lime;
            this.Btnmodifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btnmodifier.FlatAppearance.BorderSize = 0;
            this.Btnmodifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnmodifier.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnmodifier.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btnmodifier.Location = new System.Drawing.Point(213, 455);
            this.Btnmodifier.Name = "Btnmodifier";
            this.Btnmodifier.Size = new System.Drawing.Size(91, 26);
            this.Btnmodifier.TabIndex = 9;
            this.Btnmodifier.Text = "Modifier";
            this.Btnmodifier.UseVisualStyleBackColor = false;
            this.Btnmodifier.Click += new System.EventHandler(this.Btnmodifier_Click);
            // 
            // Btnsupprimer
            // 
            this.Btnsupprimer.BackColor = System.Drawing.Color.Red;
            this.Btnsupprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btnsupprimer.FlatAppearance.BorderSize = 0;
            this.Btnsupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnsupprimer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnsupprimer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btnsupprimer.Location = new System.Drawing.Point(310, 455);
            this.Btnsupprimer.Name = "Btnsupprimer";
            this.Btnsupprimer.Size = new System.Drawing.Size(91, 26);
            this.Btnsupprimer.TabIndex = 10;
            this.Btnsupprimer.Text = "Supprimer";
            this.Btnsupprimer.UseVisualStyleBackColor = false;
            this.Btnsupprimer.Click += new System.EventHandler(this.Btnsupprimer_Click);
            // 
            // Btnajouter
            // 
            this.Btnajouter.BackColor = System.Drawing.SystemColors.Highlight;
            this.Btnajouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btnajouter.FlatAppearance.BorderSize = 0;
            this.Btnajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnajouter.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnajouter.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btnajouter.Location = new System.Drawing.Point(116, 455);
            this.Btnajouter.Name = "Btnajouter";
            this.Btnajouter.Size = new System.Drawing.Size(91, 26);
            this.Btnajouter.TabIndex = 8;
            this.Btnajouter.Text = "Ajouter";
            this.Btnajouter.UseVisualStyleBackColor = false;
            this.Btnajouter.Click += new System.EventHandler(this.Btnajouter_Click);
            // 
            // Frmabonnement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 538);
            this.Controls.Add(this.Btnmodifier);
            this.Controls.Add(this.Btnsupprimer);
            this.Controls.Add(this.Btnajouter);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frmabonnement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fiche des abonnements";
            this.Load += new System.EventHandler(this.Frmabonnement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgvabonnement)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txtmontantpaye;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Adresse;
        private System.Windows.Forms.TextBox Txtnrcontrat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txtnomclient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txtprenomclient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView Dgvabonnement;
        private System.Windows.Forms.DateTimePicker Txtdateabonnement;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Cmbidclient;
        private System.Windows.Forms.TextBox Txtidabonnement;
        private System.Windows.Forms.Button Btnmodifier;
        private System.Windows.Forms.Button Btnsupprimer;
        private System.Windows.Forms.Button Btnajouter;
    }
}