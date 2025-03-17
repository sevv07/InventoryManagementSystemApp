using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }


        private void loginButton_Click(object sender, EventArgs e)
        {
            // Kullanýcýdan alýnan veriler
            string email = usernameTextbox.Text; // Username TextBox'u
            string password = passwordTextbox.Text; // Password TextBox'u


            // Database connection
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mehme\Documents\sqlDB.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;


            // SQL komutu

            try
            {

                cmd = new SqlCommand("SELECT COUNT(*) FROM Users WHERE Email = @Email AND Password = @Password", con);

                // Parametreleri ekle
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);


                // Baðlantýyý aç ve sorguyu çalýþtýr
                con.Open();
                
                int userCount = (int)cmd.ExecuteScalar(); // Kullanýcý sayýsýný kontrol eder
                con.Close();
                if (userCount > 0)
                {
                    // Giriþ baþarýlý
                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Ana menüye gitmek için yeni bir form açabilirsiniz
                    cmd = new SqlCommand("SELECT Name FROM Users WHERE Email = @Email", con);
                    cmd.Parameters.AddWithValue("@Email", email);
                    con.Open();
                    string name = cmd.ExecuteScalar().ToString();
                    con.Close();
                    MainPage mainForm = new MainPage(name);
                    mainForm.Show();
                    this.Hide(); // Login formunu gizler
                }
                else
                {
                    // Giriþ baþarýsýz
                    MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    usernameTextbox.Text = "";
                    passwordTextbox.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            // Yeni bir Register formu oluþtur ve göster
            Register registerForm = new Register(this);
            registerForm.Show(); // Yeni formu göster

            // Eðer bu formu kapatmak istiyorsanýz (örneðin, giriþ ekranýndan sonra):
            this.Hide(); // Mevcut formu gizler
        }
    }
}
