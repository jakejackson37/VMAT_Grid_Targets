using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using VMS.TPS.Common.Model.API;

namespace VMAT_Grid_Targets
{
    /// <summary>
    /// Interaction logic for InitialMenu.xaml
    /// </summary>
    public partial class InitialMenu : Window
    {
        private InterfaceSelection interfaceSelection = new InterfaceSelection();
        public InterfaceSelection Return_options
        {
            get { return interfaceSelection; }
        }

        public void GetStructureSet(StructureSet structureset)
        {
            StructureSet ss = structureset;
            IEnumerable<Structure> Structures = ss.Structures;
            foreach (Structure s in Structures)
            {
                structure_selection.Items.Add(s.Id.ToString());
            }
        }

        public InitialMenu()
        {
            InitializeComponent();
        }

        private void structure_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string ptv_selected = structure_selection.SelectedItem.ToString();
            interfaceSelection.Target = ptv_selected;
        }

        private void Calculate_Spheres_Click(object sender, RoutedEventArgs e)
        {

            if (structure_selection.SelectedItem != null)
            {
                Close();
            }
            else
            {
                MessageBox.Show("A target structure must be selected to continue");
            }
        }
    }
}
