namespace yakıtHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double yolKm = Convert.ToDouble(maskedTextBox1.Text);
            double yakitTuk = Convert.ToDouble(maskedTextBox2.Text);
            double yakıtFiyat = Convert.ToDouble(maskedTextBox3.Text);
            double ortHiz = Convert.ToDouble(maskedTextBox4.Text);
            double katsayi = Convert.ToDouble(maskedTextBox5.Text);

            if (yolKm <= 0 || yakitTuk <= 0 || yakıtFiyat <= 0 || ortHiz <= 0 || katsayi <= 0)
            {
                MessageBox.Show("Tüm sayılar pozitif olmak zorundadır.", "Hatalı Giriş!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!(katsayi >= 1 && katsayi <= 1.5))
            {
                MessageBox.Show("Trafik Katsayısı 1 ila 1,5 arası bir değer olmak zorundadır.", "Hatalı Giriş!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double topYakitTuketim = (yolKm / 100) * yakitTuk;
                double topMaliyet = topYakitTuketim * yakıtFiyat;
                double süre = yolKm / (ortHiz / katsayi);
                double kmMaliyet = topMaliyet / yolKm;

                label7.Text = ("Toplam yakıt tüketiminiz: " + topYakitTuketim.ToString("0.00") + "\nToplam maliyetiniz: " + topMaliyet.ToString("0.00") + "\nTahmini seyahat süreniz: " + süre.ToString("0.00") + "\nKilometre başı maliyetiniz: " + kmMaliyet.ToString("0.00"));
                label7.Font = new Font(label7.Font, FontStyle.Bold);

            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
