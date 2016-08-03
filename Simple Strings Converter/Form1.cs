using System;
using System.Windows.Forms;

namespace Simple_Strings_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string ToRus(string input)
        {
            input = input.Replace('А', 'A');
            input = input.Replace('Б', 'À');
            input = input.Replace('В', 'Á');
            input = input.Replace('Г', 'Â');
            input = input.Replace('Д', 'Ä');
            input = input.Replace('Е', 'E');
            input = input.Replace('Ё', 'E');
            input = input.Replace('Ж', 'Æ');
            input = input.Replace('З', 'Ç');
            input = input.Replace('И', 'È');
            input = input.Replace('Й', 'É');
            input = input.Replace('К', 'Ê');
            input = input.Replace('Л', 'Ì');
            input = input.Replace('М', 'Í');
            input = input.Replace('Н', 'Î');
            input = input.Replace('О', 'O');
            input = input.Replace('П', 'Ï');
            input = input.Replace('Р', 'P');
            input = input.Replace('С', 'C');
            input = input.Replace('Т', 'Ò');
            input = input.Replace('У', 'Ó');
            input = input.Replace('Ф', 'Ñ');
            input = input.Replace('Х', 'X');
            input = input.Replace('Ц', 'Œ');
            input = input.Replace('Ч', 'Ù');
            input = input.Replace('Ш', 'Ú');
            input = input.Replace('Щ', 'Û');
            input = input.Replace('Ъ', 'Å');
            input = input.Replace('Ы', 'Ÿ');
            input = input.Replace('Ь', 'Ö');
            input = input.Replace('Э', 'Ë');
            input = input.Replace('Ю', 'Ô');
            input = input.Replace('Я', 'Ü');
            input = input.Replace('а', 'a');
            input = input.Replace('б', 'à');
            input = input.Replace('в', 'á');
            input = input.Replace('г', 'â');
            input = input.Replace('д', 'ä');
            input = input.Replace('е', 'e');
            input = input.Replace('ё', 'e');
            input = input.Replace('ж', 'æ');
            input = input.Replace('з', 'ç');
            input = input.Replace('и', 'è');
            input = input.Replace('й', 'é');
            input = input.Replace('к', 'ê');
            input = input.Replace('л', 'ì');
            input = input.Replace('м', 'í');
            input = input.Replace('н', 'î');
            input = input.Replace('о', 'o');
            input = input.Replace('п', 'ï');
            input = input.Replace('р', 'p');
            input = input.Replace('с', 'c');
            input = input.Replace('т', 'ò');
            input = input.Replace('у', 'ó');
            input = input.Replace('ф', 'ñ');
            input = input.Replace('х', 'x');
            input = input.Replace('ц', 'œ');
            input = input.Replace('ч', 'ù');
            input = input.Replace('ш', 'ú');
            input = input.Replace('щ', 'û');
            input = input.Replace('ъ', 'å');
            input = input.Replace('ы', 'ÿ');
            input = input.Replace('ь', 'ö');
            input = input.Replace('э', 'ë');
            input = input.Replace('ю', 'ô');
            input = input.Replace('я', 'ü');
            return input;
        }

        public string ToRusBack(string input)
        {
            input = input.Replace('A', 'А');
            input = input.Replace('À', 'Б');
            input = input.Replace('Á', 'В');
            input = input.Replace('Â', 'Г');
            input = input.Replace('Ä', 'Д');
            input = input.Replace('E', 'Е');
            input = input.Replace('E', 'Ё');
            input = input.Replace('Æ', 'Ж');
            input = input.Replace('Ç', 'З');
            input = input.Replace('È', 'И');
            input = input.Replace('É', 'Й');
            input = input.Replace('Ê', 'К');
            input = input.Replace('Ì', 'Л');
            input = input.Replace('Í', 'М');
            input = input.Replace('Î', 'Н');
            input = input.Replace('O', 'О');
            input = input.Replace('Ï', 'П');
            input = input.Replace('P', 'Р');
            input = input.Replace('C', 'С');
            input = input.Replace('Ò', 'Т');
            input = input.Replace('Ó', 'У');
            input = input.Replace('Ñ', 'Ф');
            input = input.Replace('²', 'Ф'); //старое
            input = input.Replace('X', 'Х');
            input = input.Replace('Œ', 'Ц');
            input = input.Replace('Ù', 'Ч');
            input = input.Replace('Ú', 'Ш');
            input = input.Replace('Û', 'Щ');
            input = input.Replace('µ', 'Ъ'); //старое
            input = input.Replace('Å', 'Ъ');
            input = input.Replace('Ÿ', 'Ы');
            input = input.Replace('Ö', 'Ь');
            input = input.Replace('Ë', 'Э');
            input = input.Replace('Ô', 'Ю');
            input = input.Replace('Ü', 'Я');
            input = input.Replace('a', 'а');
            input = input.Replace('à', 'б');
            input = input.Replace('á', 'в');
            input = input.Replace('â', 'г');
            input = input.Replace('ä', 'д');
            input = input.Replace('e', 'е');
            input = input.Replace('e', 'ё');
            input = input.Replace('æ', 'ж');
            input = input.Replace('ç', 'з');
            input = input.Replace('è', 'и');
            input = input.Replace('é', 'й');
            input = input.Replace('ê', 'к');
            input = input.Replace('ì', 'л');
            input = input.Replace('í', 'м');
            input = input.Replace('î', 'н');
            input = input.Replace('o', 'о');
            input = input.Replace('ï', 'п');
            input = input.Replace('p', 'р');
            input = input.Replace('c', 'с');
            input = input.Replace('ò', 'т');
            input = input.Replace('ó', 'у');
            input = input.Replace('ñ', 'ф');
            input = input.Replace('³', 'ф'); //старое
            input = input.Replace('x', 'х');
            input = input.Replace('œ', 'ц');
            input = input.Replace('ù', 'ч');
            input = input.Replace('ú', 'ш');
            input = input.Replace('û', 'щ');
            input = input.Replace('°', 'ъ'); //старое
            input = input.Replace('å', 'ъ');
            input = input.Replace('ÿ', 'ы');
            input = input.Replace('ö', 'ь');
            input = input.Replace('ë', 'э');
            input = input.Replace('ô', 'ю');
            input = input.Replace('ü', 'я');
            return input;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = ToRusBack(richTextBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = ToRus(richTextBox1.Text);
        }
    }
}
