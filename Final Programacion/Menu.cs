namespace Final_Programacion
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            CreateFile frm = new CreateFile();
            frm.ShowDialog();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnModifyFile_Click(object sender, EventArgs e)
        {
            ModificarArchivo ventana = new ModificarArchivo();
            ventana.ShowDialog();
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            LeerArchivo ventana = new LeerArchivo();
            ventana.ShowDialog();
        }
    }
}