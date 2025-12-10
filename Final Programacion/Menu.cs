
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

        private void btnReportControl_Click(object sender, EventArgs e)
        {
            Reporte_Control ventana = new Reporte_Control();
            ventana.ShowDialog();
        }


        private void btnDeleteFile_Click(object sender, EventArgs e)
        {
            EliminarArchivo ventanaEliminar = new EliminarArchivo();
            ventanaEliminar.ShowDialog();
        }

        private void btnConvertFile_Click(object sender, EventArgs e)
        {
            ConvertirArchivos ventana = new ConvertirArchivos();
            ventana.ShowDialog();
        }
    }
}