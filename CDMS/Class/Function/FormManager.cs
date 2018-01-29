using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDMS.Class.Function
{
    public class FormManager<T> where T : Form, new()
    {
        public static void Show(Form ParentForm)
        {
            Type tp = typeof(T);
            foreach (Form formName in Application.OpenForms)
            {
                if (formName.Name == tp.Name)
                {
                    Application.OpenForms[tp.Name].Activate();
                    Application.OpenForms[tp.Name].WindowState = FormWindowState.Maximized;
                    return;
                }
            }
            Form formm = new T()
            {
                MdiParent = ParentForm,
                WindowState = FormWindowState.Maximized
            };
            formm.Show();
        }

        public static void Show(Form ParentForm, string _Tag, string MenuClickName)
        {
            Type tp = typeof(T);
            foreach (Form formName in Application.OpenForms)
            {
                if (formName.Name == tp.Name)
                {
                    Application.OpenForms[tp.Name].Activate();
                    return;
                }
            }

            Form formm = new T()
            {
                AccessibleDescription = MenuClickName,
                MdiParent = ParentForm,
                WindowState = FormWindowState.Maximized,
                Tag = _Tag
            };

            formm.Show();
        }

        public static void Show(T TFR, Form ParentForm, string _Tag, string MenuClickName)
        {

            Type tp = typeof(T);
            foreach (Form formName in Application.OpenForms)
            {
                if (formName.Name == tp.Name && (formName.Tag ?? "").ToString() == _Tag)
                {
                    formName.AccessibleDescription = MenuClickName;
                    formName.Activate();
                    Application.OpenForms[tp.Name].Activate();
                    return;
                }
            }

            Form formm = TFR as T;
            formm.AccessibleDescription = MenuClickName;
            formm.MdiParent = ParentForm;
            formm.WindowState = FormWindowState.Maximized;
            formm.Tag = _Tag;
            formm.Show();
        }
    }
}
