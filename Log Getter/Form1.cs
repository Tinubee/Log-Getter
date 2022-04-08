using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;

namespace Log_Getter
{
    public partial class Form1 : Form
    {
        enum FolderType { Console, CIM, Control };
        CheckBox[] Category = new CheckBox[10];
        List<CheckBox> CategoryL = new List<CheckBox>();
        public Form1()
        {
            InitializeComponent();
            Category = new CheckBox[10] { cb_Critical, cb_Error, cb_Warning, cb_Information,
                                          cb_Verbose, cb_Program, cb_Result, cb_ETC1, cb_ETC2, cb_All };
            CategoryL.AddRange(Category);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tb_SavePath.Text = Properties.Settings.Default.LastSavePath;
            cb_UsedConsole.Checked = Properties.Settings.Default.UsedConsole;
            cb_UsedControl.Checked = Properties.Settings.Default.UsedControl;
            cb_UsedCim.Checked = Properties.Settings.Default.UsedCIM;
        }

        private void btn_Copy_Click(object sender, EventArgs e)
        {
            DateTime stv = dt_Start.Value;
            DateTime endv = dt_End.Value;
            TimeSpan ts = endv - stv;
            if (ts.Days > 31 || stv > endv)
            {
                MessageBox.Show("날짜를 재설정 해주시기 바랍니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tsm_State.Text = "날짜를 재설정 해주시기 바랍니다.";
            }
            else
            {
                if (cb_UsedConsole.Checked == true)
                    LogCopy(tb_ConsolePath.Text, FolderType.Console);
                if (cb_UsedControl.Checked == true)
                    LogCopy(tb_ControlPath.Text, FolderType.Control);
                if (cb_UsedCim.Checked == true)
                    LogCopy(tb_CimPath.Text, FolderType.CIM);
                if (cb_UsedConsole.Checked == false && cb_UsedControl.Checked == false && cb_UsedCim.Checked == false)
                {
                    tsm_State.Text = "Log Copy Data가 없습니다. Copy할 Log를 선택해 주세요.";
                    MessageBox.Show("Log Copy Data가 없습니다.\nCopy할 Log를 선택해 주세요.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        void LogCopy(string FilePath, FolderType type)
        {
            try
            {
                List<string> WriteText = new List<string>();

                tsm_State.Text = $"{type.ToString()} Log Copy를 시작하였습니다.";
                DateTime oldDate = dt_Start.Value;
                DateTime newDate = dt_End.Value;
                TimeSpan ts = newDate - oldDate;
                List<string> ReadText = new List<string>();
                bool Write_Check = false;

                for (int i = 0; i <= ts.Days; i++)
                {
                    DateTime StartDate = oldDate.AddDays(i);
                    string FName = Path.Combine(FilePath, StartDate.ToString("yyyy-MM-dd") + "_Log.txt");
                    if (File.Exists(FName) == true)
                        ReadText.AddRange(File.ReadAllLines(FName, Encoding.Default));
                    ReadText.RemoveAll(r => r.Split(' ')[0] != StartDate.ToString("MM-dd"));
                    if (cb_All.Checked == true)
                    {
                        foreach (string rd in ReadText)
                            WriteText.Add(rd);
                    }
                    else
                    {
                        foreach (var cc in Category)
                            if (cc.Checked == true)
                                WriteText.AddRange(ReadText.FindAll(s => s.Split(':', ',')[3].Trim() == cc.Text));
                    }
                    if (cb_CombineText.Checked == false)
                    {
                        if (WriteText.Count > 0)
                        {
                            TextSave(WriteText, $"{type.ToString()}_{StartDate.ToString("yyyy-MM-dd")}", type);
                            Write_Check |= true;
                        }
                        else
                            Write_Check |= false;
                        WriteText.Clear();
                    }
                }

                if (cb_CombineText.Checked == true)
                {
                    if (WriteText.Count > 0)
                        TextSave(WriteText, "", type);
                    else
                    {
                        tsm_State.Text = $"{type.ToString()} Log Copy Data가 없습니다.";
                        MessageBox.Show($"{type.ToString()} Log Copy Data가 없습니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (Write_Check == false && cb_CombineText.Checked == false)
                {
                    tsm_State.Text = $"{type.ToString()} Log Copy Data가 없습니다.";
                    MessageBox.Show($"{type.ToString()} Log Copy Data가 없습니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(Convert.ToString(ee));
            }
        }

        private void TextSave(List<string> Data, string filename, FolderType type)
        {
            try
            {
                DateTime dt = DateTime.Now;
                string FolderName = Path.Combine(tb_SavePath.Text, "CopyLog모음", "LogCopy " + dt.ToString("yyyyMMdd_HHmmss"), type.ToString());
                if (Directory.Exists(FolderName) == false)
                    Directory.CreateDirectory(FolderName);

                string dd = $"{dt_Start.Value.ToString("yyyyMMdd")}" + "~" + $"{dt_End.Value.ToString("yyyyMMdd")}";
                if (dt_Start.Value == dt_End.Value)
                    dd = $"{dt_Start.Value.ToString("yyyyMMdd")}";

                string Txt_Name = (filename == "") ? type.ToString() + $"_Log_{dd}" : filename;

                using (StreamWriter sw = new StreamWriter(Path.Combine(FolderName, $"{Txt_Name}.txt"), false, Encoding.Default))
                {
                    foreach (var item in Data)
                        sw.WriteLine(item);
                }
                tsm_State.Text = "Log Copy 작업을 완료하였습니다.";
            }
            catch (Exception ee)
            {
                MessageBox.Show($"{ee}");
            }
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("프로그램을 정말 종료하시겠습니까?", "Engion Log Getter", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
        }

        private void btn_SavePath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fb = new FolderBrowserDialog();
            if (fb.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.LastSavePath = tb_SavePath.Text = fb.SelectedPath;
                Properties.Settings.Default.Save();
                tsm_State.Text = $"저장 경로를 {tb_SavePath.Text}로 변경하였습니다.";
            }
        }

        private void cb_UsedConsole_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            TextBox tx = sender as TextBox;
            string Uesd = (cb.Checked) ? "" : "미";
            tsm_State.Text = $"{(string)cb.Tag} Log를 {Uesd}사용하도록 변경하였습니다.";
            if (Uesd == "미")
            {
                cb.Font = new Font(cb.Font, FontStyle.Regular);
                cb.BackColor = SystemColors.Control;
            }
            else
            {
                cb.Font = new Font(cb.Font, FontStyle.Bold);
                cb.BackColor = Color.LawnGreen;
            }
            //string tag = Convert.ToString((sender as CheckBox).Tag);
            //switch (tag)
            //{
            //    case "콘솔":
            //        string Uesd = (cb_UsedConsole.Checked) ? "" : "미";
            //        tsm_State.Text = $"콘솔 Log {Uesd}사용하도록 변경하였습니다.";
            //        break;
            //    case "컨트롤":
            //        Uesd = (cb_UsedControl.Checked) ? "" : "미";
            //        tsm_State.Text = $"컨트롤 Log {Uesd}사용하도록 변경하였습니다.";
            //        break;
            //    case "심":
            //        Uesd = (cb_UsedCim.Checked) ? "" : "미";
            //        tsm_State.Text = $"심 Log {Uesd}사용하도록 변경하였습니다.";
            //        break;
            //}
        }
        private void dt_Start_ValueChanged(object sender, EventArgs e)
        {
            DateTime St_day = dt_Start.Value;
            DateTime End_day = dt_End.Value;
            TimeSpan tsDay = End_day - St_day;
            int Syear = dt_Start.Value.Year;
            int Eyear = dt_End.Value.Year;
            int Smonth = dt_Start.Value.Month;
            int Emonth = dt_End.Value.Month;
            int Sday = dt_Start.Value.Day;
            int Eday = dt_End.Value.Day;
            tsm_State.Text = $"{Syear}" + "년" + $"{Smonth}" + "월" + $"{Sday}" + "일~" + $"{Eyear}" + "년" + $"{Emonth}" + "월" + $"{Eday}" + "일로 날짜가 변경되었습니다.";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Oem3:
                    cb_All.Checked = !cb_All.Checked;
                    break;
                case Keys.D1:
                case Keys.D2:
                case Keys.D3:
                case Keys.D4:
                case Keys.D5:
                case Keys.D6:
                case Keys.D7:
                case Keys.D8:
                case Keys.D9:
                    int i = Convert.ToInt32(e.KeyCode) - 49;
                    if (!cb_All.Checked)
                        Category[i].Checked = !Category[i].Checked;
                    break;
                case Keys.Escape:
                    btn_Exit_Click(null, null);
                    break;
            }
        }

        private void cb_All_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < 9; i++)
            {
                Category[i].Enabled = !cb_All.Checked;
                Category[i].Checked = false;
                Category[i].BackColor = Color.Bisque;
            }
            if (cb_All.Checked == false)
            {
                cb_All.Font = new Font(cb_All.Font, FontStyle.Regular);
                cb_All.BackColor = Color.Bisque;
            }
            else
            {
                cb_All.Font = new Font(cb_All.Font, FontStyle.Bold);
                cb_All.BackColor = Color.LawnGreen;
                for (int i = 0; i < 9; i++)
                    Category[i].Font = new Font(Category[i].Font, FontStyle.Regular);
                tsm_State.Text = $"모든 Log Category를 Copy하도록 변경하였습니다.";
            }
        }

        private void Category_Change(object sender, EventArgs e)
        {
            for (int i = 0; i < 9; i++)
            {
                if (Category[i].Checked == true)
                {
                    Category[i].BackColor = Color.LawnGreen;
                    Category[i].Font = new Font(Category[i].Font, FontStyle.Bold);
                    tsm_State.Text = $"{Category[i].Text} Log Category를 선택하였습니다.";
                }
                else
                {
                    Category[i].BackColor = Color.Bisque;
                    Category[i].Font = new Font(Category[i].Font, FontStyle.Regular);
                }
            }
        }

        private void cb_CombineText_CheckedChanged(object sender, EventArgs e)
        {
            string Uesd = (cb_CombineText.Checked) ? "" : "미";
            tsm_State.Text = $"Copy한 Log.txt 날짜전체저장을 {Uesd}사용하도록 변경하였습니다.";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.UsedConsole = cb_UsedConsole.Checked;
            Properties.Settings.Default.UsedControl = cb_UsedControl.Checked;
            Properties.Settings.Default.UsedCIM = cb_UsedCim.Checked;
            Properties.Settings.Default.Save();
        }
    }
}

