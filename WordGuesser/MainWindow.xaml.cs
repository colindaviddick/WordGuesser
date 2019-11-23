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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WordGuesser
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private MediaPlayer mediaPlayer = new MediaPlayer();

        public MainWindow()
        {
            InitializeComponent();
            Name1.Text = Properties.Settings.Default.aName;
            Name2.Text = Properties.Settings.Default.bName;
            Name3.Text = Properties.Settings.Default.cName;
            Name4.Text = Properties.Settings.Default.dName;
            Name5.Text = Properties.Settings.Default.eName;

            Score1.Text = Properties.Settings.Default.aScore.ToString();
            Score2.Text = Properties.Settings.Default.bScore.ToString();
            Score3.Text = Properties.Settings.Default.cScore.ToString();
            Score4.Text = Properties.Settings.Default.dScore.ToString();
            Score5.Text = Properties.Settings.Default.eScore.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Options.Visibility = Visibility.Visible;
        }

        private void CloseMenuButton_Click(object sender, RoutedEventArgs e)
        {
            Options.Visibility = Visibility.Hidden;
        }

        private void AboutMenuButton_Click(object sender, RoutedEventArgs e)
        {
            Menu_About.Visibility = Visibility.Visible;
            Options.Visibility = Visibility.Hidden;
        }

        private void CloseAbout_Click(object sender, RoutedEventArgs e)
        {
            Options.Visibility = Visibility.Visible;
            Menu_About.Visibility = Visibility.Hidden;
        }

        private void PreferencesMenuButton_Click(object sender, RoutedEventArgs e)
        {
            Preferences.Visibility = Visibility.Visible;
            Options.Visibility = Visibility.Hidden;
        }

        private void PreferencesMenuClose_Click(object sender, RoutedEventArgs e)
        {
            Options.Visibility = Visibility.Visible;
            Preferences.Visibility = Visibility.Hidden;
        }

        private void InterfaceSoundsYes_Click(object sender, RoutedEventArgs e)
        {
            Options.Visibility = Visibility.Visible;
            Preferences.Visibility = Visibility.Hidden;
        }

        private void VoiceHandleCheck(object sender, RoutedEventArgs e)
        {

        }
        private void VoiceHandleUnchecked(object sender, RoutedEventArgs e)
        {

        }

        private void InterfaceHandleCheck(object sender, RoutedEventArgs e)
        {

        }
        private void InterfaceHandleUnchecked(object sender, RoutedEventArgs e)
        {

        }

        private void InterfaceSoundsNo_Click(object sender, RoutedEventArgs e)
        {
            Options.Visibility = Visibility.Visible;
            Preferences.Visibility = Visibility.Hidden;
        }

        private void QuitMenuButton_Click(object sender, RoutedEventArgs e)
        {
            ConfirmQuit.Visibility = Visibility.Visible;
        }

        private void ContinuePlaying_Click(object sender, RoutedEventArgs e)
        {
            ConfirmQuit.Visibility = Visibility.Hidden;
        }

        private void ConfirmQuit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void PlayNewGameMenuButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void A_Click(object sender, RoutedEventArgs e)
        {
            A.IsEnabled = false;
            mediaPlayer.Open(new Uri(@"sounds/click.wav"));
            mediaPlayer.Play();
            //CheckifLetterIsInWord('A');
        }
        private void B_Click(object sender, RoutedEventArgs e)
        {
            B.IsEnabled = false;
            //CheckifLetterIsInWord('B');
        }
        private void C_Click(object sender, RoutedEventArgs e)
        {
            C.IsEnabled = false;
            //CheckifLetterIsInWord('C');
        }
        private void D_Click(object sender, RoutedEventArgs e)
        {
            D.IsEnabled = false;
            //CheckifLetterIsInWord('D');
        }
        private void E_Click(object sender, RoutedEventArgs e)
        {
            E.IsEnabled = false;
            //CheckifLetterIsInWord('E');
        }
        private void F_Click(object sender, RoutedEventArgs e)
        {
            F.IsEnabled = false;
            //CheckifLetterIsInWord('F');
        }
        private void G_Click(object sender, RoutedEventArgs e)
        {
            G.IsEnabled = false;
            //CheckifLetterIsInWord('G');
        }
        private void H_Click(object sender, RoutedEventArgs e)
        {
            H.IsEnabled = false;
            //CheckifLetterIsInWord('H');
        }
        private void I_Click(object sender, RoutedEventArgs e)
        {
            I.IsEnabled = false;
            //CheckifLetterIsInWord('I');
        }
        private void J_Click(object sender, RoutedEventArgs e)
        {
            J.IsEnabled = false;
            //CheckifLetterIsInWord('J');
        }
        private void K_Click(object sender, RoutedEventArgs e)
        {
            K.IsEnabled = false;
            //CheckifLetterIsInWord('K');
        }
        private void L_Click(object sender, RoutedEventArgs e)
        {
            L.IsEnabled = false;
            //CheckifLetterIsInWord('L');
        }
        private void M_Click(object sender, RoutedEventArgs e)
        {
            M.IsEnabled = false;
            //CheckifLetterIsInWord('M');
        }
        private void N_Click(object sender, RoutedEventArgs e)
        {
            N.IsEnabled = false;
            //CheckifLetterIsInWord('N');
        }
        private void O_Click(object sender, RoutedEventArgs e)
        {
            O.IsEnabled = false;
            //CheckifLetterIsInWord('O');
        }
        private void P_Click(object sender, RoutedEventArgs e)
        {
            P.IsEnabled = false;
            //CheckifLetterIsInWord('P');
        }
        private void Q_Click(object sender, RoutedEventArgs e)
        {
            Q.IsEnabled = false;
            //CheckifLetterIsInWord('Q');
        }
        private void R_Click(object sender, RoutedEventArgs e)
        {
            R.IsEnabled = false;
            //CheckifLetterIsInWord('R');
        }
        private void S_Click(object sender, RoutedEventArgs e)
        {
            S.IsEnabled = false;
            //CheckifLetterIsInWord('S');
        }
        private void T_Click(object sender, RoutedEventArgs e)
        {
            T.IsEnabled = false;
            //CheckifLetterIsInWord('T');
        }
        private void U_Click(object sender, RoutedEventArgs e)
        {
            U.IsEnabled = false;
            //CheckifLetterIsInWord('U');
        }
        private void V_Click(object sender, RoutedEventArgs e)
        {
            V.IsEnabled = false;
            //CheckifLetterIsInWord('V');
        }
        private void W_Click(object sender, RoutedEventArgs e)
        {
            W.IsEnabled = false;
            //CheckifLetterIsInWord('W');
        }
        private void X_Click(object sender, RoutedEventArgs e)
        {
            X.IsEnabled = false;
            //CheckifLetterIsInWord('X');
        }
        private void Y_Click(object sender, RoutedEventArgs e)
        {
            Y.IsEnabled = false;
            //CheckifLetterIsInWord('Y');
        }
        private void Z_Click(object sender, RoutedEventArgs e)
        {
            Z.IsEnabled = false;
            //CheckifLetterIsInWord('Z');
        }
    }
}
