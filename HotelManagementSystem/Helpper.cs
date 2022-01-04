using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem
{
    internal static class Helpper
    {
        public static bool isNullOrEmpty(string text)
        {
            return text == null || text.Trim().Length == 0;
        }
        public static void showError(string errorMessage, string title = "Error")
        {
            MessageBox.Show(errorMessage, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void setError(ErrorProvider errorProvider, Control control, string value, bool clearPrevious = false)
        {
            if (clearPrevious) errorProvider.Clear();
            errorProvider.SetError(control, value);
        }
    }
}
