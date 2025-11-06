using System;
using System.IO;
using System.Windows.Forms;



namespace FeriaOnline
{
    public partial class Form1 : Form
    {
        private LoginService _loginService;
        public Form1()
        {
            InitializeComponent();
            // Ruta al archivo. 
            // "AppDomain.CurrentDomain.BaseDirectory" obtiene la carpeta donde se ejecuta el .exe
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "C:\\Users\\Jean\\source\\repos\\Proyecto-1\\FeriaOnline\\FeriaOnline\\bin\\Debug\\usuarios.txt");

            _loginService = new LoginService(filePath);
        }
        public class LoginService
        {
            private string _filePath;

            // Constructor que recibe la ruta del archivo de usuarios
            public LoginService(string filePath)
            {
                _filePath = filePath;
            }

            /// Valida un nombre de usuario y contraseña contra el archivo plano.

            public bool ValidateUser(string username, string password)
            {
                // Validaciones básicas de entrada
                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                {
                    return false;
                }

                try
                {
                    // Asegurarnos de que el archivo existe
                    if (!File.Exists(_filePath))
                    {
                        Console.WriteLine($"Error: El archivo de usuarios no se encontró en: {_filePath}");
                        return false;
                    }

                    
                    string[] lines = File.ReadAllLines(_filePath);

                    foreach (string line in lines)
                    {
                        
                        if (string.IsNullOrWhiteSpace(line)) continue;

                        // Separar la línea por la coma
                        string[] parts = line.Split(',');

                        // Asegurarnos de que la línea tiene el formato correcto (usuario,contraseña)
                        if (parts.Length == 2)
                        {
                            string storedUser = parts[0].Trim();
                            string storedPass = parts[1].Trim();

                            // Comparamos:
                            // 1. El nombre de usuario 
                            // 2. La contraseña 
                            if (string.Equals(storedUser, username, StringComparison.OrdinalIgnoreCase) &&
                                storedPass == password)
                            {
                            
                                return true;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // En una aplicación real, aquí registrarías el error (log)
                    Console.WriteLine($"Ocurrió un error al leer el archivo: {ex.Message}");
                }

                // Si el bucle termina sin encontrar una coincidencia
                return false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsuario.Text;
            string password = txtContrasena.Text;

            if (_loginService.ValidateUser(username, password))
            {
              
                MessageBox.Show($"¡Bienvenido, {username}!", "Login Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
               
                MessageBox.Show("Nombre de usuario o contraseña incorrectos.", "Login Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
