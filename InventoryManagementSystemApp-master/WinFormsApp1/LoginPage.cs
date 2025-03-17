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
            // Kullan�c�dan al�nan veriler
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


                // Ba�lant�y� a� ve sorguyu �al��t�r
                con.Open();
                
                int userCount = (int)cmd.ExecuteScalar(); // Kullan�c� say�s�n� kontrol eder
                con.Close();
                if (userCount > 0)
                {
                    // Giri� ba�ar�l�
                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Ana men�ye gitmek i�in yeni bir form a�abilirsiniz
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
                    // Giri� ba�ar�s�z
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
            // Yeni bir Register formu olu�tur ve g�ster
            Register registerForm = new Register(this);
            registerForm.Show(); // Yeni formu g�ster

            // E�er bu formu kapatmak istiyorsan�z (�rne�in, giri� ekran�ndan sonra):
            this.Hide(); // Mevcut formu gizler
 �������}
    }
}
