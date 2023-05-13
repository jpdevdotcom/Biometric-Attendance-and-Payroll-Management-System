namespace Attendance_and_Payroll_Management_System
{
    partial class CreateAccount2_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccount2_frm));
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            this.label8 = new System.Windows.Forms.Label();
            this.cboPosition = new Bunifu.UI.WinForms.BunifuDropdown();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.cboDepartment = new Bunifu.UI.WinForms.BunifuDropdown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLocation = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.txtDescription = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins", 9F);
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(25, 5);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 26);
            this.label8.TabIndex = 44;
            this.label8.Text = "Position";
            // 
            // cboPosition
            // 
            this.cboPosition.BackColor = System.Drawing.Color.White;
            this.cboPosition.BorderRadius = 1;
            this.cboPosition.Color = System.Drawing.Color.Silver;
            this.cboPosition.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cboPosition.DisabledColor = System.Drawing.Color.Gray;
            this.cboPosition.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboPosition.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cboPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPosition.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cboPosition.FillDropDown = false;
            this.cboPosition.FillIndicator = false;
            this.cboPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboPosition.Font = new System.Drawing.Font("Poppins", 9F);
            this.cboPosition.ForeColor = System.Drawing.Color.Silver;
            this.cboPosition.FormattingEnabled = true;
            this.cboPosition.Icon = null;
            this.cboPosition.IndicatorColor = System.Drawing.Color.Silver;
            this.cboPosition.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cboPosition.ItemBackColor = System.Drawing.Color.White;
            this.cboPosition.ItemBorderColor = System.Drawing.Color.White;
            this.cboPosition.ItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.cboPosition.ItemHeight = 26;
            this.cboPosition.ItemHighLightColor = System.Drawing.Color.SeaGreen;
            this.cboPosition.Items.AddRange(new object[] {
            "Chairman",
            "Manager",
            "Guard",
            "Cashier",
            "Treasurer",
            "Employee"});
            this.cboPosition.Location = new System.Drawing.Point(28, 33);
            this.cboPosition.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboPosition.Name = "cboPosition";
            this.cboPosition.Size = new System.Drawing.Size(448, 32);
            this.cboPosition.TabIndex = 42;
            this.cboPosition.Text = "Pick your Position";
            this.cboPosition.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboPosition_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 9F);
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(23, 84);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 26);
            this.label5.TabIndex = 38;
            this.label5.Text = "Description";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.ForeColor = System.Drawing.Color.Silver;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(-11, 180);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(527, 43);
            this.bunifuSeparator1.TabIndex = 45;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 9F);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(24, 238);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 26);
            this.label1.TabIndex = 49;
            this.label1.Text = "Department";
            // 
            // cboDepartment
            // 
            this.cboDepartment.BackColor = System.Drawing.Color.White;
            this.cboDepartment.BorderRadius = 1;
            this.cboDepartment.Color = System.Drawing.Color.Silver;
            this.cboDepartment.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cboDepartment.DisabledColor = System.Drawing.Color.Gray;
            this.cboDepartment.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboDepartment.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartment.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cboDepartment.FillDropDown = false;
            this.cboDepartment.FillIndicator = false;
            this.cboDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboDepartment.Font = new System.Drawing.Font("Poppins", 9F);
            this.cboDepartment.ForeColor = System.Drawing.Color.Silver;
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Icon = null;
            this.cboDepartment.IndicatorColor = System.Drawing.Color.Silver;
            this.cboDepartment.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cboDepartment.ItemBackColor = System.Drawing.Color.White;
            this.cboDepartment.ItemBorderColor = System.Drawing.Color.White;
            this.cboDepartment.ItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(65)))));
            this.cboDepartment.ItemHeight = 26;
            this.cboDepartment.ItemHighLightColor = System.Drawing.Color.SeaGreen;
            this.cboDepartment.Items.AddRange(new object[] {
            "Department of Foreign Affairs",
            "College of Science",
            "College of Engineering",
            "College of Business Administration",
            "College of Veterinary Medecine"});
            this.cboDepartment.Location = new System.Drawing.Point(27, 266);
            this.cboDepartment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(448, 32);
            this.cboDepartment.TabIndex = 48;
            this.cboDepartment.Text = "Pick your Department";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 9F);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(21, 316);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 26);
            this.label2.TabIndex = 46;
            this.label2.Text = "Location";
            // 
            // txtLocation
            // 
            this.txtLocation.AcceptsReturn = false;
            this.txtLocation.AcceptsTab = false;
            this.txtLocation.AnimationSpeed = 200;
            this.txtLocation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtLocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtLocation.BackColor = System.Drawing.Color.Transparent;
            this.txtLocation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtLocation.BackgroundImage")));
            this.txtLocation.BorderColorActive = System.Drawing.Color.SeaGreen;
            this.txtLocation.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtLocation.BorderColorHover = System.Drawing.Color.SeaGreen;
            this.txtLocation.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtLocation.BorderRadius = 10;
            this.txtLocation.BorderThickness = 1;
            this.txtLocation.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtLocation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLocation.DefaultFont = new System.Drawing.Font("Poppins", 10F);
            this.txtLocation.DefaultText = "";
            this.txtLocation.FillColor = System.Drawing.Color.White;
            this.txtLocation.HideSelection = true;
            this.txtLocation.IconLeft = null;
            this.txtLocation.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLocation.IconPadding = 10;
            this.txtLocation.IconRight = null;
            this.txtLocation.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLocation.Lines = new string[0];
            this.txtLocation.Location = new System.Drawing.Point(25, 343);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLocation.MaxLength = 32767;
            this.txtLocation.MinimumSize = new System.Drawing.Size(133, 43);
            this.txtLocation.Modified = false;
            this.txtLocation.Multiline = false;
            this.txtLocation.Name = "txtLocation";
            stateProperties1.BorderColor = System.Drawing.Color.SeaGreen;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtLocation.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.Empty;
            stateProperties2.FillColor = System.Drawing.Color.White;
            stateProperties2.ForeColor = System.Drawing.Color.Empty;
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtLocation.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.SeaGreen;
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtLocation.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtLocation.OnIdleState = stateProperties4;
            this.txtLocation.PasswordChar = '\0';
            this.txtLocation.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtLocation.PlaceholderText = "Department Location";
            this.txtLocation.ReadOnly = false;
            this.txtLocation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLocation.SelectedText = "";
            this.txtLocation.SelectionLength = 0;
            this.txtLocation.SelectionStart = 0;
            this.txtLocation.ShortcutsEnabled = true;
            this.txtLocation.Size = new System.Drawing.Size(451, 43);
            this.txtLocation.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtLocation.TabIndex = 47;
            this.txtLocation.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLocation.TextMarginBottom = 0;
            this.txtLocation.TextMarginLeft = 5;
            this.txtLocation.TextMarginTop = 0;
            this.txtLocation.TextPlaceholder = "Department Location";
            this.txtLocation.UseSystemPasswordChar = false;
            this.txtLocation.WordWrap = true;
            // 
            // txtDescription
            // 
            this.txtDescription.AcceptsReturn = false;
            this.txtDescription.AcceptsTab = false;
            this.txtDescription.AnimationSpeed = 200;
            this.txtDescription.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtDescription.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtDescription.BackColor = System.Drawing.Color.Transparent;
            this.txtDescription.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtDescription.BackgroundImage")));
            this.txtDescription.BorderColorActive = System.Drawing.Color.SeaGreen;
            this.txtDescription.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtDescription.BorderColorHover = System.Drawing.Color.SeaGreen;
            this.txtDescription.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtDescription.BorderRadius = 10;
            this.txtDescription.BorderThickness = 1;
            this.txtDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescription.DefaultFont = new System.Drawing.Font("Poppins", 10F);
            this.txtDescription.DefaultText = "";
            this.txtDescription.FillColor = System.Drawing.Color.White;
            this.txtDescription.HideSelection = true;
            this.txtDescription.IconLeft = null;
            this.txtDescription.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescription.IconPadding = 10;
            this.txtDescription.IconRight = null;
            this.txtDescription.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescription.Lines = new string[0];
            this.txtDescription.Location = new System.Drawing.Point(27, 111);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescription.MaxLength = 32767;
            this.txtDescription.MinimumSize = new System.Drawing.Size(133, 43);
            this.txtDescription.Modified = false;
            this.txtDescription.Multiline = false;
            this.txtDescription.Name = "txtDescription";
            stateProperties5.BorderColor = System.Drawing.Color.SeaGreen;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtDescription.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.Empty;
            stateProperties6.FillColor = System.Drawing.Color.White;
            stateProperties6.ForeColor = System.Drawing.Color.Empty;
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtDescription.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.SeaGreen;
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtDescription.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtDescription.OnIdleState = stateProperties8;
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtDescription.PlaceholderText = "Position Description";
            this.txtDescription.ReadOnly = false;
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescription.SelectedText = "";
            this.txtDescription.SelectionLength = 0;
            this.txtDescription.SelectionStart = 0;
            this.txtDescription.ShortcutsEnabled = true;
            this.txtDescription.Size = new System.Drawing.Size(451, 43);
            this.txtDescription.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtDescription.TabIndex = 39;
            this.txtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDescription.TextMarginBottom = 0;
            this.txtDescription.TextMarginLeft = 5;
            this.txtDescription.TextMarginTop = 0;
            this.txtDescription.TextPlaceholder = "Position Description";
            this.txtDescription.UseSystemPasswordChar = false;
            this.txtDescription.WordWrap = true;
            // 
            // CreateAccount2_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 399);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboDepartment);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cboPosition);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CreateAccount2_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateAccount2_frm";
            this.Load += new System.EventHandler(this.CreateAccount2_frm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public Bunifu.UI.WinForms.BunifuDropdown cboPosition;
        public Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtDescription;
        public Bunifu.UI.WinForms.BunifuDropdown cboDepartment;
        public Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtLocation;
    }
}