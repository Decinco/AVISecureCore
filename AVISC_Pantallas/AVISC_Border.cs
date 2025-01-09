using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AVISC_BaseForms;
using AVISC_Global;
using AVISC_Controles;


namespace AVISC_Pantallas
{
    public partial class AVISC_Border : Form
    {

        public AVISC_Border()
        {

            InitializeComponent();

            OpenForm(new AVISC_Principal()
            {
                UserName = LoginData.UserName,
                AvailableOptions = LoginData.AvailableOptions,
                ProfilePicture = LoginData.ProfilePicture
            });

            swUserOptions1.Username = LoginData.UserName;
            swUserOptions1.Category = LoginData.CategoryName;
            swUserOptions1.UserProfilePicture = LoginData.ProfilePicture;

        }

        /// <summary>
        /// Introduce un formulario nuevo, quitando el anterior. 
        /// </summary>
        /// <param name="newform">Formulario a mostrar.</param>
        private void OpenForm(Form newform)
        {


            newform.TopLevel = false;
            pnl_FormContainer.Controls.Add(newform);

            newform.Show();
            
        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void UserPanel_Click(object sender, EventArgs e)
        {

        }

        private void SetFunctionName(object sender, ControlEventArgs e)
        {
            if (pnl_FormContainer.Controls.Count > 1 && pnl_FormContainer.Controls[1] is AVISC_CloseableFeatureForm)
            {
                AVISC_CloseableFeatureForm activeFunction = (AVISC_CloseableFeatureForm)pnl_FormContainer.Controls[1];

                lbl_FeatureName.Text = activeFunction.FeatureName;
                pnl_SmallBarText.Visible = true;
                Text = $"AVI Secure Core - {activeFunction.FeatureName}";
                
            }
            else
            {
                pnl_SmallBarText.Visible = false;
                Text = $"AVI Secure Core - Menú Principal";
            }
        }
    }

}
