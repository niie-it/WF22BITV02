namespace DemoMdi
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        int loginFormIndex = 0;
        int employeeFromIndex = 0;

        private void newFormChildToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmChild = new FrmChild();
            frmChild.MdiParent = this;
            loginFormIndex++;
            frmChild.Text = $"Login {loginFormIndex}";
            frmChild.Show();
        }

        private void newEmplyeeFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmChild = new FrmEmployee();
            employeeFromIndex++;
            frmChild.Text = $"Employee {employeeFromIndex}";
            frmChild.MdiParent = this;
            frmChild.Show();
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void iconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(var frm in MdiChildren)
            {
                frm.Close();
            }
        }
    }
}
