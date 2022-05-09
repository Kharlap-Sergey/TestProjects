using System.Windows.Forms;

namespace CourseWork
{
    public class FormHelper
    {
        public static bool ShowYesOrNow(string title, string message)
        {
            return (MessageBox.Show(message, title,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes);
        }
    }
}
