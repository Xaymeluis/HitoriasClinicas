using System.Windows.Forms;

namespace HistoriasClinicas
{
    class ClassShowMessage 
    {
        public static void UserError(string Message)
        {
            MessageBox.Show(Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        } 
    }
}
