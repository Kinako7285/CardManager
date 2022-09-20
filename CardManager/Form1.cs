using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Threading;
using System.IO.Compression;
using System.IO;
using System.Runtime.InteropServices.ComTypes;


namespace CardManager
{
    public partial class Form1 : Form
    {
        [DllImport("kernel32.dll", EntryPoint = "WritePrivateProfileStringW", CharSet = CharSet.Unicode, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool WritePrivateProfileString(string lpAppName, string lpKeyName, string lpString, string lpFileName);

        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern short GetKeyState(int nVirtKey);
        public Form1()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;


        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.FileSavePath == "")
            {

                TAB.SelectedIndex = 0;


            }
            else
            {

                TAB.SelectedIndex = 1;
                TAB1.Visible = true;

                CARD1.Text = Properties.Settings.Default.CARD1NICK;
                CARD2.Text = Properties.Settings.Default.CARD2NICK;
                CARD3.Text = Properties.Settings.Default.CARD3NICK;

                CARD1AC.Text = Properties.Settings.Default.CARD1AC;
                CARD2AC.Text = Properties.Settings.Default.CARD2AC;
                CARD3AC.Text = Properties.Settings.Default.CARD3AC;

                CARD1NICK.Text = Properties.Settings.Default.CARD1NICK;
                CARD2NICK.Text = Properties.Settings.Default.CARD2NICK;
                CARD3NICK.Text = Properties.Settings.Default.CARD3NICK;

                CardDataPath.Text = Properties.Settings.Default.FileSavePath;

            }


            if (CARD1AC.Text == "0000-0000-0000-0000")
            {

                CARD1BT.Enabled = false;
                CARD1BT.Text = "カードが登録されていません";
                CARD1BT2.Enabled = false;
            }
            else
            {

                CARD1BT.Enabled = true;
                CARD1BT.Text = "このカードを使用する";
                CARD1BT2.Enabled = true;
            }

            if (CARD2AC.Text == "0000-0000-0000-0000")
            {

                CARD2BT.Enabled = false;
                CARD2BT.Text = "カードが登録されていません";
                CARD2BT2.Enabled = false;
            }
            else
            {

                CARD2BT.Enabled = true;
                CARD2BT.Text = "このカードを使用する";
                CARD2BT2.Enabled = true;
            }

            if (CARD3AC.Text == "0000-0000-0000-0000")
            {

                CARD3BT.Enabled = false;
                CARD3BT.Text = "カードが登録されていません";
                CARD3BT2.Enabled = false;
            }
            else
            {

                CARD3BT.Enabled = true;
                CARD3BT.Text = "このカードを使用する";
                CARD3BT2.Enabled = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();


            folderBrowserDialog.Description = "フォルダを選択してください。";


            folderBrowserDialog.SelectedPath = @"C:";


            folderBrowserDialog.ShowNewFolderButton = true;


            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                CardDataPath.Text = folderBrowserDialog.SelectedPath;
            }


            folderBrowserDialog.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CardDataPath.Text == "")
            {

                MessageBox.Show("ディレクトリが指定されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                //if (System.IO.File.Exists(CardDataPath.Text+@"\card.ini"))
                //{

                    TAB.SelectedIndex = 1;

                Properties.Settings.Default.FileSavePath = CardDataPath.Text;

                Properties.Settings.Default.Save();

                CARD1.Text = Properties.Settings.Default.CARD1NICK;
                CARD2.Text = Properties.Settings.Default.CARD2NICK;
                CARD3.Text = Properties.Settings.Default.CARD3NICK;

                CARD1AC.Text = Properties.Settings.Default.CARD1AC;
                CARD2AC.Text = Properties.Settings.Default.CARD2AC;
                CARD3AC.Text = Properties.Settings.Default.CARD3AC;

                CARD1NICK.Text = Properties.Settings.Default.CARD1NICK;
                CARD2NICK.Text = Properties.Settings.Default.CARD2NICK;
                CARD3NICK.Text = Properties.Settings.Default.CARD3NICK;

                TAB1.Visible = true;

                //}
                //else
                //{
                //    MessageBox.Show("card.iniが存在しません\nゲームを一度プレイしてからやり直してください", "ファイルが存在しません", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (NEWAC.Text == "")
            {
                MessageBox.Show("アクセスコードを入力してください", "すべての項目に入力してくだい", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                if (NEWKC.Text == "")
                {
                    MessageBox.Show("チップIDを入力してくだい", "すべての項目に入力してくだい", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (Properties.Settings.Default.CARD1AC != "0000-0000-0000-0000")
                    {

                            DialogResult result = MessageBox.Show("このスロットには既にカードが登録されています\nカードの情報を更新しますか？", "情報更新", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == System.Windows.Forms.DialogResult.Yes)
                        {

                            Properties.Settings.Default.CARD1AC = NEWAC.Text;
                            Properties.Settings.Default.CARD1KC = NEWKC.Text;

                            Properties.Settings.Default.Save();

                            NEWAC.Text = null;
                            NEWKC.Text = null;

                            TAB1.SelectedIndex = 0;
                            CARD1AC.Text = Properties.Settings.Default.CARD1AC;


                            CARD1BT.Enabled = true;
                            CARD1BT.Text = "このカードを使用する";
                            CARD1BT2.Enabled = true;

                        }
                    }
                    else
                    {

                        Properties.Settings.Default.CARD1AC = NEWAC.Text;
                        Properties.Settings.Default.CARD1KC = NEWKC.Text;

                        Properties.Settings.Default.Save();

                        NEWAC.Text = null;
                        NEWKC.Text = null;

                        TAB1.SelectedIndex = 0;
                        CARD1AC.Text = Properties.Settings.Default.CARD1AC;


                        CARD1BT.Enabled = true;
                        CARD1BT.Text = "このカードを使用する";
                        CARD1BT2.Enabled = true;

                    }


                    
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (NEWAC.Text == "")
            {
                MessageBox.Show("アクセスコードを入力してください", "すべての項目に入力してくだい", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (NEWKC.Text == "")
                {
                    MessageBox.Show("チップIDを入力してくだい", "すべての項目に入力してくだい", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    if (Properties.Settings.Default.CARD2AC != "0000-0000-0000-0000")
                    {

                        DialogResult result = MessageBox.Show("このスロットには既にカードが登録されています\nカードの情報を更新しますか？", "情報更新", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == System.Windows.Forms.DialogResult.Yes)
                        {

                            Properties.Settings.Default.CARD2AC = NEWAC.Text;
                            Properties.Settings.Default.CARD2KC = NEWKC.Text;

                            Properties.Settings.Default.Save();

                            NEWAC.Text = null;
                            NEWKC.Text = null;

                            TAB1.SelectedIndex = 1;
                            CARD2AC.Text = Properties.Settings.Default.CARD2AC;


                            CARD2BT.Enabled = true;
                            CARD2BT.Text = "このカードを使用する";
                            CARD2BT2.Enabled = true;

                        }
                    }
                    else
                    {

                        Properties.Settings.Default.CARD2AC = NEWAC.Text;
                        Properties.Settings.Default.CARD2KC = NEWKC.Text;

                        Properties.Settings.Default.Save();

                        NEWAC.Text = null;
                        NEWKC.Text = null;

                        TAB1.SelectedIndex = 1;
                        CARD2AC.Text = Properties.Settings.Default.CARD2AC;


                        CARD2BT.Enabled = true;
                        CARD2BT.Text = "このカードを使用する";
                        CARD2BT2.Enabled = true;

                    }




                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (NEWAC.Text == "")
            {
                MessageBox.Show("アクセスコードを入力してください", "すべての項目に入力してくだい", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (NEWKC.Text == "")
                {
                    MessageBox.Show("チップIDを入力してくだい", "すべての項目に入力してくだい", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    if (Properties.Settings.Default.CARD3AC != "0000-0000-0000-0000")
                    {

                        DialogResult result = MessageBox.Show("このスロットには既にカードが登録されています\nカードの情報を更新しますか？", "情報更新", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == System.Windows.Forms.DialogResult.Yes)
                        {

                            Properties.Settings.Default.CARD3AC = NEWAC.Text;
                            Properties.Settings.Default.CARD3KC = NEWKC.Text;

                            Properties.Settings.Default.Save();

                            NEWAC.Text = null;
                            NEWKC.Text = null;

                            TAB1.SelectedIndex = 2;
                            CARD3AC.Text = Properties.Settings.Default.CARD3AC;

                            CARD3BT.Enabled = true;
                            CARD3BT.Text = "このカードを使用する";
                            CARD3BT2.Enabled = true;

                        }
                    }
                    else
                    {

                        Properties.Settings.Default.CARD3AC = NEWAC.Text;
                        Properties.Settings.Default.CARD3KC = NEWKC.Text;

                        Properties.Settings.Default.Save();

                        NEWAC.Text = null;
                        NEWKC.Text = null;

                        TAB1.SelectedIndex = 2;
                        CARD3AC.Text = Properties.Settings.Default.CARD3AC;

                        CARD3BT.Enabled = true;
                        CARD3BT.Text = "このカードを使用する";
                        CARD3BT2.Enabled = true;

                    }



                }
            }
        }

        private void CARD1NICK_TextChanged(object sender, EventArgs e)
        {

            Properties.Settings.Default.CARD1NICK = CARD1NICK.Text;
            Properties.Settings.Default.Save();
            CARD1.Text = Properties.Settings.Default.CARD1NICK;

        }

        private void CARD2NICK_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.CARD2NICK = CARD2NICK.Text;
            Properties.Settings.Default.Save();
            CARD2.Text = Properties.Settings.Default.CARD2NICK;
        }

        private void CARD3NICK_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.CARD3NICK = CARD3NICK.Text;
            Properties.Settings.Default.Save();
            CARD3.Text = Properties.Settings.Default.CARD3NICK;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            TAB.SelectedIndex = 0;
            TAB1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("このカードを登録解除してもよろしいですか？\n登録を解除すると登録されていたカードのアクセス情報が全て削除されます", "登録解除", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Properties.Settings.Default.CARD1AC = "0000-0000-0000-0000";
                Properties.Settings.Default.CARD1KC = "00000000000000000000";
                Properties.Settings.Default.CARD1NICK = "カード1";
                Properties.Settings.Default.Save();

                CARD1.Text = Properties.Settings.Default.CARD1NICK;

                CARD1AC.Text = Properties.Settings.Default.CARD1AC;

                CARD1NICK.Text = Properties.Settings.Default.CARD1NICK;

                CARD1BT.Enabled = false;
                CARD1BT.Text = "カードが登録されていません";
                CARD1BT2.Enabled = false;

                DialogResult result1 = MessageBox.Show("カードを登録解除しました", "登録解除", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("このカードを登録解除してもよろしいですか？\n登録を解除すると登録されていたカードのアクセス情報が全て削除されます", "登録解除", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Properties.Settings.Default.CARD2AC = "0000-0000-0000-0000";
                Properties.Settings.Default.CARD2KC = "00000000000000000000";
                Properties.Settings.Default.CARD2NICK = "カード2";
                Properties.Settings.Default.Save();

                CARD2.Text = Properties.Settings.Default.CARD2NICK;

                CARD2AC.Text = Properties.Settings.Default.CARD2AC;

                CARD2NICK.Text = Properties.Settings.Default.CARD2NICK;

                CARD2BT.Enabled = false;
                CARD2BT.Text = "カードが登録されていません";
                CARD2BT2.Enabled = false;

                DialogResult result1 = MessageBox.Show("カードを登録解除しました", "登録解除", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("このカードを登録解除してもよろしいですか？\n登録を解除すると登録されていたカードのアクセス情報が全て削除されます", "登録解除", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Properties.Settings.Default.CARD3AC = "0000-0000-0000-0000";
                Properties.Settings.Default.CARD3KC = "00000000000000000000";
                Properties.Settings.Default.CARD3NICK = "カード3";
                Properties.Settings.Default.Save();

                CARD3.Text = Properties.Settings.Default.CARD3NICK;

                CARD3AC.Text = Properties.Settings.Default.CARD3AC;

                CARD3NICK.Text = Properties.Settings.Default.CARD3NICK;

                CARD3BT.Enabled = false;
                CARD3BT.Text = "カードが登録されていません";
                CARD3BT2.Enabled = false;

                DialogResult result1 = MessageBox.Show("カードを登録解除しました", "登録解除", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("card.iniに記録されているアクセスコードは上書きされます\nこのカードを使用しますか？", "カード上書き", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {

                WritePrivateProfileString("card", "accessCode", Properties.Settings.Default.CARD1AC, CardDataPath.Text + @"\card.ini");
                WritePrivateProfileString("card", "chipId", Properties.Settings.Default.CARD1KC, CardDataPath.Text + @"\card.ini");

                DialogResult result1 = MessageBox.Show("カードを使用登録しました", "使用登録", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("card.iniに記録されているアクセスコードは上書きされます\nこのカードを使用しますか？", "カード上書き", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {

                WritePrivateProfileString("card", "accessCode", Properties.Settings.Default.CARD2AC, CardDataPath.Text + @"\card.ini");
                WritePrivateProfileString("card", "chipId", Properties.Settings.Default.CARD2KC, CardDataPath.Text + @"\card.ini");

                DialogResult result1 = MessageBox.Show("カードを使用登録しました", "使用登録", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("card.iniに記録されているアクセスコードは上書きされます\nこのカードを使用しますか？", "カード上書き", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {

                WritePrivateProfileString("card", "accessCode", Properties.Settings.Default.CARD3AC, CardDataPath.Text + @"\card.ini");
                WritePrivateProfileString("card", "chipId", Properties.Settings.Default.CARD3KC, CardDataPath.Text + @"\card.ini");

                DialogResult result1 = MessageBox.Show("カードを使用登録しました", "使用登録", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void CARD3NICK_Click(object sender, EventArgs e)
        {

        }

    }
}
