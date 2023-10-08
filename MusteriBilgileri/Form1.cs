namespace MusteriBilgileri
{
    public partial class Form1 : Form
    {
        List<MusteriBilgi> kisiler = new List<MusteriBilgi>();

        public Form1()
        {
            InitializeComponent();
        }
        public Form1(List<MusteriBilgi> musteriBilgileri)
        {
            InitializeComponent();
            kisiler = musteriBilgileri;

        }

        public void btnYeniMusteri_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            this.Hide();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            foreach(MusteriBilgi musteribilgi in kisiler)
            {
                lboxMusteriler.Items.Add(musteribilgi.Ad);
                lboxMusteriler.Items.Add(musteribilgi.Soyad);
            }
        }

        public void lboxMusteriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indeksNo = lboxMusteriler.SelectedIndex;
            string bilgi = $"Adı : {kisiler[indeksNo].Ad}\n" +
                $"Soyadı : {kisiler[indeksNo].Soyad}\n" +
                $"Telefonu : {kisiler[indeksNo].Telefon}\n" +
                $"Yaşı : {kisiler[indeksNo].Yas}\n" +
                $"Adresi : {kisiler[indeksNo].Adres}";

            MessageBox.Show(bilgi, "Müşteri Bilgileri", MessageBoxButtons.OK, MessageBoxIcon.Information );
        }
    }
}

