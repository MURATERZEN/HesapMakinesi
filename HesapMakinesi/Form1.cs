using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {

        double sayi1, sayi2, fark2, toplam, fark, bolum, carpým, bolum2, carpým1;
        double sayi_bölme, sayi_carpma, sayi_cikarma, sayi_toplama;
        string islem;
        double Sonuc_Cikar = 0, Sonuc_Topla = 0;
        double Sonuc_Bol = 1, Sonuc_Carp = 1;
        double a;



#pragma warning disable CS8618 // Null atanamaz alan, oluþturucudan çýkýþ yaparken null olmayan bir deðer içermelidir. Alaný null atanabilir olarak bildirmeyi düþünün.
        public Form1()
#pragma warning restore CS8618 // Null atanamaz alan, oluþturucudan çýkýþ yaparken null olmayan bir deðer içermelidir. Alaný null atanabilir olarak bildirmeyi düþünün.
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0")
            {
                TextBox1.Text = "1";
            }
            else
            {
                TextBox1.Text += "1";
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0")
            {
                TextBox1.Text = "2";
            }
            else
            {
                TextBox1.Text += "2";
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0")
            {
                TextBox1.Text = "3";
            }
            else
            {
                TextBox1.Text += "3";
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0")
            {
                TextBox1.Text = "4";
            }
            else
            {
                TextBox1.Text += "4";
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0")
            {
                TextBox1.Text = "5";
            }
            else
            {
                TextBox1.Text += "5";
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0")
            {
                TextBox1.Text = "6";
            }
            else
            {
                TextBox1.Text += "6";
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult x = MessageBox.Show("Programdan Çýkmak Ýstediðinizden Emin Misiniz?", "Çýkýþ Mesajý!", MessageBoxButtons.YesNo);
            if (x == DialogResult.Yes)
            {

                Environment.Exit(0);

            }
            else if (x == DialogResult.No)
            {

                e.Cancel = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0")
            {
                TextBox1.Text = "7";
            }
            else
            {
                TextBox1.Text += "7";
            }
        }



        private void button8_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0")
            {
                TextBox1.Text = "8";
            }
            else
            {
                TextBox1.Text += "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0")
            {
                TextBox1.Text = "9";
            }
            else
            {
                TextBox1.Text += "9";
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "0" || TextBox1.Text == null)
            {
                TextBox1.Text = "0";

            }
            else
            {
                TextBox1.Text += "0";
            }

        }
        private void Topla_Click(object sender, EventArgs e)
        {


            if (islem == "/" && TextBox1.Text != "")
            {
                sayi1 = Convert.ToDouble(TextBox1.Text);
                sayi2 = Convert.ToDouble(label1.Text);
                a = sayi2 / sayi1;
                TextBox1.Clear();
                a = Math.Round(a, 4);
                label1.Text = Convert.ToString(a);
                islem = "/";
            }
            if (islem == "-" && TextBox1.Text != "")
            {
                sayi1 = Convert.ToDouble(TextBox1.Text);
                sayi2 = Convert.ToDouble(label1.Text);
                TextBox1.Clear();
                a = sayi2 - sayi1;
                a = Math.Round(a, 4);
                label1.Text = Convert.ToString(a);
                islem = "-";
            }
            if (islem == "*" && TextBox1.Text != "")
            {
                sayi1 = Convert.ToDouble(TextBox1.Text);
                sayi2 = Convert.ToDouble(label1.Text);
                TextBox1.Clear();
                a = sayi2 * sayi1;
                a = Math.Round(a, 4);
                label1.Text = Convert.ToString(a);
                islem = "*";
            }

            if (TextBox1.Text != null && label1.Text == "Sonuc" || label1.Text == "")
            {
                toplam = Convert.ToDouble(TextBox1.Text);
                Sonuc_Topla += toplam;
                Sonuc_Topla = Math.Round(Sonuc_Topla, 4);
                label1.Text = Convert.ToString(Sonuc_Topla);
                TextBox1.Clear();


            }
            if (TextBox1.Text == "" && label1.Text != null)
            {
                Sonuc_Topla = Convert.ToDouble(label1.Text);


            }
            if (islem == "=" && TextBox1.Text!="")
            {
                label1.Text = "";
                toplam = Convert.ToDouble(TextBox1.Text);
                Sonuc_Topla = 0;
                Sonuc_Topla += toplam;
                Sonuc_Topla = Math.Round(Sonuc_Topla, 4);
                label1.Text = Convert.ToString(Sonuc_Topla);



            }
            if (islem == "=" && TextBox1.Text == "")
            {
                sayi_toplama= Convert.ToDouble(label1.Text);
                TextBox1.Text=Convert.ToString(sayi_toplama) ;
            }

                if (TextBox1.Text != "" && islem == "+")
            {
                toplam = Convert.ToDouble(TextBox1.Text);
                Sonuc_Topla += toplam;
                Sonuc_Topla = Math.Round(Sonuc_Topla, 4);
                label1.Text = Convert.ToString(Sonuc_Topla);


            }
            TextBox1.Clear();




            sayi1 = 0;
            sayi2 = 0;
            a = 0;
            Sonuc_Cikar = 0;
            Sonuc_Bol = 1;
            Sonuc_Carp = 1;
            bolum2 = 0;
            fark2 = 0;
            islem = "+";
        }

        private void Cýkar_Click(object sender, EventArgs e)
        {
            if (islem == "/" && TextBox1.Text != "")
            {
                sayi1 = Convert.ToDouble(TextBox1.Text);
                sayi2 = Convert.ToDouble(label1.Text);

                a = sayi2 / sayi1;
                TextBox1.Clear();
                a = Math.Round(a, 4);
                label1.Text = Convert.ToString(a);

                islem = "/";
            }
            if (islem == "+" && TextBox1.Text != "")
            {
                sayi1 = Convert.ToDouble(TextBox1.Text);
                sayi2 = Convert.ToDouble(label1.Text);
                a = sayi2 + sayi1;
                TextBox1.Clear();
                a = Math.Round(a, 4);
                label1.Text = Convert.ToString(a);

                islem = "+";
            }
            if (islem == "*" && TextBox1.Text != "")
            {
                sayi1 = Convert.ToDouble(TextBox1.Text);
                sayi2 = Convert.ToDouble(label1.Text);
                a = sayi2 * sayi1;
                TextBox1.Clear();
                a = Math.Round(a, 4);
                label1.Text = Convert.ToString(a);
                islem = "*";
            }

            if (TextBox1.Text != null && label1.Text == "Sonuc" || label1.Text == "")
            {
                fark = Convert.ToDouble(TextBox1.Text);
                TextBox1.Clear();
                Sonuc_Cikar = 0;
                Sonuc_Cikar = fark - Sonuc_Cikar;

                Sonuc_Cikar = Math.Round(Sonuc_Cikar, 4);
                label1.Text = Convert.ToString(Sonuc_Cikar);

            }
            if (TextBox1.Text == "" && label1.Text != null)
            {
                fark = Convert.ToDouble(label1.Text);

            }
            if (islem == "="&& TextBox1.Text != "")
            {
                label1.Text = "";
                fark = Convert.ToDouble(TextBox1.Text);
                TextBox1.Clear();
                Sonuc_Cikar = 0;
                Sonuc_Cikar = fark - Sonuc_Cikar;

                Sonuc_Cikar = Math.Round(Sonuc_Cikar, 4);
                label1.Text = Convert.ToString(Sonuc_Cikar);

            }
            if (islem == "=" && TextBox1.Text == "")
            {
                sayi_cikarma = Convert.ToDouble(label1.Text);
                TextBox1.Text = Convert.ToString(sayi_cikarma);
            }
            if (TextBox1.Text != "" && islem == "-")
            {
                fark = Convert.ToDouble(TextBox1.Text);
                TextBox1.Clear();
                fark2 = Convert.ToDouble(label1.Text);

                fark2 -= fark;

                fark2 = Math.Round(fark2, 4);
                label1.Text = Convert.ToString(fark2);

            }




            Sonuc_Topla = 0;
            Sonuc_Bol = 1;
            Sonuc_Carp = 1;
            sayi1 = 0;
            sayi2 = 0;
            a = 0;



            islem = "-";
        }
        private void Carp_Click(object sender, EventArgs e)
        {
            if (islem == "/" && TextBox1.Text != "")
            {
                sayi1 = Convert.ToDouble(TextBox1.Text);
                sayi2 = Convert.ToDouble(label1.Text);

                a = sayi2 / sayi1;
                TextBox1.Clear();
                a = Math.Round(a, 4);
                label1.Text = Convert.ToString(a);

                islem = "/";
            }
            if (islem == "+" && TextBox1.Text != "")
            {
                sayi1 = Convert.ToDouble(TextBox1.Text);
                sayi2 = Convert.ToDouble(label1.Text);
                a = sayi2 + sayi1;
                TextBox1.Clear();
                a = Math.Round(a, 4);
                label1.Text = Convert.ToString(a);

                islem = "+";
            }
            if (islem == "-" && TextBox1.Text != "")
            {
                sayi1 = Convert.ToDouble(TextBox1.Text);
                sayi2 = Convert.ToDouble(label1.Text);
                a = sayi2 - sayi1;
                TextBox1.Clear();
                a = Math.Round(a, 4);
                label1.Text = Convert.ToString(a);


                islem = "-";
            }
            if (TextBox1.Text != null && label1.Text == "Sonuc" || label1.Text == "")
            {
                carpým1 = Convert.ToDouble(TextBox1.Text);
                Sonuc_Carp *= carpým1;
                Sonuc_Carp = Math.Round(Sonuc_Carp, 4);
                label1.Text = Convert.ToString(Sonuc_Carp);
                TextBox1.Clear();

            }
            if (TextBox1.Text == "" && label1.Text != null)
            {
                Sonuc_Carp = Convert.ToDouble(label1.Text);

            }
            if (islem == "=" &&  TextBox1.Text != "")
            {
                label1.Text = "";
                carpým = Convert.ToDouble(TextBox1.Text);
                Sonuc_Carp = 1;
                Sonuc_Carp *= carpým;
                Sonuc_Carp = Math.Round(Sonuc_Carp, 4);


                label1.Text = Convert.ToString(Sonuc_Carp);
            }
            if (islem == "=" && TextBox1.Text == "")
            {
                sayi_carpma = Convert.ToDouble(label1.Text);
                TextBox1.Text = Convert.ToString(sayi_carpma);
            }

            if (TextBox1.Text != "" && islem == "*")
            {
                carpým1 = Convert.ToDouble(TextBox1.Text);

                Sonuc_Carp *= carpým1;
                Sonuc_Carp = Math.Round(Sonuc_Carp, 4);

                if (Sonuc_Carp == -0)
                {
                    Sonuc_Carp = 0;
                    label1.Text = Convert.ToString(Sonuc_Carp);
                }
                label1.Text = Convert.ToString(Sonuc_Carp);
            }

            TextBox1.Clear();

            sayi1 = 0;
            sayi2 = 0;
            a = 0;
            Sonuc_Topla = 0;
            Sonuc_Bol = 1;
            Sonuc_Cikar = 0;
            fark2 = 0;
            bolum2 = 0;
            islem = "*";
        }
        private void Bol_Click(object sender, EventArgs e)
        {
            if (islem == "*" && TextBox1.Text != "")
            {
                sayi1 = Convert.ToDouble(TextBox1.Text);
                sayi2 = Convert.ToDouble(label1.Text);
                a = sayi2 * sayi1;
                TextBox1.Clear();
                label1.Text = Convert.ToString(a);
                islem = "*";
            }
            if (islem == "+" && TextBox1.Text != "")
            {
                sayi1 = Convert.ToDouble(TextBox1.Text);
                sayi2 = Convert.ToDouble(label1.Text);
                a = sayi2 + sayi1;
                TextBox1.Clear();
                a = Math.Round(a, 4);
                label1.Text = Convert.ToString(a);

                islem = "+";
            }
            if (islem == "-" && TextBox1.Text != "")
            {
                sayi1 = Convert.ToDouble(TextBox1.Text);
                sayi2 = Convert.ToDouble(label1.Text);
                a = sayi2 - sayi1;
                TextBox1.Clear();
                a = Math.Round(a, 4);
                label1.Text = Convert.ToString(a);


                islem = "-";
            }
            if (TextBox1.Text != null && label1.Text == "Sonuc" || label1.Text == "")
            {
                bolum = Convert.ToDouble(TextBox1.Text);
                TextBox1.Clear();

                Sonuc_Bol = bolum / Sonuc_Bol;
                Sonuc_Bol = Math.Round(Sonuc_Bol, 4);
                label1.Text = Convert.ToString(Sonuc_Bol);

            }
            if (TextBox1.Text == "" && label1.Text != null)
            {
                bolum = Convert.ToDouble(label1.Text);
                TextBox1.Clear();
            }
            if (islem == "/")
            {
                bolum = Convert.ToDouble(TextBox1.Text);
                TextBox1.Clear();
                bolum2 = Convert.ToDouble(label1.Text);

                bolum2 /= bolum;

                bolum2 = Math.Round(bolum2, 4);
                label1.Text = Convert.ToString(bolum2);

            }

            if (islem == "=" && TextBox1.Text != "")
            {
                label1.Text += "";
                bolum = Convert.ToDouble(TextBox1.Text);
                Sonuc_Bol = 1;
                Sonuc_Bol = bolum / Sonuc_Bol;
                Sonuc_Bol = Math.Round(Sonuc_Bol, 4);


                label1.Text = Convert.ToString(Sonuc_Bol);
            }
            if (islem == "=" && TextBox1.Text == "")
            {
                sayi_bölme = Convert.ToDouble(label1.Text);
                TextBox1.Text = Convert.ToString(sayi_bölme);
            }
            if (bolum == 0)
            {

                MessageBox.Show("SIFIRA BÖLÜNEMEZ");
            }
            TextBox1.Clear();
            sayi1 = 0;
            sayi2 = 0;
            a = 0;
            Sonuc_Topla = 0;
            Sonuc_Cikar = 0;
            Sonuc_Carp = 1;
            fark2 = 0;
            islem = "/";
        }
        private void Esit_Click(object sender, EventArgs e)
        {
            if (islem == "+" && TextBox1.Text != "")
            {
                sayi_toplama = Convert.ToDouble(TextBox1.Text);
                Sonuc_Topla += sayi_toplama;
                Sonuc_Topla = Math.Round(Sonuc_Topla, 4);
                TextBox1.Text = Convert.ToString(Sonuc_Topla);
            }
            if (islem == "+" && TextBox1.Text == "")
            {
                sayi_toplama = Convert.ToDouble(label1.Text);
                TextBox1.Text = Convert.ToString(sayi_toplama);
                label1.Text = "";

            }

            if (islem == "*" && TextBox1.Text == "")
            {
                sayi_carpma = Convert.ToDouble(label1.Text);
                TextBox1.Text = Convert.ToString(sayi_carpma);
                label1.Text = "";


            }
            if (islem == "*" && TextBox1.Text != "")
            {
                sayi_carpma = Convert.ToDouble(TextBox1.Text);
                Sonuc_Carp *= sayi_carpma;
                Sonuc_Carp = Math.Round(Sonuc_Carp, 4);
                TextBox1.Text = Convert.ToString(Sonuc_Carp);
            }

            if (islem == "-" && TextBox1.Text != "")
            {
                sayi_cikarma = Convert.ToDouble(TextBox1.Text);
                Sonuc_Cikar= Convert.ToDouble(label1.Text);
                Sonuc_Cikar = Sonuc_Cikar - sayi_cikarma;
                Sonuc_Cikar = Math.Round(Sonuc_Cikar, 4);
                TextBox1.Text = Convert.ToString(Sonuc_Cikar);
            }
            if (islem == "-" && TextBox1.Text == "")
            {
                sayi_cikarma = Convert.ToDouble(label1.Text);
                TextBox1.Text = Convert.ToString(sayi_cikarma);
                label1.Text = "";
            }



            if (islem == "/" && TextBox1.Text == "")
            {
                sayi_bölme = Convert.ToDouble(label1.Text);
                TextBox1.Text = Convert.ToString(sayi_bölme);
                label1.Text = "";
            }
            if (islem == "/" && TextBox1.Text != "")
            {
                sayi_bölme = Convert.ToDouble(TextBox1.Text);
                Sonuc_Bol=Convert.ToDouble(label1.Text);
                Sonuc_Bol = Sonuc_Bol / sayi_bölme;
                Sonuc_Bol = Math.Round(Sonuc_Bol, 4);
                TextBox1.Text = Convert.ToString(Sonuc_Bol);
            }



            islem = "=";


        }
        private void button11_Click(object sender, EventArgs e)
        {

            if (TextBox1.Text.Contains(',') == true)
            {
                MessageBox.Show("Daha Fazla Virgül Girilemez");
            }
            if (TextBox1.Text == "")
            {
                MessageBox.Show("Önce Sayi Giriniz");
            }

            if (TextBox1.Text.Contains(',') == false && TextBox1.Text != "")
            {
                TextBox1.Text += ",";
            }


        }


        private void Sil_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "0";
            label1.Text = "Sonuc";
            fark2 = 0;
            bolum2 = 0;
            Sonuc_Topla = 0;
            Sonuc_Cikar = 0;
            Sonuc_Bol = 1;
            Sonuc_Carp = 1;
            islem = "";

            fark = 0;
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            if (TextBox1.Text == "")
            {
                TextBox1.Text = "0";
            }
            if (TextBox1.Text == ",")
            {
                TextBox1.Text = "0";
            }

            if (Convert.ToDouble(TextBox1.Text) > 0)
            {
                TextBox1.Text = TextBox1.Text.Remove(TextBox1.Text.Length - 1, 1);
                if (TextBox1.Text.Length == 0)
                {
                    TextBox1.Text = "0";
                }

            }
            else if (TextBox1.Text == "0")
            {
                TextBox1.Text = "0";
            }

        }


    }
}