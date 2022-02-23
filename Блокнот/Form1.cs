using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Блокнот
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void ExitTSMI_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //тип шрифта
        private void BoldTSMI_Click(object sender, EventArgs e)
        {
            //Жирный
            FontStyle style;
            try
            {
                style = NotePadRichTextBox.SelectionFont.Style; //при разных размерах текста
            }
            catch
            {
                style = 0;
            }

            if (NotePadRichTextBox.SelectionFont.Bold)
            {
                style &= ~FontStyle.Bold;
                BoldTSMI.Font = new Font(BoldTSMI.Font, FontStyle.Regular);
            }
            else
            {
                style |= FontStyle.Bold;
                BoldTSMI.Font = new Font(BoldTSMI.Font, FontStyle.Bold);
            }
            NotePadRichTextBox.SelectionFont = new Font(NotePadRichTextBox.SelectionFont, style);
            NotePadRichTextBox.Focus();
        }

        private void UnderLineTSMI_Click(object sender, EventArgs e)
        {

            //Подчеркнутый
            FontStyle style;
            try
            {
                style = NotePadRichTextBox.SelectionFont.Style; //при разных размерах текста
            }
            catch
            {
                style = 0;
            }

            if (NotePadRichTextBox.SelectionFont.Underline)
            {
                style &= ~FontStyle.Underline;
                UnderLineTSMI.Font = new Font(UnderLineTSMI.Font, FontStyle.Regular);
            }
            else
            {
                style |= FontStyle.Underline;
                UnderLineTSMI.Font = new Font(UnderLineTSMI.Font, FontStyle.Bold);
            }
            NotePadRichTextBox.SelectionFont = new Font(NotePadRichTextBox.SelectionFont, style);
            NotePadRichTextBox.Focus();
        }

        private void ItalicTSMI_Click(object sender, EventArgs e)
        {
            //Курсив
            FontStyle style;
            try
            {
                style = NotePadRichTextBox.SelectionFont.Style; //Ошибка при разных размерах текста
            }
            catch
            {
                style = 0;
            }

            if (NotePadRichTextBox.SelectionFont.Italic)
            {
                style &= ~FontStyle.Italic;
                ItalicTSMI.Font = new Font(ItalicTSMI.Font, FontStyle.Regular);
            }
            else
            {
                style |= FontStyle.Italic;
                ItalicTSMI.Font = new Font(ItalicTSMI.Font, FontStyle.Bold);
            }
            NotePadRichTextBox.SelectionFont = new Font(NotePadRichTextBox.SelectionFont, style);
            NotePadRichTextBox.Focus();
        }
        //цвета
        private void BlackTSMI_Click(object sender, EventArgs e)
        {

            NotePadRichTextBox.SelectionColor = Color.Black;
        }

        private void BlueTSMI_Click(object sender, EventArgs e)
        {
            NotePadRichTextBox.SelectionColor = Color.SkyBlue;
        }

        private void RedTSMI_Click(object sender, EventArgs e)
        {
            NotePadRichTextBox.SelectionColor = Color.Red;
        }

        private void GreenTSMI_Click(object sender, EventArgs e)
        {
            NotePadRichTextBox.SelectionColor = Color.Green;
        }

        private void FontComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (FontComboBox.Text)
            {
                case "Times New Roman":
                    {
                        Font myfont = new Font("Times New Roman", Convert.ToByte(SizeComboBox.SelectedItem));
                        NotePadRichTextBox.SelectionFont = myfont;
                        break;
                    }
                case "Arial":
                    {
                        Font myfont = new Font("Arial", Convert.ToByte(SizeComboBox.SelectedItem));
                        NotePadRichTextBox.SelectionFont = myfont;
                        break;
                    }
                case "Tahoma":
                    {
                        Font myfont = new Font("Tahoma", Convert.ToByte(SizeComboBox.SelectedItem));
                        NotePadRichTextBox.SelectionFont = myfont;
                        break;
                    }
                default:
                    {
                        MessageBox.Show("Ошибка");
                        break;
                    }

            }
        }

        private void SizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Font myfont = new Font(FontComboBox.SelectedText, Convert.ToByte(SizeComboBox.SelectedItem));
            NotePadRichTextBox.SelectionFont = myfont;
        }
        //сохранение
        private void SaveTSMI_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "Текстовый документ (*.txt)|*.txt|Все файлы (*.*)|*.*"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, NotePadRichTextBox.Text);
                MessageBox.Show("Файл сохранен, спасибо!");
            }
        }
        //загрузка
        private void OpenTSMI_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Текстовый документ (*.txt)|*.txt|Все файлы (*.*)|*.*"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                NotePadRichTextBox.Text = File.ReadAllText(ofd.FileName);
                MessageBox.Show("Файл открыт, спасибо!");
            }
        }
        //создание
        private void CreateTSMI_Click(object sender, EventArgs e)
        {
            NotePadRichTextBox.Clear();
        }

        private void ProgramTSMI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Обалдеть я создала свою первую программу,теперь я программист!\n Реально рабочий блокнот всем советую!");
        }
        //копировать
        private void CopyTSMI_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(NotePadRichTextBox.Text);
        }
        //вставить
        private void PasteTSMI_Click(object sender, EventArgs e)
        {
            NotePadRichTextBox.Text += Clipboard.GetText();
        }
        //вырезать
        private void CutTSMI_Click(object sender, EventArgs e)
        {
            int StartPosition = NotePadRichTextBox.SelectionStart;//начало
            int LengthSelection = NotePadRichTextBox.SelectionLength;//конец
            NotePadRichTextBox.Text = NotePadRichTextBox.Text.Remove(StartPosition, LengthSelection);
        }
    }
}

