using System;
using System.Windows;
using System.Threading.Tasks;
using Dnd_character_sheet;
using System.Data;
using System.Linq;
namespace Dnd_character_sheet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DndCharacterData db = new DndCharacterData();
        SpellsList Sp = new SpellsList();
       // int ModifierNum1;
        //int ModifierNum2;
        //int ModifierNum3;
        //int ModifierNum4;
        //int ModifierNum5;
        //nt ModifierNum6;
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
            var Query =
                from F in db.Feats
                where F.ClassID == 1
                select F;
            Featlist.ItemsSource = Query.ToList();
        }

        private void Bard_Click(object sender, RoutedEventArgs e)
        {
            var Query =
                from B in db.Feats
                where B.ClassID == 2
                select B;
            Featlist.ItemsSource = Query.ToList();
        }

        private void Rogue_Click(object sender, RoutedEventArgs e)
        {
            var Query =
                from R in db.Feats
                where R.ClassID == 3
                select R;
            Featlist.ItemsSource = Query.ToList();
        }

        #endregion

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
             string[] AbilityScore = { "1", "2-3", "4-5", "6-7", "8-9", "10-11", "12-13", "14-15", "16-17", "18-19", "20-21", "22-23", "24-25", "26-27", "28-29", "30" };
            CbxStrength.ItemsSource = AbilityScore;
            CbxDex.ItemsSource = AbilityScore;
            CbxCon.ItemsSource = AbilityScore;
            CbxInt.ItemsSource = AbilityScore;
            CbxWis.ItemsSource = AbilityScore;
            CbxCha.ItemsSource = AbilityScore;
        }

        private void Human_Click(object sender, RoutedEventArgs e)
        {
            var query =
                from H in db.Races
                where H.RaceID == 1
                select H;
            Featlist.ItemsSource = query.ToList();
        }

        private void SpellBtn_Click(object sender, RoutedEventArgs e)
        {
            var query =
                from S in Sp.Spells
                where S.Level ==1
                select S;
            SpellsLbx.ItemsSource = query.ToList();
        }
    }
}
