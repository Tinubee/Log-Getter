namespace Log_Getter
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cb_Critical = new System.Windows.Forms.CheckBox();
            this.cb_Error = new System.Windows.Forms.CheckBox();
            this.cb_Warning = new System.Windows.Forms.CheckBox();
            this.cb_Information = new System.Windows.Forms.CheckBox();
            this.cb_Verbose = new System.Windows.Forms.CheckBox();
            this.cb_Program = new System.Windows.Forms.CheckBox();
            this.cb_Result = new System.Windows.Forms.CheckBox();
            this.cb_ETC1 = new System.Windows.Forms.CheckBox();
            this.cb_ETC2 = new System.Windows.Forms.CheckBox();
            this.tb_ConsolePath = new System.Windows.Forms.TextBox();
            this.cb_All = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dt_End = new System.Windows.Forms.DateTimePicker();
            this.dt_Start = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_SavePath = new System.Windows.Forms.TextBox();
            this.btn_SavePath = new System.Windows.Forms.Button();
            this.btn_Copy = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.cb_UsedConsole = new System.Windows.Forms.CheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsm_State = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tb_ControlPath = new System.Windows.Forms.TextBox();
            this.cb_UsedControl = new System.Windows.Forms.CheckBox();
            this.tb_CimPath = new System.Windows.Forms.TextBox();
            this.cb_UsedCim = new System.Windows.Forms.CheckBox();
            this.cb_CombineText = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_Critical
            // 
            this.cb_Critical.AutoSize = true;
            this.cb_Critical.Enabled = false;
            this.cb_Critical.Font = new System.Drawing.Font("맑은 고딕 Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cb_Critical.Location = new System.Drawing.Point(16, 72);
            this.cb_Critical.Name = "cb_Critical";
            this.cb_Critical.Size = new System.Drawing.Size(87, 29);
            this.cb_Critical.TabIndex = 0;
            this.cb_Critical.Tag = "0";
            this.cb_Critical.Text = "Critical";
            this.cb_Critical.UseVisualStyleBackColor = true;
            this.cb_Critical.CheckedChanged += new System.EventHandler(this.Category_Change);
            // 
            // cb_Error
            // 
            this.cb_Error.AutoSize = true;
            this.cb_Error.Enabled = false;
            this.cb_Error.Font = new System.Drawing.Font("맑은 고딕 Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cb_Error.Location = new System.Drawing.Point(16, 101);
            this.cb_Error.Name = "cb_Error";
            this.cb_Error.Size = new System.Drawing.Size(73, 29);
            this.cb_Error.TabIndex = 1;
            this.cb_Error.Tag = "1";
            this.cb_Error.Text = "Error";
            this.cb_Error.UseVisualStyleBackColor = true;
            this.cb_Error.CheckedChanged += new System.EventHandler(this.Category_Change);
            // 
            // cb_Warning
            // 
            this.cb_Warning.AutoSize = true;
            this.cb_Warning.Enabled = false;
            this.cb_Warning.Font = new System.Drawing.Font("맑은 고딕 Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cb_Warning.Location = new System.Drawing.Point(16, 130);
            this.cb_Warning.Name = "cb_Warning";
            this.cb_Warning.Size = new System.Drawing.Size(103, 29);
            this.cb_Warning.TabIndex = 1;
            this.cb_Warning.Tag = "2";
            this.cb_Warning.Text = "Warning";
            this.cb_Warning.UseVisualStyleBackColor = true;
            this.cb_Warning.CheckedChanged += new System.EventHandler(this.Category_Change);
            // 
            // cb_Information
            // 
            this.cb_Information.AutoSize = true;
            this.cb_Information.Enabled = false;
            this.cb_Information.Font = new System.Drawing.Font("맑은 고딕 Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cb_Information.Location = new System.Drawing.Point(16, 159);
            this.cb_Information.Name = "cb_Information";
            this.cb_Information.Size = new System.Drawing.Size(122, 29);
            this.cb_Information.TabIndex = 1;
            this.cb_Information.Tag = "3";
            this.cb_Information.Text = "Infomation";
            this.cb_Information.UseVisualStyleBackColor = true;
            this.cb_Information.CheckedChanged += new System.EventHandler(this.Category_Change);
            // 
            // cb_Verbose
            // 
            this.cb_Verbose.AutoSize = true;
            this.cb_Verbose.Enabled = false;
            this.cb_Verbose.Font = new System.Drawing.Font("맑은 고딕 Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cb_Verbose.Location = new System.Drawing.Point(16, 188);
            this.cb_Verbose.Name = "cb_Verbose";
            this.cb_Verbose.Size = new System.Drawing.Size(100, 29);
            this.cb_Verbose.TabIndex = 1;
            this.cb_Verbose.Tag = "4";
            this.cb_Verbose.Text = "Verbose";
            this.cb_Verbose.UseVisualStyleBackColor = true;
            this.cb_Verbose.CheckedChanged += new System.EventHandler(this.Category_Change);
            // 
            // cb_Program
            // 
            this.cb_Program.AutoSize = true;
            this.cb_Program.Enabled = false;
            this.cb_Program.Font = new System.Drawing.Font("맑은 고딕 Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cb_Program.Location = new System.Drawing.Point(15, 217);
            this.cb_Program.Name = "cb_Program";
            this.cb_Program.Size = new System.Drawing.Size(104, 29);
            this.cb_Program.TabIndex = 1;
            this.cb_Program.Tag = "5";
            this.cb_Program.Text = "Program";
            this.cb_Program.UseVisualStyleBackColor = true;
            this.cb_Program.CheckedChanged += new System.EventHandler(this.Category_Change);
            // 
            // cb_Result
            // 
            this.cb_Result.AutoSize = true;
            this.cb_Result.Enabled = false;
            this.cb_Result.Font = new System.Drawing.Font("맑은 고딕 Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cb_Result.Location = new System.Drawing.Point(15, 246);
            this.cb_Result.Name = "cb_Result";
            this.cb_Result.Size = new System.Drawing.Size(81, 29);
            this.cb_Result.TabIndex = 1;
            this.cb_Result.Tag = "6";
            this.cb_Result.Text = "Result";
            this.cb_Result.UseVisualStyleBackColor = true;
            this.cb_Result.CheckedChanged += new System.EventHandler(this.Category_Change);
            // 
            // cb_ETC1
            // 
            this.cb_ETC1.AutoSize = true;
            this.cb_ETC1.Enabled = false;
            this.cb_ETC1.Font = new System.Drawing.Font("맑은 고딕 Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cb_ETC1.Location = new System.Drawing.Point(16, 275);
            this.cb_ETC1.Name = "cb_ETC1";
            this.cb_ETC1.Size = new System.Drawing.Size(70, 29);
            this.cb_ETC1.TabIndex = 1;
            this.cb_ETC1.Tag = "7";
            this.cb_ETC1.Text = "ETC1";
            this.cb_ETC1.UseVisualStyleBackColor = true;
            this.cb_ETC1.CheckedChanged += new System.EventHandler(this.Category_Change);
            // 
            // cb_ETC2
            // 
            this.cb_ETC2.AutoSize = true;
            this.cb_ETC2.Enabled = false;
            this.cb_ETC2.Font = new System.Drawing.Font("맑은 고딕 Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cb_ETC2.Location = new System.Drawing.Point(15, 304);
            this.cb_ETC2.Name = "cb_ETC2";
            this.cb_ETC2.Size = new System.Drawing.Size(73, 29);
            this.cb_ETC2.TabIndex = 1;
            this.cb_ETC2.Tag = "8";
            this.cb_ETC2.Text = "ETC2";
            this.cb_ETC2.UseVisualStyleBackColor = true;
            this.cb_ETC2.CheckedChanged += new System.EventHandler(this.Category_Change);
            // 
            // tb_ConsolePath
            // 
            this.tb_ConsolePath.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_ConsolePath.Enabled = false;
            this.tb_ConsolePath.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_ConsolePath.Location = new System.Drawing.Point(218, 42);
            this.tb_ConsolePath.Name = "tb_ConsolePath";
            this.tb_ConsolePath.ReadOnly = true;
            this.tb_ConsolePath.Size = new System.Drawing.Size(369, 27);
            this.tb_ConsolePath.TabIndex = 2;
            this.tb_ConsolePath.TabStop = false;
            this.tb_ConsolePath.Text = "D:\\Log";
            // 
            // cb_All
            // 
            this.cb_All.AutoSize = true;
            this.cb_All.BackColor = System.Drawing.Color.LawnGreen;
            this.cb_All.Checked = true;
            this.cb_All.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_All.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cb_All.Location = new System.Drawing.Point(16, 29);
            this.cb_All.Name = "cb_All";
            this.cb_All.Size = new System.Drawing.Size(54, 29);
            this.cb_All.TabIndex = 3;
            this.cb_All.Tag = "9";
            this.cb_All.Text = "All";
            this.cb_All.UseVisualStyleBackColor = false;
            this.cb_All.CheckedChanged += new System.EventHandler(this.cb_All_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Bisque;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cb_All);
            this.groupBox1.Controls.Add(this.cb_Critical);
            this.groupBox1.Controls.Add(this.cb_Error);
            this.groupBox1.Controls.Add(this.cb_ETC2);
            this.groupBox1.Controls.Add(this.cb_Warning);
            this.groupBox1.Controls.Add(this.cb_ETC1);
            this.groupBox1.Controls.Add(this.cb_Information);
            this.groupBox1.Controls.Add(this.cb_Result);
            this.groupBox1.Controls.Add(this.cb_Verbose);
            this.groupBox1.Controls.Add(this.cb_Program);
            this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(20, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 343);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log Category";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("굴림", 2F);
            this.label4.Location = new System.Drawing.Point(16, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 2);
            this.label4.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dt_End);
            this.groupBox2.Controls.Add(this.dt_Start);
            this.groupBox2.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(218, 239);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(369, 116);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(61, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "To :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(41, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "From :";
            // 
            // dt_End
            // 
            this.dt_End.CalendarFont = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dt_End.Font = new System.Drawing.Font("굴림", 11F);
            this.dt_End.Location = new System.Drawing.Point(108, 72);
            this.dt_End.Name = "dt_End";
            this.dt_End.Size = new System.Drawing.Size(200, 24);
            this.dt_End.TabIndex = 0;
            this.dt_End.TabStop = false;
            this.dt_End.ValueChanged += new System.EventHandler(this.dt_Start_ValueChanged);
            // 
            // dt_Start
            // 
            this.dt_Start.CalendarFont = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dt_Start.Font = new System.Drawing.Font("굴림", 11F);
            this.dt_Start.Location = new System.Drawing.Point(108, 34);
            this.dt_Start.Name = "dt_Start";
            this.dt_Start.Size = new System.Drawing.Size(200, 24);
            this.dt_Start.TabIndex = 0;
            this.dt_Start.TabStop = false;
            this.dt_Start.ValueChanged += new System.EventHandler(this.dt_Start_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(20, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Save path :";
            // 
            // tb_SavePath
            // 
            this.tb_SavePath.Enabled = false;
            this.tb_SavePath.Font = new System.Drawing.Font("굴림", 11F);
            this.tb_SavePath.Location = new System.Drawing.Point(123, 363);
            this.tb_SavePath.Name = "tb_SavePath";
            this.tb_SavePath.ReadOnly = true;
            this.tb_SavePath.Size = new System.Drawing.Size(432, 24);
            this.tb_SavePath.TabIndex = 6;
            this.tb_SavePath.Text = "C:\\";
            // 
            // btn_SavePath
            // 
            this.btn_SavePath.Location = new System.Drawing.Point(563, 363);
            this.btn_SavePath.Name = "btn_SavePath";
            this.btn_SavePath.Size = new System.Drawing.Size(27, 26);
            this.btn_SavePath.TabIndex = 7;
            this.btn_SavePath.Text = "...";
            this.btn_SavePath.UseVisualStyleBackColor = true;
            this.btn_SavePath.Click += new System.EventHandler(this.btn_SavePath_Click);
            // 
            // btn_Copy
            // 
            this.btn_Copy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Copy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Copy.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold);
            this.btn_Copy.Location = new System.Drawing.Point(20, 426);
            this.btn_Copy.Name = "btn_Copy";
            this.btn_Copy.Size = new System.Drawing.Size(280, 58);
            this.btn_Copy.TabIndex = 8;
            this.btn_Copy.Text = "Copy";
            this.btn_Copy.UseVisualStyleBackColor = false;
            this.btn_Copy.Click += new System.EventHandler(this.btn_Copy_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold);
            this.btn_Exit.Location = new System.Drawing.Point(310, 426);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(280, 58);
            this.btn_Exit.TabIndex = 9;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // cb_UsedConsole
            // 
            this.cb_UsedConsole.AutoSize = true;
            this.cb_UsedConsole.BackColor = System.Drawing.SystemColors.Control;
            this.cb_UsedConsole.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cb_UsedConsole.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cb_UsedConsole.Location = new System.Drawing.Point(218, 12);
            this.cb_UsedConsole.Name = "cb_UsedConsole";
            this.cb_UsedConsole.Size = new System.Drawing.Size(110, 25);
            this.cb_UsedConsole.TabIndex = 6;
            this.cb_UsedConsole.Tag = "콘솔";
            this.cb_UsedConsole.Text = "[CONSOLE]";
            this.cb_UsedConsole.UseVisualStyleBackColor = false;
            this.cb_UsedConsole.CheckedChanged += new System.EventHandler(this.cb_UsedConsole_CheckedChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_State,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 493);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(620, 24);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsm_State
            // 
            this.tsm_State.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.tsm_State.Name = "tsm_State";
            this.tsm_State.Size = new System.Drawing.Size(484, 19);
            this.tsm_State.Spring = true;
            this.tsm_State.Text = "상태";
            this.tsm_State.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(121, 19);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // tb_ControlPath
            // 
            this.tb_ControlPath.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_ControlPath.Enabled = false;
            this.tb_ControlPath.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_ControlPath.Location = new System.Drawing.Point(218, 120);
            this.tb_ControlPath.Name = "tb_ControlPath";
            this.tb_ControlPath.ReadOnly = true;
            this.tb_ControlPath.Size = new System.Drawing.Size(369, 27);
            this.tb_ControlPath.TabIndex = 2;
            this.tb_ControlPath.TabStop = false;
            this.tb_ControlPath.Text = "D:\\Control_Log";
            // 
            // cb_UsedControl
            // 
            this.cb_UsedControl.AutoSize = true;
            this.cb_UsedControl.BackColor = System.Drawing.SystemColors.Control;
            this.cb_UsedControl.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cb_UsedControl.Location = new System.Drawing.Point(218, 90);
            this.cb_UsedControl.Name = "cb_UsedControl";
            this.cb_UsedControl.Size = new System.Drawing.Size(112, 25);
            this.cb_UsedControl.TabIndex = 6;
            this.cb_UsedControl.Tag = "컨트롤";
            this.cb_UsedControl.Text = "[CONTROL]";
            this.cb_UsedControl.UseVisualStyleBackColor = false;
            this.cb_UsedControl.CheckedChanged += new System.EventHandler(this.cb_UsedConsole_CheckedChanged);
            // 
            // tb_CimPath
            // 
            this.tb_CimPath.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_CimPath.Enabled = false;
            this.tb_CimPath.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_CimPath.Location = new System.Drawing.Point(218, 201);
            this.tb_CimPath.Name = "tb_CimPath";
            this.tb_CimPath.ReadOnly = true;
            this.tb_CimPath.Size = new System.Drawing.Size(369, 27);
            this.tb_CimPath.TabIndex = 2;
            this.tb_CimPath.TabStop = false;
            this.tb_CimPath.Text = "D:\\Log\\Eqp";
            // 
            // cb_UsedCim
            // 
            this.cb_UsedCim.AutoSize = true;
            this.cb_UsedCim.BackColor = System.Drawing.SystemColors.Control;
            this.cb_UsedCim.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cb_UsedCim.Location = new System.Drawing.Point(218, 171);
            this.cb_UsedCim.Name = "cb_UsedCim";
            this.cb_UsedCim.Size = new System.Drawing.Size(68, 25);
            this.cb_UsedCim.TabIndex = 6;
            this.cb_UsedCim.Tag = "심";
            this.cb_UsedCim.Text = "[CIM]";
            this.cb_UsedCim.UseVisualStyleBackColor = false;
            this.cb_UsedCim.CheckedChanged += new System.EventHandler(this.cb_UsedConsole_CheckedChanged);
            // 
            // cb_CombineText
            // 
            this.cb_CombineText.AutoSize = true;
            this.cb_CombineText.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cb_CombineText.Location = new System.Drawing.Point(24, 397);
            this.cb_CombineText.Name = "cb_CombineText";
            this.cb_CombineText.Size = new System.Drawing.Size(149, 17);
            this.cb_CombineText.TabIndex = 11;
            this.cb_CombineText.Text = "Combine LogText";
            this.cb_CombineText.UseVisualStyleBackColor = true;
            this.cb_CombineText.CheckedChanged += new System.EventHandler(this.cb_CombineText_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 517);
            this.Controls.Add(this.cb_CombineText);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.cb_UsedCim);
            this.Controls.Add(this.cb_UsedControl);
            this.Controls.Add(this.tb_CimPath);
            this.Controls.Add(this.cb_UsedConsole);
            this.Controls.Add(this.tb_ControlPath);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.tb_ConsolePath);
            this.Controls.Add(this.btn_Copy);
            this.Controls.Add(this.btn_SavePath);
            this.Controls.Add(this.tb_SavePath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(636, 556);
            this.MinimumSize = new System.Drawing.Size(636, 556);
            this.Name = "Form1";
            this.Text = "Engion Log Getter Ver 1.0.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cb_Critical;
        private System.Windows.Forms.CheckBox cb_Error;
        private System.Windows.Forms.CheckBox cb_Warning;
        private System.Windows.Forms.CheckBox cb_Information;
        private System.Windows.Forms.CheckBox cb_Verbose;
        private System.Windows.Forms.CheckBox cb_Program;
        private System.Windows.Forms.CheckBox cb_Result;
        private System.Windows.Forms.CheckBox cb_ETC1;
        private System.Windows.Forms.CheckBox cb_ETC2;
        private System.Windows.Forms.TextBox tb_ConsolePath;
        private System.Windows.Forms.CheckBox cb_All;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cb_UsedConsole;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dt_End;
        private System.Windows.Forms.DateTimePicker dt_Start;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_SavePath;
        private System.Windows.Forms.Button btn_SavePath;
        private System.Windows.Forms.Button btn_Copy;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsm_State;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_ControlPath;
        private System.Windows.Forms.CheckBox cb_UsedControl;
        private System.Windows.Forms.TextBox tb_CimPath;
        private System.Windows.Forms.CheckBox cb_UsedCim;
        private System.Windows.Forms.CheckBox cb_CombineText;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

