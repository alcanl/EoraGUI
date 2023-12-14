namespace EoraGuiDemo.Forms.ControlForms
{
    partial class UserControlPatient
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2ShadowPanelMain = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.ButtonDeleteSession = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonCreateSession = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonDeletePatient = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonEditPatient = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonSaveNotes = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonNewPatient = new Guna.UI2.WinForms.Guna2Button();
            this.tableLayoutPanelPatient = new System.Windows.Forms.TableLayoutPanel();
            this.guna2PanelNotes = new Guna.UI2.WinForms.Guna2Panel();
            this.labelNotes = new System.Windows.Forms.Label();
            this.guna2PanelSessionList = new Guna.UI2.WinForms.Guna2Panel();
            this.labelSessionList = new System.Windows.Forms.Label();
            this.guna2PanelPatientList = new Guna.UI2.WinForms.Guna2Panel();
            this.labelPatientList = new System.Windows.Forms.Label();
            this.guna2DataGridViewPatientList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelSessionData = new Guna.UI2.WinForms.Guna2Panel();
            this.DataGridViewSession = new Guna.UI2.WinForms.Guna2DataGridView();
            this.PanelNotes = new Guna.UI2.WinForms.Guna2Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientListDTOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.guna2ShadowPanelMain.SuspendLayout();
            this.tableLayoutPanelPatient.SuspendLayout();
            this.guna2PanelNotes.SuspendLayout();
            this.guna2PanelSessionList.SuspendLayout();
            this.guna2PanelPatientList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridViewPatientList)).BeginInit();
            this.PanelSessionData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewSession)).BeginInit();
            this.PanelNotes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientListDTOBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ShadowPanelMain
            // 
            this.guna2ShadowPanelMain.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanelMain.Controls.Add(this.ButtonDeleteSession);
            this.guna2ShadowPanelMain.Controls.Add(this.ButtonCreateSession);
            this.guna2ShadowPanelMain.Controls.Add(this.ButtonDeletePatient);
            this.guna2ShadowPanelMain.Controls.Add(this.ButtonEditPatient);
            this.guna2ShadowPanelMain.Controls.Add(this.ButtonSaveNotes);
            this.guna2ShadowPanelMain.Controls.Add(this.ButtonNewPatient);
            this.guna2ShadowPanelMain.Controls.Add(this.tableLayoutPanelPatient);
            this.guna2ShadowPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2ShadowPanelMain.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanelMain.Location = new System.Drawing.Point(0, 0);
            this.guna2ShadowPanelMain.Margin = new System.Windows.Forms.Padding(0);
            this.guna2ShadowPanelMain.MinimumSize = new System.Drawing.Size(1029, 586);
            this.guna2ShadowPanelMain.Name = "guna2ShadowPanelMain";
            this.guna2ShadowPanelMain.Radius = 5;
            this.guna2ShadowPanelMain.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanelMain.ShadowShift = 30;
            this.guna2ShadowPanelMain.Size = new System.Drawing.Size(1142, 610);
            this.guna2ShadowPanelMain.TabIndex = 1;
            // 
            // ButtonDeleteSession
            // 
            this.ButtonDeleteSession.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ButtonDeleteSession.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonDeleteSession.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonDeleteSession.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonDeleteSession.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonDeleteSession.FillColor = System.Drawing.Color.Transparent;
            this.ButtonDeleteSession.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonDeleteSession.ForeColor = System.Drawing.Color.Black;
            this.ButtonDeleteSession.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonDeleteSession.HoverState.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ButtonDeleteSession.Location = new System.Drawing.Point(517, 547);
            this.ButtonDeleteSession.MaximumSize = new System.Drawing.Size(123, 28);
            this.ButtonDeleteSession.MinimumSize = new System.Drawing.Size(113, 18);
            this.ButtonDeleteSession.Name = "ButtonDeleteSession";
            this.ButtonDeleteSession.Size = new System.Drawing.Size(113, 18);
            this.ButtonDeleteSession.TabIndex = 10;
            this.ButtonDeleteSession.Text = "Delete Session";
            // 
            // ButtonCreateSession
            // 
            this.ButtonCreateSession.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ButtonCreateSession.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonCreateSession.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonCreateSession.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonCreateSession.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonCreateSession.FillColor = System.Drawing.Color.Transparent;
            this.ButtonCreateSession.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonCreateSession.ForeColor = System.Drawing.Color.Black;
            this.ButtonCreateSession.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonCreateSession.HoverState.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ButtonCreateSession.Location = new System.Drawing.Point(398, 547);
            this.ButtonCreateSession.MaximumSize = new System.Drawing.Size(123, 28);
            this.ButtonCreateSession.MinimumSize = new System.Drawing.Size(113, 18);
            this.ButtonCreateSession.Name = "ButtonCreateSession";
            this.ButtonCreateSession.Size = new System.Drawing.Size(113, 18);
            this.ButtonCreateSession.TabIndex = 9;
            this.ButtonCreateSession.Text = "Create Session";
            // 
            // ButtonDeletePatient
            // 
            this.ButtonDeletePatient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonDeletePatient.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonDeletePatient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonDeletePatient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonDeletePatient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonDeletePatient.FillColor = System.Drawing.Color.Transparent;
            this.ButtonDeletePatient.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonDeletePatient.ForeColor = System.Drawing.Color.Black;
            this.ButtonDeletePatient.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonDeletePatient.HoverState.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ButtonDeletePatient.Location = new System.Drawing.Point(235, 546);
            this.ButtonDeletePatient.MaximumSize = new System.Drawing.Size(109, 28);
            this.ButtonDeletePatient.MinimumSize = new System.Drawing.Size(99, 18);
            this.ButtonDeletePatient.Name = "ButtonDeletePatient";
            this.ButtonDeletePatient.Size = new System.Drawing.Size(99, 18);
            this.ButtonDeletePatient.TabIndex = 8;
            this.ButtonDeletePatient.Text = "Delete Patient";
            // 
            // ButtonEditPatient
            // 
            this.ButtonEditPatient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonEditPatient.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonEditPatient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonEditPatient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonEditPatient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonEditPatient.FillColor = System.Drawing.Color.Transparent;
            this.ButtonEditPatient.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonEditPatient.ForeColor = System.Drawing.Color.Black;
            this.ButtonEditPatient.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonEditPatient.HoverState.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ButtonEditPatient.Location = new System.Drawing.Point(140, 547);
            this.ButtonEditPatient.MaximumSize = new System.Drawing.Size(99, 28);
            this.ButtonEditPatient.MinimumSize = new System.Drawing.Size(89, 18);
            this.ButtonEditPatient.Name = "ButtonEditPatient";
            this.ButtonEditPatient.Size = new System.Drawing.Size(89, 18);
            this.ButtonEditPatient.TabIndex = 7;
            this.ButtonEditPatient.Text = "Edit Patient";
            // 
            // ButtonSaveNotes
            // 
            this.ButtonSaveNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSaveNotes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonSaveNotes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonSaveNotes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonSaveNotes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonSaveNotes.FillColor = System.Drawing.Color.Transparent;
            this.ButtonSaveNotes.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonSaveNotes.ForeColor = System.Drawing.Color.Black;
            this.ButtonSaveNotes.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonSaveNotes.HoverState.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ButtonSaveNotes.Location = new System.Drawing.Point(1020, 545);
            this.ButtonSaveNotes.MaximumSize = new System.Drawing.Size(99, 46);
            this.ButtonSaveNotes.Name = "ButtonSaveNotes";
            this.ButtonSaveNotes.Size = new System.Drawing.Size(78, 20);
            this.ButtonSaveNotes.TabIndex = 6;
            this.ButtonSaveNotes.Text = "Save Note";
            // 
            // ButtonNewPatient
            // 
            this.ButtonNewPatient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonNewPatient.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonNewPatient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonNewPatient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonNewPatient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonNewPatient.FillColor = System.Drawing.Color.Transparent;
            this.ButtonNewPatient.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonNewPatient.ForeColor = System.Drawing.Color.Black;
            this.ButtonNewPatient.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonNewPatient.HoverState.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ButtonNewPatient.Location = new System.Drawing.Point(45, 546);
            this.ButtonNewPatient.MaximumSize = new System.Drawing.Size(99, 28);
            this.ButtonNewPatient.MinimumSize = new System.Drawing.Size(89, 18);
            this.ButtonNewPatient.Name = "ButtonNewPatient";
            this.ButtonNewPatient.Size = new System.Drawing.Size(89, 18);
            this.ButtonNewPatient.TabIndex = 3;
            this.ButtonNewPatient.Text = "New Patient";
            // 
            // tableLayoutPanelPatient
            // 
            this.tableLayoutPanelPatient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelPatient.ColumnCount = 3;
            this.tableLayoutPanelPatient.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelPatient.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanelPatient.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanelPatient.Controls.Add(this.guna2PanelNotes, 2, 0);
            this.tableLayoutPanelPatient.Controls.Add(this.guna2PanelSessionList, 1, 0);
            this.tableLayoutPanelPatient.Controls.Add(this.guna2PanelPatientList, 0, 0);
            this.tableLayoutPanelPatient.Controls.Add(this.guna2DataGridViewPatientList, 0, 1);
            this.tableLayoutPanelPatient.Controls.Add(this.PanelSessionData, 1, 1);
            this.tableLayoutPanelPatient.Controls.Add(this.PanelNotes, 2, 1);
            this.tableLayoutPanelPatient.Location = new System.Drawing.Point(45, 57);
            this.tableLayoutPanelPatient.Name = "tableLayoutPanelPatient";
            this.tableLayoutPanelPatient.RowCount = 2;
            this.tableLayoutPanelPatient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanelPatient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93F));
            this.tableLayoutPanelPatient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelPatient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelPatient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelPatient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelPatient.Size = new System.Drawing.Size(1053, 482);
            this.tableLayoutPanelPatient.TabIndex = 0;
            // 
            // guna2PanelNotes
            // 
            this.guna2PanelNotes.Controls.Add(this.labelNotes);
            this.guna2PanelNotes.CustomBorderColor = System.Drawing.Color.Silver;
            this.guna2PanelNotes.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.guna2PanelNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2PanelNotes.Location = new System.Drawing.Point(701, 0);
            this.guna2PanelNotes.Margin = new System.Windows.Forms.Padding(0);
            this.guna2PanelNotes.Name = "guna2PanelNotes";
            this.guna2PanelNotes.Size = new System.Drawing.Size(352, 33);
            this.guna2PanelNotes.TabIndex = 2;
            // 
            // labelNotes
            // 
            this.labelNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelNotes.AutoSize = true;
            this.labelNotes.Font = new System.Drawing.Font("Mongolian Baiti", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNotes.ForeColor = System.Drawing.Color.Black;
            this.labelNotes.Location = new System.Drawing.Point(144, 7);
            this.labelNotes.Name = "labelNotes";
            this.labelNotes.Size = new System.Drawing.Size(54, 18);
            this.labelNotes.TabIndex = 0;
            this.labelNotes.Text = "Notes";
            this.labelNotes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2PanelSessionList
            // 
            this.guna2PanelSessionList.Controls.Add(this.labelSessionList);
            this.guna2PanelSessionList.CustomBorderColor = System.Drawing.Color.Silver;
            this.guna2PanelSessionList.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.guna2PanelSessionList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2PanelSessionList.Location = new System.Drawing.Point(350, 0);
            this.guna2PanelSessionList.Margin = new System.Windows.Forms.Padding(0);
            this.guna2PanelSessionList.Name = "guna2PanelSessionList";
            this.guna2PanelSessionList.Size = new System.Drawing.Size(351, 33);
            this.guna2PanelSessionList.TabIndex = 1;
            // 
            // labelSessionList
            // 
            this.labelSessionList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelSessionList.AutoSize = true;
            this.labelSessionList.Font = new System.Drawing.Font("Mongolian Baiti", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSessionList.ForeColor = System.Drawing.Color.Black;
            this.labelSessionList.Location = new System.Drawing.Point(117, 7);
            this.labelSessionList.Name = "labelSessionList";
            this.labelSessionList.Size = new System.Drawing.Size(105, 18);
            this.labelSessionList.TabIndex = 0;
            this.labelSessionList.Text = "Session List";
            this.labelSessionList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2PanelPatientList
            // 
            this.guna2PanelPatientList.Controls.Add(this.labelPatientList);
            this.guna2PanelPatientList.CustomBorderColor = System.Drawing.Color.Silver;
            this.guna2PanelPatientList.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.guna2PanelPatientList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2PanelPatientList.Location = new System.Drawing.Point(0, 0);
            this.guna2PanelPatientList.Margin = new System.Windows.Forms.Padding(0);
            this.guna2PanelPatientList.Name = "guna2PanelPatientList";
            this.guna2PanelPatientList.Size = new System.Drawing.Size(350, 33);
            this.guna2PanelPatientList.TabIndex = 0;
            // 
            // labelPatientList
            // 
            this.labelPatientList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelPatientList.AutoSize = true;
            this.labelPatientList.Font = new System.Drawing.Font("Mongolian Baiti", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPatientList.ForeColor = System.Drawing.Color.Black;
            this.labelPatientList.Location = new System.Drawing.Point(119, 7);
            this.labelPatientList.Name = "labelPatientList";
            this.labelPatientList.Size = new System.Drawing.Size(100, 18);
            this.labelPatientList.TabIndex = 0;
            this.labelPatientList.Text = "Patient List";
            this.labelPatientList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2DataGridViewPatientList
            // 
            this.guna2DataGridViewPatientList.AllowUserToOrderColumns = true;
            this.guna2DataGridViewPatientList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Mongolian Baiti", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.guna2DataGridViewPatientList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridViewPatientList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridViewPatientList.ColumnHeadersHeight = 35;
            this.guna2DataGridViewPatientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridViewPatientList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.Lastname,
            this.birthdateDataGridViewTextBoxColumn,
            this.PhoneNumber});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridViewPatientList.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridViewPatientList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2DataGridViewPatientList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.guna2DataGridViewPatientList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridViewPatientList.Location = new System.Drawing.Point(0, 33);
            this.guna2DataGridViewPatientList.Margin = new System.Windows.Forms.Padding(0);
            this.guna2DataGridViewPatientList.Name = "guna2DataGridViewPatientList";
            this.guna2DataGridViewPatientList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.guna2DataGridViewPatientList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridViewPatientList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.guna2DataGridViewPatientList.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.guna2DataGridViewPatientList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.guna2DataGridViewPatientList.Size = new System.Drawing.Size(350, 449);
            this.guna2DataGridViewPatientList.TabIndex = 3;
            this.guna2DataGridViewPatientList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridViewPatientList.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2DataGridViewPatientList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.guna2DataGridViewPatientList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.guna2DataGridViewPatientList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.guna2DataGridViewPatientList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridViewPatientList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridViewPatientList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.guna2DataGridViewPatientList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridViewPatientList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2DataGridViewPatientList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridViewPatientList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridViewPatientList.ThemeStyle.HeaderStyle.Height = 35;
            this.guna2DataGridViewPatientList.ThemeStyle.ReadOnly = false;
            this.guna2DataGridViewPatientList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridViewPatientList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridViewPatientList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2DataGridViewPatientList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.guna2DataGridViewPatientList.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridViewPatientList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.guna2DataGridViewPatientList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // Lastname
            // 
            this.Lastname.DataPropertyName = "Lastname";
            this.Lastname.HeaderText = "Lastname";
            this.Lastname.Name = "Lastname";
            // 
            // birthdateDataGridViewTextBoxColumn
            // 
            this.birthdateDataGridViewTextBoxColumn.DataPropertyName = "Birthdate";
            this.birthdateDataGridViewTextBoxColumn.HeaderText = "Birthdate";
            this.birthdateDataGridViewTextBoxColumn.Name = "birthdateDataGridViewTextBoxColumn";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.DataPropertyName = "PhoneNumber";
            this.PhoneNumber.HeaderText = "PhoneNumber";
            this.PhoneNumber.Name = "PhoneNumber";
            // 
            // PanelSessionData
            // 
            this.PanelSessionData.Controls.Add(this.DataGridViewSession);
            this.PanelSessionData.CustomBorderColor = System.Drawing.Color.Silver;
            this.PanelSessionData.CustomBorderThickness = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.PanelSessionData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelSessionData.Location = new System.Drawing.Point(350, 33);
            this.PanelSessionData.Margin = new System.Windows.Forms.Padding(0);
            this.PanelSessionData.Name = "PanelSessionData";
            this.PanelSessionData.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.PanelSessionData.Size = new System.Drawing.Size(351, 449);
            this.PanelSessionData.TabIndex = 4;
            // 
            // DataGridViewSession
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.DataGridViewSession.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewSession.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DataGridViewSession.ColumnHeadersHeight = 4;
            this.DataGridViewSession.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewSession.DefaultCellStyle = dataGridViewCellStyle8;
            this.DataGridViewSession.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewSession.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewSession.Location = new System.Drawing.Point(3, 0);
            this.DataGridViewSession.Margin = new System.Windows.Forms.Padding(0);
            this.DataGridViewSession.Name = "DataGridViewSession";
            this.DataGridViewSession.RowHeadersVisible = false;
            this.DataGridViewSession.Size = new System.Drawing.Size(345, 449);
            this.DataGridViewSession.TabIndex = 0;
            this.DataGridViewSession.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewSession.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridViewSession.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridViewSession.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridViewSession.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridViewSession.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewSession.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewSession.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridViewSession.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridViewSession.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DataGridViewSession.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridViewSession.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridViewSession.ThemeStyle.HeaderStyle.Height = 4;
            this.DataGridViewSession.ThemeStyle.ReadOnly = false;
            this.DataGridViewSession.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewSession.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewSession.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DataGridViewSession.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridViewSession.ThemeStyle.RowsStyle.Height = 22;
            this.DataGridViewSession.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewSession.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // PanelNotes
            // 
            this.PanelNotes.Controls.Add(this.richTextBox1);
            this.PanelNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelNotes.Location = new System.Drawing.Point(701, 33);
            this.PanelNotes.Margin = new System.Windows.Forms.Padding(0);
            this.PanelNotes.Name = "PanelNotes";
            this.PanelNotes.Size = new System.Drawing.Size(352, 449);
            this.PanelNotes.TabIndex = 5;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(352, 200);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataSource = typeof(EoraGuiDemo.Entity.Patient);
            // 
            // patientListDTOBindingSource1
            // 
            this.patientListDTOBindingSource1.DataSource = typeof(EoraGuiDemo.DTO.PatientListDTO);
            // 
            // UserControlPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2ShadowPanelMain);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(1500, 900);
            this.MinimumSize = new System.Drawing.Size(1142, 610);
            this.Name = "UserControlPatient";
            this.Size = new System.Drawing.Size(1142, 610);
            this.guna2ShadowPanelMain.ResumeLayout(false);
            this.tableLayoutPanelPatient.ResumeLayout(false);
            this.guna2PanelNotes.ResumeLayout(false);
            this.guna2PanelNotes.PerformLayout();
            this.guna2PanelSessionList.ResumeLayout(false);
            this.guna2PanelSessionList.PerformLayout();
            this.guna2PanelPatientList.ResumeLayout(false);
            this.guna2PanelPatientList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridViewPatientList)).EndInit();
            this.PanelSessionData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewSession)).EndInit();
            this.PanelNotes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientListDTOBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanelMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPatient;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelPatientList;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelNotes;
        private System.Windows.Forms.Label labelNotes;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelSessionList;
        private System.Windows.Forms.Label labelSessionList;
        private System.Windows.Forms.Label labelPatientList;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridViewPatientList;
        private Guna.UI2.WinForms.Guna2Panel PanelSessionData;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridViewSession;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource patientListDTOBindingSource1;
        private Guna.UI2.WinForms.Guna2Button ButtonNewPatient;
        private Guna.UI2.WinForms.Guna2Button ButtonSaveNotes;
        private Guna.UI2.WinForms.Guna2Button ButtonDeletePatient;
        private Guna.UI2.WinForms.Guna2Button ButtonEditPatient;
        private Guna.UI2.WinForms.Guna2Button ButtonCreateSession;
        private Guna.UI2.WinForms.Guna2Button ButtonDeleteSession;
        private Guna.UI2.WinForms.Guna2Panel PanelNotes;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}
