using System.Diagnostics;

namespace redimencion
{
    public partial class Form1 : Form
    {
        FolderBrowserDialog CarpetaEntrada;
        FolderBrowserDialog CarpetaSalida;
        bool Redimencionar = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCarpetaOrigen_Click(object sender, EventArgs e)
        {
            CarpetaEntrada = new FolderBrowserDialog();
            if(CarpetaEntrada.ShowDialog() == DialogResult.OK){
                txtRutaOrigen.Text= CarpetaEntrada.SelectedPath;
                txtRutaDestino.Text= CarpetaEntrada.SelectedPath;
                Redimencionar = true;
            }
        }

        private void btnRedimensionar_Click(object sender, EventArgs e)
        {
            if (Redimencionar)
            {
                // Informacion de los archivos
                String[] files = Directory.GetFiles(txtRutaOrigen.Text);
                String NombreArchivo;
                String NuevaCarpetaArchivo;
                NuevaCarpetaArchivo = txtRutaDestino.Text + "\\";

                // Datos del arreglo

                for (int i = 0; i < files.Length; i++)
                {
                    if (Path.GetExtension(files[i]) == ".jpg") //Ext .jpg
                    {
                        NombreArchivo = Path.GetFileName(files[i]);
                        Bitmap orig = new Bitmap(files[i].Trim()); // archivo a trabajar
                        Bitmap bmp = new Bitmap(RedimensionarImagen(orig, (int)nupAncho.Value, (int)nupAlto.Value));
                        bmp.Save(NuevaCarpetaArchivo + txtNomenclatura.Text + NombreArchivo, System.Drawing.Imaging.ImageFormat.Jpeg);

                        // Barra de progreso 

                        pbprogreso.Value = (100 * i + 1) / (files.Length);
                         
                    }
                }
                if (pbprogreso.Value <= 100)
                {
                   pbprogreso.Value = 0;
                    MessageBox.Show("imagenes procesadas");
                    

                }
                    


            }
        }
        public static Bitmap RedimensionarImagen(Image imagenOriginal, int width, int height)
        {
            //Obtener el tamaño maximo
            var Radio = Math.Max((double)width / imagenOriginal.Width, (double)height /imagenOriginal.Height);
            //Nuevo Ancho y Alto
            var NuevoAncho = (int)(imagenOriginal.Width * Radio);
            var NuevoAlto = (int)(imagenOriginal.Height * Radio);
            var ImagenRedomencionada = new Bitmap(NuevoAncho, NuevoAlto);
            //copiamos la imagen
            Graphics.FromImage(ImagenRedomencionada).DrawImage(imagenOriginal, 0, 0, NuevoAncho, NuevoAlto);
            Bitmap ImagenFinal = new Bitmap(ImagenRedomencionada);
            return ImagenFinal;
        }

        private void btnCarpetaDestino_Click(object sender, EventArgs e)
        {
            CarpetaSalida = new FolderBrowserDialog();
            if (CarpetaSalida.ShowDialog() == DialogResult.OK)
            {
                txtRutaDestino.Text= CarpetaSalida.SelectedPath;
                Redimencionar = true;
            }
        }

        private void nupAncho_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}