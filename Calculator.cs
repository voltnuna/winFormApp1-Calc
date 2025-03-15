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

        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox1_TextChanged_1(object sender, EventArgs e) { }

        private void HelloLabel_Click(object sender, EventArgs e)
        {
            int num1 = 1;
            int num2 = 2;
            int sum = num1 + num2;
            HelloLabel.Text = sum.ToString();
        }

        //name이 sumBtn인 Button을 Click시 실행되는 메서드 
        private void sumBtn_Click(object sender, EventArgs e)
        {

            int number1 = 0;
            int number2 = 0;

            //String.IsNullOrWhiteSpace
            //문자열이 null, 비어 있음("") 또는 공백 문자로만 구성되어 있는지를 확인하는 데 사용됩니다.

            if (String.IsNullOrWhiteSpace(sum1.Text) || String.IsNullOrWhiteSpace(sum2.Text)) {
                MessageBox.Show("숫자를 입력해주세요!");
                sum1.SelectAll(); //text전체 블럭으로 선택됨
                sum1.Focus(); //textbox에 포커스1
                //clearText();
                
                return ;
            }
            // int.TryParse는 int형 값을 String으로 변환해보고 성공하면 number1이라는 변수에 저장 결과에 따라 true false 반환
            if (int.TryParse(sum1.Text, out number1) == false) {
                MessageBox.Show("Sum1에 문자가 들어왔습니다!");
                clearText();
                return;
            } else if (int.TryParse(sum2.Text, out number2) == false) { 
                MessageBox.Show("Sum2에 숫자를 입력하세요!");
                clearText();
                return;
            }

            result.Text = addCalc(number1, number2);
            result2.Text = subCalc(number1, number2);
        }

        public void clearText(){
            sum1.Text = "";
            sum2.Text = "";
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


/*          int number1 = Convert.ToInt32(sum1.Text); // Int로 형변환 기본이 32bit
            int number2 = Convert.ToInt32(sum2.Text);
*/

