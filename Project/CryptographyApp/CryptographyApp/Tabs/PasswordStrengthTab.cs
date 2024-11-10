using System;
using System.Linq;
using System.Windows.Forms;

namespace CryptographyApp.Tabs
{
    public partial class PasswordStrengthTab : UserControl
    {
        private static readonly Random random = new Random();

        public PasswordStrengthTab()
        {
            InitializeComponent();

            passwordTextbox.TextChanged += passwordTextbox_TextChanged;
        }

        private int CalculateCharacterSetSize(string password)
        {
            int charsetSize = 0;

            if (password.Any(char.IsLower)) charsetSize += 26; // Lowercase
            if (password.Any(char.IsUpper)) charsetSize += 26; // Uppercase
            if (password.Any(char.IsDigit)) charsetSize += 10; // Digits
            if (password.Any(ch => !char.IsLetterOrDigit(ch))) charsetSize += 32; // Symbols

            return charsetSize;
        }

        private double CalculateEntropy(string password)
        {
            int charsetSize = CalculateCharacterSetSize(password);
            if (charsetSize == 0) return 0;

            double entropy = password.Length * Math.Log2(charsetSize);
            return entropy;
        }

        private void weakPasswordButton_Click(object sender, EventArgs e)
        {
            passwordTextbox.Text = GenerateWeakPassword();
        }

        private void moderatePasswordButton_Click(object sender, EventArgs e)
        {
            passwordTextbox.Text = GenerateModeratePassword();
        }

        private void strongPasswordButton_Click(object sender, EventArgs e)
        {
            passwordTextbox.Text = GenerateStrongPassword();
        }

        private void passwordTextbox_TextChanged(object sender, EventArgs e)
        {
            // Calculate and display entropy and strength
            string password = passwordTextbox.Text;
            double entropy = CalculateEntropy(password);
            entropyLabel.Text = $"Entropy: {entropy:F2} bits";
            strengthLabel.Text = $"Strength: {GetPasswordStrength(entropy)}";
        }

        private string GenerateWeakPassword()
        {
            const string lowercaseChars = "abcdefghijklmnopqrstuvwxyz";
            return GeneratePassword(lowercaseChars, 6); // Short length, only lowercase
        }

        private string GenerateModeratePassword()
        {
            const string moderateChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return GeneratePassword(moderateChars, 10); // Medium length, mixed characters
        }

        private string GenerateStrongPassword()
        {
            const string strongChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()_-+=<>?";
            return GeneratePassword(strongChars, 14); // Longer length, mixed characters + symbols
        }

        private string GeneratePassword(string charset, int length)
        {
            return new string(Enumerable.Repeat(charset, length)
                                        .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private string GetPasswordStrength(double entropy)
        {
            if (entropy < 28) return "Very Weak";
            if (entropy < 36) return "Weak";
            if (entropy < 60) return "Moderate";
            if (entropy < 80) return "Strong";
            return "Very Strong";
        }
    }
}
