using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Calculator : Form
    {

        // data field
        private static string screenNum = ""; // 계산기 화면에 표시되는 값 즉, screenLabel.Text에 들어갈.
        private static string addVal = "";//연산 버튼 입력 후
        

        public Calculator()
        {
            InitializeComponent();
        }
        
        
        //S: 핵심코드
        public void setScreen(string clickedNum) {
            if (screenNum != "0") {
                screenNum += clickedNum;
            }
            else {
                screenNum = clickedNum;
            }
            screenLabel.Text = screenNum;
        }

        public string addCalc(int a, int b)
        {
            return (a + b).ToString(); //모든 데이터타입이 ToString메서드 가지고 있다.
        }

        public string subCalc(int a, int b)
        {
            return (a - b).ToString(); //모든 데이터타입이 ToString메서드 가지고 있다.
        }

        //S: UI Event Handler
       
        private void clickNumber(object sender, EventArgs e)  //숫자패드 누르면 실행
        {
            Button clickedBtn = sender as Button;
            if (clickedBtn != null)
            {
                setScreen(clickedBtn.Text);
            }else{
                setScreen("ERROR!");
                return;
            }
        }
        //연산자 버튼 클릭시 실행
        private void clickedOperator() {
            
        }
     
        private void screenNum_Click(object sender, EventArgs e) //label
        {

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {

        }

        private void btnSub_Click(object sender, EventArgs e)
        {

        }

        private void btnDiv_Click(object sender, EventArgs e)
        {

        }

        private void btnMulti_Click(object sender, EventArgs e)
        {

        }

        private void dot_Click(object sender, EventArgs e)
        {

        }

        private void getResult_Click(object sender, EventArgs e)
        {

        }

    }
}


//UI와 핵심 코드는 완전히 분리 되도록 코딩한다.
//UI가 바뀌어서 수정되어야하는 핵심 코드는 잘못된 것
//좋은 코드는 UI가 바뀌어도 핵심 코드를 손댈 필요가 없도록 분리가 잘 되어있다.
//위의 addCalc,subCalc처럼