using OYUN.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OYUN
{
    public partial class Form2 : Form
    {


        public Form2()
        {
            InitializeComponent();
        }
        int sure = 3;
        private void timer1_Tick(object sender, EventArgs e)
        {

            sure--;
            lblsure.Text = sure.ToString();
            if (sure == 0)
            {
                timer1.Enabled = false;
                sure = 3;
                for (int i = 0; i < butonlardizisi.Length; i++)
                {
                    butonlardizisi[i].ImageIndex = 7;
                }
            }
       
        }
        int hamlesayisi = 10;
        private void Form2_Load(object sender, EventArgs e)
        {
            lblhamlesayisi.Text = hamlesayisi.ToString();
            axWindowsMediaPlayer1.Visible = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
          


        }
        Button[] butonlardizisi = new Button[12];
        #region buton değer şeysi

        int btn1;
        int btn2;
        int btn3;
        int btn4;
        int btn5;
        int btn6;
        int btn7;
        int btn8;
        int btn9;
        int btn10;
        int btn11;
        int btn0;
        #endregion
        #region buton bool kontrol
        bool[] butonkontrol = new bool[12];
        #endregion
        private void btnkarıstır_Click(object sender, EventArgs e)
        {
            btnkarıstır.Enabled = false;
            hamlesayisi = 10;
            timer1.Enabled = true;
            int çilek = 0;
            int elma = 0;
            int armut = 0;
            int uzum = 0;
            int muz = 0;
            int portakal = 0;
            #region butonları buton dizisine atama
            butonlardizisi[0] = button1;
            butonlardizisi[1] = button2;
            butonlardizisi[2] = button3;
            butonlardizisi[3] = button4;
            butonlardizisi[4] = button5;
            butonlardizisi[5] = button6;
            butonlardizisi[6] = button7;
            butonlardizisi[7] = button8;
            butonlardizisi[8] = button9;
            butonlardizisi[9] = button10;
            butonlardizisi[10] = button11;
            butonlardizisi[11] = button12;
            #endregion
            Random randomolusturucu = new Random();

            for (int i = 0; i < butonlardizisi.Length; i++)
            {
                Tekrar:
                int randomdeger = randomolusturucu.Next(6);
                if (randomdeger == 0)
                {
                    if (çilek < 2)
                    {
                        çilek++;
                        butonlardizisi[i].ImageIndex = randomdeger;
                        #region hangibutonşeysi
                        if (i == 0) { btn0 = randomdeger; }
                        if (i == 1) { btn1 = randomdeger; }
                        if (i == 2) { btn2 = randomdeger; }
                        if (i == 3) { btn3 = randomdeger; }
                        if (i == 4) { btn4 = randomdeger; }
                        if (i == 5) { btn5 = randomdeger; }
                        if (i == 6) { btn6 = randomdeger; }
                        if (i == 7) { btn7 = randomdeger; }
                        if (i == 8) { btn8 = randomdeger; }
                        if (i == 9) { btn9 = randomdeger; }
                        if (i == 10) { btn10 = randomdeger; }
                        if (i == 11) { btn11 = randomdeger; }
                        #endregion
                    }
                    else
                    {
                        goto Tekrar;
                    }
                }
                if (randomdeger == 1)
                {
                    if (elma < 2)
                    {
                        elma++;
                        butonlardizisi[i].ImageIndex = randomdeger;
                        #region hangibutonşeysi
                        if (i == 0) { btn0 = randomdeger; }
                        if (i == 1) { btn1 = randomdeger; }
                        if (i == 2) { btn2 = randomdeger; }
                        if (i == 3) { btn3 = randomdeger; }
                        if (i == 4) { btn4 = randomdeger; }
                        if (i == 5) { btn5 = randomdeger; }
                        if (i == 6) { btn6 = randomdeger; }
                        if (i == 7) { btn7 = randomdeger; }
                        if (i == 8) { btn8 = randomdeger; }
                        if (i == 9) { btn9 = randomdeger; }
                        if (i == 10) { btn10 = randomdeger; }
                        if (i == 11) { btn11 = randomdeger; }
                        #endregion
                    }
                    else
                    {
                        goto Tekrar;
                    }
                }
                if (randomdeger == 2)
                {
                    if (armut < 2)
                    {
                        armut++;
                        butonlardizisi[i].ImageIndex = randomdeger;
                        #region hangibutonşeysi
                        if (i == 0) { btn0 = randomdeger; }
                        if (i == 1) { btn1 = randomdeger; }
                        if (i == 2) { btn2 = randomdeger; }
                        if (i == 3) { btn3 = randomdeger; }
                        if (i == 4) { btn4 = randomdeger; }
                        if (i == 5) { btn5 = randomdeger; }
                        if (i == 6) { btn6 = randomdeger; }
                        if (i == 7) { btn7 = randomdeger; }
                        if (i == 8) { btn8 = randomdeger; }
                        if (i == 9) { btn9 = randomdeger; }
                        if (i == 10) { btn10 = randomdeger; }
                        if (i == 11) { btn11 = randomdeger; }
                        #endregion
                    }
                    else
                    {
                        goto Tekrar;
                    }
                }
                if (randomdeger == 3)
                {
                    if (uzum < 2)
                    {
                        uzum++;
                        butonlardizisi[i].ImageIndex = randomdeger;
                        #region hangibutonşeysi
                        if (i == 0) { btn0 = randomdeger; }
                        if (i == 1) { btn1 = randomdeger; }
                        if (i == 2) { btn2 = randomdeger; }
                        if (i == 3) { btn3 = randomdeger; }
                        if (i == 4) { btn4 = randomdeger; }
                        if (i == 5) { btn5 = randomdeger; }
                        if (i == 6) { btn6 = randomdeger; }
                        if (i == 7) { btn7 = randomdeger; }
                        if (i == 8) { btn8 = randomdeger; }
                        if (i == 9) { btn9 = randomdeger; }
                        if (i == 10) { btn10 = randomdeger; }
                        if (i == 11) { btn11 = randomdeger; }
                        #endregion
                    }
                    else
                    {
                        goto Tekrar;
                    }
                }
                if (randomdeger == 4)
                {
                    if (muz < 2)
                    {
                        muz++;
                        butonlardizisi[i].ImageIndex = randomdeger;
                        #region hangibutonşeysi
                        if (i == 0) { btn0 = randomdeger; }
                        if (i == 1) { btn1 = randomdeger; }
                        if (i == 2) { btn2 = randomdeger; }
                        if (i == 3) { btn3 = randomdeger; }
                        if (i == 4) { btn4 = randomdeger; }
                        if (i == 5) { btn5 = randomdeger; }
                        if (i == 6) { btn6 = randomdeger; }
                        if (i == 7) { btn7 = randomdeger; }
                        if (i == 8) { btn8 = randomdeger; }
                        if (i == 9) { btn9 = randomdeger; }
                        if (i == 10) { btn10 = randomdeger; }
                        if (i == 11) { btn11 = randomdeger; }
                        #endregion
                    }
                    else
                    {
                        goto Tekrar;
                    }
                }
                if (randomdeger == 5)
                {
                    if (portakal < 2)
                    {
                        portakal++;
                        butonlardizisi[i].ImageIndex = randomdeger;
                        #region hangibutonşeysi
                        if (i == 0) { btn0 = randomdeger; }
                        if (i == 1) { btn1 = randomdeger; }
                        if (i == 2) { btn2 = randomdeger; }
                        if (i == 3) { btn3 = randomdeger; }
                        if (i == 4) { btn4 = randomdeger; }
                        if (i == 5) { btn5 = randomdeger; }
                        if (i == 6) { btn6 = randomdeger; }
                        if (i == 7) { btn7 = randomdeger; }
                        if (i == 8) { btn8 = randomdeger; }
                        if (i == 9) { btn9 = randomdeger; }
                        if (i == 10) { btn10 = randomdeger; }
                        if (i == 11) { btn11 = randomdeger; }
                        #endregion
                    }
                    else
                    {
                        goto Tekrar;
                    }
                }

            }
            #region bunları buton dizisine atama
            button1 = butonlardizisi[0];
            button2 = butonlardizisi[1];
            button3 = butonlardizisi[2];
            button4 = butonlardizisi[3];
            button5 = butonlardizisi[4];
            button6 = butonlardizisi[5];
            button7 = butonlardizisi[6];
            button8 = butonlardizisi[7];
            button9 = butonlardizisi[8];
            button10 = butonlardizisi[9];
            button11 = butonlardizisi[10];
            button12 = butonlardizisi[11];
            #endregion

            #region butonların aktifliğini ayarlama
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            #endregion
        }


        private void btncıkıs_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      public  int secilen1 = -1;
       public int secilen2 = -1;
        int secilensayisi = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            button1.ImageIndex = btn0;
            if (secilensayisi < 1) { secilensayisi++; secilen1 = btn0;button1.Enabled = false; }
            else if (secilensayisi == 1 ) { secilensayisi++; secilen2 = btn0; timer2.Enabled = true; button1.Enabled = false; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
             button2.ImageIndex = btn1;
            if (secilensayisi < 1   ){ secilensayisi++; secilen1 = btn1; button2.Enabled = false; }
            else if (secilensayisi ==1 ) { secilensayisi++; secilen2 = btn1; timer2.Enabled = true; button2.Enabled = false; }
        }

        private void button3_Click(object sender, EventArgs e)
        {
             button3.ImageIndex = btn2;
            if (secilensayisi < 1 ) { secilensayisi++; secilen1 = btn2; button3.Enabled = false; }
            else if (secilensayisi ==1) { secilensayisi++; secilen2 = btn2; timer2.Enabled = true; button3.Enabled = false; }
        }


        private void button4_Click(object sender, EventArgs e)
        {
             button4.ImageIndex = btn3;
            if (secilensayisi < 1 ) { secilensayisi++; secilen1 = btn3; button4.Enabled = false; }
            else if (secilensayisi == 1) { secilensayisi++; secilen2 = btn3; timer2.Enabled = true; button4.Enabled = false; }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            button5.ImageIndex = btn4;
            if (secilensayisi < 1 ) { secilensayisi++; secilen1 = btn4; button5.Enabled = false; }
            else if (secilensayisi == 1) { secilensayisi++; secilen2 = btn4; timer2.Enabled = true; button5.Enabled = false; }
        }

        private void button6_Click(object sender, EventArgs e)
        {
             button6.ImageIndex = btn5;
            if (secilensayisi < 1 ) { secilensayisi++; secilen1 = btn5; button6.Enabled = false; }
            else if (secilensayisi == 1) { secilensayisi++; secilen2 = btn5; timer2.Enabled = true; button6.Enabled = false; }
        }

        private void button7_Click(object sender, EventArgs e)
        {
             button7.ImageIndex = btn6;
            if (secilensayisi < 1) { secilensayisi++; secilen1 = btn6; button7.Enabled = false; }
            else if (secilensayisi == 1) { secilensayisi++; secilen2 = btn6; timer2.Enabled = true; button7.Enabled = false; }
        }

        private void button8_Click(object sender, EventArgs e)
        {
             button8.ImageIndex = btn7;
            if (secilensayisi < 1 ) { secilensayisi++; secilen1 = btn7; button8.Enabled = false; }
            else if (secilensayisi == 1) { secilensayisi++; secilen2 = btn7; timer2.Enabled = true; button8.Enabled = false; }
            }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.ImageIndex = btn8;
            if (secilensayisi < 1 ) { secilensayisi++; secilen1 = btn8; button9.Enabled = false; }
            else if (secilensayisi == 1) { secilensayisi++; secilen2 = btn8; timer2.Enabled = true; button9.Enabled = false; }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.ImageIndex = btn9;
            if (secilensayisi < 1) { secilensayisi++; secilen1 = btn9; button10.Enabled = false; }
            else if (secilensayisi == 1) { secilensayisi++; secilen2 = btn9; timer2.Enabled = true; button10.Enabled = false; }
        }

        private void button11_Click(object sender, EventArgs e)
        {
             button11.ImageIndex = btn10;
            if (secilensayisi < 1 ) { secilensayisi++; secilen1 = btn10; button11.Enabled = false; }
            else if (secilensayisi == 1) { secilensayisi++; secilen2 = btn10; timer2.Enabled = true; button11.Enabled = false; }
        }

        private void button12_Click(object sender, EventArgs e)
        {
             button12.ImageIndex = btn11;
            if (secilensayisi < 1) { secilensayisi++; secilen1 = btn11; button12.Enabled = false; }
            else if (secilensayisi == 1) { secilensayisi++; secilen2 = btn11; timer2.Enabled = true; button12.Enabled = false; }
        }
          
             int dogrusayisi = 0;
            public void karsılastır(int secilen1, int secilen2)
            {
            
            if (secilen1 == secilen2 )
                {
                dogrusayisi++;
               
                secilensayisi = 0;
                #region seçilen butonun aktifliğini yok etme
                if (secilen1 == btn0) { button1.Enabled = false;button1.ImageIndex = btn0; }
                if (secilen1 == btn1 ){ button2.Enabled = false; button2.ImageIndex = btn1; }
                if (secilen1 == btn2) { button3.Enabled = false; button3.ImageIndex = btn2; }
                if (secilen1 == btn3) { button4.Enabled = false; button4.ImageIndex = btn3; }
                if (secilen1 == btn4) { button5.Enabled = false; button5.ImageIndex = btn4; }
                if (secilen1 == btn5) { button6.Enabled = false; button6.ImageIndex = btn5; }
                if (secilen1 == btn6) { button7.Enabled = false; button7.ImageIndex = btn6; }
                if (secilen1 == btn7) { button8.Enabled = false; button8.ImageIndex = btn7; }
                if (secilen1 == btn8) { button9.Enabled = false; button9.ImageIndex = btn8; }
                if (secilen1 == btn9) { button10.Enabled = false; button10.ImageIndex = btn9; }
                if (secilen1 == btn10) { button11.Enabled = false; button11.ImageIndex = btn10; }
                if (secilen1 == btn11) { button12.Enabled = false; button12.ImageIndex = btn11; }

                if (secilen2 == btn0) { button1.Enabled = false; button1.ImageIndex = btn0; }
                if (secilen2 == btn1) { button2.Enabled = false; button2.ImageIndex = btn1; }
                if (secilen2 == btn2) { button3.Enabled = false; button3.ImageIndex = btn2; }
                if (secilen2 == btn3) { button4.Enabled = false; button4.ImageIndex = btn3; }
                if (secilen2 == btn4) { button5.Enabled = false; button5.ImageIndex = btn4; }
                if (secilen2 == btn5) { button6.Enabled = false; button6.ImageIndex = btn5; }
                if (secilen2 == btn6) { button7.Enabled = false; button7.ImageIndex = btn6; }
                if (secilen2 == btn7) { button8.Enabled = false; button8.ImageIndex = btn7; }
                if (secilen2 == btn8) { button9.Enabled = false; button9.ImageIndex = btn8; }
                if (secilen2 == btn9) { button10.Enabled = false; button10.ImageIndex = btn9; }
                if (secilen2 == btn10) { button11.Enabled = false; button11.ImageIndex = btn10; }
                if (secilen2 == btn11) { button12.Enabled = false; button12.ImageIndex = btn11; }
                hamlesayisi--;lblhamlesayisi.Text = hamlesayisi.ToString();
                secilen1 = degererieksi1yap();
                secilen2 = degererieksi1yap();
                if (dogrusayisi == 6) { MessageBox.Show("Tebrikler kazandınız."); btnkarıstır.Enabled = true; }
                else if (hamlesayisi == 0)
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    button10.Enabled = false;
                    button11.Enabled = false;
                    button12.Enabled = false;
                    btnkarıstır.Enabled = false;
                    MessageBox.Show("Hamleniz bitti .Kaybettiniz.");
                    btnkarıstır.Enabled = true;
                }
                #endregion

            }
       
            else if(secilen1!=secilen2&&secilen1!=-1&&secilen2!=-1)
            {


                hamlesayisi--; lblhamlesayisi.Text = hamlesayisi.ToString();

                if (secilen1 == btn0) { button1.ImageIndex = 7; button1.Enabled = true; }
                if (secilen2 == btn0) { button1.ImageIndex = 7; button1.Enabled = true; }
                if (secilen1 == btn1) { button2.ImageIndex = 7; button2.Enabled = true; }
                if (secilen2 == btn1) { button2.ImageIndex = 7; button2.Enabled = true; }
                if (secilen1 == btn2) { button3.ImageIndex = 7; button3.Enabled = true; }
                if (secilen2 == btn2) { button3.ImageIndex = 7; button3.Enabled = true; }
                if (secilen1 == btn3) { button4.ImageIndex = 7; button4.Enabled = true; }
                if (secilen2 == btn3) { button4.ImageIndex = 7; button4.Enabled = true; }
                if (secilen1 == btn4) { button5.ImageIndex = 7; button5.Enabled = true; }
                if (secilen2 == btn4) { button5.ImageIndex = 7; button5.Enabled = true; }
                if (secilen1 == btn5) { button6.ImageIndex = 7; button6.Enabled = true; }
                if (secilen2 == btn5) { button6.ImageIndex = 7; button6.Enabled = true; }
                if (secilen1 == btn6) { button7.ImageIndex = 7; button7.Enabled = true; }
                if (secilen2 == btn6) { button7.ImageIndex = 7; button7.Enabled = true; }
                if (secilen1 == btn7) { button8.ImageIndex = 7; button8.Enabled = true; }
                if (secilen2 == btn7) { button8.ImageIndex = 7; button8.Enabled = true; }
                if (secilen1 == btn8) { button9.ImageIndex = 7; button9.Enabled = true; }
                if (secilen2 == btn8) { button9.ImageIndex = 7; button9.Enabled = true; }
                if (secilen1 == btn9) { button10.ImageIndex = 7; button10.Enabled = true; }
                if (secilen2 == btn9) { button10.ImageIndex = 7; button10.Enabled = true; }
                if (secilen1 == btn10) { button11.ImageIndex = 7; button11.Enabled = true; }
                if (secilen2 == btn10) { button11.ImageIndex = 7; button11.Enabled = true; }
                if (secilen1 == btn11) { button12.ImageIndex = 7; button12.Enabled = true; }
                if (secilen2 == btn11) { button12.ImageIndex = 7; button12.Enabled = true; }
                secilen1 = degererieksi1yap();
                secilen2 = degererieksi1yap();
                if (hamlesayisi == 0)
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    button10.Enabled = false;
                    button11.Enabled = false;
                    button12.Enabled = false;
                    btnkarıstır.Enabled = false;
                    MessageBox.Show("Hamleniz bitti .Kaybettiniz.");
                    btnkarıstır.Enabled = true;
                }

                secilensayisi = 0;

            }
        }
       
        static int degererieksi1yap()
        {
            return -1;
        }
        int basılanmeyvenindurmasuresi = 2;
        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            basılanmeyvenindurmasuresi--;
            if (basılanmeyvenindurmasuresi == 0) { timer2.Enabled = false; karsılastır(secilen1, secilen2); basılanmeyvenindurmasuresi = 2; }
           
           
        }

       
    }
} 
