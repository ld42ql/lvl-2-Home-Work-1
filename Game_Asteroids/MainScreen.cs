using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Asteroids
{


    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            MenuScreen menu = new MenuScreen();
            InitializeComponent();
            menu.Init(this);
            menu.Draw();
            BoxRecords.Visible = false;
            BtnReturn.Enabled = false;
            BtnReturn.Visible = false;
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {

        }
        

        private void btnStart_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void NewGame()
        {
            HideMenu();
            Game game = new Game();
            game.ValueAstr = 20;
            game.Init(this);
            game.Draw();
        }

        private void HideMenu()
        {
            btnStart.Enabled = false;
            btnRecords.Enabled = false;
            btnExit.Enabled = false;
            btnStart.Visible = false;
            btnRecords.Visible = false;
            btnExit.Visible = false;
            Lbl.Visible = false;
        }

        private void ViewMenu()
        {
            btnStart.Enabled = true;
            btnRecords.Enabled = true;
            btnExit.Enabled = true;
            btnStart.Visible = true;
            btnRecords.Visible = true;
            btnExit.Visible = true;
            Lbl.Visible = true;
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            HideMenu();
            BoxRecords.Visible = true;
            BtnReturn.Enabled = true;
            BtnReturn.Visible = true;
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            ViewMenu();
            BoxRecords.Visible = false;
            BtnReturn.Enabled = false;
            BtnReturn.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
