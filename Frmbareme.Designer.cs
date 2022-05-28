namespace Gst_association
{
    partial class Frmbareme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmbareme));
            this.Btnmodifier = new System.Windows.Forms.Button();
            this.Btnsupprimer = new System.Windows.Forms.Button();
            this.Btnajouter = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Dgvbareme = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Txtbarememin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txtbarememax = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txtidbareme = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgvbareme)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btnmodifier
            // 
            this.Btnmodifier.BackColor = System.Drawing.Color.Lime;
            this.Btnmodifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btnmodifier.FlatAppearance.BorderSize = 0;
            this.Btnmodifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnmodifier.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnmodifier.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btnmodifier.Location = new System.Drawing.Point(135, 236);
            this.Btnmodifier.Name = "Btnmodifier";
            this.Btnmodifier.Size = new System.Drawing.Size(91, 26);
            this.Btnmodifier.TabIndex = 18;
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
            this.Btnsupprimer.Location = new System.Drawing.Point(232, 236);
            this.Btnsupprimer.Name = "Btnsupprimer";
            this.Btnsupprimer.Size = new System.Drawing.Size(91, 26);
            this.Btnsupprimer.TabIndex = 19;
            this.Btnsupprimer.Text = "Supprimer";
            this.Btnsupprimer.UseVisualStyleBackColor = false;
            // 
            // Btnajouter
            // 
            this.Btnajouter.BackColor = System.Drawing.SystemColors.Highlight;
            this.Btnajouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btnajouter.FlatAppearance.BorderSize = 0;
            this.Btnajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnajouter.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnajouter.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btnajouter.Location = new System.Drawing.Point(38, 236);
            this.Btnajouter.Name = "Btnajouter";
            this.Btnajouter.Size = new System.Drawing.Size(91, 26);
            this.Btnajouter.TabIndex = 17;
            this.Btnajouter.Text = "Ajouter";
            this.Btnajouter.UseVisualStyleBackColor = false;
            this.Btnajouter.Click += new System.EventHandler(this.Btnajouter_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.Dgvbareme);
            this.panel2.Location = new System.Drawing.Point(395, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(539, 283);
            this.panel2.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Image = global::Gst_association.Properties.Resources.icons8_rechercher_des_contacts_16;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(203, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 28);
            this.button1.TabIndex = 22;
            this.button1.Text = "Sélectionner";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Dgvbareme
            // 
            this.Dgvbareme.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dgvbareme.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgvbareme.CausesValidation = false;
            this.Dgvbareme.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgvbareme.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgvbareme.ColumnHeadersHeight = 35;
            this.Dgvbareme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Dgvbareme.EnableHeadersVisualStyles = false;
            this.Dgvbareme.Location = new System.Drawing.Point(22, 4);
            this.Dgvbareme.MultiSelect = false;
            this.Dgvbareme.Name = "Dgvbareme";
            this.Dgvbareme.ReadOnly = true;
            this.Dgvbareme.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgvbareme.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Dgvbareme.RowHeadersVisible = false;
            this.Dgvbareme.RowHeadersWidth = 55;
            this.Dgvbareme.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgvbareme.Size = new System.Drawing.Size(499, 196);
            this.Dgvbareme.TabIndex = 14;
            this.Dgvbareme.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgvbareme_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Txtbarememin);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Txtbarememax);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Txtidbareme);
            this.panel1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Location = new System.Drawing.Point(10, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 202);
            this.panel1.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(5, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Qté Min :";
            // 
            // Txtbarememin
            // 
            this.Txtbarememin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txtbarememin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtbarememin.Location = new System.Drawing.Point(134, 77);
            this.Txtbarememin.Name = "Txtbarememin";
            this.Txtbarememin.Size = new System.Drawing.Size(201, 27);
            this.Txtbarememin.TabIndex = 1;
            this.Txtbarememin.WordWrap = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(5, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Qté Max :";
            // 
            // Txtbarememax
            // 
            this.Txtbarememax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txtbarememax.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtbarememax.Location = new System.Drawing.Point(134, 131);
            this.Txtbarememax.Name = "Txtbarememax";
            this.Txtbarememax.Size = new System.Drawing.Size(201, 27);
            this.Txtbarememax.TabIndex = 2;
            this.Txtbarememax.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(5, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Identifiant :";
            // 
            // Txtidbareme
            // 
            this.Txtidbareme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txtidbareme.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtidbareme.Location = new System.Drawing.Point(134, 24);
            this.Txtidbareme.Name = "Txtidbareme";
            this.Txtidbareme.Size = new System.Drawing.Size(201, 27);
            this.Txtidbareme.TabIndex = 0;
            this.Txtidbareme.WordWrap = false;
            // 
            // Frmbareme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 320);
            this.Controls.Add(this.Btnmodifier);
            this.Controls.Add(this.Btnsupprimer);
            this.Controls.Add(this.Btnajouter);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frmbareme";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fiche des Barèmes";
            this.Load += new System.EventHandler(this.Frmbareme_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgvbareme)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btnmodifier;
        private System.Windows.Forms.Button Btnsupprimer;
        private System.Windows.Forms.Button Btnajouter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView Dgvbareme;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txtbarememin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txtbarememax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txtidbareme;
    }
}