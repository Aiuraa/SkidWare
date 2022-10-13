namespace SkidWare
{
    partial class SkidWareForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SkidWareForm));
            this.richTextBoxScript = new System.Windows.Forms.RichTextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExecute = new System.Windows.Forms.Button();
            this.labelLogo = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.labelClose = new System.Windows.Forms.Label();
            this.labelMinimize = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnAttach = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBoxScript
            // 
            this.richTextBoxScript.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxScript.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxScript.Location = new System.Drawing.Point(13, 136);
            this.richTextBoxScript.Name = "richTextBoxScript";
            this.richTextBoxScript.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.richTextBoxScript.Size = new System.Drawing.Size(427, 173);
            this.richTextBoxScript.TabIndex = 0;
            this.richTextBoxScript.Text = "Insert your script here";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(13, 107);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.OnLoadButtonClicked);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(94, 107);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.OnButtonSaveClicked);
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(366, 322);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(74, 26);
            this.btnExecute.TabIndex = 3;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.OnButtonExecuteClicked);
            // 
            // labelLogo
            // 
            this.labelLogo.AutoSize = true;
            this.labelLogo.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelLogo.Location = new System.Drawing.Point(2, 6);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(167, 41);
            this.labelLogo.TabIndex = 5;
            this.labelLogo.Text = "SkidWare";
            this.labelLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnSkidWareFormMouseDown);
            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelClose.Location = new System.Drawing.Point(423, 9);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(23, 25);
            this.labelClose.TabIndex = 6;
            this.labelClose.Text = "x";
            this.labelClose.Click += new System.EventHandler(this.OnButtonCloseClicked);
            // 
            // labelMinimize
            // 
            this.labelMinimize.AutoSize = true;
            this.labelMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinimize.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelMinimize.Location = new System.Drawing.Point(392, 9);
            this.labelMinimize.Name = "labelMinimize";
            this.labelMinimize.Size = new System.Drawing.Size(25, 25);
            this.labelMinimize.TabIndex = 7;
            this.labelMinimize.Text = "_";
            this.labelMinimize.Click += new System.EventHandler(this.OnButtonMinimizeClicked);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelStatus.Location = new System.Drawing.Point(9, 47);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(130, 21);
            this.labelStatus.TabIndex = 8;
            this.labelStatus.Text = "Status: Initializing";
            this.labelStatus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnSkidWareFormMouseDown);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.linkLabel1.Location = new System.Drawing.Point(12, 335);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(96, 13);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Copyleft 2022 - Ebi";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnButtonCopyleftClicked);
            // 
            // btnAttach
            // 
            this.btnAttach.Location = new System.Drawing.Point(287, 322);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(73, 26);
            this.btnAttach.TabIndex = 10;
            this.btnAttach.Text = "Attach";
            this.btnAttach.UseVisualStyleBackColor = true;
            this.btnAttach.Click += new System.EventHandler(this.OnButtonAttachClicked);
            // 
            // SkidWareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(455, 364);
            this.Controls.Add(this.btnAttach);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelMinimize);
            this.Controls.Add(this.labelClose);
            this.Controls.Add(this.labelLogo);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.richTextBoxScript);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SkidWareForm";
            this.Load += new System.EventHandler(this.OnSkidWareFormLoad);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnSkidWareFormMouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxScript;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.Label labelMinimize;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnAttach;
    }
}

