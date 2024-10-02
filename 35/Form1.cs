namespace _35
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int saat = 0, dakika = 0, saniye = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            if (saniye == 60)
            {
                saniye = 0;  // Saniye sýfýrlanýyor
                dakika++;    // Dakika artýrýlýyor
            }

            if (dakika == 60)
            {
                dakika = 0;  // Dakika sýfýrlanýyor
                saat++;      // Saat artýrýlýyor
            }

            if (saat == 24)
            {
                saat = 0;    // Saat 24 olunca sýfýrlanýyor
            }

            // Label'lara güncellenmiþ zaman deðerlerini yazdýrma
            label3.Text = saniye.ToString("D2"); // Saniyeyi iki haneli göster
            label2.Text = dakika.ToString("D2"); // Dakikayý iki haneli göster
            label1.Text = saat.ToString("D2");   // Saati iki haneli göster
        }
    }
}
