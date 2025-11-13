using System.Linq;
using System.Windows.Forms;

namespace projectFinalAppdev
{
    public static class FormManager
    {
        public static void ShowUnique<T>() where T : Form, new()
        {
            var existing = Application.OpenForms.OfType<T>().FirstOrDefault();
            if (existing != null)
            {
                if (existing.WindowState == FormWindowState.Minimized)
                    existing.WindowState = FormWindowState.Normal;
                existing.BringToFront();
                existing.Activate();
            }
            else
            {
                var form = new T();
                form.Show();
            }
        }
    }
}