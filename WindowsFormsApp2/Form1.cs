using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void hakkındaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("2019-2020 Proje Ödevi - Şeref Can Mertdoğan","Hakkında");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void yardımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yardım Menüsüne Hoş Geldiniz!\n - İşlemler için klavyenizdeki (+ , - , * , / ) işlem simgelerini kullanın. \n - Üslü sayıları malesef ki çıkan uyumsuzluklar, vb. yüzünden kullanamazsınız. \n - Bunlar dışında, yardıma ihtiyacınız olursa, iam@canmertdogan.com'a ya da sınıfta bana sorabilirsiniz, ya da sosyal medya hesaplarından sorularınızı yazabilirsiniz. \n Hepinize iyi günler dilerim.", "Yardım");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
          
        }

        private void button2_Click(object sender, EventArgs e)
        {

            /* 
             * 2x+1
               2x-1
               ax+b
               2x²-3x+1
               (m+3)x³+5x²+(n-1)x+3 */
            if (textBox3 == null)
            {
                MessageBox.Show("Tam verim alabilmek için a değişkenine sayı veriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (textBox4 == null)
            {
                MessageBox.Show("Tam verim alabilmek için b değişkenine sayı veriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (textBox5 == null)
            {
                MessageBox.Show("Tam verim alabilmek için m değişkenine sayı veriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (textBox6 == null)
            {
                MessageBox.Show("Tam verim alabilmek için n değişkenine sayı veriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if ( comboBox1.SelectedIndex == 0)
            {
                //2x+1
                Double s1, sonuc;
                
                string sonucstring, sonucfinal;
                s1 = Convert.ToDouble(textBox1.Text);
                sonuc = s1 * 2 + 1;
                sonucstring = Convert.ToString(s1);
                sonucfinal = sonuc.ToString();
                textBox2.Text = "2 . " + s1 + " + 1 = " + sonucfinal;

            }
            if (comboBox1.SelectedIndex == 1)
            {
                //2x-1
                
                Double s1, sonuc;
                string sonucstring, sonucfinal;
                s1 = Convert.ToDouble(textBox1.Text);
                sonuc = s1 * 2 - 1;
                sonucstring = Convert.ToString(s1);
                sonucfinal = sonuc.ToString();
                textBox2.Text = "2 . " + s1 + " - 1 = " + sonucfinal;

            }
            
            if (comboBox1.SelectedIndex == 2)
            {
                //ax+b

                Double s1, a, b, sonuc;
                string sonucstring, sonucfinal;
                try
                {
                    
                    s1 = Convert.ToDouble(textBox1.Text);
                    a = Convert.ToDouble(textBox3.Text);
                    b = Convert.ToDouble(textBox4.Text);
                    sonuc = a * s1 + b;
                    sonucstring = Convert.ToString(s1);
                    sonucfinal = sonuc.ToString();
                    textBox2.Text = a + " . " + s1 + " + " + b + " = " + sonucfinal;
                }
                catch(Exception)
                {
                    MessageBox.Show("Lütfen A ve B değişkenlerine sayı biçiminde değer giriniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                



                

            }

            if (comboBox1.SelectedIndex == 3)
            {
                //2x²+3x-1
                Double s1, sonuc;
                string sonucstring, sonucfinal;
                try
                {
                    s1 = Convert.ToDouble(textBox1.Text);
                    sonuc = 2 * s1 * s1 - 3 * s1 + 1;
                    sonucstring = Convert.ToString(s1);
                    sonucfinal = sonuc.ToString();



                    textBox2.Text = "2 . " + s1 + "² " + " - 3 . " + s1 + " + 1" + " = " + sonucfinal;
                }
                catch(Exception)
                {
                    MessageBox.Show("Lütfen A ve B değişkenlerine sayı biçiminde değer giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (comboBox1.SelectedIndex == 4)
            {
                //(m+3)x³+5x²+(n-1)x+3
                Double s1,m, n, sonuc;
                string sonucstring, sonucfinal;
                try
                {
                    s1 = Convert.ToDouble(textBox1.Text);
                    m = Convert.ToDouble(textBox5.Text);
                    n = Convert.ToDouble(textBox6.Text);
                    sonuc = m + 3 * s1 * s1 * s1 + 5 * s1 * s1 + n - 1 * s1 + 3;
                    sonucstring = Convert.ToString(s1);
                    sonucfinal = sonuc.ToString();



                    textBox2.Text = "( " + m + " + 3" + " )" + " . " + s1 + "³ + " + "5 . " + s1 + "² " + "( " + n + " - 1 ) . " + s1 + " + 3" + " = " + sonucfinal;
                }
                catch(Exception)
                {
                    MessageBox.Show("Lütfen M ve N değişkenlerine sayı biçiminde değer giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                //ax+b
                textBox3.Enabled = false;
                textBox4.Enabled = false;
                textBox5.Enabled = false;
                textBox6.Enabled = false;
                label3.Text = "Fonksiyon Türü : Sabit Fonksiyon";

            }
            if (comboBox1.SelectedIndex == 1)
            {
                //ax+b
                textBox3.Enabled = false;
                textBox4.Enabled = false;
                textBox5.Enabled = false;
                textBox6.Enabled = false;
                label3.Text = "Fonksiyon Türü : Bileşik Fonksiyon";

            }
            if (comboBox1.SelectedIndex == 3)
            {
                //ax+b
                textBox3.Enabled = false;
                textBox4.Enabled = false;
                textBox5.Enabled = false;
                textBox6.Enabled = false;
                label3.Text = "Fonksiyon Türü : Örten Fonksiyon";

            }
            if (comboBox1.SelectedIndex == 2)
            {
                //ax+b
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                textBox5.Enabled = false;
                textBox6.Enabled = false;
                label3.Text = "Fonksiyon Türü : Birim Fonksiyon";

            }
            if (comboBox1.SelectedIndex == 4)
            {
                //ax+b
                textBox3.Enabled = false;
                textBox4.Enabled = false;
                textBox5.Enabled = true;
                textBox6.Enabled = true;
                label3.Text = "Fonksiyon Türü : Kürek Fonksiyon";
            }

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
