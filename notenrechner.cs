namespace Notenrechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNote1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNote2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNote3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNote4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNote5_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonBerechnen_Click(object sender, EventArgs e)
        {
            // Variablen zur Aufnahme der eingegebenen Noten und der Anzahl der ausgefüllten Textboxen
            double durchschnitt = 0;
            int ausgefüllteTextBoxen = 0;

            // Versuche die eingegebenen Noten zu parsen und berechne den Durchschnitt
            if (double.TryParse(txtNote1.Text.Replace(',', '.'), out double note1))
            {
                durchschnitt += note1;
                ausgefüllteTextBoxen++;
            }
            if (double.TryParse(txtNote2.Text.Replace(',', '.'), out double note2))
            {
                durchschnitt += note2;
                ausgefüllteTextBoxen++;
            }
            if (double.TryParse(txtNote3.Text.Replace(',', '.'), out double note3))
            {
                durchschnitt += note3;
                ausgefüllteTextBoxen++;
            }
            if (double.TryParse(txtNote4.Text.Replace(',', '.'), out double note4))
            {
                durchschnitt += note4;
                ausgefüllteTextBoxen++;
            }
            if (double.TryParse(txtNote5.Text.Replace(',', '.'), out double note5))
            {
                durchschnitt += note5;
                ausgefüllteTextBoxen++;
            }

            // Überprüfe, ob mindestens 2 Textboxen ausgefüllt wurden
            if (ausgefüllteTextBoxen < 2)
            {
                MessageBox.Show("Bitte füllen Sie mindestens zwei Textboxen aus.");
                return;
            }

            // Berechnung des Durchschnitts
            durchschnitt /= ausgefüllteTextBoxen;

            // Anzeigen des Durchschnitts
            MessageBox.Show("Der Durchschnitt der Noten beträgt: " + durchschnitt.ToString("F2"));
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            // Leere alle Textboxen
            txtNote1.Text = "";
            txtNote2.Text = "";
            txtNote3.Text = "";
            txtNote4.Text = "";
            txtNote5.Text = "";
        }
    }
}
