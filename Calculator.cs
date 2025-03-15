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
        public Calculator()
        {
            InitializeComponent();
        }

        private void HelloLabel_Click(object sender, EventArgs e)
        {
            int num1 = 1;
            int num2 = 2;
            int sum = num1 + num2;
            HelloLabel.Text = sum.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        //name이 sumBtn인 Button을 Click시 실행되는 메서드 
        private void sumBtn_Click(object sender, EventArgs e)
        {
            int number1 = Convert.ToInt32(sum1.Text); // Int로 형변환 기본이 32bit
            int number2 = Convert.ToInt32(sum2.Text);

            result.Text = addCalc(number1, number2);
            result2.Text = subCalc(number1, number2);
        }


        public string addCalc(int a, int b)
        {
            return (a + b).ToString(); //모든 데이터타입이 ToString메서드 가지고 있다.
        }
   
        public string subCalc(int a, int b)
        {
            return (a - b).ToString(); //모든 데이터타입이 ToString메서드 가지고 있다.
        }
    }
}
/*
 * 메소드는 클래스에 속한 함수를 말함 메소드는 함수인데 클래스에 속한 함수를 메소드라고 부름
함수는 함수 이름과 매개변수로 프로토타입이 결정됨 매개변수가 다르다면 동일한 이름의 함수를 여러개 만들 수 있다.
이걸 오버로딩이라고 한다. 함수의 리턴형은 함수의 프로토타입이 결정되는 데에 어떠한 역할도 하지 않음.  

 
 */

