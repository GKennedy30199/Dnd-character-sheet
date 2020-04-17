using System;
using System.Windows;
using System.Threading.Tasks;
using Dnd_character_sheet;
using System.Data;
namespace Dnd_character_sheet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DndCharacterData db = new DndCharacterData();
        
        public MainWindow()
        {
            
            InitializeComponent();
        }

        //DiceRoller

        #region DiceRoller
        public void D10Dicerolling()
        {
            Random D10Roll = new Random();
            for (int i=0; i < 10; i++)
            {
                D10Results.Text = D10Roll.Next(1, 11).ToString();
                
            }
        }
        public void D12DiceRolling()
        {
            Random D12Roll = new Random();
            for(int i=0; i<12; i++)
            {
                D12Results.Text = D12Roll.Next(1, 13).ToString();
            }
        }
        public void D20DiceRolling()
        {
            Random D20Roll = new Random();
            for (int i = 0; i < 20; i++)
            {
                D20Results.Text = D20Roll.Next(1, 21).ToString();
            }
        }
        public void D4DiceRolling()
        {
            Random D4Roll = new Random();
            for (int i = 0; i < 4; i++)
            {
                D4Results.Text = D4Roll.Next(1, 5).ToString();
            }
        }
        public void D6DiceRolling()
        {
            Random D6Roll = new Random();
            for (int i = 0; i < 6; i++)
            {
                D6Results.Text = D6Roll.Next(1, 7).ToString();
            }
        }
        public void D8DiceRolling()
        {
            Random D8Roll = new Random();
            for (int i = 0; i < 8; i++)
            {
                D8Results.Text = D8Roll.Next(1, 9).ToString();
            }
        }


        public void CharacterRoll()
        {
            Random roll = new Random();
            //strengh
            int r1 = roll.Next(1, 7);
            int r2 = roll.Next(1, 7);
            int r3 = roll.Next(1, 7);
            //Dexterity
            int r4 = roll.Next(1, 7);
            int r5 = roll.Next(1, 7);
            int r6 = roll.Next(1, 7);
            //Constitution
            int r7 = roll.Next(1, 7);
            int r8 = roll.Next(1, 7);
            int r9 = roll.Next(1, 7);
            //Intelligence
            int r10 = roll.Next(1, 7);
            int r11= roll.Next(1, 7);
            int r12= roll.Next(1, 7);
            //Wisdom
            int r13= roll.Next(1, 7);
            int r14= roll.Next(1, 7);
            int r15= roll.Next(1, 7);
            //Charisma
            int r16= roll.Next(1, 7);
            int r17= roll.Next(1, 7);
            int r18= roll.Next(1, 7);

            int Full1 = r1 + r2 + r3;
            int Full2 = r4 + r5 + r6;
            int Full3 = r7 + r8 + r9;
            int Full4 = r10 + r11 + r12;
            int Full5 = r13 + r14 + r15;
            int Full6 = r16 + r17 + r18;

            StrengthStat.Text = Full1.ToString();
            DexStat.Text = Full2.ToString();
            ConstStat.Text = Full3.ToString();
            IntelStat.Text = Full4.ToString();
            WisStat.Text = Full5.ToString();
            ChaStat.Text = Full6.ToString();

        }
        private void RollD10_Click(object sender, RoutedEventArgs e)
        {
            D10Dicerolling();
        }

        private void RollD12_Click(object sender, RoutedEventArgs e)
        {
            D12DiceRolling();
        }

        private void RollD20_Click(object sender, RoutedEventArgs e)
        {
            D20DiceRolling();
        }

        private void RollD4_Click(object sender, RoutedEventArgs e)
        {
            D4DiceRolling();
        }

        private void RollD6_Click(object sender, RoutedEventArgs e)
        {
            D6DiceRolling();
        }

        private void RollD8_Click(object sender, RoutedEventArgs e)
        {
            D8DiceRolling();
        }


       

        

        private void CharacterStatRoll_Click(object sender, RoutedEventArgs e)
        {
            CharacterRoll();
        }
        #endregion

        //FeatsList
        #region Featslist
        private void Fighter_Click(object sender, RoutedEventArgs e)
        {
            //var query = from f in db.Classes
              //          select f;
            
        }

        private void Bard_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Rogue_Click(object sender, RoutedEventArgs e)
        {

        }
        #endregion
    }
}
