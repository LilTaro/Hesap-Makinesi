namespace Hesap_Makinesi
{
    public partial class HesapMakinesi : Form
    {
        //Hesaplama ��in De�i�kenler
        int secim = 0;
        double sayi1, sayi2, sonuc;
        public HesapMakinesi()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Uygulamay� Kapat�r
            Application.Exit();
        }

        private void Buttons(object sender, EventArgs e)
        {
            //TextBoxa Sayilar Buradan Yaziliyor 
            if (TxtCalculate.Text=="0")
            {
                TxtCalculate.Text = "";
            }
            TxtCalculate.Text = TxtCalculate.Text + ((Button)sender).Text;
        }

        private void BtnTopla_Click(object sender, EventArgs e)
        {
            //Toplama ��lemi
            sayi1 = double.Parse(TxtCalculate.Text);
            secim = 1;
            TxtCalculate.Text = "0";
        }

        private void BtnCikar_Click(object sender, EventArgs e)
        {
            //��karma ��lemi
            sayi1 = double.Parse(TxtCalculate.Text);
            secim = 2;
            TxtCalculate.Text = "0";
        }

        private void BtnBol_Click(object sender, EventArgs e)
        {
            //B�lme ��lemi
            sayi1 = double.Parse(TxtCalculate.Text);
            secim = 3;
            TxtCalculate.Text = "0";
        }

        private void BtnCarp_Click(object sender, EventArgs e)
        {
            //�arpma ��lemi
            sayi1 = double.Parse(TxtCalculate.Text);
            secim = 4;
            TxtCalculate.Text = "0";
        }

        private void BtnEsittir_Click(object sender, EventArgs e)
        {
            //Girilen Say�lar�n ��lemi Burada Yap�l�yor
            sayi2= double.Parse(TxtCalculate.Text);
            if (secim==1)
            {
                sonuc = sayi1 + sayi2;
                TxtCalculate.Text = sonuc.ToString();
            }
            if (secim == 2)
            {
                sonuc = sayi1 - sayi2;
                TxtCalculate.Text = sonuc.ToString();
            }
            if (secim == 3)
            {
                sonuc = sayi1 / sayi2;
                TxtCalculate.Text = sonuc.ToString();
            }
            if (secim == 4)
            {
                sonuc = sayi1 * sayi2;
                TxtCalculate.Text = sonuc.ToString();
            }
        }

        private void BtnVirgul_Click(object sender, EventArgs e)
        {
            //Virgul Atama ��lemi Burda Yap�l�yor
            if (TxtCalculate.Text.IndexOf(",")<1)
            {
                TxtCalculate.Text = TxtCalculate.Text + ",";
            }
        }

        private void BtnPN_Click(object sender, EventArgs e)
        {
            //Say�lar� Pozitif ya da Negatif De�ere �eviriyor
            if (TxtCalculate.Text!="0")
            {
                if (TxtCalculate.Text.StartsWith("-"))
                {
                    TxtCalculate.Text = TxtCalculate.Text.Replace("-", "");
                }
                else if (TxtCalculate.Text.StartsWith(""))
                {
                    TxtCalculate.Text = "-" + TxtCalculate.Text;
                }
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            //Textboxtaki Her�eyi Silmeye Yar�yor
            TxtCalculate.Text = "0";
        }

        private void BtnBackSpace_Click(object sender, EventArgs e)
        {
            //Textboxtaki De�erleri Teker Teker Silmeye Yar�yor
            TxtCalculate.Text=TxtCalculate.Text.Substring(0,TxtCalculate.Text.Length-1);
            if (TxtCalculate.Text=="")
            {
                TxtCalculate.Text = "0";
            }
        }
    }
}