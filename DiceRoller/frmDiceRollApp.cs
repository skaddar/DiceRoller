using System;
using System.Drawing;
using System.Windows.Forms;

namespace DiceRoller
{
    public partial class frmDiceRollApp : Form
    {
        private D6 die = new D6();

        private string assetsPath = Application.StartupPath + "\\Assets\\";

        // maps each dice value to its matching image file
        private string[] dicePngs = new string[]
        {
            "",                // 0
            "dice-one.png",    // 1
            "dice-two.png",    // 2
            "dice-three.png",  // 3
            "dice-four.png",   // 4
            "dice-five.png",   // 5
            "dice-six.png"     // 6
        };

        public frmDiceRollApp()
        {
            InitializeComponent();
            btnPickUp.Enabled = false;
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            try
            {
                // die.Roll() handles the random number, tracking and stats — defined in Die.cs, implemented in D6.cs
                int result = die.Roll();

                btnRoll.Enabled = false;
                btnPickUp.Enabled = false;

                picDice.Image = null;
                picDice.Refresh();

                picDice.Image = Image.FromFile(assetsPath + "RollIt.gif");

                Timer rollTimer = new Timer();
                rollTimer.Interval = 2000;
                rollTimer.Tick += (s, args) =>
                {
                    rollTimer.Stop();
                    rollTimer.Dispose();

                    Image old = picDice.Image;
                    picDice.Image = null;
                    old?.Dispose();

                    // use result from die.Roll() to pick the right image
                    Image original = Image.FromFile(assetsPath + dicePngs[result]);
                    Bitmap resized = new Bitmap(original, picDice.Size);
                    original.Dispose();

                    picDice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    picDice.Image = resized;

                    // pull stats from die object, not local variables
                    UpdateStats();

                    btnPickUp.Enabled = true;
                };
                rollTimer.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                btnRoll.Enabled = true;
            }
        }

        private void btnPickUp_Click(object sender, EventArgs e)
        {
            try
            {
                btnPickUp.Enabled = false;
                btnRoll.Enabled = false;

                Image oldImage = picDice.Image;
                picDice.Image = null;
                oldImage?.Dispose();
                picDice.Refresh();

                picDice.Image = Image.FromFile(assetsPath + "Pickup.gif");

                Timer pickupTimer = new Timer();
                pickupTimer.Interval = 2000;
                pickupTimer.Tick += (s, args) =>
                {
                    pickupTimer.Stop();
                    pickupTimer.Dispose();

                    Image old = picDice.Image;
                    picDice.Image = null;
                    old?.Dispose();

                    picDice.Refresh();
                    btnRoll.Enabled = true;
                };
                pickupTimer.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                btnPickUp.Enabled = true;
            }
        }

        private void UpdateStats()
        {
            // everything now comes from the die object instead of local variables
            lblTotalRolls.Text = $"Total Rolls: {die.TotalRolls}";
            lblAverage.Text = $"Average: {die.GetAverage():F2}";

            // die.RollFrequency and die.GetPercent() are inherited from Die.cs
            lblFreq1.Text = $"1: {die.RollFrequency[1]}  ({die.GetPercent(1)}%)";
            lblFreq2.Text = $"2: {die.RollFrequency[2]}  ({die.GetPercent(2)}%)";
            lblFreq3.Text = $"3: {die.RollFrequency[3]}  ({die.GetPercent(3)}%)";
            lblFreq4.Text = $"4: {die.RollFrequency[4]}  ({die.GetPercent(4)}%)";
            lblFreq5.Text = $"5: {die.RollFrequency[5]}  ({die.GetPercent(5)}%)";
            lblFreq6.Text = $"6: {die.RollFrequency[6]}  ({die.GetPercent(6)}%)";
        }
    }
}