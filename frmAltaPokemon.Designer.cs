
namespace POKEMON
{
    partial class frmAltaPokemon
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
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.tboxNumber = new System.Windows.Forms.TextBox();
            this.tboxDesc = new System.Windows.Forms.TextBox();
            this.tboxName = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblWeak = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.cboWeak = new System.Windows.Forms.ComboBox();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbxPokemon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(12, 33);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(44, 13);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "Number";
            this.lblNumber.Click += new System.EventHandler(this.lblNumber_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 69);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            this.lblName.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(12, 98);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description";
            // 
            // tboxNumber
            // 
            this.tboxNumber.Location = new System.Drawing.Point(74, 30);
            this.tboxNumber.Name = "tboxNumber";
            this.tboxNumber.Size = new System.Drawing.Size(255, 20);
            this.tboxNumber.TabIndex = 1;
            // 
            // tboxDesc
            // 
            this.tboxDesc.Location = new System.Drawing.Point(74, 95);
            this.tboxDesc.Name = "tboxDesc";
            this.tboxDesc.Size = new System.Drawing.Size(255, 20);
            this.tboxDesc.TabIndex = 3;
            this.tboxDesc.TextChanged += new System.EventHandler(this.tboxDesc_TextChanged);
            // 
            // tboxName
            // 
            this.tboxName.Location = new System.Drawing.Point(74, 66);
            this.tboxName.Name = "tboxName";
            this.tboxName.Size = new System.Drawing.Size(255, 20);
            this.tboxName.TabIndex = 2;
            this.tboxName.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(76, 233);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(256, 233);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblWeak
            // 
            this.lblWeak.AutoSize = true;
            this.lblWeak.Location = new System.Drawing.Point(14, 201);
            this.lblWeak.Name = "lblWeak";
            this.lblWeak.Size = new System.Drawing.Size(58, 13);
            this.lblWeak.TabIndex = 8;
            this.lblWeak.Text = "Weakness";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(12, 168);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 9;
            this.lblType.Text = "Type";
            this.lblType.Click += new System.EventHandler(this.lblType_Click);
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(74, 165);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(121, 21);
            this.cboType.TabIndex = 5;
            // 
            // cboWeak
            // 
            this.cboWeak.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboWeak.FormattingEnabled = true;
            this.cboWeak.Location = new System.Drawing.Point(74, 198);
            this.cboWeak.Name = "cboWeak";
            this.cboWeak.Size = new System.Drawing.Size(121, 21);
            this.cboWeak.TabIndex = 6;
            // 
            // tbUrl
            // 
            this.tbUrl.Location = new System.Drawing.Point(74, 127);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(255, 20);
            this.tbUrl.TabIndex = 4;
            this.tbUrl.Leave += new System.EventHandler(this.tbUrl_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Url Img";
            // 
            // pbxPokemon
            // 
            this.pbxPokemon.Location = new System.Drawing.Point(335, 30);
            this.pbxPokemon.Name = "pbxPokemon";
            this.pbxPokemon.Size = new System.Drawing.Size(196, 189);
            this.pbxPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPokemon.TabIndex = 14;
            this.pbxPokemon.TabStop = false;
            // 
            // frmAltaPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(543, 318);
            this.Controls.Add(this.pbxPokemon);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboWeak);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblWeak);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tboxName);
            this.Controls.Add(this.tboxDesc);
            this.Controls.Add(this.tboxNumber);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblNumber);
            this.Name = "frmAltaPokemon";
            this.Text = "New Pokemon";
            this.Load += new System.EventHandler(this.frmAltaPokemon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPokemon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox tboxNumber;
        private System.Windows.Forms.TextBox tboxDesc;
        private System.Windows.Forms.TextBox tboxName;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblWeak;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.ComboBox cboWeak;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbxPokemon;
    }
}