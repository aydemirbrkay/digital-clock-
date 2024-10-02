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
                saniye = 0;  // Saniye s�f�rlan�yor
                dakika++;    // Dakika art�r�l�yor
            }

            if (dakika == 60)
            {
                dakika = 0;  // Dakika s�f�rlan�yor
                saat++;      // Saat art�r�l�yor
            }

            if (saat == 24)
            {
                saat = 0;    // Saat 24 olunca s�f�rlan�yor
            }

            // Label'lara g�ncellenmi� zaman de�erlerini yazd�rma
            label3.Text = saniye.ToString("D2"); // Saniyeyi iki haneli g�ster
            label2.Text = dakika.ToString("D2"); // Dakikay� iki haneli g�ster
            label1.Text = saat.ToString("D2");   // Saati iki haneli g�ster
        }
    }
}
